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
        // _lock nesnesi, çoklu iş parçacığı ortamlarında güvenliği sağlamak için kullanılır.
        private static readonly object _lock = new object();

        private static RestaurantDbContext _db;

        public static RestaurantDbContext RestaurantMenuContext {
            get
            {
                lock (_lock)
                {
                    if (_db == null)
                    {
                        _db = new RestaurantDbContext();
                    }
                    return _db;
                }
            }
        }
         

    }
}
