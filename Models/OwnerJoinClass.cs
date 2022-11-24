using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class OwnerJoinClass
    {
        public TenantClass TDetails { get; set; }

        public Circulations CDetails { get; set; }

        public VisitRequest VDetails { get; set; }

        public ReqDetails ReqDetails { get; set; }

        public OwnerClass OwDetails { get; set; }
    }
}
