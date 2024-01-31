using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCourse.Models;

namespace WebAppCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> listcourses = new List<Course>()
{
    new Course{ Id=1,Name="Sam",Fee=5000,Technology="Java",Start=new DateTime(day:23,month:11,year:2019),End=new DateTime(day:23,month:02,year:2020)},
     new Course{ Id=2,Name="Aju",Fee=6000,Technology="c#",Start=new DateTime(day:24,month:11,year:2019),End=new DateTime(day:23,month:02,year:2020)},
         new Course{ Id=3,Name="pavi",Fee=7000,Technology="testing",Start=new DateTime(day:24,month:11,year:2019),End=new DateTime(day:23,month:02,year:2020)},
        };
        public ActionResult Index()
        {
            return View(listcourses);
        }
    }
}