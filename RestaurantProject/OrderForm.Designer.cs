namespace RestaurantProject
{
    partial class OrderForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMenus = new System.Windows.Forms.Label();
            this.cbxMenus = new System.Windows.Forms.ComboBox();
            this.rdoBigSize = new System.Windows.Forms.RadioButton();
            this.rdoSmallSize = new System.Windows.Forms.RadioButton();
            this.rdoMiddleSize = new System.Windows.Forms.RadioButton();
            this.gbxExtras = new System.Windows.Forms.GroupBox();
            this.ckbxSarmısaklıMayonez = new System.Windows.Forms.CheckBox();
            this.ckbxBallıHardal = new System.Windows.Forms.CheckBox();
            this.ckbxHardal = new System.Windows.Forms.CheckBox();
            this.ckbxBuffalo = new System.Windows.Forms.CheckBox();
            this.ckbxRanch = new System.Windows.Forms.CheckBox();
            this.ckbxBarbeku = new System.Windows.Forms.CheckBox();
            this.ckbxMayonez = new System.Windows.Forms.CheckBox();
            this.ckbxAcıSos = new System.Windows.Forms.CheckBox();
            this.ckbxKetcap = new System.Windows.Forms.CheckBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.countHamburger = new System.Windows.Forms.NumericUpDown();
            this.lblDecription = new System.Windows.Forms.Label();
            this.gbxExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countHamburger)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(28, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblMenus
            // 
            this.lblMenus.AutoSize = true;
            this.lblMenus.Location = new System.Drawing.Point(25, 87);
            this.lblMenus.Name = "lblMenus";
            this.lblMenus.Size = new System.Drawing.Size(47, 16);
            this.lblMenus.TabIndex = 1;
            this.lblMenus.Text = "Menus";
            // 
            // cbxMenus
            // 
            this.cbxMenus.FormattingEnabled = true;
            this.cbxMenus.Location = new System.Drawing.Point(28, 133);
            this.cbxMenus.Name = "cbxMenus";
            this.cbxMenus.Size = new System.Drawing.Size(229, 24);
            this.cbxMenus.TabIndex = 2;
            this.cbxMenus.SelectedIndexChanged += new System.EventHandler(this.MenuSelectedChanged);
            // 
            // rdoBigSize
            // 
            this.rdoBigSize.AutoSize = true;
            this.rdoBigSize.Location = new System.Drawing.Point(28, 177);
            this.rdoBigSize.Name = "rdoBigSize";
            this.rdoBigSize.Size = new System.Drawing.Size(77, 20);
            this.rdoBigSize.TabIndex = 3;
            this.rdoBigSize.TabStop = true;
            this.rdoBigSize.Text = "Big Size";
            this.rdoBigSize.UseVisualStyleBackColor = true;
            // 
            // rdoSmallSize
            // 
            this.rdoSmallSize.AutoSize = true;
            this.rdoSmallSize.Location = new System.Drawing.Point(28, 275);
            this.rdoSmallSize.Name = "rdoSmallSize";
            this.rdoSmallSize.Size = new System.Drawing.Size(91, 20);
            this.rdoSmallSize.TabIndex = 3;
            this.rdoSmallSize.TabStop = true;
            this.rdoSmallSize.Text = "Small Size";
            this.rdoSmallSize.UseVisualStyleBackColor = true;
            // 
            // rdoMiddleSize
            // 
            this.rdoMiddleSize.AutoSize = true;
            this.rdoMiddleSize.Location = new System.Drawing.Point(28, 228);
            this.rdoMiddleSize.Name = "rdoMiddleSize";
            this.rdoMiddleSize.Size = new System.Drawing.Size(98, 20);
            this.rdoMiddleSize.TabIndex = 3;
            this.rdoMiddleSize.TabStop = true;
            this.rdoMiddleSize.Text = "Middle Size";
            this.rdoMiddleSize.UseVisualStyleBackColor = true;
            // 
            // gbxExtras
            // 
            this.gbxExtras.BackColor = System.Drawing.Color.LightCoral;
            this.gbxExtras.Controls.Add(this.ckbxSarmısaklıMayonez);
            this.gbxExtras.Controls.Add(this.ckbxBallıHardal);
            this.gbxExtras.Controls.Add(this.ckbxHardal);
            this.gbxExtras.Controls.Add(this.ckbxBuffalo);
            this.gbxExtras.Controls.Add(this.ckbxRanch);
            this.gbxExtras.Controls.Add(this.ckbxBarbeku);
            this.gbxExtras.Controls.Add(this.ckbxMayonez);
            this.gbxExtras.Controls.Add(this.ckbxAcıSos);
            this.gbxExtras.Controls.Add(this.ckbxKetcap);
            this.gbxExtras.Location = new System.Drawing.Point(28, 319);
            this.gbxExtras.Name = "gbxExtras";
            this.gbxExtras.Size = new System.Drawing.Size(450, 192);
            this.gbxExtras.TabIndex = 4;
            this.gbxExtras.TabStop = false;
            this.gbxExtras.Text = "Extras";
            // 
            // ckbxSarmısaklıMayonez
            // 
            this.ckbxSarmısaklıMayonez.AutoSize = true;
            this.ckbxSarmısaklıMayonez.Location = new System.Drawing.Point(292, 119);
            this.ckbxSarmısaklıMayonez.Name = "ckbxSarmısaklıMayonez";
            this.ckbxSarmısaklıMayonez.Size = new System.Drawing.Size(150, 20);
            this.ckbxSarmısaklıMayonez.TabIndex = 5;
            this.ckbxSarmısaklıMayonez.Tag = "3";
            this.ckbxSarmısaklıMayonez.Text = "Sarmısaklı Mayonez";
            this.ckbxSarmısaklıMayonez.UseVisualStyleBackColor = true;
            // 
            // ckbxBallıHardal
            // 
            this.ckbxBallıHardal.AutoSize = true;
            this.ckbxBallıHardal.Location = new System.Drawing.Point(292, 76);
            this.ckbxBallıHardal.Name = "ckbxBallıHardal";
            this.ckbxBallıHardal.Size = new System.Drawing.Size(99, 20);
            this.ckbxBallıHardal.TabIndex = 5;
            this.ckbxBallıHardal.Tag = "3";
            this.ckbxBallıHardal.Text = "Ballı Hardal";
            this.ckbxBallıHardal.UseVisualStyleBackColor = true;
            // 
            // ckbxHardal
            // 
            this.ckbxHardal.AutoSize = true;
            this.ckbxHardal.Location = new System.Drawing.Point(18, 119);
            this.ckbxHardal.Name = "ckbxHardal";
            this.ckbxHardal.Size = new System.Drawing.Size(70, 20);
            this.ckbxHardal.TabIndex = 5;
            this.ckbxHardal.Tag = "2";
            this.ckbxHardal.Text = "Hardal";
            this.ckbxHardal.UseVisualStyleBackColor = true;
            // 
            // ckbxBuffalo
            // 
            this.ckbxBuffalo.AutoSize = true;
            this.ckbxBuffalo.Location = new System.Drawing.Point(292, 38);
            this.ckbxBuffalo.Name = "ckbxBuffalo";
            this.ckbxBuffalo.Size = new System.Drawing.Size(70, 20);
            this.ckbxBuffalo.TabIndex = 5;
            this.ckbxBuffalo.Tag = "2";
            this.ckbxBuffalo.Text = "Buffalo";
            this.ckbxBuffalo.UseVisualStyleBackColor = true;
            // 
            // ckbxRanch
            // 
            this.ckbxRanch.AutoSize = true;
            this.ckbxRanch.Location = new System.Drawing.Point(149, 119);
            this.ckbxRanch.Name = "ckbxRanch";
            this.ckbxRanch.Size = new System.Drawing.Size(68, 20);
            this.ckbxRanch.TabIndex = 5;
            this.ckbxRanch.Tag = "3";
            this.ckbxRanch.Text = "Ranch";
            this.ckbxRanch.UseVisualStyleBackColor = true;
            // 
            // ckbxBarbeku
            // 
            this.ckbxBarbeku.AutoSize = true;
            this.ckbxBarbeku.Location = new System.Drawing.Point(149, 81);
            this.ckbxBarbeku.Name = "ckbxBarbeku";
            this.ckbxBarbeku.Size = new System.Drawing.Size(80, 20);
            this.ckbxBarbeku.TabIndex = 5;
            this.ckbxBarbeku.Tag = "2";
            this.ckbxBarbeku.Text = "Barbeku";
            this.ckbxBarbeku.UseVisualStyleBackColor = true;
            // 
            // ckbxMayonez
            // 
            this.ckbxMayonez.AutoSize = true;
            this.ckbxMayonez.Location = new System.Drawing.Point(18, 76);
            this.ckbxMayonez.Name = "ckbxMayonez";
            this.ckbxMayonez.Size = new System.Drawing.Size(84, 20);
            this.ckbxMayonez.TabIndex = 5;
            this.ckbxMayonez.Tag = "1.50";
            this.ckbxMayonez.Text = "Mayonez";
            this.ckbxMayonez.UseVisualStyleBackColor = true;
            // 
            // ckbxAcıSos
            // 
            this.ckbxAcıSos.AutoSize = true;
            this.ckbxAcıSos.Location = new System.Drawing.Point(149, 38);
            this.ckbxAcıSos.Name = "ckbxAcıSos";
            this.ckbxAcıSos.Size = new System.Drawing.Size(75, 20);
            this.ckbxAcıSos.TabIndex = 5;
            this.ckbxAcıSos.Tag = "1.75";
            this.ckbxAcıSos.Text = "Acı Sos";
            this.ckbxAcıSos.UseVisualStyleBackColor = true;
            // 
            // ckbxKetcap
            // 
            this.ckbxKetcap.AutoSize = true;
            this.ckbxKetcap.Location = new System.Drawing.Point(18, 38);
            this.ckbxKetcap.Name = "ckbxKetcap";
            this.ckbxKetcap.Size = new System.Drawing.Size(71, 20);
            this.ckbxKetcap.TabIndex = 5;
            this.ckbxKetcap.Tag = "1.50";
            this.ckbxKetcap.Text = "Ketcap";
            this.ckbxKetcap.UseVisualStyleBackColor = true;
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(565, 52);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(926, 436);
            this.lstOrders.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdd.Location = new System.Drawing.Point(565, 525);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 57);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTotalPrice.Location = new System.Drawing.Point(1355, 525);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(136, 57);
            this.btnTotalPrice.TabIndex = 6;
            this.btnTotalPrice.Text = "Total Price";
            this.btnTotalPrice.UseVisualStyleBackColor = false;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // countHamburger
            // 
            this.countHamburger.Location = new System.Drawing.Point(410, 52);
            this.countHamburger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countHamburger.Name = "countHamburger";
            this.countHamburger.Size = new System.Drawing.Size(68, 22);
            this.countHamburger.TabIndex = 8;
            this.countHamburger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDecription
            // 
            this.lblDecription.BackColor = System.Drawing.Color.White;
            this.lblDecription.Location = new System.Drawing.Point(36, 540);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(442, 139);
            this.lblDecription.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1548, 726);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.countHamburger);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.gbxExtras);
            this.Controls.Add(this.rdoMiddleSize);
            this.Controls.Add(this.rdoSmallSize);
            this.Controls.Add(this.rdoBigSize);
            this.Controls.Add(this.cbxMenus);
            this.Controls.Add(this.lblMenus);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxExtras.ResumeLayout(false);
            this.gbxExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countHamburger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMenus;
        private System.Windows.Forms.ComboBox cbxMenus;
        private System.Windows.Forms.RadioButton rdoBigSize;
        private System.Windows.Forms.RadioButton rdoSmallSize;
        private System.Windows.Forms.RadioButton rdoMiddleSize;
        private System.Windows.Forms.GroupBox gbxExtras;
        private System.Windows.Forms.CheckBox ckbxSarmısaklıMayonez;
        private System.Windows.Forms.CheckBox ckbxBallıHardal;
        private System.Windows.Forms.CheckBox ckbxHardal;
        private System.Windows.Forms.CheckBox ckbxBuffalo;
        private System.Windows.Forms.CheckBox ckbxBarbeku;
        private System.Windows.Forms.CheckBox ckbxAcıSos;
        private System.Windows.Forms.CheckBox ckbxKetcap;
        private System.Windows.Forms.CheckBox ckbxRanch;
        private System.Windows.Forms.CheckBox ckbxMayonez;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.NumericUpDown countHamburger;
        private System.Windows.Forms.Label lblDecription;
    }
}

