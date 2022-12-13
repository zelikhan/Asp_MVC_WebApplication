using Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        List<student> std = new List<student>()
        {
            new student(){id=1,name="Muzammil",address="Kamra Cantt",gpa=3.0,p_no=0232323,age=20},
            new student(){id=2,name="Huzaifa",address="Hazro Vero",gpa=4.0,p_no=0232323,age=20 },
            new student(){id=3,name="Ahmed",address="Islamabad",gpa=4.0,p_no=35623,age=20 },
            new student(){id=4,name="Khushi",address="Bahalwalpur",gpa=4.0,p_no=345345,age=20 },
            new student(){id=5,name="Moiz",address="Karachi",gpa=4.0,p_no=345,age=20 },
            new student(){id=6,name="Irtaza",address="Attock",gpa=4.0,p_no=532323,age=20},

        };

        public ActionResult Index()
        {
            return View(std);
        }

        public ActionResult Edit(int id)
        {
            student stu = new student();
            stu = std.FirstOrDefault(x => x.id == id);
            return View(stu);
        }

        public ActionResult Details(int id)
        {
            student stu = new student();
            stu = std.FirstOrDefault(x => x.id == id);
            //std.Add(stu);
            return View(stu);
        }

        public ActionResult Delete(int id)
        {
            student stu = new student();
            stu = std.FirstOrDefault(x => x.id == id);
            std.Remove(stu);
            return View(stu);
        }

        public ActionResult Create()
        {
            student stu = new student();   
            std.Add(stu);
            return View();
        }








    }
}