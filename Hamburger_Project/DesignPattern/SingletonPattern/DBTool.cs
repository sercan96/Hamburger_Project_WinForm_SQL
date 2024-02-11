using OOP_3_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_Interface.DesignPattern.SingletonPattern
{
    class DBTool
    {
        public DBTool()
        { }

        private static HamburgerMenuContext _db;

        public static HamburgerMenuContext HamburgerMenuContext { 
            get
            {
                if (_db == null) _db = new HamburgerMenuContext();
                return _db;
            } 
        }
         

    }
}
