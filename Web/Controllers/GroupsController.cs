using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.Common;
using MVC.DataAccess;
using System.Linq;

namespace Controllers
{
    [Route("/courses/{idCourse}/[controller]/")]    
    public class GroupsController : Controller
    {
        private UnitOfWork unitOfWork;
        private readonly IStringLocalizer<GroupsController> _localizer;
        private readonly ILogger<GroupsController> _logger;
        public GroupsController(UniversityContext context, IStringLocalizer<GroupsController> localizer,
            ILogger<GroupsController> logger)
        {
            unitOfWork = new UnitOfWork(context);
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet("/courses/{id}/groups")]     
        public IActionResult Groups(int id)
        {
            Course course = unitOfWork.Courses.GetById(id);
            if (course == null)
                return NotFound();
            ViewBag.CourseId = id;
            return View("Groups", unitOfWork);
        }        

        [HttpGet("/courses/{idCourse}/groups/edit/{idGroup}")]
        public IActionResult GetEditGroup(int idCourse, int idGroup)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            if (course == null || course.Id != group.CourseId)
                return NotFound();
            ViewData["Courses"] = unitOfWork.Courses.GetAll();
            return View("EditGroup", group);
        }

        [HttpPost]
        [Route("/groups/EditGroup")]
        public IActionResult EditGroup(Group group)
        {
            if (group != null && group.Name != null && group.CourseId != 0)
            {
                unitOfWork.Groups.Update(group);
                unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertEditSuccess"].Value;
                TempData["AlertStatus"] = true;
            }
            else
            {
                TempData["AlertMessage"] = _localizer["AlertEditFail"].Value;
                TempData["AlertStatus"] = false;
            }

            return Redirect($"/courses/{group.CourseId}/groups");
        }

        [HttpGet("/courses/{idCourse}/groups/delete/{idGroup}")]
        public IActionResult DeleteGroup(int idCourse, int idGroup)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);

            if (course == null || group == null || course.Id != group.CourseId)
            {
                TempData["AlertMessage"] = _localizer["AlertRemoveNotFound"].Value;
                TempData["AlertStatus"] = false;
                return Redirect($"/courses/{group.CourseId}/groups");
            }

            int studentsCount = unitOfWork.Students.GetAll().Where(x => x.GroupId == group.Id).Count();
            if (studentsCount != 0)
            {
                TempData["AlertMessage"] = _localizer["AlertNotEmptyGroup"].Value;
                TempData["AlertStatus"] = false;
            }
            else
            {
                unitOfWork.Groups.Remove(group.Id);
                unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertRemoveSuccess"].Value;
                TempData["AlertStatus"] = true;

            }
            return Redirect($"/courses/{group.CourseId}/groups");
        }

        [HttpGet]
        [Route("/groups/create")]
        public IActionResult Create()
        {
            ViewData["Courses"] = unitOfWork.Courses.GetAll();
            return View("Create");
        }

        [HttpPost]
        [Route("/groups/create")]
        public IActionResult Create(Group group)
        {
            if (group != null && group.Name != null && group.CourseId != 0)
            {
                unitOfWork.Groups.Create(group);
                unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertCreateSuccess"].Value;
                TempData["AlertStatus"] = true;
            }
            else
            {
                TempData["AlertMessage"] = _localizer["AlertCreateFail"].Value;
                TempData["AlertStatus"] = false;
            }

            return Redirect($"/courses/{group.CourseId}/groups");
        }
    }
}
