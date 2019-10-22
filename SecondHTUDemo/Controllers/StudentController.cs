using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using SecondHTUDemo.Models;
using Microsoft.AspNet.Identity;

namespace SecondHTUDemo.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Student 


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Edit()
        {

            var studentId = User.Identity.GetUserId();
            var student1 = db.Students.SingleOrDefault(x => x.Id == studentId);
            EditStudentProfileViewModel Profile = new EditStudentProfileViewModel();

            Profile.Email = student1.Email;
            Profile.FirstName = student1.FirstName;
            //Profile.LastName = student1.LastName;

            return View(Profile);
        }

        [HttpPost]
        public ActionResult Edit(EditStudentProfileViewModel Profile)
        {
            var studentId = User.Identity.GetUserId();
            var student1 = db.Students.SingleOrDefault(x => x.Id == studentId);



            student1.Email = Profile.Email;
            student1.FirstName = Profile.FirstName;
            student1.LastName = Profile.LastName;
            student1.Major = Profile.Major;

            db.Entry(student1).State = EntityState.Modified;
            db.SaveChanges();




            return View(Profile);
        }


    }
}