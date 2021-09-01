using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.Common;
using MVC.DataAccess;
using MVC.Web.Models.Student;
using SmartBreadcrumbs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    [Route("/courses/{idCourse}/groups/{idGroup}")]
    public class StudentsController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<StudentsController> _localizer;
        private readonly ILogger<StudentsController> _logger;
        public StudentsController(IUnitOfWork unitOfWork, IStringLocalizer<StudentsController> localizer,
            ILogger<StudentsController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}")]
        [Breadcrumb("Students", FromController = typeof(GroupsController), FromAction = "Groups")]
        public IActionResult Students(int idCourse, int idGroup, string lastName, int page = 1,
            StudentSortState sortOrder = StudentSortState.LastNameAsc)
        {
            int pageSize = 10;
            Course course = _unitOfWork.Courses.GetById(idCourse);
            Group group = _unitOfWork.Groups.GetById(idGroup);
            if (course == null || course.Id != group.CourseId)
                return NotFound();

            ViewBag.Group = group;

            IQueryable<Student> students = _unitOfWork.Students.GetAll().Where( x => x.GroupId == idGroup);
            if (!String.IsNullOrEmpty(lastName))
            {
                students = students.Where(p => p.LastName.Contains(lastName));
            }

            switch (sortOrder)
            {
                case StudentSortState.FirstNameAsc:
                    students = students.OrderBy(s => s.FirstName);
                    break;
                case StudentSortState.FirstNameDesc:
                    students = students.OrderByDescending(s => s.FirstName);
                    break;
                case StudentSortState.LastNameDesc:
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case StudentSortState.AgeAsc:
                    students = students.OrderBy(s => s.DateOfBirth);
                    break;
                case StudentSortState.AgeDesc:
                    students = students.OrderByDescending(s => s.DateOfBirth);
                    break;
                case StudentSortState.ExamScoreAsc:
                    students = students.OrderBy(s => s.ExamScore);
                    break;
                case StudentSortState.ExamScoreDesc:
                    students = students.OrderByDescending(s => s.ExamScore);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }

            var count = students.Count();
            var items = students.Skip((page - 1) * pageSize).Take(pageSize);

            StudentIndexViewModel viewModel = new StudentIndexViewModel
            {
                PageViewModel = new StudentPageViewModel(count, page, pageSize),
                SortViewModel = new StudentSortViewModel(sortOrder),
                FilterViewModel = new StudentFilterViewModel(lastName),
                Students = items
            };

            ViewData["PageSize"] = pageSize;

            return View("Students", viewModel);
        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}/students/edit/{idStudent}")]
        public IActionResult GetEditStudent(int idCourse, int idGroup, int idStudent)
        {
            Course course = _unitOfWork.Courses.GetById(idCourse);
            Group group = _unitOfWork.Groups.GetById(idGroup);
            Student student = _unitOfWork.Students.GetById(idStudent);
            if (course == null || course.Id != group.CourseId || student == null || student.GroupId != group.Id)
                return NotFound();
            ViewData["Groups"] = _unitOfWork.Groups.GetAll();
            ViewBag.GroupId = idGroup;
            ViewBag.CourseId = idCourse;
            return View("EditStudent", student);
        }

        [HttpPost]
        [Route("/students/EditStudent")]
        public IActionResult EditStudent(Student student)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(student.LastName))
            {
                ModelState.AddModelError(nameof(student.LastName), _localizer["EmptyLastName"]);
            }
            if (string.IsNullOrEmpty(student.FirstName))
            {
                ModelState.AddModelError(nameof(student.FirstName), _localizer["EmptyFirstName"]);
            }
            if (student.GroupId == 0)
            {
                ModelState.AddModelError(nameof(student.GroupId), _localizer["NotSelectedGroup"]);
            }
            if (student.ExamScore == 0)
            {
                ModelState.AddModelError(nameof(student.ExamScore), _localizer["EmptyExamScore"]);
            }
            if (student.DateOfBirth == null)
            {
                ModelState.AddModelError(nameof(student.DateOfBirth), _localizer["EmptyDateOfBirth"]);                
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Students.Update(student);
                _unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertEditSuccess"].Value;
                TempData["AlertStatus"] = true;
                var group = _unitOfWork.Groups.GetById(student.GroupId);
                return Redirect($"/courses/{group.CourseId}/groups/{group.Id}");
            }
            else
            {
                ViewData["Groups"] = _unitOfWork.Groups.GetAll();
                ViewBag.GroupId = student.GroupId;
                ViewBag.CourseId = _unitOfWork.Groups.GetById(student.GroupId).CourseId;
                return View(student);
            }
        }
       

        [HttpGet("/courses/{idCourse}/groups/{idGroup}/students/delete/{idStudent}")]
        public IActionResult DeleteStudent(int idCourse, int idGroup, int idStudent)
        {
            Student student = _unitOfWork.Students.GetById(idStudent);
            if (student == null)
            {
                TempData["AlertMessage"] = _localizer["AlertRemoveNotFound"].Value;
                TempData["AlertStatus"] = false;
                return Redirect($"/courses/{idCourse}/groups/{idGroup}");
            }
                
            _unitOfWork.Students.Remove(student.Id);
            _unitOfWork.Save();
            TempData["AlertMessage"] = _localizer["AlertRemoveSuccess"].Value;
            TempData["AlertStatus"] = true;
            return Redirect($"/courses/{idCourse}/groups/{idGroup}");
        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}/students/multipleDelete/")]
        public IActionResult MultipleDelete(int idCourse, int idGroup, string ids)
        {
            var idStudents = new List<int>();
            try
            {
                idStudents = ids.Split(',').Select(x => int.Parse(x)).ToList();
            }
            catch
            {
                TempData["AlertMessage"] = _localizer["AlertFailMultipleDelete"].Value;
                TempData["AlertStatus"] = false;
                var group = _unitOfWork.Groups.GetById(idGroup);
                return Redirect($"/courses/{group.CourseId}/groups/{group.Id}");
            }

            foreach(var id in idStudents)
            {
                Student student = _unitOfWork.Students.GetById(id);
                if (student == null)
                {
                    TempData["AlertMessage"] = _localizer["AlertMultipleRemoveNotFound"].Value;
                    TempData["AlertStatus"] = false;
                    return Redirect($"/courses/{idCourse}/groups/{idGroup}");
                }
                _unitOfWork.Students.Remove(student.Id);
            }
            _unitOfWork.Save();
            TempData["AlertMessage"] = _localizer["AlertMultipleRemoveSuccess"].Value;
            TempData["AlertStatus"] = true;
            return Redirect($"/courses/{idCourse}/groups/{idGroup}");
        }


        [HttpGet]
        [Route("/students/create")]
        public IActionResult Create(int idGroup, int idCourse)
        {
            ViewData["Groups"] = _unitOfWork.Groups.GetAll();
            ViewBag.GroupId = idGroup;            
            ViewBag.CourseId = idCourse;            
            return View("Create");
        }

        [HttpPost]
        [Route("/students/create")]
        public IActionResult Create(Student student)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(student.LastName))
            {
                ModelState.AddModelError(nameof(student.LastName), _localizer["EmptyLastName"]);
            }
            if (string.IsNullOrEmpty(student.FirstName))
            {
                ModelState.AddModelError(nameof(student.FirstName), _localizer["EmptyFirstName"]);
            }
            if (student.GroupId == 0)
            {
                ModelState.AddModelError(nameof(student.GroupId), _localizer["NotSelectedGroup"]);
            }
            if (student.ExamScore == 0)
            {
                ModelState.AddModelError(nameof(student.ExamScore), _localizer["EmptyExamScore"]);
            }
            if (student.DateOfBirth == null)
            {
                ModelState.AddModelError(nameof(student.DateOfBirth), _localizer["EmptyDateOfBirth"]);                
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Students.Create(student);
                _unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertCreateSuccess"].Value;
                TempData["AlertStatus"] = true;
                var group = _unitOfWork.Groups.GetById(student.GroupId);
                return Redirect($"/courses/{group.CourseId}/groups/{group.Id}");
            }
            else
            {
                ViewData["Groups"] = _unitOfWork.Groups.GetAll();
                ViewBag.GroupId = student.GroupId;
                ViewBag.CourseId = _unitOfWork.Groups.GetById(student.GroupId).CourseId; 
                return View(student);
            }
        }
    }
}
