namespace Hospitality
{
    partial class ShowOrdersRorm
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
            this.DataGVShowOrders = new System.Windows.Forms.DataGridView();
            this.BtnPrv = new System.Windows.Forms.Button();
            this.BtnNxt = new System.Windows.Forms.Button();
            this.LblCategoryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVShowOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGVShowOrders
            // 
            this.DataGVShowOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVShowOrders.Location = new System.Drawing.Point(52, 57);
            this.DataGVShowOrders.Name = "DataGVShowOrders";
            this.DataGVShowOrders.RowHeadersWidth = 51;
            this.DataGVShowOrders.RowTemplate.Height = 24;
            this.DataGVShowOrders.Size = new System.Drawing.Size(695, 316);
            this.DataGVShowOrders.TabIndex = 0;
            // 
            // BtnPrv
            // 
            this.BtnPrv.Location = new System.Drawing.Point(137, 415);
            this.BtnPrv.Name = "BtnPrv";
            this.BtnPrv.Size = new System.Drawing.Size(75, 23);
            this.BtnPrv.TabIndex = 1;
            this.BtnPrv.Text = "<<<<";
            this.BtnPrv.UseVisualStyleBackColor = true;
            this.BtnPrv.Click += new System.EventHandler(this.BtnPrv_Click);
            // 
            // BtnNxt
            // 
            this.BtnNxt.Location = new System.Drawing.Point(569, 415);
            this.BtnNxt.Name = "BtnNxt";
            this.BtnNxt.Size = new System.Drawing.Size(75, 23);
            this.BtnNxt.TabIndex = 2;
            this.BtnNxt.Text = ">>>>";
            this.BtnNxt.UseVisualStyleBackColor = true;
            this.BtnNxt.Click += new System.EventHandler(this.BtnNxt_Click);
            // 
            // LblCategoryName
            // 
            this.LblCategoryName.AutoSize = true;
            this.LblCategoryName.Location = new System.Drawing.Point(377, 22);
            this.LblCategoryName.Name = "LblCategoryName";
            this.LblCategoryName.Size = new System.Drawing.Size(44, 16);
            this.LblCategoryName.TabIndex = 3;
            this.LblCategoryName.Text = "label1";
            // 
            // ShowOrdersRorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCategoryName);
            this.Controls.Add(this.BtnNxt);
            this.Controls.Add(this.BtnPrv);
            this.Controls.Add(this.DataGVShowOrders);
            this.Name = "ShowOrdersRorm";
            this.Text = "ShowOrdersRorm";
            this.Load += new System.EventHandler(this.ShowOrdersRorm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVShowOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGVShowOrders;
        private System.Windows.Forms.Button BtnPrv;
        private System.Windows.Forms.Button BtnNxt;
        private System.Windows.Forms.Label LblCategoryName;
    }
}