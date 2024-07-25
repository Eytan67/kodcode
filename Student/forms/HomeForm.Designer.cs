namespace Student.forms
{
    partial class HomeForm
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
            this.BtnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNameField = new System.Windows.Forms.TextBox();
            this.CmbBxCources = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LstBxCources = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(626, 323);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(120, 115);
            this.BtnEnter.TabIndex = 0;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Name";
            // 
            // TxtNameField
            // 
            this.TxtNameField.Location = new System.Drawing.Point(626, 77);
            this.TxtNameField.Name = "TxtNameField";
            this.TxtNameField.Size = new System.Drawing.Size(120, 22);
            this.TxtNameField.TabIndex = 2;
            // 
            // CmbBxCources
            // 
            this.CmbBxCources.FormattingEnabled = true;
            this.CmbBxCources.Location = new System.Drawing.Point(626, 152);
            this.CmbBxCources.Name = "CmbBxCources";
            this.CmbBxCources.Size = new System.Drawing.Size(121, 24);
            this.CmbBxCources.TabIndex = 3;
            this.CmbBxCources.SelectedIndexChanged += new System.EventHandler(this.CmbBxCources_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 256);
            this.dataGridView1.TabIndex = 4;
            // 
            // LstBxCources
            // 
            this.LstBxCources.FormattingEnabled = true;
            this.LstBxCources.ItemHeight = 16;
            this.LstBxCources.Location = new System.Drawing.Point(627, 213);
            this.LstBxCources.Name = "LstBxCources";
            this.LstBxCources.Size = new System.Drawing.Size(120, 84);
            this.LstBxCources.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "choose cource";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LstBxCources);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmbBxCources);
            this.Controls.Add(this.TxtNameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnter);
            this.Name = "HomeForm";
            this.Text = "PaymentForm2";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNameField;
        private System.Windows.Forms.ComboBox CmbBxCources;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox LstBxCources;
        private System.Windows.Forms.Label label2;
    }
}