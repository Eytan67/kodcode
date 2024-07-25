namespace Hospitality
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCategoryInpot = new System.Windows.Forms.TextBox();
            this.LstBxCategorys = new System.Windows.Forms.ListBox();
            this.BtnEnterCategory = new System.Windows.Forms.Button();
            this.BtnShowOrders = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Ccategory name";
            // 
            // TxtCategoryInpot
            // 
            this.TxtCategoryInpot.Location = new System.Drawing.Point(343, 92);
            this.TxtCategoryInpot.Name = "TxtCategoryInpot";
            this.TxtCategoryInpot.Size = new System.Drawing.Size(100, 22);
            this.TxtCategoryInpot.TabIndex = 4;
            this.TxtCategoryInpot.TextChanged += new System.EventHandler(this.TxtCategoryInpot_TextChanged);
            // 
            // LstBxCategorys
            // 
            this.LstBxCategorys.FormattingEnabled = true;
            this.LstBxCategorys.ItemHeight = 16;
            this.LstBxCategorys.Location = new System.Drawing.Point(283, 238);
            this.LstBxCategorys.Name = "LstBxCategorys";
            this.LstBxCategorys.Size = new System.Drawing.Size(222, 180);
            this.LstBxCategorys.TabIndex = 3;
            this.LstBxCategorys.SelectedIndexChanged += new System.EventHandler(this.LstBxCategorys_SelectedIndexChanged);
            // 
            // BtnEnterCategory
            // 
            this.BtnEnterCategory.Location = new System.Drawing.Point(283, 179);
            this.BtnEnterCategory.Name = "BtnEnterCategory";
            this.BtnEnterCategory.Size = new System.Drawing.Size(88, 33);
            this.BtnEnterCategory.TabIndex = 6;
            this.BtnEnterCategory.Text = "Enter";
            this.BtnEnterCategory.UseVisualStyleBackColor = true;
            this.BtnEnterCategory.Click += new System.EventHandler(this.BtnEnterCategory_Click);
            // 
            // BtnShowOrders
            // 
            this.BtnShowOrders.Location = new System.Drawing.Point(43, 345);
            this.BtnShowOrders.Name = "BtnShowOrders";
            this.BtnShowOrders.Size = new System.Drawing.Size(119, 73);
            this.BtnShowOrders.TabIndex = 7;
            this.BtnShowOrders.Text = "Show orders";
            this.BtnShowOrders.UseVisualStyleBackColor = true;
            this.BtnShowOrders.Click += new System.EventHandler(this.BtnShowOrders_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(417, 179);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(88, 33);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnShowOrders);
            this.Controls.Add(this.BtnEnterCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCategoryInpot);
            this.Controls.Add(this.LstBxCategorys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCategoryInpot;
        private System.Windows.Forms.ListBox LstBxCategorys;
        private System.Windows.Forms.Button BtnEnterCategory;
        private System.Windows.Forms.Button BtnShowOrders;
        private System.Windows.Forms.Button BtnDelete;
    }
}

