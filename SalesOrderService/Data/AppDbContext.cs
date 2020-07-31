using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesOrderService.Models;

namespace SalesOrderService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<SalesOrderService.Models.Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {

        }

    }
}
