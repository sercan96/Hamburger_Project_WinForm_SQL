namespace HomeworkProject
{
    partial class Form2
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
            this.cbxCategory1 = new System.Windows.Forms.ComboBox();
            this.btnAddHomework = new System.Windows.Forms.Button();
            this.txtAddHomeworkDesc = new System.Windows.Forms.TextBox();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.txtHomeworkTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxCategory1
            // 
            this.cbxCategory1.FormattingEnabled = true;
            this.cbxCategory1.Location = new System.Drawing.Point(44, 44);
            this.cbxCategory1.Name = "cbxCategory1";
            this.cbxCategory1.Size = new System.Drawing.Size(387, 24);
            this.cbxCategory1.TabIndex = 0;
            // 
            // btnAddHomework
            // 
            this.btnAddHomework.Location = new System.Drawing.Point(44, 287);
            this.btnAddHomework.Name = "btnAddHomework";
            this.btnAddHomework.Size = new System.Drawing.Size(387, 58);
            this.btnAddHomework.TabIndex = 2;
            this.btnAddHomework.Text = "Add Homework";
            this.btnAddHomework.UseVisualStyleBackColor = true;
            this.btnAddHomework.Click += new System.EventHandler(this.btnAddHomework_Click);
            // 
            // txtAddHomeworkDesc
            // 
            this.txtAddHomeworkDesc.Location = new System.Drawing.Point(44, 151);
            this.txtAddHomeworkDesc.Multiline = true;
            this.txtAddHomeworkDesc.Name = "txtAddHomeworkDesc";
            this.txtAddHomeworkDesc.Size = new System.Drawing.Size(387, 94);
            this.txtAddHomeworkDesc.TabIndex = 3;
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(44, 351);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(387, 58);
            this.btnForm3.TabIndex = 2;
            this.btnForm3.Text = "Form3";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // txtHomeworkTitle
            // 
            this.txtHomeworkTitle.Location = new System.Drawing.Point(44, 90);
            this.txtHomeworkTitle.Multiline = true;
            this.txtHomeworkTitle.Name = "txtHomeworkTitle";
            this.txtHomeworkTitle.Size = new System.Drawing.Size(387, 35);
            this.txtHomeworkTitle.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(534, 496);
            this.Controls.Add(this.txtHomeworkTitle);
            this.Controls.Add(this.txtAddHomeworkDesc);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnAddHomework);
            this.Controls.Add(this.cbxCategory1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCategory1;
        private System.Windows.Forms.Button btnAddHomework;
        private System.Windows.Forms.TextBox txtAddHomeworkDesc;
        private System.Windows.Forms.Button btnForm3;
        private System.Windows.Forms.TextBox txtHomeworkTitle;
    }
}