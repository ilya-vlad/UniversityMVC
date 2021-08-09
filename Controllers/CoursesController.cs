using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC.Controllers
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

        [HttpGet("{idCourse}/groups/edit/{idGroup}")]
        
        public IActionResult GetEditGroup(int idCourse, int idGroup)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            if (course == null || course.Id != group.CourseId)
                return NotFound();            
            return View("EditGroup", group);
        }

        [HttpPost]        
        [Route("EditGroup")]
        public IActionResult EditGroup(Group group)
        {
            unitOfWork.Groups.Update(group);
            unitOfWork.Save();
            var response = new Response();
            response.Message = $"Group {group.Name} updated!";
            response.PathBack = $"{group.CourseId}/groups";
            return View("Response", response);
        }


        [HttpGet("{idCourse}/groups/delete/{idGroup}")]
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


        [HttpGet("{idCourse}/groups/{idGroup}")]
        public IActionResult GetStudents(int idCourse, int idGroup)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            if (course == null || course.Id != group.CourseId)
                return NotFound();
            ViewBag.GroupId = idGroup;
            return View("Students", unitOfWork);
        }

        [HttpGet("{idCourse}/groups/{idGroup}/students/edit/{idStudent}")]
        public IActionResult GetOptionsStudent(int idCourse, int idGroup, int idStudent)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            Student student = unitOfWork.Students.GetById(idStudent);
            if (course == null || course.Id != group.CourseId || student.GroupId != group.Id)
                return NotFound();
            return View("EditStudent", student);
        }

        [HttpPost]
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

        [HttpGet("{idCourse}/groups/{idGroup}/students/delete/{idStudent}")]
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
    }
}