using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentQuest.Models
{
    public class OwCircClass
    {
        public OwnerClass OwDetails { get; set; }

        public Circulations CDetails { get; set; }
    }
}
