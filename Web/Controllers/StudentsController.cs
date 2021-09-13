using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.Common;
using MVC.DataAccess;
using MVC.Web.Models.Student;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    [Route("/courses/{idCourse}/groups/{idGroup}")]
    public class StudentsController : BaseController<StudentsController>
    {
        public StudentsController(IUnitOfWork unitOfWork, IStringLocalizer<StudentsController> localizer,
            ILogger<StudentsController> logger) : base(unitOfWork, localizer, logger)
        {

        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}")]
        public IActionResult Index(int idCourse, int idGroup, string lastName, int page = 1,
            StudentSortState sortOrder = StudentSortState.LastNameAsc)
        {
            int pageSize = 10;
            Course course = _unitOfWork.Courses.GetById(idCourse);
            Group group = _unitOfWork.Groups.GetById(idGroup);
            if (course == null || group == null || course.Id != group.CourseId)
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
                Items = items
            };

            if (items.Count() == 0)
            {
                ViewData["NoResults"] = _localizer["NoResults"];
            }

            ViewBag.SortState = sortOrder;
            ViewData["PageSize"] = pageSize;
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, group);

            return View(viewModel);
        }

        [HttpGet("/courses/{idCourse}/groups/{idGroup}/students/edit/{idStudent}")]
        public IActionResult GetStudent(int idCourse, int idGroup, int idStudent)
        {        
            Course course = _unitOfWork.Courses.GetById(idCourse);
            Group group = _unitOfWork.Groups.GetById(idGroup);
            Student student = _unitOfWork.Students.GetById(idStudent);
            if (course == null || course.Id != group.CourseId || student == null || student.GroupId != group.Id)
                return NotFound();
            ViewData["Groups"] = _unitOfWork.Groups.GetAll();
            ViewBag.GroupId = idGroup;
            ViewBag.CourseId = idCourse;            
            ViewBag.OldName = student.LastName + " " + student.FirstName;
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, group, student.LastName + " " + student.FirstName);

            return View("Edit", student);
        }

        [HttpPost]
        [Route("/students/edit")]
        public IActionResult Edit(Student student)
        {
            if (string.IsNullOrEmpty(student.FirstName))               
                student.FirstName = student.FirstName.Trim();
            if (string.IsNullOrEmpty(student.LastName))
                student.LastName = student.LastName.Trim();
            Group group = _unitOfWork.Groups.GetById(student.GroupId);
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
                return Redirect($"/courses/{group.CourseId}/groups/{group.Id}");
            }

            ViewBag.CourseId = group.CourseId;
            ViewBag.GroupId = student.GroupId;
            ViewData["Groups"] = _unitOfWork.Groups.GetAll();
            Student editableStudent = _unitOfWork.Students.GetById(student.Id);
            Course course = _unitOfWork.Courses.GetById(group.CourseId);
            ViewBag.OldName = editableStudent.LastName + " " + editableStudent.FirstName;
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, group, editableStudent.LastName + " " + editableStudent.FirstName);
            
            return View(student);            
        }
       

        [HttpGet("/courses/{idCourse}/groups/{idGroup}/students/delete/{idStudent}")]
        public IActionResult Delete(int idCourse, int idGroup, int idStudent)
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
        public IActionResult MultipleDelete(int idCourse, int idGroup, int[] id)
        {    
            foreach(var _id in id)
            {
                Student student = _unitOfWork.Students.GetById(_id);
                if (student == null)
                {
                    TempData["AlertMessage"] = _localizer["AlertMultipleRemoveNotFound"].Value;
                    TempData["AlertStatus"] = false;
                    return Redirect($"/courses/{idCourse}/groups/{idGroup}");
                }
                _unitOfWork.Students.Remove(student.Id);
            }
            if(id.Length > 0)
            {
                _unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertMultipleRemoveSuccess"].Value;
                TempData["AlertStatus"] = true;
                return Redirect($"/courses/{idCourse}/groups/{idGroup}");
            }            
            TempData["AlertMessage"] = _localizer["AlertFailMultipleDelete"].Value;
            TempData["AlertStatus"] = false;
            var group = _unitOfWork.Groups.GetById(idGroup);
            return Redirect($"/courses/{group.CourseId}/groups/{group.Id}");            
        }

        [HttpGet]
        [Route("/students/create")]
        public IActionResult Create(int idGroup, int idCourse)
        {
            Group group = _unitOfWork.Groups.GetById(idGroup);
            Course course = _unitOfWork.Courses.GetById(idCourse);
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, group, _localizer["CreateStudent"]);
            ViewData["Groups"] = _unitOfWork.Groups.GetAll();
            ViewBag.GroupId = idGroup;            
            ViewBag.CourseId = idCourse;            
            return View("Create");
        }

        [HttpPost]
        [Route("/students/create")]
        public IActionResult Create(Student student)
        {
            if (string.IsNullOrEmpty(student.FirstName))
                student.FirstName = student.FirstName.Trim();
            if (string.IsNullOrEmpty(student.LastName))
                student.LastName = student.LastName.Trim();
            Group group = _unitOfWork.Groups.GetById(student.GroupId);
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
                return Redirect($"/courses/{group.CourseId}/groups/{group.Id}");
            }

            ViewBag.CourseId = group.CourseId;
            ViewBag.GroupId = student.GroupId;
            ViewData["Groups"] = _unitOfWork.Groups.GetAll();
            Course course = _unitOfWork.Courses.GetById(group.CourseId);
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, group, _localizer["CreateStudent"]);
            
            return View(student);            
        }

        private MvcBreadcrumbNode GetBreadCrumbs(Course course, Group group, string currentName)
        {
            currentName = currentName == null ? string.Empty : currentName;
            var node1 = new MvcBreadcrumbNode("Index", "Courses", _localizer["AllCourses"]);
            var node2 = new MvcBreadcrumbNode("Index", "Groups", course.Name)
            {
                RouteValues = new { idCourse=course.Id },
                Parent = node1
            };
            var node3 = new MvcBreadcrumbNode("Index", "Students", group.Name)
            {
                RouteValues = new { idCourse=course.Id, idGroup=group.Id },
                Parent = node2
            };
            var node4 = new MvcBreadcrumbNode("", "", currentName)
            {
                Parent = node3
            };
            return node4;
        }

        private MvcBreadcrumbNode GetBreadCrumbs(Course course, Group group)
        {
            var node1 = new MvcBreadcrumbNode("Index", "Courses", _localizer["AllCourses"]);
            var node2 = new MvcBreadcrumbNode("Index", "Groups", course.Name)
            {
                RouteValues = new { idCourse = course.Id },
                Parent = node1
            };
            var node3 = new MvcBreadcrumbNode("", "", group.Name)
            {               
                Parent = node2
            };
            return node3;
        }
    }
}
