using RestaurantProject.Models;
using OOP_3_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("MyConnection")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
