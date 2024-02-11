namespace HomeworkProject
{
    partial class Form3
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
            this.cbxCategory2 = new System.Windows.Forms.ComboBox();
            this.numericCount = new System.Windows.Forms.NumericUpDown();
            this.lstHomeworks = new System.Windows.Forms.ListBox();
            this.btnRandomQuestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCategory2
            // 
            this.cbxCategory2.FormattingEnabled = true;
            this.cbxCategory2.Location = new System.Drawing.Point(33, 49);
            this.cbxCategory2.Name = "cbxCategory2";
            this.cbxCategory2.Size = new System.Drawing.Size(392, 24);
            this.cbxCategory2.TabIndex = 0;
            // 
            // numericCount
            // 
            this.numericCount.Location = new System.Drawing.Point(33, 110);
            this.numericCount.Name = "numericCount";
            this.numericCount.Size = new System.Drawing.Size(82, 22);
            this.numericCount.TabIndex = 1;
            // 
            // lstHomeworks
            // 
            this.lstHomeworks.FormattingEnabled = true;
            this.lstHomeworks.ItemHeight = 16;
            this.lstHomeworks.Location = new System.Drawing.Point(33, 185);
            this.lstHomeworks.Name = "lstHomeworks";
            this.lstHomeworks.Size = new System.Drawing.Size(392, 180);
            this.lstHomeworks.TabIndex = 2;
            // 
            // btnRandomQuestion
            // 
            this.btnRandomQuestion.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRandomQuestion.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRandomQuestion.Location = new System.Drawing.Point(33, 425);
            this.btnRandomQuestion.Name = "btnRandomQuestion";
            this.btnRandomQuestion.Size = new System.Drawing.Size(392, 41);
            this.btnRandomQuestion.TabIndex = 3;
            this.btnRandomQuestion.Text = "Random Question";
            this.btnRandomQuestion.UseVisualStyleBackColor = false;
            this.btnRandomQuestion.Click += new System.EventHandler(this.btnRandomQuestion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(33, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Random Question";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClear);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(450, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRandomQuestion);
            this.Controls.Add(this.lstHomeworks);
            this.Controls.Add(this.numericCount);
            this.Controls.Add(this.cbxCategory2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCategory2;
        private System.Windows.Forms.NumericUpDown numericCount;
        private System.Windows.Forms.ListBox lstHomeworks;
        private System.Windows.Forms.Button btnRandomQuestion;
        private System.Windows.Forms.Button button1;
    }
}