using OOP_3_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Models
{
    class DBTool
    {
        public DBTool()
        { }

        private static RestaurantDbContext _db;

        public static RestaurantDbContext HamburgerMenuContext { 
            get
            {
                if (_db == null) _db = new RestaurantDbContext();
                return _db;
            } 
        }
         

    }
}
