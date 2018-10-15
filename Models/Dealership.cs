using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1b.Models
{
    public class Dealership
    {
        /*
        Model - Add the Dealership entity with the following mandatory fields: ID, Name and Email.  
        It should also have an optional PhoneNumber field.    
        Use suitable annotation attributes for display and validation purposes.
        */
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public int PhoneNumber { get; set; }
    }
}
