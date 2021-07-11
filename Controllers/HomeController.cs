using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }


        //private GeneralModel GetGeneralModel()
        //{
        //    var model = new GeneralModel();
        //    model.Courses = db.Courses.ToList();
        //    model.Groups = db.Groups.ToList();
        //    model.Students = db.Students.ToList();
        //    return model;
        //}


        public IActionResult Courses()
        {
            var courses = unitOfWork.Courses.GetAll();
            return View();
        }

        public IActionResult Editor()
        {
            return View();
        }
        
        public IActionResult Groups(int? id)
        {
            if (id == null) return RedirectToAction("Courses");
            ViewBag.CourseId = id;          
            return View(new UnitOfWork());
        }

        public IActionResult Students(int? id)
        {
            if (id == null) return RedirectToAction("Courses");
            ViewBag.GroupId = id;           
            return View(new UnitOfWork());
        }

    }
}
