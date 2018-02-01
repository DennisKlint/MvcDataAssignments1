using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcDataAssignments.Models
{
    public class PersonModel
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a Name")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Please enter a City")]
        public string City { get; set; }
        [Required (ErrorMessage = "Please enter a number")]
        public int PhoneNumber { get; set; }
    }
}