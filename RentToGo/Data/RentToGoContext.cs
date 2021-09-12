using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentToGo.Models;

namespace RentToGo.Data
{
    public class RentToGoContext : DbContext
    {
        public RentToGoContext (DbContextOptions<RentToGoContext> options)
            : base(options)
        {
        }

        public DbSet<RentToGo.Models.Agent> Agent { get; set; }

        public DbSet<RentToGo.Models.Customer> Customer { get; set; }

        public DbSet<RentToGo.Models.Property> Property { get; set; }
    }
}
