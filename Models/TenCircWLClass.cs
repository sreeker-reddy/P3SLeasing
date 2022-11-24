using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class TenCircWLClass
    {
        public TenantClass TDetails { get; set; }

        public Circulations CDetails { get; set; }

        public WLClass WDetails { get; set; }
    }
}
