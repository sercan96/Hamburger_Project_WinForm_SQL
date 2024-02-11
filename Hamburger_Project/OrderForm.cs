using HamburgerProject.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HamburgerProject
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = DBTool.HamburgerMenuContext)
            {
                foreach (HamburgerMenu item in db.HamburgerMenus)
                {
                    cbxMenus.Items.Add(item);
                }
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
