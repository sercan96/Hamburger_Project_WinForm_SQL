using HomeworkProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Category> categories = new List<Category>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category1 = new Category(txtCategory.Text);
            categories.Add(category1);
            MessageBox.Show(category1.Name);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(categories);
            form2.Show();
        }
    }
}
