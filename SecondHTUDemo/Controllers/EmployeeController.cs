using Microsoft.AspNet.Identity;
using SecondHTUDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondHTUDemo.Controllers
{
    public class EmployeeController : Controller
    {

        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Edit()
        {

            var EmployeeId = User.Identity.GetUserId();
            var Employee1 = db.Employees.SingleOrDefault(x => x.Id == EmployeeId);
            EditEmployeeProfileViewModel Profile = new EditEmployeeProfileViewModel();

            Profile.Email = Employee1.Email;
            Profile.FirstName = Employee1.FirstName;
            //Profile.LastName = student1.LastName;

            return View(Profile);
        }

        [HttpPost]
        public ActionResult Edit(EditEmployeeProfileViewModel Profile)
        {
            var EmployeeId = User.Identity.GetUserId();
            var Employee1 = db.Employees.SingleOrDefault(x => x.Id == EmployeeId);



            Employee1.Email = Profile.Email;
            Employee1.FirstName = Profile.FirstName;
            Employee1.LastName = Profile.LastName;
            Employee1.City = Profile.City;

            db.Entry(Employee1).State = EntityState.Modified;
            db.SaveChanges();
            return View(Profile);
        }


    }
}