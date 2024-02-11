using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_Interface.Models
{
    public class HamburgerMenu : BaseEntity
    {
        public string Description { get; set; }

        public HamburgerMenu(string name, decimal price, string description)
        {
            Name = name;         
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} => Price : {Price}";
        }

    }
}
