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
        public IActionResult Courses()
        {
            var courses = unitOfWork.Courses.GetAll();            
            return View("Courses", courses);
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
        }

        [HttpGet]
        [Route("/courses/create")]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [Route("/courses/create")]
        public IActionResult Create(Course course)
        {
            if(course != null && course.Name != null)
            {
                unitOfWork.Courses.Create(course);
                unitOfWork.Save();                                
                TempData["AlertMessage"] = _localizer["AlertCreateSuccess"].Value;
                TempData["AlertStatus"] = true;
            }
            else
            {
                TempData["AlertMessage"] = _localizer["AlertCreateFail"].Value;
                TempData["AlertStatus"] = false;
            }            
            return RedirectToAction("courses", "courses");            
        }
    }
}