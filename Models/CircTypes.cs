using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class CircTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Circulation Type")]
        public string CircType { get; set; }
    }
}
