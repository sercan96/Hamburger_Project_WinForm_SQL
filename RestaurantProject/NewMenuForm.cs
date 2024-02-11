using RestaurantProject;
using RestaurantProject.Models;
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
        RestaurantDbContext _db;
        void GetListOfMenu()
        {
            using (_db = new RestaurantDbContext())
            {
                // Check if there is a hamburger menu in the database
                if (!_db.Products.Any())
                {
                    // If there are no hamburger menus in the database, default menus are added
                    List<Category> defaultCategories =  AddDefaultCategory();
                    List<Product> defaultMenus = AddDefaultProducts();
                    _db.Products.AddRange(defaultMenus);
                    _db.Categories.AddRange(defaultCategories);
                    _db.SaveChanges();
                }

                // Load hamburger menus into DataGridView
                dgwMenuList.DataSource = _db.Products.ToList();
            }      
        }

        List<Category> AddDefaultCategory()
        {
            List<Category> categories = new List<Category>
            {
                new Category{Name = "Hamburger",Description = "Favorite Hamburgers" },
                new Category{Name = "Soap",Description = "Favorite Soap" },
                new Category{Name = "Pizza",Description = "Favorite Pizza" }
            };
            return categories;
        }

        List<Product> AddDefaultProducts()
        {           
            List<Product> products = new List<Product>()
              {
                   new Product("Texas Steakhouse",140,"A great fried delicacy from the gourmet menu"){CategoryId=1},
                   new Product("Barbeku Brioche",190, "Are you ready a barbeque hot of Mexico"){CategoryId=1},
                   new Product("Crispy Chicken", 170,"Chickens have never been this crispy") { CategoryId = 1 },
                   new Product("SteakHouse", 210,"You will like it so much that you will want more") { CategoryId = 1 },
                   new Product("Lentil Soup", 50,"We are the address of the most delicious soups") { CategoryId = 2 },
                   new Product("Anchovy", 210,"Freshly collected from the Black Sea") { CategoryId = 3 }
              };

            return products;
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

            using (_db = new RestaurantDbContext())
            {
                Product hamburgerMenu = new Product(txtMenuName.Text, Convert.ToDecimal(txtMenuPrice.Text), txtMenuDesc.Text);
                _db.Products.Add(hamburgerMenu);
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
