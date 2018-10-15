using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Lab1b.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }
   
        [Required]
        public int BirthDate { get; set; }

    }
}
