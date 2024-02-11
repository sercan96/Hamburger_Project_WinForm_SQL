using HamburgerProject;
using HamburgerProject.Models;
using OOP_3_Interface.DesignPattern.SingletonPattern;
using OOP_3_Interface.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3_Interface
{
    public partial class NewMenuForm : Form
    {
        public NewMenuForm()
        {
            InitializeComponent();
        }

        private void NewMenuForm_Load(object sender, EventArgs e)
        {
            GetListOfMenu();
        }
        HamburgerMenuContext _db;
        void GetListOfMenu()
        {
            using (_db = new HamburgerMenuContext())
            {
                // Check if there is a hamburger menu in the database
                if (!_db.HamburgerMenus.Any())
                {
                    // If there are no hamburger menus in the database, default menus are added
                    List<HamburgerMenu> defaultMenus = DefaultMenus();
                    _db.HamburgerMenus.AddRange(defaultMenus);
                    _db.SaveChanges();
                }

                // Load hamburger menus into DataGridView
                dgwMenuList.DataSource = _db.HamburgerMenus.ToList();
            }      
        }

        List<HamburgerMenu> DefaultMenus()
        {
            List<HamburgerMenu> hamburgerMenus = new List<HamburgerMenu>()
              {
                   new HamburgerMenu("Texas Steakhouse",140,"A great fried delicacy from the gourmet menu"),
                   new HamburgerMenu("Barbeku Brioche",190, "Are you ready a barbeque hot of Mexico"),
                   new HamburgerMenu("Crispy Chicken", 170,"Chickens have never been this crispy"),
                   new HamburgerMenu("SteakHouse", 210,"You will like it so much that you will want more"),
              };

            return hamburgerMenus;
        }

        private void btnGoOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void btnAddNewMenu_Click(object sender, EventArgs e)
        {
            if (!CheckMenuInfo("Fill In The Remaining Information"))
                return;

            using (_db = new HamburgerMenuContext())
            {
                HamburgerMenu hamburgerMenu = new HamburgerMenu(txtMenuName.Text, Convert.ToDecimal(txtMenuPrice.Text), txtMenuDesc.Text);
                _db.HamburgerMenus.Add(hamburgerMenu);
                _db.SaveChanges();
            }

            MessageBox.Show("Added new Menu");


        }

        private bool CheckMenuInfo(string info)
        {
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    if(item == null)
                    {
                        MessageBox.Show(info);
                        return false;
                    }
               
                }
            }
            return true;

        }

        private void btnListMenus_Click(object sender, EventArgs e)
        {
            GetListOfMenu();
        }
    }
}
