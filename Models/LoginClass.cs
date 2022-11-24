using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RentQuest.Models
{
    
    public class LoginClass
    {
        [Required(ErrorMessage = "Please Enter email")]
        [Display(Name = "Email : ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter password")]
        [Display(Name = "Password : ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
