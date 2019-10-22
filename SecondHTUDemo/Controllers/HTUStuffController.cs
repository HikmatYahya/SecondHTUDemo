using Microsoft.AspNet.Identity;
using SecondHTUDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace SecondHTUDemo.Controllers
{
    public class HTUStuffController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: HTUStuff
        public ActionResult Index()
        {
            var HTUStuffId = User.Identity.GetUserId();
            var HTUStuff1 = db.HTUStuffs.SingleOrDefault(x => x.Id == HTUStuffId);
            EditHTUStuffProfileViewModel Profile = new EditHTUStuffProfileViewModel();

            Profile.Email = HTUStuff1.Email;
            Profile.FirstName = HTUStuff1.FirstName;
            return View();
        }



        [HttpGet]
        public ActionResult Edit()
        {

            var HTUStuffId = User.Identity.GetUserId();
            var HTUStuff1 = db.HTUStuffs.SingleOrDefault(x => x.Id == HTUStuffId);
            EditHTUStuffProfileViewModel Profile = new EditHTUStuffProfileViewModel();

            Profile.Email = HTUStuff1.Email;
            Profile.FirstName = HTUStuff1.FirstName;
           //Profile.LastName = student1.LastName;

            return View(Profile);
        }

        [HttpPost]
        public ActionResult Edit(EditHTUStuffProfileViewModel Profile)
        {
            var HTUStuffId = User.Identity.GetUserId();
            var HTUStuff1 = db.HTUStuffs.SingleOrDefault(x => x.Id == HTUStuffId);



            HTUStuff1.Email = Profile.Email;
            HTUStuff1.FirstName = Profile.FirstName;
            HTUStuff1.LastName = Profile.LastName;
            //HTUStuff1. = Profile.Major;

            db.Entry(HTUStuff1).State = EntityState.Modified;
            db.SaveChanges();




            return View(Profile);
        }




    }
}