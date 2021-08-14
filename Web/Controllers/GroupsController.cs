using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Common;
using MVC.DataAccess;
using System.Linq;

namespace MVC.Web.Controllers
{
    [Route("/courses/{idCourse}/[controller]/")]
    public class GroupsController : Controller
    {
        private UnitOfWork unitOfWork;
        public GroupsController(UniversityContext context)
        {
            unitOfWork = new UnitOfWork(context);
        }

        [HttpGet("/courses/{id}/groups")]
        public IActionResult GetGroups(int id)
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
            return View("EditGroup", group);
        }

        [HttpPost]
        [Route("/groups/EditGroup")]
        public IActionResult EditGroup(Group group)
        {
            unitOfWork.Groups.Update(group);
            unitOfWork.Save();
            var response = new Response();
            response.Message = $"Group {group.Name} updated!";
            response.PathBack = $"{group.CourseId}/groups";
            return View("Response", response);
        }

        [HttpGet("/courses/{idCourse}/groups/delete/{idGroup}")]
        public IActionResult DeleteGroup(int idCourse, int idGroup)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            if (course == null || course.Id != group.CourseId)
                return NotFound();
            int studentsCount = unitOfWork.Students.GetAll().Where(x => x.GroupId == group.Id).Count();
            var response = new Response();
            response.PathBack = $"{group.CourseId}/groups";
            if (studentsCount != 0)
            {
                response.Message = $"Group {group.Name} contains students! Deletion is not possible!";
            }
            else
            {
                unitOfWork.Groups.Remove(group.Id);
                unitOfWork.Save();
                response.Message = $"Group {group.Name} deleted!";
            }
            return View("Response", response);
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
            unitOfWork.Groups.Create(group);
            unitOfWork.Save();
            var response = new Response();
            response.Message = $"Group {group.Name} created!";
            response.PathBack = $"{group.CourseId}/groups";
            return View("Response", response);
        }
    }
}
