using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Entity
{
    public class Product : IEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        /// <summary> Entity-CTOR
        /// Entity Framework, sınıfları veritabanından veri çekerken parametreli bir yapılandırıcı kullanmaz. Veritabanından veri çekerken,     varsayılan (parametresiz) bir yapılandırıcı bekler.
        /// </summary>
        public Product() 
        {
        
        }
        public Product(string name, decimal price, string description)
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
