using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class WLClass
    {
        [Key]
        public int Id { get; set; }
        public int C_Id { get; set; }
        
        public string T_Email { get; set; }

    }
}
