using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List(string SearchKey = null)
        {
            TeacherDataController controller = new TeacherDataController();
            IEnumerable<Teacher> teachers = controller.ListTeachers(SearchKey);
            return View(teachers);
        }
        public ActionResult Show(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher teacher = controller.FindTeacher(id);
            return View(teacher);
        }
        public ActionResult New()
        {
            return View();
        }
        //POST : /Teacher/Create
        [HttpPost]
        public ActionResult Create(string teacherfname, string teacherlname, string employeenumber, DateTime date, decimal salary)
        {
            //Identify that this method is running
            //Identify the inputs provided from the form

            Debug.WriteLine("I have accessed the Create Method!");
            Debug.WriteLine(teacherfname);
            Debug.WriteLine(teacherlname);
            Debug.WriteLine(employeenumber);

            Teacher NewTeacher = new Teacher();
            NewTeacher.teacherfname = teacherfname;
            NewTeacher.teacherlname = teacherlname;
            NewTeacher.enumber = employeenumber;
            NewTeacher.date = date;
            NewTeacher.salary = salary;

            TeacherDataController controller = new TeacherDataController();
            controller.AddTeacher(NewTeacher);

            return RedirectToAction("List");
        }
        public ActionResult Delete(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            controller.DeleteTeacher(id);
            return RedirectToAction("List");
        }
    }
}