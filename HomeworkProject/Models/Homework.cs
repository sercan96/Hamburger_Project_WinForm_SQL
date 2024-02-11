using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject.Models
{
    public class Homework
    {
        public string Title { get; set; }
        public string Question { get; set; }

        public Homework(string title, string question)
        {
            Title = title;
            Question = question;
        }
    }
}
