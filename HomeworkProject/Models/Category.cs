using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<Homework> Homeworks { get; set; }

        public Category(string name)
        {
            Name = name;
            Homeworks = new List<Homework>();
        }
        public override string ToString()
        {
            return $"Name : {Name} , Homework Count : {Homeworks.Count}";
        }
    }
}
