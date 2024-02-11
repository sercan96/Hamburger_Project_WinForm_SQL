using HamburgerProject.Enums;
using HamburgerProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HamburgerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<HamburgerMenu> hamburgerMenus = new List<HamburgerMenu>()
            {
                new HamburgerMenu("Texas Steakhouse",140,"A great fried delicacy from the gourmet menu"),
                new HamburgerMenu("Barbeku Brioche",190, "Are you ready a barbeque hot of Mexico"),
                new HamburgerMenu("Crispy Chicken", 170,"Chickens have never been this crispy"),
                new HamburgerMenu("SteakHouse", 210,"You will like it so much that you will want more"),
            };

            foreach (HamburgerMenu item in hamburgerMenus)
            {
                cbxMenus.Items.Add(item);
            }
        }

        private void MenuSelectedChanged(object sender, EventArgs e)
        {
            if(cbxMenus.SelectedIndex > -1)
            {
                HamburgerMenu hamburger = cbxMenus.SelectedItem as HamburgerMenu;
                lblDecription.Text = hamburger.Description;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail(txtName.Text);

            foreach (CheckBox item in gbxExtras.Controls)
            {
                if(item.Checked)
                {
                    Extra extra = new Extra();
                    extra.Name = item.Text;
                    extra.Price = Convert.ToDecimal(item.Tag);
                    orderDetail.Extras.Add(extra);
                }
            }

            if (rdoBigSize.Checked) orderDetail.Size = HamburgerSize.Big;
            else if (rdoMiddleSize.Checked) orderDetail.Size = HamburgerSize.Medium;

            orderDetail.Count = Convert.ToInt32(countHamburger.Value);
            orderDetail.ChoosenMenu = cbxMenus.SelectedItem as HamburgerMenu;

    
            orderDetail.CalculateTotalFee();
           
            lstOrders.Items.Add(orderDetail);

       
        }

        private void btnCiro_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (OrderDetail item in lstOrders.Items)
            {
                total += item.Price;
            }
            MessageBox.Show(total.ToString());
        }
    }
}
