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
    public partial class Form2 : Form
    {
        public Form2(List<Category> categories)
        {
            InitializeComponent();

            cbxCategory1.DataSource = categories;
        }
        private void btnAddHomework_Click(object sender, EventArgs e)
        {
            if (cbxCategory1.SelectedIndex > -1)
            {
                Category category = cbxCategory1.SelectedItem as Category;
                Homework homework = new Homework(txtHomeworkTitle.Text, txtAddHomeworkDesc.Text);
                category.Homeworks.Add(homework);
            }
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(cbxCategory1);
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

   
    }
}
