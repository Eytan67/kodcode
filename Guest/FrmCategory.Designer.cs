namespace Guest
{
    partial class FrmCategory
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
            this.DataGVOrders = new System.Windows.Forms.DataGridView();
            this.DataGVMyOrders = new System.Windows.Forms.DataGridView();
            this.BtnAddDish = new System.Windows.Forms.Button();
            this.BtnPrv = new System.Windows.Forms.Button();
            this.BtnNxt = new System.Windows.Forms.Button();
            this.LblCategoryName = new System.Windows.Forms.Label();
            this.TxtOrderInpot = new System.Windows.Forms.TextBox();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVMyOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGVOrders
            // 
            this.DataGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVOrders.Location = new System.Drawing.Point(58, 51);
            this.DataGVOrders.Name = "DataGVOrders";
            this.DataGVOrders.RowHeadersWidth = 51;
            this.DataGVOrders.RowTemplate.Height = 24;
            this.DataGVOrders.Size = new System.Drawing.Size(668, 159);
            this.DataGVOrders.TabIndex = 0;
            this.DataGVOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVOrders_CellContentDoubleClick);
            // 
            // DataGVMyOrders
            // 
            this.DataGVMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVMyOrders.Location = new System.Drawing.Point(58, 250);
            this.DataGVMyOrders.Name = "DataGVMyOrders";
            this.DataGVMyOrders.RowHeadersWidth = 51;
            this.DataGVMyOrders.RowTemplate.Height = 24;
            this.DataGVMyOrders.Size = new System.Drawing.Size(668, 150);
            this.DataGVMyOrders.TabIndex = 1;
            // 
            // BtnAddDish
            // 
            this.BtnAddDish.Location = new System.Drawing.Point(565, 216);
            this.BtnAddDish.Name = "BtnAddDish";
            this.BtnAddDish.Size = new System.Drawing.Size(143, 23);
            this.BtnAddDish.TabIndex = 2;
            this.BtnAddDish.Text = "Add a dish";
            this.BtnAddDish.UseVisualStyleBackColor = true;
            this.BtnAddDish.Click += new System.EventHandler(this.BtnAddDish_Click);
            // 
            // BtnPrv
            // 
            this.BtnPrv.Location = new System.Drawing.Point(112, 406);
            this.BtnPrv.Name = "BtnPrv";
            this.BtnPrv.Size = new System.Drawing.Size(75, 23);
            this.BtnPrv.TabIndex = 3;
            this.BtnPrv.Text = "<<<<";
            this.BtnPrv.UseVisualStyleBackColor = true;
            this.BtnPrv.Click += new System.EventHandler(this.BtnPrv_Click);
            // 
            // BtnNxt
            // 
            this.BtnNxt.Location = new System.Drawing.Point(614, 406);
            this.BtnNxt.Name = "BtnNxt";
            this.BtnNxt.Size = new System.Drawing.Size(75, 23);
            this.BtnNxt.TabIndex = 4;
            this.BtnNxt.Text = ">>>>";
            this.BtnNxt.UseVisualStyleBackColor = true;
            this.BtnNxt.Click += new System.EventHandler(this.BtnNxt_Click);
            // 
            // LblCategoryName
            // 
            this.LblCategoryName.AutoSize = true;
            this.LblCategoryName.Location = new System.Drawing.Point(338, 20);
            this.LblCategoryName.Name = "LblCategoryName";
            this.LblCategoryName.Size = new System.Drawing.Size(117, 16);
            this.LblCategoryName.TabIndex = 5;
            this.LblCategoryName.Text = "LblCategoryName";
            // 
            // TxtOrderInpot
            // 
            this.TxtOrderInpot.Location = new System.Drawing.Point(292, 217);
            this.TxtOrderInpot.Name = "TxtOrderInpot";
            this.TxtOrderInpot.Size = new System.Drawing.Size(163, 22);
            this.TxtOrderInpot.TabIndex = 6;
            this.TxtOrderInpot.Visible = false;
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.Location = new System.Drawing.Point(112, 216);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.BtnAddOrder.TabIndex = 7;
            this.BtnAddOrder.Text = "Enter";
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            this.BtnAddOrder.Visible = false;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddOrder);
            this.Controls.Add(this.TxtOrderInpot);
            this.Controls.Add(this.LblCategoryName);
            this.Controls.Add(this.BtnNxt);
            this.Controls.Add(this.BtnPrv);
            this.Controls.Add(this.BtnAddDish);
            this.Controls.Add(this.DataGVMyOrders);
            this.Controls.Add(this.DataGVOrders);
            this.Name = "FrmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVMyOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGVOrders;
        private System.Windows.Forms.DataGridView DataGVMyOrders;
        private System.Windows.Forms.Button BtnAddDish;
        private System.Windows.Forms.Button BtnPrv;
        private System.Windows.Forms.Button BtnNxt;
        private System.Windows.Forms.Label LblCategoryName;
        private System.Windows.Forms.TextBox TxtOrderInpot;
        private System.Windows.Forms.Button BtnAddOrder;
    }
}