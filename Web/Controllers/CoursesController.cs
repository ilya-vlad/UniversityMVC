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

namespace Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class CoursesController : Controller
    {
        private UnitOfWork unitOfWork;
        private readonly IStringLocalizer<CoursesController> _localizer;
        private readonly ILogger<CoursesController> _logger;

        public CoursesController(UniversityContext context, IStringLocalizer<CoursesController> localizer,
            ILogger<CoursesController> logger)
        {
            unitOfWork = new UnitOfWork(context);
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]       
        public IActionResult Courses(string name, int page = 1, CourseSortState sortOrder = CourseSortState.NameAsc)
        {
            int pageSize = 5;

            IQueryable<Course> courses = unitOfWork.Courses.GetAll();
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
        public IActionResult GetEditCourse(int idCourse)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);            
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
                unitOfWork.Courses.Update(course);
                unitOfWork.Save();
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
            Course course = unitOfWork.Courses.GetById(idCourse);

            if (course == null)
            {
                TempData["AlertMessage"] = _localizer["AlertRemoveNotFound"].Value;
                TempData["AlertStatus"] = false;
            }
            else
            {
                int groupsCount = unitOfWork.Groups.GetAll().Where(x => x.CourseId == course.Id).Count();
                if(groupsCount != 0)
                {
                    TempData["AlertMessage"] = _localizer["AlertNotEmptyCourse"].Value;
                    TempData["AlertStatus"] = false;
                }
                else
                {
                    unitOfWork.Courses.Remove(course.Id);
                    unitOfWork.Save();
                    TempData["AlertMessage"] = _localizer["AlertRemoveSuccess"].Value;
                    TempData["AlertStatus"] = true;
                }                
            }    
            return Redirect($"/courses");
        }

        [HttpGet]
        [Route("/courses/create")]
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
                unitOfWork.Courses.Create(course);
                unitOfWork.Save();
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