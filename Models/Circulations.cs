using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class Circulations
    {
        public int Id { get; set; }

        public string HEmail { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]

        [Display(Name = "Monthly Rent")]
        public decimal Monthly_Rent { get; set; }

        public string Image { get; set; }

        [Display(Name ="Residence Location")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Available")]
        public bool isAvailable { get; set; }

        [Display(Name = "Circulation Type")]
        [Required]
        public int CircTypeId { get; set; }

        [ForeignKey("CircTypeId")]
        public CircTypes CircTypes { get; set; }

        public int House_No { get; set; }

        public string Flat_No { get; set; }

        public decimal SizeSQFT { get; set; }

        public int num_bed { get; set; }

        public int num_bath { get; set; }

        public string Cdetails { get; set; }

        //public string Votes { get; set; }
    }
}
