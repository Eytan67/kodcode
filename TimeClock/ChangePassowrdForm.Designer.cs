namespace TimeClock
{
    partial class ChangePassowrdForm
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
            this.TxtOldPasField = new System.Windows.Forms.TextBox();
            this.TxtConfirmField = new System.Windows.Forms.TextBox();
            this.TxtNewPasField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BttnEnter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtOldPasField
            // 
            this.TxtOldPasField.Location = new System.Drawing.Point(296, 110);
            this.TxtOldPasField.Name = "TxtOldPasField";
            this.TxtOldPasField.Size = new System.Drawing.Size(148, 22);
            this.TxtOldPasField.TabIndex = 0;
            // 
            // TxtConfirmField
            // 
            this.TxtConfirmField.Location = new System.Drawing.Point(296, 268);
            this.TxtConfirmField.Name = "TxtConfirmField";
            this.TxtConfirmField.Size = new System.Drawing.Size(148, 22);
            this.TxtConfirmField.TabIndex = 1;
            // 
            // TxtNewPasField
            // 
            this.TxtNewPasField.Location = new System.Drawing.Point(296, 186);
            this.TxtNewPasField.Name = "TxtNewPasField";
            this.TxtNewPasField.Size = new System.Drawing.Size(148, 22);
            this.TxtNewPasField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter old passowrd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm new passowrd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter new passowrd";
            // 
            // BttnEnter
            // 
            this.BttnEnter.Location = new System.Drawing.Point(330, 341);
            this.BttnEnter.Name = "BttnEnter";
            this.BttnEnter.Size = new System.Drawing.Size(75, 23);
            this.BttnEnter.TabIndex = 6;
            this.BttnEnter.Text = "enter";
            this.BttnEnter.UseVisualStyleBackColor = true;
            this.BttnEnter.Click += new System.EventHandler(this.BttnEnter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter id";
            // 
            // TxtIdField
            // 
            this.TxtIdField.Location = new System.Drawing.Point(296, 45);
            this.TxtIdField.Name = "TxtIdField";
            this.TxtIdField.Size = new System.Drawing.Size(148, 22);
            this.TxtIdField.TabIndex = 8;
            // 
            // ChangePassowrdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtIdField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BttnEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNewPasField);
            this.Controls.Add(this.TxtConfirmField);
            this.Controls.Add(this.TxtOldPasField);
            this.Name = "ChangePassowrdForm";
            this.Text = "ChangePassowrdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOldPasField;
        private System.Windows.Forms.TextBox TxtConfirmField;
        private System.Windows.Forms.TextBox TxtNewPasField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BttnEnter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdField;
    }
}