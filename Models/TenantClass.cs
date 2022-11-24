using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RentQuest.Models
{
    public class TenantClass
    {
        [Key]
        public int TID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name : ")]
        [StringLength(maximumLength: 10, MinimumLength = 2, ErrorMessage = "Length must be max 10 & min 2")]
        public string TName { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [Display(Name = "Password : ")]
        [DataType(DataType.Password)]
        public string TPwd { get; set; }
        //[Required(ErrorMessage = "Enter Re-Password")]
        [Display(Name = "Re-Password : ")]
        [DataType(DataType.Password)]
        [Compare("TPwd", ErrorMessage = "Password and Confirmation Password must match")]
        public string TRePwd { get; set; }
        [Required(ErrorMessage = "Enter email address")]
        [Display(Name = "Email : ")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string TEmail { get; set; }
        [Required(ErrorMessage = "Enter phone number")]
        [Display(Name = "Phone Number : ")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Number must be numeric")]
        [StringLength(maximumLength: 15, MinimumLength = 5, ErrorMessage = "Length must be max 15 & min 5")]
        public string TPhone { get; set; }
        [Required(ErrorMessage = "Select Gender")]
        [Display(Name = "Gender : ")]
        public string TGender { get; set; }
        [Required(ErrorMessage = "Give Date of Birth")]
        [Display(Name = "Date of Birth : ")]
        public DateTime TDOB { get; set; }
        [Display(Name = "Profile Image : ")]
        public string TImg { get; set; }
    }
}
