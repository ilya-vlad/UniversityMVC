using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MVC.Common;
using MVC.DataAccess;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.Extensions.Logging;
using MVC.Web.Models.Course;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;

namespace Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class CoursesController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<CoursesController> _localizer;
        private readonly ILogger<CoursesController> _logger;

        public CoursesController(IUnitOfWork unitOfWork, IStringLocalizer<CoursesController> localizer, 
            ILogger<CoursesController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        [DefaultBreadcrumb("Courses")]
        public IActionResult Courses(string name, int page = 1, CourseSortState sortOrder = CourseSortState.NameAsc)
        {
            var nodes = new MvcBreadcrumbNode("courses", "courses", "курсы")
            {
                Parent = new MvcBreadcrumbNode("courses", "courses", "курсы")
                {
                    OverwriteTitleOnExactMatch = false,
                    RouteValues = new { id = 5, idCourse = 2 },
                    Parent = new RazorPageBreadcrumbNode("/courses", "courses")
                    {
                        Parent = new MvcRouteBreadcrumbNode("/courses/edit/1", "title")
                        {
                            OverwriteTitleOnExactMatch = true
                        }
                    }
                }

            };


            ViewData["BreadcrumbNode"] = nodes; // Use the last node






            int pageSize = 5;

            IQueryable<Course> courses = _unitOfWork.Courses.GetAll();
            if (!String.IsNullOrEmpty(name))
            {
                courses = courses.Where(p => p.Name.Contains(name));
            }

            switch (sortOrder)
            {
                case CourseSortState.NameDesc:
                    courses = courses.OrderByDescending(s => s.Name);
                    break;
                case CourseSortState.DescriptionAsc:
                    courses = courses.OrderBy(s => s.Description);
                    break;
                case CourseSortState.DescriptionDesc:
                    courses = courses.OrderByDescending(s => s.Description);
                    break;                
                default:
                    courses = courses.OrderBy(s => s.Name);
                    break;
            }

            var count = courses.Count();
            var items = courses.Skip((page - 1) * pageSize).Take(pageSize);

            CourseIndexViewModel viewModel = new CourseIndexViewModel
            {
                PageViewModel = new CoursePageViewModel(count, page, pageSize),
                SortViewModel = new CourseSortViewModel(sortOrder),
                FilterViewModel = new CourseFilterViewModel(name),
                Courses = items
            };

            ViewData["PageSize"] = pageSize;

            return View("Courses", viewModel);
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
        }

        [HttpGet("/courses/edit/{idCourse}")]
        [Breadcrumb("Edit")]
        public IActionResult GetEditCourse(int idCourse)
        {
            Course course = _unitOfWork.Courses.GetById(idCourse);            
            if (course == null) 
                return NotFound();            
            return View("EditCourse", course);
        }

        [HttpPost]
        [Route("/courses/EditCourse")]
        public IActionResult EditCourse(Course course)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(course.Name))
            {
                ModelState.AddModelError(nameof(course.Name), _localizer["EmptyName"]);
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Courses.Update(course);
                _unitOfWork.Save();
                _logger.LogInformation($"Edited course {course.Name}");
                TempData["AlertMessage"] = _localizer["AlertEditSuccess"].Value;
                TempData["AlertStatus"] = true;
                return RedirectToAction("courses", "courses");
            }
            else
            {
                return View(course);
            }
        }

        [HttpGet("/courses/delete/{idCourse}")]
        public IActionResult DeleteCourse(int idCourse)
        {
            Course course = _unitOfWork.Courses.GetById(idCourse);

            if (course == null)
            {
                TempData["AlertMessage"] = _localizer["AlertRemoveNotFound"].Value;
                TempData["AlertStatus"] = false;
            }
            else
            {
                int groupsCount = _unitOfWork.Groups.GetAll().Where(x => x.CourseId == course.Id).Count();
                if(groupsCount != 0)
                {
                    TempData["AlertMessage"] = _localizer["AlertNotEmptyCourse"].Value;
                    TempData["AlertStatus"] = false;
                }
                else
                {
                    _unitOfWork.Courses.Remove(course.Id);
                    _unitOfWork.Save();
                    TempData["AlertMessage"] = _localizer["AlertRemoveSuccess"].Value;
                    TempData["AlertStatus"] = true;
                }                
            }    
            return Redirect($"/courses");
        }

        [HttpGet]
        [Route("/courses/create")]
        [Breadcrumb("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/courses/create")]
        public IActionResult Create(Course course)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(course.Name))
            {
                ModelState.AddModelError(nameof(course.Name), _localizer["EmptyName"]);
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Courses.Create(course);
                _unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertCreateSuccess"].Value;
                TempData["AlertStatus"] = true;
                return RedirectToAction("courses", "courses");
            }
            else
            {              
                return View(course);
            }            
        }
    }
}