namespace TimeClock
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdField = new System.Windows.Forms.TextBox();
            this.TxtPassowrdField = new System.Windows.Forms.TextBox();
            this.BtnChangePass = new System.Windows.Forms.Button();
            this.TxtFullNameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter passowrd";
            // 
            // TxtIdField
            // 
            this.TxtIdField.Location = new System.Drawing.Point(397, 116);
            this.TxtIdField.Name = "TxtIdField";
            this.TxtIdField.Size = new System.Drawing.Size(100, 22);
            this.TxtIdField.TabIndex = 2;
            this.TxtIdField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdField_KeyPress);
            // 
            // TxtPassowrdField
            // 
            this.TxtPassowrdField.Location = new System.Drawing.Point(558, 116);
            this.TxtPassowrdField.Name = "TxtPassowrdField";
            this.TxtPassowrdField.Size = new System.Drawing.Size(100, 22);
            this.TxtPassowrdField.TabIndex = 3;
            this.TxtPassowrdField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdField_KeyPress);
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.Location = new System.Drawing.Point(638, 326);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.Size = new System.Drawing.Size(111, 84);
            this.BtnChangePass.TabIndex = 4;
            this.BtnChangePass.Text = "Change passowrd";
            this.BtnChangePass.UseVisualStyleBackColor = true;
            this.BtnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // TxtFullNameField
            // 
            this.TxtFullNameField.Location = new System.Drawing.Point(219, 116);
            this.TxtFullNameField.Name = "TxtFullNameField";
            this.TxtFullNameField.Size = new System.Drawing.Size(100, 22);
            this.TxtFullNameField.TabIndex = 6;
            this.TxtFullNameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdField_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "enter full Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show Time clock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtFullNameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnChangePass);
            this.Controls.Add(this.TxtPassowrdField);
            this.Controls.Add(this.TxtIdField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdField;
        private System.Windows.Forms.TextBox TxtPassowrdField;
        private System.Windows.Forms.Button BtnChangePass;
        private System.Windows.Forms.TextBox TxtFullNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

