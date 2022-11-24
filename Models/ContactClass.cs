using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class ContactClass
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter phone number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Number must be numeric")]
        [StringLength(maximumLength: 15, MinimumLength = 5, ErrorMessage = "Length must be max 15 & min 5")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Enter message")]
        public string Message { get; set; }
    }
}
