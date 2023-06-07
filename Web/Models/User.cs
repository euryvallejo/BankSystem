using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models {
    public class User : IdentityUser{
        public int UserId { get; set; }
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public string UserName { get; set; }        
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }

    }
}