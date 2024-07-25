namespace System.forms
{
    partial class CreateCourceForm
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
            this.TxtCoursePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumOfDays = new System.Windows.Forms.TextBox();
            this.TxtNumOfHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.LstBxTopices = new System.Windows.Forms.ListBox();
            this.CmbBxChooseTopic = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.LblCostCource = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNameOfCource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtCoursePrice
            // 
            this.TxtCoursePrice.Location = new System.Drawing.Point(44, 68);
            this.TxtCoursePrice.Name = "TxtCoursePrice";
            this.TxtCoursePrice.Size = new System.Drawing.Size(100, 22);
            this.TxtCoursePrice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "price";
            // 
            // TxtNumOfDays
            // 
            this.TxtNumOfDays.Location = new System.Drawing.Point(295, 70);
            this.TxtNumOfDays.Name = "TxtNumOfDays";
            this.TxtNumOfDays.Size = new System.Drawing.Size(100, 22);
            this.TxtNumOfDays.TabIndex = 2;
            // 
            // TxtNumOfHours
            // 
            this.TxtNumOfHours.Location = new System.Drawing.Point(169, 68);
            this.TxtNumOfHours.Name = "TxtNumOfHours";
            this.TxtNumOfHours.Size = new System.Drawing.Size(100, 22);
            this.TxtNumOfHours.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "number of days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "number of hours";
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Location = new System.Drawing.Point(436, 70);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.DtpStartDate.TabIndex = 7;
            // 
            // LstBxTopices
            // 
            this.LstBxTopices.FormattingEnabled = true;
            this.LstBxTopices.ItemHeight = 16;
            this.LstBxTopices.Location = new System.Drawing.Point(44, 137);
            this.LstBxTopices.Name = "LstBxTopices";
            this.LstBxTopices.Size = new System.Drawing.Size(155, 164);
            this.LstBxTopices.TabIndex = 8;
            // 
            // CmbBxChooseTopic
            // 
            this.CmbBxChooseTopic.FormattingEnabled = true;
            this.CmbBxChooseTopic.Location = new System.Drawing.Point(321, 179);
            this.CmbBxChooseTopic.Name = "CmbBxChooseTopic";
            this.CmbBxChooseTopic.Size = new System.Drawing.Size(121, 24);
            this.CmbBxChooseTopic.TabIndex = 9;
            this.CmbBxChooseTopic.SelectedIndexChanged += new System.EventHandler(this.CmbBxChooseTopic_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose topics";
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(44, 335);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(134, 44);
            this.BtnEnter.TabIndex = 11;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // LblCostCource
            // 
            this.LblCostCource.AutoSize = true;
            this.LblCostCource.Location = new System.Drawing.Point(447, 353);
            this.LblCostCource.Name = "LblCostCource";
            this.LblCostCource.Size = new System.Drawing.Size(132, 16);
            this.LblCostCource.TabIndex = 12;
            this.LblCostCource.Text = "the cost of the course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "cource name";
            // 
            // TxtNameOfCource
            // 
            this.TxtNameOfCource.Location = new System.Drawing.Point(675, 72);
            this.TxtNameOfCource.Name = "TxtNameOfCource";
            this.TxtNameOfCource.Size = new System.Drawing.Size(100, 22);
            this.TxtNameOfCource.TabIndex = 14;
            // 
            // CreateCourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtNameOfCource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblCostCource);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbBxChooseTopic);
            this.Controls.Add(this.LstBxTopices);
            this.Controls.Add(this.DtpStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumOfHours);
            this.Controls.Add(this.TxtNumOfDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCoursePrice);
            this.Name = "CreateCourceForm";
            this.Text = "CreateCourceForm";
            this.Load += new System.EventHandler(this.CreateCourceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.TextBox TxtCoursePrice;
        private Windows.Forms.Label label1;
        private Windows.Forms.TextBox TxtNumOfDays;
        private Windows.Forms.TextBox TxtNumOfHours;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label3;
        private Windows.Forms.Label label4;
        private Windows.Forms.DateTimePicker DtpStartDate;
        private Windows.Forms.ListBox LstBxTopices;
        private Windows.Forms.ComboBox CmbBxChooseTopic;
        private Windows.Forms.Label label5;
        private Windows.Forms.Button BtnEnter;
        private Windows.Forms.Label LblCostCource;
        private Windows.Forms.Label label6;
        private Windows.Forms.TextBox TxtNameOfCource;
    }
}