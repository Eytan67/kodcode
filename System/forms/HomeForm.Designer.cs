namespace System
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
            this.BtnCreateCource = new System.Windows.Forms.Button();
            this.BtnAddLecturer = new System.Windows.Forms.Button();
            this.AddTopic = new System.Windows.Forms.Button();
            this.LblLecturerName = new System.Windows.Forms.Label();
            this.TxtLecturerSalary = new System.Windows.Forms.TextBox();
            this.TxtLecturerName = new System.Windows.Forms.TextBox();
            this.LblLecturerSalary = new System.Windows.Forms.Label();
            this.BtnEnterLecturer = new System.Windows.Forms.Button();
            this.LblTopicName = new System.Windows.Forms.Label();
            this.LblTopicHours = new System.Windows.Forms.Label();
            this.LblTopicLecturer = new System.Windows.Forms.Label();
            this.TxtTopicLecturer = new System.Windows.Forms.TextBox();
            this.TxtTopicHours = new System.Windows.Forms.TextBox();
            this.TxtTopicName = new System.Windows.Forms.TextBox();
            this.BtnEnterTopic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreateCource
            // 
            this.BtnCreateCource.Location = new System.Drawing.Point(150, 82);
            this.BtnCreateCource.Name = "BtnCreateCource";
            this.BtnCreateCource.Size = new System.Drawing.Size(118, 84);
            this.BtnCreateCource.TabIndex = 0;
            this.BtnCreateCource.Text = "Create cource";
            this.BtnCreateCource.UseVisualStyleBackColor = true;
            this.BtnCreateCource.Click += new System.EventHandler(this.BtnCreateCource_Click);
            // 
            // BtnAddLecturer
            // 
            this.BtnAddLecturer.Location = new System.Drawing.Point(305, 82);
            this.BtnAddLecturer.Name = "BtnAddLecturer";
            this.BtnAddLecturer.Size = new System.Drawing.Size(118, 84);
            this.BtnAddLecturer.TabIndex = 1;
            this.BtnAddLecturer.Text = "Add lecturer";
            this.BtnAddLecturer.UseVisualStyleBackColor = true;
            this.BtnAddLecturer.Click += new System.EventHandler(this.BtnAddLecturer_Click);
            // 
            // AddTopic
            // 
            this.AddTopic.Location = new System.Drawing.Point(451, 82);
            this.AddTopic.Name = "AddTopic";
            this.AddTopic.Size = new System.Drawing.Size(118, 84);
            this.AddTopic.TabIndex = 2;
            this.AddTopic.Text = "Add topic";
            this.AddTopic.UseVisualStyleBackColor = true;
            this.AddTopic.Click += new System.EventHandler(this.AddTopic_Click);
            // 
            // LblLecturerName
            // 
            this.LblLecturerName.AutoSize = true;
            this.LblLecturerName.Location = new System.Drawing.Point(337, 184);
            this.LblLecturerName.Name = "LblLecturerName";
            this.LblLecturerName.Size = new System.Drawing.Size(41, 16);
            this.LblLecturerName.TabIndex = 3;
            this.LblLecturerName.Text = "name";
            this.LblLecturerName.Visible = false;
            // 
            // TxtLecturerSalary
            // 
            this.TxtLecturerSalary.Location = new System.Drawing.Point(315, 281);
            this.TxtLecturerSalary.Name = "TxtLecturerSalary";
            this.TxtLecturerSalary.Size = new System.Drawing.Size(100, 22);
            this.TxtLecturerSalary.TabIndex = 4;
            this.TxtLecturerSalary.Visible = false;
            // 
            // TxtLecturerName
            // 
            this.TxtLecturerName.Location = new System.Drawing.Point(315, 216);
            this.TxtLecturerName.Name = "TxtLecturerName";
            this.TxtLecturerName.Size = new System.Drawing.Size(100, 22);
            this.TxtLecturerName.TabIndex = 5;
            this.TxtLecturerName.Visible = false;
            // 
            // LblLecturerSalary
            // 
            this.LblLecturerSalary.AutoSize = true;
            this.LblLecturerSalary.Location = new System.Drawing.Point(316, 253);
            this.LblLecturerSalary.Name = "LblLecturerSalary";
            this.LblLecturerSalary.Size = new System.Drawing.Size(71, 16);
            this.LblLecturerSalary.TabIndex = 6;
            this.LblLecturerSalary.Text = "salary size";
            this.LblLecturerSalary.Visible = false;
            // 
            // BtnEnterLecturer
            // 
            this.BtnEnterLecturer.Location = new System.Drawing.Point(315, 328);
            this.BtnEnterLecturer.Name = "BtnEnterLecturer";
            this.BtnEnterLecturer.Size = new System.Drawing.Size(109, 33);
            this.BtnEnterLecturer.TabIndex = 7;
            this.BtnEnterLecturer.Text = "Enter";
            this.BtnEnterLecturer.UseVisualStyleBackColor = true;
            this.BtnEnterLecturer.Visible = false;
            this.BtnEnterLecturer.Click += new System.EventHandler(this.BtnEnterLecturer_Click);
            // 
            // LblTopicName
            // 
            this.LblTopicName.AutoSize = true;
            this.LblTopicName.Location = new System.Drawing.Point(471, 194);
            this.LblTopicName.Name = "LblTopicName";
            this.LblTopicName.Size = new System.Drawing.Size(73, 16);
            this.LblTopicName.TabIndex = 8;
            this.LblTopicName.Text = "topic name";
            this.LblTopicName.Visible = false;
            // 
            // LblTopicHours
            // 
            this.LblTopicHours.AutoSize = true;
            this.LblTopicHours.Location = new System.Drawing.Point(471, 241);
            this.LblTopicHours.Name = "LblTopicHours";
            this.LblTopicHours.Size = new System.Drawing.Size(40, 16);
            this.LblTopicHours.TabIndex = 9;
            this.LblTopicHours.Text = "hours";
            this.LblTopicHours.Visible = false;
            // 
            // LblTopicLecturer
            // 
            this.LblTopicLecturer.AutoSize = true;
            this.LblTopicLecturer.Location = new System.Drawing.Point(471, 281);
            this.LblTopicLecturer.Name = "LblTopicLecturer";
            this.LblTopicLecturer.Size = new System.Drawing.Size(51, 16);
            this.LblTopicLecturer.TabIndex = 10;
            this.LblTopicLecturer.Text = "lecturer";
            this.LblTopicLecturer.Visible = false;
            // 
            // TxtTopicLecturer
            // 
            this.TxtTopicLecturer.Location = new System.Drawing.Point(464, 300);
            this.TxtTopicLecturer.Name = "TxtTopicLecturer";
            this.TxtTopicLecturer.Size = new System.Drawing.Size(100, 22);
            this.TxtTopicLecturer.TabIndex = 11;
            this.TxtTopicLecturer.Visible = false;
            // 
            // TxtTopicHours
            // 
            this.TxtTopicHours.Location = new System.Drawing.Point(464, 260);
            this.TxtTopicHours.Name = "TxtTopicHours";
            this.TxtTopicHours.Size = new System.Drawing.Size(100, 22);
            this.TxtTopicHours.TabIndex = 12;
            this.TxtTopicHours.Visible = false;
            // 
            // TxtTopicName
            // 
            this.TxtTopicName.Location = new System.Drawing.Point(464, 214);
            this.TxtTopicName.Name = "TxtTopicName";
            this.TxtTopicName.Size = new System.Drawing.Size(100, 22);
            this.TxtTopicName.TabIndex = 13;
            this.TxtTopicName.Visible = false;
            // 
            // BtnEnterTopic
            // 
            this.BtnEnterTopic.Location = new System.Drawing.Point(464, 360);
            this.BtnEnterTopic.Name = "BtnEnterTopic";
            this.BtnEnterTopic.Size = new System.Drawing.Size(109, 33);
            this.BtnEnterTopic.TabIndex = 14;
            this.BtnEnterTopic.Text = "Enter";
            this.BtnEnterTopic.UseVisualStyleBackColor = true;
            this.BtnEnterTopic.Visible = false;
            this.BtnEnterTopic.Click += new System.EventHandler(this.BtnEnterTopic_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEnterTopic);
            this.Controls.Add(this.TxtTopicName);
            this.Controls.Add(this.TxtTopicHours);
            this.Controls.Add(this.TxtTopicLecturer);
            this.Controls.Add(this.LblTopicLecturer);
            this.Controls.Add(this.LblTopicHours);
            this.Controls.Add(this.LblTopicName);
            this.Controls.Add(this.BtnEnterLecturer);
            this.Controls.Add(this.LblLecturerSalary);
            this.Controls.Add(this.TxtLecturerName);
            this.Controls.Add(this.TxtLecturerSalary);
            this.Controls.Add(this.LblLecturerName);
            this.Controls.Add(this.AddTopic);
            this.Controls.Add(this.BtnAddLecturer);
            this.Controls.Add(this.BtnCreateCource);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Button BtnCreateCource;
        private Windows.Forms.Button BtnAddLecturer;
        private Windows.Forms.Button AddTopic;
        private Windows.Forms.Label LblLecturerName;
        private Windows.Forms.TextBox TxtLecturerSalary;
        private Windows.Forms.TextBox TxtLecturerName;
        private Windows.Forms.Label LblLecturerSalary;
        private Windows.Forms.Button BtnEnterLecturer;
        private Windows.Forms.Label LblTopicName;
        private Windows.Forms.Label LblTopicHours;
        private Windows.Forms.Label LblTopicLecturer;
        private Windows.Forms.TextBox TxtTopicLecturer;
        private Windows.Forms.TextBox TxtTopicHours;
        private Windows.Forms.TextBox TxtTopicName;
        private Windows.Forms.Button BtnEnterTopic;
    }
}

