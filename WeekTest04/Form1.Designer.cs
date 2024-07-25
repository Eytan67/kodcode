namespace WeekTest04
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
            this.CnbBxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBxDay = new System.Windows.Forms.ComboBox();
            this.CnbBxDayInMonth = new System.Windows.Forms.ComboBox();
            this.CnbBxMonth = new System.Windows.Forms.ComboBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.TxtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CnbBxYear
            // 
            this.CnbBxYear.FormattingEnabled = true;
            this.CnbBxYear.Items.AddRange(new object[] {
            "תשפ_ד",
            "תשפ_ה",
            "תשפ_ו",
            "תשפ_ז",
            "תשפ_ח",
            "תשפ_ט",
            "תשצ",
            "תשצ_א",
            "תשצ_ב"});
            this.CnbBxYear.Location = new System.Drawing.Point(44, 103);
            this.CnbBxYear.Name = "CnbBxYear";
            this.CnbBxYear.Size = new System.Drawing.Size(121, 24);
            this.CnbBxYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "היום בשבוע";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "היום בחודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "חודש";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "שנה";
            // 
            // CmbBxDay
            // 
            this.CmbBxDay.FormattingEnabled = true;
            this.CmbBxDay.Items.AddRange(new object[] {
            "ראשון",
            "שני ",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי"});
            this.CmbBxDay.Location = new System.Drawing.Point(592, 103);
            this.CmbBxDay.Name = "CmbBxDay";
            this.CmbBxDay.Size = new System.Drawing.Size(121, 24);
            this.CmbBxDay.TabIndex = 7;
            // 
            // CnbBxDayInMonth
            // 
            this.CnbBxDayInMonth.FormattingEnabled = true;
            this.CnbBxDayInMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.CnbBxDayInMonth.Location = new System.Drawing.Point(389, 103);
            this.CnbBxDayInMonth.Name = "CnbBxDayInMonth";
            this.CnbBxDayInMonth.Size = new System.Drawing.Size(121, 24);
            this.CnbBxDayInMonth.TabIndex = 8;
            // 
            // CnbBxMonth
            // 
            this.CnbBxMonth.FormattingEnabled = true;
            this.CnbBxMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשוון",
            "כסלו",
            "טבת",
            "שבט אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.CnbBxMonth.Location = new System.Drawing.Point(225, 103);
            this.CnbBxMonth.Name = "CnbBxMonth";
            this.CnbBxMonth.Size = new System.Drawing.Size(121, 24);
            this.CnbBxMonth.TabIndex = 9;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(424, 253);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 10;
            this.BtnEnter.Text = "כתוב";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // TxtRes
            // 
            this.TxtRes.Location = new System.Drawing.Point(34, 314);
            this.TxtRes.Name = "TxtRes";
            this.TxtRes.Size = new System.Drawing.Size(741, 22);
            this.TxtRes.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtRes);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.CnbBxMonth);
            this.Controls.Add(this.CnbBxDayInMonth);
            this.Controls.Add(this.CmbBxDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CnbBxYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CnbBxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBxDay;
        private System.Windows.Forms.ComboBox CnbBxDayInMonth;
        private System.Windows.Forms.ComboBox CnbBxMonth;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.TextBox TxtRes;
    }
}

