using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentQuest.Models;

namespace RentQuest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CircTypes> CircTypes { get; set; }

        public DbSet<Circulations> Circulations { get; set; }

        public DbSet<VisitRequest> VisitRequests { get; set; }

        public DbSet<ReqDetails> ReqDetails { get; set; }

        public DbSet<TenantClass> Tenants { get; set; }

        public DbSet<OwnerClass> Owners { get; set; }

        public DbSet<WLClass> WishList { get; set; }

        //public DbSet<ReviewClass> Reviews { get; set; }

        public DbSet<ContactClass> Contacts { get; set; }
    }
}
