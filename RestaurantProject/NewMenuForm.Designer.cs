namespace OOP_3_Interface
{
    partial class NewMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.lblHamburgerName = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.txtMenuDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewMenu = new System.Windows.Forms.Button();
            this.dgwMenuList = new System.Windows.Forms.DataGridView();
            this.btnListMenus = new System.Windows.Forms.Button();
            this.btnGoOrder = new System.Windows.Forms.Button();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenuList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(34, 58);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(241, 22);
            this.txtMenuName.TabIndex = 0;
            // 
            // lblHamburgerName
            // 
            this.lblHamburgerName.AutoSize = true;
            this.lblHamburgerName.Location = new System.Drawing.Point(34, 36);
            this.lblHamburgerName.Name = "lblHamburgerName";
            this.lblHamburgerName.Size = new System.Drawing.Size(80, 16);
            this.lblHamburgerName.TabIndex = 1;
            this.lblHamburgerName.Text = "Menu Name";
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Location = new System.Drawing.Point(34, 135);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(74, 16);
            this.lblMenuPrice.TabIndex = 3;
            this.lblMenuPrice.Text = "Menu Price";
            // 
            // txtMenuDesc
            // 
            this.txtMenuDesc.Location = new System.Drawing.Point(37, 278);
            this.txtMenuDesc.Multiline = true;
            this.txtMenuDesc.Name = "txtMenuDesc";
            this.txtMenuDesc.Size = new System.Drawing.Size(241, 128);
            this.txtMenuDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu Decription";
            // 
            // btnAddNewMenu
            // 
            this.btnAddNewMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddNewMenu.Location = new System.Drawing.Point(93, 412);
            this.btnAddNewMenu.Name = "btnAddNewMenu";
            this.btnAddNewMenu.Size = new System.Drawing.Size(101, 40);
            this.btnAddNewMenu.TabIndex = 7;
            this.btnAddNewMenu.Text = "Add";
            this.btnAddNewMenu.UseVisualStyleBackColor = false;
            this.btnAddNewMenu.Click += new System.EventHandler(this.btnAddNewMenu_Click);
            // 
            // dgwMenuList
            // 
            this.dgwMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMenuList.Location = new System.Drawing.Point(357, 58);
            this.dgwMenuList.Name = "dgwMenuList";
            this.dgwMenuList.RowHeadersWidth = 51;
            this.dgwMenuList.RowTemplate.Height = 24;
            this.dgwMenuList.Size = new System.Drawing.Size(642, 216);
            this.dgwMenuList.TabIndex = 8;
            // 
            // btnListMenus
            // 
            this.btnListMenus.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnListMenus.Location = new System.Drawing.Point(357, 297);
            this.btnListMenus.Name = "btnListMenus";
            this.btnListMenus.Size = new System.Drawing.Size(101, 40);
            this.btnListMenus.TabIndex = 9;
            this.btnListMenus.Text = "List Menus";
            this.btnListMenus.UseVisualStyleBackColor = false;
            this.btnListMenus.Click += new System.EventHandler(this.btnListMenus_Click);
            // 
            // btnGoOrder
            // 
            this.btnGoOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnGoOrder.Location = new System.Drawing.Point(457, 386);
            this.btnGoOrder.Name = "btnGoOrder";
            this.btnGoOrder.Size = new System.Drawing.Size(392, 66);
            this.btnGoOrder.TabIndex = 9;
            this.btnGoOrder.Text = "Order Panel";
            this.btnGoOrder.UseVisualStyleBackColor = false;
            this.btnGoOrder.Click += new System.EventHandler(this.btnGoOrder_Click);
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Location = new System.Drawing.Point(37, 165);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(241, 22);
            this.txtMenuPrice.TabIndex = 10;
            // 
            // NewMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 504);
            this.Controls.Add(this.txtMenuPrice);
            this.Controls.Add(this.btnGoOrder);
            this.Controls.Add(this.btnListMenus);
            this.Controls.Add(this.dgwMenuList);
            this.Controls.Add(this.btnAddNewMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMenuPrice);
            this.Controls.Add(this.txtMenuDesc);
            this.Controls.Add(this.lblHamburgerName);
            this.Controls.Add(this.txtMenuName);
            this.Name = "NewMenuForm";
            this.Text = "NewMenu";
            this.Load += new System.EventHandler(this.NewMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label lblHamburgerName;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.TextBox txtMenuDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewMenu;
        private System.Windows.Forms.DataGridView dgwMenuList;
        private System.Windows.Forms.Button btnListMenus;
        private System.Windows.Forms.Button btnGoOrder;
        private System.Windows.Forms.TextBox txtMenuPrice;
    }
}