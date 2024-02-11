using RestaurantProject;
using RestaurantProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantProject.Entity;
using System.Security.Cryptography;
using System.Data.Entity;
using System.Xml.Linq;

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
            GetDefaultMenus();
        }
        void GetDefaultMenus()
        {
            var db = DBTool.RestaurantMenuContext;
            // Check if there is a hamburger menu in the database
            if (!db.Products.Any())
            {
                // If there are no hamburger menus in the database, default menus are added
                List<Category> defaultCategories = AddDefaultCategory();
                List<Product> defaultMenus = AddDefaultProducts();
                db.Products.AddRange(defaultMenus);
                db.Categories.AddRange(defaultCategories);
                db.SaveChanges();
            }

            // Load hamburger menus into DataGridView
            dgwMenuList.DataSource = db.Products.ToList();

            cmbCategories.DataSource = db.Categories.ToList();
            cmbCategoryList.DataSource = db.Categories.ToList();
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
            if (!CheckMenuInfo(grbAddProduct,"Fill In The Remaining Information"))
                return;

            ListProductByCategory();

            MessageBox.Show("Added new Menu");


        }

        void ListProductByCategory()
        {
            Category c = cmbCategories.SelectedItem as Category;
            var db = DBTool.RestaurantMenuContext;
            // Add the product directly

            Product product = new Product(txtProductName.Text, Convert.ToDecimal(txtProductPrice.Text), txtMenuDesc.Text)
            { CategoryId = c.Id };
            db.Products.Add(product);
            db.SaveChanges();

            // Adding the Product via Category

            Category category = new Category()
            {
                Name = c.Name,
                Description = c.Description,
                Products = new List<Product> { new Product(txtProductName.Text, Convert.ToDecimal(txtProductPrice.Text), txtMenuDesc.Text) }
            };
            db.Categories.Add(category);
            db.SaveChanges();
        }

        private bool CheckMenuInfo(GroupBox groupBox,string info)
        {
            var textBoxes = groupBox.Controls.OfType<TextBox>();
            foreach (TextBox item in textBoxes)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show(info);
                    return false;
                }
            }
            return true;

        }

        private void btnListMenus_Click(object sender, EventArgs e)
        {
            dgwMenuList.DataSource = DBTool.RestaurantMenuContext.Products.ToList();
        }

        private void btnListCategoryMenu_Click(object sender, EventArgs e)
        {
            dgwMenuList.DataSource = DBTool.RestaurantMenuContext.Categories.ToList();

        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            if (!CheckMenuInfo(grbAddCategory, "Fill In The Remaining Information"))
                return;

            AddNewCategory();
        }

        private void AddNewCategory()
        {
            var db = DBTool.RestaurantMenuContext;
            Category c = new Category()
            {
                Name = txtCategoryName.Text,
                Description = txtCategoryDesc.Text
            };

            db.Categories.Add(c);
            db.SaveChanges();

            cmbCategories.Items.Add(c);
            cmbCategoryList.Items.Add(c);
            MessageBox.Show($"New Category Added ({c.Name})");
        }

        private void btnListProductByCategory_Click(object sender, EventArgs e)
        {
            Category category = cmbCategoryList.SelectedItem as Category;
            dgwMenuList.DataSource = DBTool.RestaurantMenuContext.Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        private void btnProdutctById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            Product product = DBTool.RestaurantMenuContext.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);

            List<Product> productList = new List<Product>();
            productList.Add(product);
            dgwMenuList.DataSource = productList;

            /*
             *  Navigation Property :
             *  
             *  Pricable(Ana), nesnesindeki listeden oluşan nesnelerin navigation propertyleri null olacaktır. Fakat  ".Include(p=>           p.Category)" FirstOrDefault metodu, belirli bir productId ile eşleşen ürünü alırken aynı sorguda ilgili Category nesnesini   de yükleyecektir. Böylece, dönen Product nesnesi, ilişkili Category nesnesine de erişilebilir olacaktır.
             *  
             *  Dependent(Bağımlı), nesneden navigation Property id tanımlandığında otomatik olarak o id ile nesne ilişkilendirilir ve       navigation property otomaik doldurulur.
             *  
            */



        }
    }
}
