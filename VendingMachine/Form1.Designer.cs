namespace VendingMachine
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
            this.BtnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDrinkName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbBxSuger = new System.Windows.Forms.ComboBox();
            this.CmbBxCoffee = new System.Windows.Forms.ComboBox();
            this.CmbBxMilk = new System.Windows.Forms.ComboBox();
            this.CmbBxCocoa = new System.Windows.Forms.ComboBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnIncrese = new System.Windows.Forms.Button();
            this.BtnDecrese = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(119, 128);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drink";
            // 
            // TxtDrinkName
            // 
            this.TxtDrinkName.Location = new System.Drawing.Point(583, 29);
            this.TxtDrinkName.Name = "TxtDrinkName";
            this.TxtDrinkName.Size = new System.Drawing.Size(100, 22);
            this.TxtDrinkName.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(119, 172);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(26, 128);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "cocoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "milk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "coffee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "sugar";
            // 
            // CmbBxSuger
            // 
            this.CmbBxSuger.FormattingEnabled = true;
            this.CmbBxSuger.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
            this.CmbBxSuger.Location = new System.Drawing.Point(642, 129);
            this.CmbBxSuger.Name = "CmbBxSuger";
            this.CmbBxSuger.Size = new System.Drawing.Size(40, 24);
            this.CmbBxSuger.TabIndex = 11;
            // 
            // CmbBxCoffee
            // 
            this.CmbBxCoffee.FormattingEnabled = true;
            this.CmbBxCoffee.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
            this.CmbBxCoffee.Location = new System.Drawing.Point(583, 129);
            this.CmbBxCoffee.Name = "CmbBxCoffee";
            this.CmbBxCoffee.Size = new System.Drawing.Size(40, 24);
            this.CmbBxCoffee.TabIndex = 14;
            // 
            // CmbBxMilk
            // 
            this.CmbBxMilk.FormattingEnabled = true;
            this.CmbBxMilk.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
            this.CmbBxMilk.Location = new System.Drawing.Point(517, 129);
            this.CmbBxMilk.Name = "CmbBxMilk";
            this.CmbBxMilk.Size = new System.Drawing.Size(40, 24);
            this.CmbBxMilk.TabIndex = 15;
            // 
            // CmbBxCocoa
            // 
            this.CmbBxCocoa.FormattingEnabled = true;
            this.CmbBxCocoa.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
            this.CmbBxCocoa.Location = new System.Drawing.Point(454, 129);
            this.CmbBxCocoa.Name = "CmbBxCocoa";
            this.CmbBxCocoa.Size = new System.Drawing.Size(40, 24);
            this.CmbBxCocoa.TabIndex = 16;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(377, 131);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(33, 22);
            this.TxtPrice.TabIndex = 17;
            // 
            // BtnIncrese
            // 
            this.BtnIncrese.Location = new System.Drawing.Point(350, 107);
            this.BtnIncrese.Name = "BtnIncrese";
            this.BtnIncrese.Size = new System.Drawing.Size(18, 23);
            this.BtnIncrese.TabIndex = 18;
            this.BtnIncrese.Text = "^";
            this.BtnIncrese.UseVisualStyleBackColor = true;
            this.BtnIncrese.Click += new System.EventHandler(this.BtnIncrese_Click);
            // 
            // BtnDecrese
            // 
            this.BtnDecrese.Location = new System.Drawing.Point(350, 136);
            this.BtnDecrese.Name = "BtnDecrese";
            this.BtnDecrese.Size = new System.Drawing.Size(18, 23);
            this.BtnDecrese.TabIndex = 19;
            this.BtnDecrese.Text = ".";
            this.BtnDecrese.UseVisualStyleBackColor = true;
            this.BtnDecrese.Click += new System.EventHandler(this.BtnDecrese_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(119, 65);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 20;
            this.BtnUpdate.Text = "UPdate";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(705, 226);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDecrese);
            this.Controls.Add(this.BtnIncrese);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.CmbBxCocoa);
            this.Controls.Add(this.CmbBxMilk);
            this.Controls.Add(this.CmbBxCoffee);
            this.Controls.Add(this.CmbBxSuger);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtDrinkName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDrinkName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBxSuger;
        private System.Windows.Forms.ComboBox CmbBxCoffee;
        private System.Windows.Forms.ComboBox CmbBxMilk;
        private System.Windows.Forms.ComboBox CmbBxCocoa;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnIncrese;
        private System.Windows.Forms.Button BtnDecrese;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

