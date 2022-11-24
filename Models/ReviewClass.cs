using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class ReviewClass
    {
        [Key]
        public int R_Id { get; set; }

        public int SectionId { get; set; }

        public string temail { get; set; }

        public int c_Id { get; set; }

        public int Vote { get; set; }

        public bool active { get; set; }
    }
}
