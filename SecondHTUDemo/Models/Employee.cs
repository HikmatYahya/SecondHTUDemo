using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecondHTUDemo.Models
{
    public class Employee
    {

        public string Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [StringLength(256)]
        public string FirstName { get; set; }

        [StringLength(256)]
        //[DataType()]
        public string LastName { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        public bool IsApproved { get; set; }

        [StringLength(256)]
        public string SkillsLookingFor { get; set; }

        public string Phone { get; set; }

    }
}