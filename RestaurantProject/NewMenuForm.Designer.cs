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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtMenuDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewMenu = new System.Windows.Forms.Button();
            this.dgwMenuList = new System.Windows.Forms.DataGridView();
            this.btnListMenus = new System.Windows.Forms.Button();
            this.btnGoOrder = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryadd = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnListCategory = new System.Windows.Forms.Button();
            this.grbAddCategory = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCategoryList = new System.Windows.Forms.Label();
            this.btnListProductsByCategory = new System.Windows.Forms.Button();
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.grbAddProduct = new System.Windows.Forms.GroupBox();
            this.txtCategoryDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbProductById = new System.Windows.Forms.GroupBox();
            this.ProductId = new System.Windows.Forms.Label();
            this.btnProdutctById = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenuList)).BeginInit();
            this.grbAddCategory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbAddProduct.SuspendLayout();
            this.grbProductById.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(28, 146);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(241, 22);
            this.txtProductName.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(28, 124);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(25, 191);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(87, 16);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "Product Price";
            // 
            // txtMenuDesc
            // 
            this.txtMenuDesc.Location = new System.Drawing.Point(28, 331);
            this.txtMenuDesc.Multiline = true;
            this.txtMenuDesc.Name = "txtMenuDesc";
            this.txtMenuDesc.Size = new System.Drawing.Size(241, 128);
            this.txtMenuDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu Decription";
            // 
            // btnAddNewMenu
            // 
            this.btnAddNewMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddNewMenu.Location = new System.Drawing.Point(84, 465);
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
            this.dgwMenuList.Size = new System.Drawing.Size(923, 216);
            this.dgwMenuList.TabIndex = 8;
            // 
            // btnListMenus
            // 
            this.btnListMenus.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnListMenus.Location = new System.Drawing.Point(357, 315);
            this.btnListMenus.Name = "btnListMenus";
            this.btnListMenus.Size = new System.Drawing.Size(101, 40);
            this.btnListMenus.TabIndex = 9;
            this.btnListMenus.Text = "List Products";
            this.btnListMenus.UseVisualStyleBackColor = false;
            this.btnListMenus.Click += new System.EventHandler(this.btnListMenus_Click);
            // 
            // btnGoOrder
            // 
            this.btnGoOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnGoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoOrder.Location = new System.Drawing.Point(610, 302);
            this.btnGoOrder.Name = "btnGoOrder";
            this.btnGoOrder.Size = new System.Drawing.Size(670, 53);
            this.btnGoOrder.TabIndex = 9;
            this.btnGoOrder.Text = "Go Order Panel";
            this.btnGoOrder.UseVisualStyleBackColor = false;
            this.btnGoOrder.Click += new System.EventHandler(this.btnGoOrder_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(28, 221);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(241, 22);
            this.txtProductPrice.TabIndex = 10;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(28, 67);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(241, 24);
            this.cmbCategories.TabIndex = 11;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(28, 40);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(123, 16);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Choose Categories";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(6, 49);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(216, 22);
            this.txtCategoryName.TabIndex = 0;
            // 
            // lblCategoryadd
            // 
            this.lblCategoryadd.AutoSize = true;
            this.lblCategoryadd.Location = new System.Drawing.Point(3, 30);
            this.lblCategoryadd.Name = "lblCategoryadd";
            this.lblCategoryadd.Size = new System.Drawing.Size(102, 16);
            this.lblCategoryadd.TabIndex = 1;
            this.lblCategoryadd.Text = "Category Name";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddCategory.Location = new System.Drawing.Point(6, 142);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(106, 32);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // btnListCategory
            // 
            this.btnListCategory.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnListCategory.Location = new System.Drawing.Point(473, 315);
            this.btnListCategory.Name = "btnListCategory";
            this.btnListCategory.Size = new System.Drawing.Size(111, 40);
            this.btnListCategory.TabIndex = 7;
            this.btnListCategory.Text = "List Category";
            this.btnListCategory.UseVisualStyleBackColor = false;
            this.btnListCategory.Click += new System.EventHandler(this.btnListCategoryMenu_Click);
            // 
            // grbAddCategory
            // 
            this.grbAddCategory.BackColor = System.Drawing.Color.MistyRose;
            this.grbAddCategory.Controls.Add(this.label2);
            this.grbAddCategory.Controls.Add(this.lblCategoryadd);
            this.grbAddCategory.Controls.Add(this.txtCategoryDesc);
            this.grbAddCategory.Controls.Add(this.txtCategoryName);
            this.grbAddCategory.Controls.Add(this.btnAddCategory);
            this.grbAddCategory.Location = new System.Drawing.Point(356, 374);
            this.grbAddCategory.Name = "grbAddCategory";
            this.grbAddCategory.Size = new System.Drawing.Size(287, 190);
            this.grbAddCategory.TabIndex = 12;
            this.grbAddCategory.TabStop = false;
            this.grbAddCategory.Text = "CATEGORY";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox2.Controls.Add(this.lblCategoryList);
            this.groupBox2.Controls.Add(this.btnListProductsByCategory);
            this.groupBox2.Controls.Add(this.cmbCategoryList);
            this.groupBox2.Location = new System.Drawing.Point(680, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 190);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LIST PRODUCT BY CATEGORY";
            // 
            // lblCategoryList
            // 
            this.lblCategoryList.AutoSize = true;
            this.lblCategoryList.Location = new System.Drawing.Point(6, 52);
            this.lblCategoryList.Name = "lblCategoryList";
            this.lblCategoryList.Size = new System.Drawing.Size(73, 16);
            this.lblCategoryList.TabIndex = 1;
            this.lblCategoryList.Text = "Categories";
            // 
            // btnListProductsByCategory
            // 
            this.btnListProductsByCategory.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnListProductsByCategory.Location = new System.Drawing.Point(9, 109);
            this.btnListProductsByCategory.Name = "btnListProductsByCategory";
            this.btnListProductsByCategory.Size = new System.Drawing.Size(212, 32);
            this.btnListProductsByCategory.TabIndex = 7;
            this.btnListProductsByCategory.Text = "Product By Category";
            this.btnListProductsByCategory.UseVisualStyleBackColor = false;
            this.btnListProductsByCategory.Click += new System.EventHandler(this.btnListProductByCategory_Click);
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(9, 79);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(212, 24);
            this.cmbCategoryList.TabIndex = 11;
            // 
            // grbAddProduct
            // 
            this.grbAddProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbAddProduct.Controls.Add(this.lblCategoryName);
            this.grbAddProduct.Controls.Add(this.txtProductName);
            this.grbAddProduct.Controls.Add(this.lblProductName);
            this.grbAddProduct.Controls.Add(this.cmbCategories);
            this.grbAddProduct.Controls.Add(this.txtMenuDesc);
            this.grbAddProduct.Controls.Add(this.txtProductPrice);
            this.grbAddProduct.Controls.Add(this.lblProductPrice);
            this.grbAddProduct.Controls.Add(this.label1);
            this.grbAddProduct.Controls.Add(this.btnAddNewMenu);
            this.grbAddProduct.Location = new System.Drawing.Point(12, 42);
            this.grbAddProduct.Name = "grbAddProduct";
            this.grbAddProduct.Size = new System.Drawing.Size(317, 521);
            this.grbAddProduct.TabIndex = 14;
            this.grbAddProduct.TabStop = false;
            this.grbAddProduct.Text = "ADD PRODUCT";
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.Location = new System.Drawing.Point(6, 109);
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Size = new System.Drawing.Size(216, 22);
            this.txtCategoryDesc.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // grbProductById
            // 
            this.grbProductById.BackColor = System.Drawing.Color.Gold;
            this.grbProductById.Controls.Add(this.ProductId);
            this.grbProductById.Controls.Add(this.btnProdutctById);
            this.grbProductById.Controls.Add(this.txtProductId);
            this.grbProductById.Location = new System.Drawing.Point(994, 374);
            this.grbProductById.Name = "grbProductById";
            this.grbProductById.Size = new System.Drawing.Size(286, 190);
            this.grbProductById.TabIndex = 14;
            this.grbProductById.TabStop = false;
            this.grbProductById.Text = "PRODUCT BY ID WITH CATEGORY NAME";
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.Location = new System.Drawing.Point(6, 40);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(64, 16);
            this.ProductId.TabIndex = 1;
            this.ProductId.Text = "ProductId";
            // 
            // btnProdutctById
            // 
            this.btnProdutctById.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnProdutctById.Location = new System.Drawing.Point(9, 109);
            this.btnProdutctById.Name = "btnProdutctById";
            this.btnProdutctById.Size = new System.Drawing.Size(212, 32);
            this.btnProdutctById.TabIndex = 7;
            this.btnProdutctById.Text = "Product";
            this.btnProdutctById.UseVisualStyleBackColor = false;
            this.btnProdutctById.Click += new System.EventHandler(this.btnProdutctById_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(6, 69);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(241, 22);
            this.txtProductId.TabIndex = 10;
            // 
            // NewMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 604);
            this.Controls.Add(this.grbProductById);
            this.Controls.Add(this.grbAddProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbAddCategory);
            this.Controls.Add(this.btnListCategory);
            this.Controls.Add(this.btnGoOrder);
            this.Controls.Add(this.btnListMenus);
            this.Controls.Add(this.dgwMenuList);
            this.Name = "NewMenuForm";
            this.Text = "NewMenu";
            this.Load += new System.EventHandler(this.NewMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenuList)).EndInit();
            this.grbAddCategory.ResumeLayout(false);
            this.grbAddCategory.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbAddProduct.ResumeLayout(false);
            this.grbAddProduct.PerformLayout();
            this.grbProductById.ResumeLayout(false);
            this.grbProductById.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtMenuDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewMenu;
        private System.Windows.Forms.DataGridView dgwMenuList;
        private System.Windows.Forms.Button btnListMenus;
        private System.Windows.Forms.Button btnGoOrder;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryadd;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnListCategory;
        private System.Windows.Forms.GroupBox grbAddCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCategoryList;
        private System.Windows.Forms.Button btnListProductsByCategory;
        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.GroupBox grbAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryDesc;
        private System.Windows.Forms.GroupBox grbProductById;
        private System.Windows.Forms.Label ProductId;
        private System.Windows.Forms.Button btnProdutctById;
        private System.Windows.Forms.TextBox txtProductId;
    }
}