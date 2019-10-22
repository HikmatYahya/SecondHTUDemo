using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecondHTUDemo.Models
{
    public class HTUStuff
    {
        public string Id { get; set; }

        public string Email { get; set; }


        [StringLength(256)]
        public string FirstName { get; set; }

        [StringLength(256)]
        //[DataType()]
        public string LastName { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
    }
}