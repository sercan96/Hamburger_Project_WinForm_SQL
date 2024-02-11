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
    public partial class Form3 : Form
    {
        public Form3(ComboBox categories)
        {
            InitializeComponent();

            //foreach (var item in categories.Items)
            //{
            //    cbxCategory2.Items.Add(item);
            //}

            cbxCategory2.DataSource = categories.DataSource;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
  
        }

        private void btnRandomQuestion_Click(object sender, EventArgs e)
        {
            if(cbxCategory2.SelectedIndex > -1)
            {
                Category category = cbxCategory2.SelectedItem as Category;

                Random rnd = new Random();
                for (int i = 0; i < numericCount.Value; i++)
                {
                    if(category.Homeworks.Count >= numericCount.Value)
                    {
                        lstHomeworks.Items.Add(category.Homeworks[rnd.Next(0, category.Homeworks.Count)].Question);
                    }
                    else
                    {
                        MessageBox.Show("Bu kategoride istediğiniz kadar ödev bulunmamakta");
                    }
                }              
            }
        }

        private void btnClear(object sender, EventArgs e)
        {
            lstHomeworks.Items.Clear();
        }
    }
}
