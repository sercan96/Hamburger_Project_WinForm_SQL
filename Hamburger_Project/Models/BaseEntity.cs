using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerProject.Models
{
    public abstract class BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
