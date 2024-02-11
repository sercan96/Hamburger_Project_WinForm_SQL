namespace OOP_3_Interface
{
    partial class LoginForm
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.AddNewMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOrder.Location = new System.Drawing.Point(60, 223);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(198, 42);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "CUSTOMER LOGIN";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // AddNewMenu
            // 
            this.AddNewMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddNewMenu.Location = new System.Drawing.Point(60, 284);
            this.AddNewMenu.Name = "AddNewMenu";
            this.AddNewMenu.Size = new System.Drawing.Size(198, 48);
            this.AddNewMenu.TabIndex = 0;
            this.AddNewMenu.Text = "ADMIN LOGIN";
            this.AddNewMenu.UseVisualStyleBackColor = false;
            this.AddNewMenu.Click += new System.EventHandler(this.AddNewMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_3_Interface.Properties.Resources.restaurant_open_sign;
            this.pictureBox1.Location = new System.Drawing.Point(41, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(328, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddNewMenu);
            this.Controls.Add(this.btnOrder);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button AddNewMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}