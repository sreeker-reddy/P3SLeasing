using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class OwnerClass
    {
        [Key]
        public int H_ID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name : ")]
        [StringLength(maximumLength: 10, MinimumLength = 2, ErrorMessage = "Length must be max 10 & min 2")]
        public string HName { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [Display(Name = "Password : ")]
        [DataType(DataType.Password)]
        public string HPwd { get; set; }
        //[Required(ErrorMessage = "Enter Re-Password")]
        [Display(Name = "Re-Password : ")]
        [DataType(DataType.Password)]
        [Compare("HPwd", ErrorMessage = "Password and Confirmation Password must match")]
        public string HRePwd { get; set; }
        [Required(ErrorMessage = "Enter email address")]
        [Display(Name = "Email : ")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string HEmail { get; set; }
        [Required(ErrorMessage = "Enter phone number")]
        [Display(Name = "Phone Number : ")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Number must be numeric")]
        [StringLength(maximumLength: 15, MinimumLength = 5, ErrorMessage = "Length must be max 15 & min 5")]
        public string HPhone { get; set; }
        [Required(ErrorMessage = "Select Gender")]
        [Display(Name = "Gender : ")]
        public string HGender { get; set; }
        [Required(ErrorMessage = "Give Date of Birth")]
        [Display(Name = "Date of Birth : ")]
        public DateTime HDOB { get; set; }
        [Display(Name = "Profile Image : ")]
        public string HImg { get; set; }
    }
}
