using HamburgerProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_Interface.Models
{
    public class HamburgerMenuContext : DbContext
    {
        public HamburgerMenuContext() : base("MyConnection")
        { }
        public DbSet<HamburgerMenu> HamburgerMenus { get; set; }
    }
}
