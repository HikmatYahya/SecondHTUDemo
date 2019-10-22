using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecondHTUDemo.Models
{
    public class Student
    {

        public string Id { get; set; }

        [StringLength(256)]
        public string FirstName { get; set; }

       [StringLength(256)]
        public string LastName { get; set; }

        public string Email { get; set; }

        //[Range(17,60)]
        public int Age { get; set; }
        public string Major { get; set; }
        public string Country { get; set; }

       
        public string City { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public bool IsApproved { get; set; }
        public string StudentSkills { get; set; }
        public string CV_Path { get; set; }

    }
}