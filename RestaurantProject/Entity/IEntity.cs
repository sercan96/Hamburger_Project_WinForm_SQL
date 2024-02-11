using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Entity
{
    public interface IEntity
    {
        int Id { get; }
        string Name { get; }
    }
}
