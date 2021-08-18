﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.Common;
using MVC.DataAccess;
using System.Linq;

namespace Controllers
{
    [Route("/courses/{idCourse}/groups/{idGroup}")]
    public class StudentsController : Controller
    {
        private UnitOfWork unitOfWork;
        private readonly IStringLocalizer<StudentsController> _localizer;
        private readonly ILogger<StudentsController> _logger;
        public StudentsController(UniversityContext context, IStringLocalizer<StudentsController> localizer,
            ILogger<StudentsController> logger)
        {
            unitOfWork = new UnitOfWork(context);
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}")]
        public IActionResult Students(int idCourse, int idGroup)
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
            ViewData["Groups"] = unitOfWork.Groups.GetAll();
            return View("EditStudent", student);
        }

        [HttpPost]
        [Route("/students/EditStudent")]
        public IActionResult EditStudent(Student student)
        {
            if (student != null && student.FirstName != null && student.LastName != null
                && student.GroupId != 0 && student.ExamScore != 0)
            {
                unitOfWork.Students.Update(student);
                unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertEditSuccess"].Value;
                TempData["AlertStatus"] = true;
            }
            else
            {
                TempData["AlertMessage"] = _localizer["AlertEditFail"].Value;
                TempData["AlertStatus"] = false;
            }

            int? courseId = unitOfWork.Groups.GetById(student.GroupId).CourseId;
            return Redirect($"/courses/{courseId}/groups/{student.GroupId}");
        }
       

        [HttpGet("/courses/{idCourse}/groups/{idGroup}/students/delete/{idStudent}")]
        public IActionResult DeleteStudent(int idCourse, int idGroup, int idStudent)
        {
            Course course = unitOfWork.Courses.GetById(idCourse);
            Group group = unitOfWork.Groups.GetById(idGroup);
            Student student = unitOfWork.Students.GetById(idStudent);



            if (course == null || group == null || student == null || course.Id != group.CourseId 
                || student.GroupId != group.Id)
            {
                TempData["AlertMessage"] = _localizer["AlertRemoveNotFound"].Value;
                TempData["AlertStatus"] = false;
                return Redirect($"/courses/{idCourse}/groups/{idGroup}");
            }
                
            unitOfWork.Students.Remove(student.Id);
            unitOfWork.Save();
            TempData["AlertMessage"] = _localizer["AlertRemoveSuccess"].Value;
            TempData["AlertStatus"] = true;
            return Redirect($"/courses/{idCourse}/groups/{idGroup}");
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
            if (student != null && student.FirstName != null && student.LastName != null
               && student.GroupId != 0 && student.ExamScore != 0)
            {
                unitOfWork.Students.Create(student);
                unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertCreateSuccess"].Value;
                TempData["AlertStatus"] = true;
            }
            else
            {
                TempData["AlertMessage"] = _localizer["AlertCreateFail"].Value;
                TempData["AlertStatus"] = false;
            }

            var group = unitOfWork.Groups.GetById(student.GroupId);
            return Redirect($"/courses/{group.CourseId}/groups/{group.Id}");
        }
    }
}
