using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MVC.Common;
using MVC.DataAccess;

namespace MVC.Web.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class CoursesController : Controller
    {
        private UnitOfWork unitOfWork;
        public CoursesController(UniversityContext context)
        {
            unitOfWork = new UnitOfWork(context);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Courses()
        {
            var courses = unitOfWork.Courses.GetAll();
            return View("Courses", courses);
        }

        [HttpGet("{id}/groups")]
        public IActionResult GetGroups(int id)
        {
            Course course = unitOfWork.Courses.GetById(id);
            if (course == null)
                return NotFound();
            ViewBag.CourseId = id;
            return View("Groups", unitOfWork);
        }
    }
}