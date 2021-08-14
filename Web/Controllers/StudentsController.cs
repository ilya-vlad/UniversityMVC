using Microsoft.AspNetCore.Mvc;
using MVC.Common;
using MVC.DataAccess;
using System.Linq;

namespace MVC.Web.Controllers
{
    [Route("/courses/{idCourse}/groups/{idGroup}")]
    public class StudentsController : Controller
    {
        private UnitOfWork unitOfWork;
        public StudentsController(UniversityContext context)
        {
            unitOfWork = new UnitOfWork(context);
        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}")]
        public IActionResult GetStudents(int idCourse, int idGroup)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            if (course == null || course.Id != group.CourseId)
                return NotFound();
            ViewBag.GroupId = idGroup;
            return View("Students", unitOfWork);
        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}/students/edit/{idStudent}")]
        public IActionResult GetOptionsStudent(int idCourse, int idGroup, int idStudent)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            Student student = unitOfWork.Students.GetById(idStudent);
            if (course == null || course.Id != group.CourseId || student == null || student.GroupId != group.Id)
                return NotFound();
            return View("EditStudent", student);
        }

        [HttpPost]
        [Route("/students/EditStudent")]
        public IActionResult EditStudent(Student student)
        {
            unitOfWork.Students.Update(student);
            unitOfWork.Save();
            var group = unitOfWork.Groups.GetById(student.GroupId);
            var response = new Response();
            response.Message = $"Student {student.FirstName} {student.LastName} updated!";
            response.PathBack = $"{group.CourseId}/groups/{student.GroupId}";
            return View("Response", response);
        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}/students/delete/{idStudent}")]
        public IActionResult DeleteStudent(int idCourse, int idGroup, int idStudent)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            Student student = unitOfWork.Students.GetById(idStudent);
            if (course == null || course.Id != group.CourseId || student.GroupId != group.Id)
                return NotFound();
            var response = new Response();
            unitOfWork.Students.Remove(student.Id);
            unitOfWork.Save();
            response.Message = $"Student {student.FirstName} {student.LastName} deleted!";
            response.PathBack = $"{group.CourseId}/groups/{student.GroupId}";
            return View("Response", response);
        }

        [HttpGet]
        [Route("/students/create")]
        public IActionResult Create()
        {
            ViewData["Groups"] = unitOfWork.Groups.GetAll();
            return View("Create");
        }

        [HttpPost]
        [Route("/students/create")]
        public IActionResult Create(Student student)
        {
            unitOfWork.Students.Create(student);
            unitOfWork.Save();
            var group = unitOfWork.Groups.GetById(student.GroupId);
            var response = new Response();
            response.Message = $"Student {student.FirstName} {student.LastName} created!";
            response.PathBack = $"{group.CourseId}/groups/{student.GroupId}";
            return View("Response", response);
        }
    }
}
