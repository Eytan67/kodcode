namespace Guest
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
            this.Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGuestNameInpot = new System.Windows.Forms.TextBox();
            this.LstBxGuests = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(362, 169);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(75, 23);
            this.Btn.TabIndex = 10;
            this.Btn.Text = "Enter";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Name";
            // 
            // TxtGuestNameInpot
            // 
            this.TxtGuestNameInpot.Location = new System.Drawing.Point(350, 107);
            this.TxtGuestNameInpot.Name = "TxtGuestNameInpot";
            this.TxtGuestNameInpot.Size = new System.Drawing.Size(100, 22);
            this.TxtGuestNameInpot.TabIndex = 8;
            // 
            // LstBxGuests
            // 
            this.LstBxGuests.FormattingEnabled = true;
            this.LstBxGuests.ItemHeight = 16;
            this.LstBxGuests.Location = new System.Drawing.Point(289, 214);
            this.LstBxGuests.Name = "LstBxGuests";
            this.LstBxGuests.Size = new System.Drawing.Size(222, 180);
            this.LstBxGuests.TabIndex = 7;
            this.LstBxGuests.SelectedIndexChanged += new System.EventHandler(this.LstBxGuests_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGuestNameInpot);
            this.Controls.Add(this.LstBxGuests);
            this.Name = "Form1";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGuestNameInpot;
        private System.Windows.Forms.ListBox LstBxGuests;
        private System.Windows.Forms.Label label2;
    }
}

