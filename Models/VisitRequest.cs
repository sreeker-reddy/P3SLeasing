using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class VisitRequest
    {
        public VisitRequest()
        {
            ReqDetails = new List<ReqDetails>();
        }

        public int Id { get; set; }

        [Display(Name = "Request No.")]
        public string ReqNo { get; set; }

        //[Required]
        //public string Name { get; set; }

        //[Required]
        //[Display(Name ="Phone No.")]
        //public string PhoneNo { get; set; }

        //[Required]
        //[EmailAddress]
        public string Email { get; set; }

        //[Required]
        //public string Address { get; set; }


        public DateTime? ReqDate { get; set; }

        //[Required]
        //public int TenID { get; set; }

        //[ForeignKey("TenID")]
        //public TenantClass TenantClass { get; set; }

        public virtual List<ReqDetails> ReqDetails { get; set; }
    }
}
