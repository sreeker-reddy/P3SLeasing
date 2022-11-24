using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class ReqDetails
    {
        public int Id { get; set; }

        [Display(Name ="Visit Request")]
        public int ReqId { get; set; }

        [Display(Name = "Circulation")]
        public int C_Id { get; set; }

        [ForeignKey("ReqId")]
        public VisitRequest VisitRequest { get; set; }


        [ForeignKey("C_Id")]
        public Circulations Circulation { get; set; }
    }
}
