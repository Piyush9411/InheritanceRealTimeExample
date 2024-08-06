using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRealTimeExample
{
    public class ECommerce : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-FOG7AJIS;Database=EFCoreDemo;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }

    }
}
