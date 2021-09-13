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
    public class CoursesController : BaseController<CoursesController>
    {
        public CoursesController(IUnitOfWork unitOfWork, IStringLocalizer<CoursesController> localizer,
            ILogger<CoursesController> logger) : base(unitOfWork, localizer, logger)
        {
            
        }

        [HttpGet]        
        public IActionResult Index(string name, int page = 1, CourseSortState sortOrder = CourseSortState.NameAsc)
        {
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
            
            if(items.Count() == 0)
            {
                ViewData["NoResults"] = _localizer["NoResults"];
            }

            ViewBag.SortState = sortOrder;
            ViewData["PageSize"] = pageSize;
            ViewData["BreadcrumbNode"] = GetBreadCrumbs();
            return View(viewModel);
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
        public IActionResult GetCourse(int idCourse)
        {            
            Course course = _unitOfWork.Courses.GetById(idCourse);
            if (course == null)
                return NotFound();
            
            ViewBag.OldName = course.Name;
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course.Name);
            return View("Edit", course);
        }

        [HttpPost]
        [Route("/courses/edit")]
        public IActionResult Edit(Course course)
        {
            if (!string.IsNullOrEmpty(course.Name))
                course.Name = course.Name.Trim();
            if (!string.IsNullOrEmpty(course.Description))
                course.Description = course.Description.Trim();
            ModelState.Clear();
            if (string.IsNullOrEmpty(course.Name))
            {
                ModelState.AddModelError(nameof(course.Name), _localizer["EmptyName"]);
            }
            else if (_unitOfWork.Courses.GetAll().Where(x => x.Name == course.Name && x.Id != course.Id).Count() > 0)
            {
                ModelState.AddModelError(nameof(course.Name), _localizer["AlreadyExistName"]);
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

            Course editableCourse = _unitOfWork.Courses.GetById(course.Id);
            ViewBag.OldName = editableCourse.Name;
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(editableCourse.Name);
            return View(course);            
        }        

        [HttpGet("/courses/delete/{idCourse}")]
        public IActionResult Delete(int idCourse)
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
        public IActionResult Create()
        {
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(_localizer["CreateCourse"]);
            return View();
        }

        [HttpPost]
        [Route("/courses/create")]
        public IActionResult Create(Course course)
        {
            if(!string.IsNullOrEmpty(course.Name))
                course.Name = course.Name.Trim();
            if(!string.IsNullOrEmpty(course.Description)) 
                course.Description = course.Description.Trim();
            ModelState.Clear();
            if (string.IsNullOrEmpty(course.Name))
            {
                ModelState.AddModelError(nameof(course.Name), _localizer["EmptyName"]);
            }
            if (_unitOfWork.Courses.GetAll().Where( x => x.Name == course.Name).Count() > 0)
            {
                ModelState.AddModelError(nameof(course.Name), _localizer["AlreadyExistName"]);
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Courses.Create(course);
                _unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertCreateSuccess"].Value;
                TempData["AlertStatus"] = true;
                return RedirectToAction("courses", "courses");
            }          
           
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(_localizer["CreateCourse"]);
            return View(course);                     
        }

        private MvcBreadcrumbNode GetBreadCrumbs(string currentName)
        {
            currentName = currentName == null ? string.Empty : currentName;
            var node1 = new MvcBreadcrumbNode("Index", "Courses", _localizer["AllCourses"]);
            var node2 = new MvcBreadcrumbNode("", "", currentName)
            {
                Parent = node1
            };
            return node2;
        }

        private MvcBreadcrumbNode GetBreadCrumbs()
        {
            var node1 = new MvcBreadcrumbNode("Index", "Courses", _localizer["AllCourses"]);           
            return node1;
        }
    }
}