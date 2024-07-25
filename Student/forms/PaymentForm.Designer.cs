namespace Student
{
    partial class PaymentForm
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
            this.Debt = new System.Windows.Forms.Label();
            this.TxtDisplayDebt = new System.Windows.Forms.TextBox();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Debt
            // 
            this.Debt.AutoSize = true;
            this.Debt.Location = new System.Drawing.Point(217, 88);
            this.Debt.Name = "Debt";
            this.Debt.Size = new System.Drawing.Size(68, 16);
            this.Debt.TabIndex = 0;
            this.Debt.Text = "yout debt :";
            // 
            // TxtDisplayDebt
            // 
            this.TxtDisplayDebt.Location = new System.Drawing.Point(304, 82);
            this.TxtDisplayDebt.Name = "TxtDisplayDebt";
            this.TxtDisplayDebt.Size = new System.Drawing.Size(100, 22);
            this.TxtDisplayDebt.TabIndex = 1;
            // 
            // BtnPayment
            // 
            this.BtnPayment.Location = new System.Drawing.Point(341, 258);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Size = new System.Drawing.Size(75, 23);
            this.BtnPayment.TabIndex = 2;
            this.BtnPayment.Text = "payment";
            this.BtnPayment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter an amount";
            // 
            // TxtPayment
            // 
            this.TxtPayment.Location = new System.Drawing.Point(304, 214);
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.Size = new System.Drawing.Size(146, 22);
            this.TxtPayment.TabIndex = 4;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnPayment);
            this.Controls.Add(this.TxtDisplayDebt);
            this.Controls.Add(this.Debt);
            this.Name = "PaymentForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Debt;
        private System.Windows.Forms.TextBox TxtDisplayDebt;
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPayment;
    }
}

