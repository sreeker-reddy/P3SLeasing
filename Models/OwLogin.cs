using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class OwLogin
    {
        [Required(ErrorMessage = "Please Enter email")]
        [Display(Name = "Email : ")]
        public string H_Email { get; set; }
        [Required(ErrorMessage = "Please Enter password")]
        [Display(Name = "Password : ")]
        [DataType(DataType.Password)]
        public string H_Password { get; set; }
    }
}
