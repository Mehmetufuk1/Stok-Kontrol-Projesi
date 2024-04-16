using Microsoft.EntityFrameworkCore;
using StockControlProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlProject.Repositories.Context
{
    public class StockControlContext :DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-M2EMNTI;Database=stock-project11;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=true;TrustServerCertificate=True;");
        }
    }
}
