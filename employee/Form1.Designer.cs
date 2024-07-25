namespace employee
{
    partial class form1
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
            this.LblFName = new System.Windows.Forms.Label();
            this.LblLName = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblBirthday = new System.Windows.Forms.Label();
            this.FNameField = new System.Windows.Forms.TextBox();
            this.LNameField = new System.Windows.Forms.TextBox();
            this.AgeField = new System.Windows.Forms.TextBox();
            this.IdField = new System.Windows.Forms.TextBox();
            this.PnlGender = new System.Windows.Forms.Panel();
            this.RdBtnFemale = new System.Windows.Forms.RadioButton();
            this.RdBtnMale = new System.Windows.Forms.RadioButton();
            this.PnlMaritalStatus = new System.Windows.Forms.Panel();
            this.RdBtnWidower = new System.Windows.Forms.RadioButton();
            this.RdBtnDivorced = new System.Windows.Forms.RadioButton();
            this.RdBtnMarried = new System.Windows.Forms.RadioButton();
            this.RdBtnSingle = new System.Windows.Forms.RadioButton();
            this.DTimeField = new System.Windows.Forms.DateTimePicker();
            this.LblCode = new System.Windows.Forms.Label();
            this.CodeField = new System.Windows.Forms.TextBox();
            this.BtnNxt = new System.Windows.Forms.Button();
            this.BtnPrv = new System.Windows.Forms.Button();
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblStreet = new System.Windows.Forms.Label();
            this.LblCellPhone = new System.Windows.Forms.Label();
            this.LblLandline = new System.Windows.Forms.Label();
            this.CityField = new System.Windows.Forms.TextBox();
            this.NumberField = new System.Windows.Forms.TextBox();
            this.StreetField = new System.Windows.Forms.TextBox();
            this.CellPhoneField = new System.Windows.Forms.TextBox();
            this.LandlineField = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSearchByCode = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearchById = new System.Windows.Forms.Button();
            this.PnlGender.SuspendLayout();
            this.PnlMaritalStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFName
            // 
            this.LblFName.AutoSize = true;
            this.LblFName.Location = new System.Drawing.Point(204, 68);
            this.LblFName.Name = "LblFName";
            this.LblFName.Size = new System.Drawing.Size(69, 16);
            this.LblFName.TabIndex = 0;
            this.LblFName.Text = "First name";
            // 
            // LblLName
            // 
            this.LblLName.AutoSize = true;
            this.LblLName.Location = new System.Drawing.Point(333, 68);
            this.LblLName.Name = "LblLName";
            this.LblLName.Size = new System.Drawing.Size(69, 16);
            this.LblLName.TabIndex = 1;
            this.LblLName.Text = "Last name";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(707, 68);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(18, 16);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "Inpot";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(91, 68);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(32, 16);
            this.LblAge.TabIndex = 3;
            this.LblAge.Text = "Age";
            // 
            // LblBirthday
            // 
            this.LblBirthday.AutoSize = true;
            this.LblBirthday.Location = new System.Drawing.Point(513, 68);
            this.LblBirthday.Name = "LblBirthday";
            this.LblBirthday.Size = new System.Drawing.Size(56, 16);
            this.LblBirthday.TabIndex = 4;
            this.LblBirthday.Text = "Birthday";
            // 
            // FNameField
            // 
            this.FNameField.Location = new System.Drawing.Point(188, 109);
            this.FNameField.Name = "FNameField";
            this.FNameField.Size = new System.Drawing.Size(100, 22);
            this.FNameField.TabIndex = 5;
            // 
            // LNameField
            // 
            this.LNameField.Location = new System.Drawing.Point(318, 109);
            this.LNameField.Name = "LNameField";
            this.LNameField.Size = new System.Drawing.Size(100, 22);
            this.LNameField.TabIndex = 6;
            // 
            // AgeField
            // 
            this.AgeField.Location = new System.Drawing.Point(72, 109);
            this.AgeField.Name = "AgeField";
            this.AgeField.ReadOnly = true;
            this.AgeField.Size = new System.Drawing.Size(100, 22);
            this.AgeField.TabIndex = 7;
            // 
            // IdField
            // 
            this.IdField.Location = new System.Drawing.Point(688, 111);
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(100, 22);
            this.IdField.TabIndex = 9;
            // 
            // PnlGender
            // 
            this.PnlGender.Controls.Add(this.RdBtnFemale);
            this.PnlGender.Controls.Add(this.RdBtnMale);
            this.PnlGender.Location = new System.Drawing.Point(449, 176);
            this.PnlGender.Name = "PnlGender";
            this.PnlGender.Size = new System.Drawing.Size(192, 212);
            this.PnlGender.TabIndex = 10;
            // 
            // RdBtnFemale
            // 
            this.RdBtnFemale.AutoSize = true;
            this.RdBtnFemale.Location = new System.Drawing.Point(57, 111);
            this.RdBtnFemale.Name = "RdBtnFemale";
            this.RdBtnFemale.Size = new System.Drawing.Size(74, 20);
            this.RdBtnFemale.TabIndex = 5;
            this.RdBtnFemale.TabStop = true;
            this.RdBtnFemale.Text = "Female";
            this.RdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // RdBtnMale
            // 
            this.RdBtnMale.AutoSize = true;
            this.RdBtnMale.Location = new System.Drawing.Point(52, 41);
            this.RdBtnMale.Name = "RdBtnMale";
            this.RdBtnMale.Size = new System.Drawing.Size(61, 20);
            this.RdBtnMale.TabIndex = 4;
            this.RdBtnMale.TabStop = true;
            this.RdBtnMale.Text = "Male ";
            this.RdBtnMale.UseVisualStyleBackColor = true;
            // 
            // PnlMaritalStatus
            // 
            this.PnlMaritalStatus.Controls.Add(this.RdBtnWidower);
            this.PnlMaritalStatus.Controls.Add(this.RdBtnDivorced);
            this.PnlMaritalStatus.Controls.Add(this.RdBtnMarried);
            this.PnlMaritalStatus.Controls.Add(this.RdBtnSingle);
            this.PnlMaritalStatus.Location = new System.Drawing.Point(176, 176);
            this.PnlMaritalStatus.Name = "PnlMaritalStatus";
            this.PnlMaritalStatus.Size = new System.Drawing.Size(168, 212);
            this.PnlMaritalStatus.TabIndex = 11;
            // 
            // RdBtnWidower
            // 
            this.RdBtnWidower.AutoSize = true;
            this.RdBtnWidower.Location = new System.Drawing.Point(36, 166);
            this.RdBtnWidower.Name = "RdBtnWidower";
            this.RdBtnWidower.Size = new System.Drawing.Size(81, 20);
            this.RdBtnWidower.TabIndex = 3;
            this.RdBtnWidower.TabStop = true;
            this.RdBtnWidower.Text = "Widower";
            this.RdBtnWidower.UseVisualStyleBackColor = true;
            // 
            // RdBtnDivorced
            // 
            this.RdBtnDivorced.AutoSize = true;
            this.RdBtnDivorced.Location = new System.Drawing.Point(36, 128);
            this.RdBtnDivorced.Name = "RdBtnDivorced";
            this.RdBtnDivorced.Size = new System.Drawing.Size(83, 20);
            this.RdBtnDivorced.TabIndex = 2;
            this.RdBtnDivorced.TabStop = true;
            this.RdBtnDivorced.Text = "Divorced";
            this.RdBtnDivorced.UseVisualStyleBackColor = true;
            // 
            // RdBtnMarried
            // 
            this.RdBtnMarried.AutoSize = true;
            this.RdBtnMarried.Location = new System.Drawing.Point(36, 87);
            this.RdBtnMarried.Name = "RdBtnMarried";
            this.RdBtnMarried.Size = new System.Drawing.Size(74, 20);
            this.RdBtnMarried.TabIndex = 1;
            this.RdBtnMarried.TabStop = true;
            this.RdBtnMarried.Text = "Married";
            this.RdBtnMarried.UseVisualStyleBackColor = true;
            // 
            // RdBtnSingle
            // 
            this.RdBtnSingle.AutoSize = true;
            this.RdBtnSingle.Location = new System.Drawing.Point(36, 41);
            this.RdBtnSingle.Name = "RdBtnSingle";
            this.RdBtnSingle.Size = new System.Drawing.Size(66, 20);
            this.RdBtnSingle.TabIndex = 0;
            this.RdBtnSingle.TabStop = true;
            this.RdBtnSingle.Text = "Single";
            this.RdBtnSingle.UseVisualStyleBackColor = true;
            // 
            // DTimeField
            // 
            this.DTimeField.Location = new System.Drawing.Point(463, 111);
            this.DTimeField.Name = "DTimeField";
            this.DTimeField.Size = new System.Drawing.Size(200, 22);
            this.DTimeField.TabIndex = 12;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(799, 35);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(40, 16);
            this.LblCode.TabIndex = 13;
            this.LblCode.Text = "Code";
            // 
            // CodeField
            // 
            this.CodeField.Location = new System.Drawing.Point(808, 62);
            this.CodeField.Name = "CodeField";
            this.CodeField.ReadOnly = true;
            this.CodeField.Size = new System.Drawing.Size(31, 22);
            this.CodeField.TabIndex = 14;
            // 
            // BtnNxt
            // 
            this.BtnNxt.Location = new System.Drawing.Point(534, 433);
            this.BtnNxt.Name = "BtnNxt";
            this.BtnNxt.Size = new System.Drawing.Size(75, 23);
            this.BtnNxt.TabIndex = 15;
            this.BtnNxt.Text = ">>>>";
            this.BtnNxt.UseVisualStyleBackColor = true;
            this.BtnNxt.Click += new System.EventHandler(this.BtnNxt_Click);
            // 
            // BtnPrv
            // 
            this.BtnPrv.Location = new System.Drawing.Point(248, 433);
            this.BtnPrv.Name = "BtnPrv";
            this.BtnPrv.Size = new System.Drawing.Size(75, 23);
            this.BtnPrv.TabIndex = 16;
            this.BtnPrv.Text = "<<<<";
            this.BtnPrv.UseVisualStyleBackColor = true;
            this.BtnPrv.Click += new System.EventHandler(this.BtnPrv_Click);
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(245, 512);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(55, 16);
            this.LblNumber.TabIndex = 17;
            this.LblNumber.Text = "Number";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(116, 512);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(29, 16);
            this.LblCity.TabIndex = 18;
            this.LblCity.Text = "City";
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(413, 512);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(42, 16);
            this.LblStreet.TabIndex = 19;
            this.LblStreet.Text = "Street";
            // 
            // LblCellPhone
            // 
            this.LblCellPhone.AutoSize = true;
            this.LblCellPhone.Location = new System.Drawing.Point(711, 512);
            this.LblCellPhone.Name = "LblCellPhone";
            this.LblCellPhone.Size = new System.Drawing.Size(69, 16);
            this.LblCellPhone.TabIndex = 20;
            this.LblCellPhone.Text = "CellPhone";
            // 
            // LblLandline
            // 
            this.LblLandline.AutoSize = true;
            this.LblLandline.Location = new System.Drawing.Point(560, 512);
            this.LblLandline.Name = "LblLandline";
            this.LblLandline.Size = new System.Drawing.Size(58, 16);
            this.LblLandline.TabIndex = 21;
            this.LblLandline.Text = "Landline";
            // 
            // CityField
            // 
            this.CityField.Location = new System.Drawing.Point(72, 541);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(100, 22);
            this.CityField.TabIndex = 22;
            // 
            // NumberField
            // 
            this.NumberField.Location = new System.Drawing.Point(223, 541);
            this.NumberField.Name = "NumberField";
            this.NumberField.Size = new System.Drawing.Size(100, 22);
            this.NumberField.TabIndex = 23;
            // 
            // StreetField
            // 
            this.StreetField.Location = new System.Drawing.Point(380, 541);
            this.StreetField.Name = "StreetField";
            this.StreetField.Size = new System.Drawing.Size(100, 22);
            this.StreetField.TabIndex = 24;
            // 
            // CellPhoneField
            // 
            this.CellPhoneField.Location = new System.Drawing.Point(688, 541);
            this.CellPhoneField.Name = "CellPhoneField";
            this.CellPhoneField.Size = new System.Drawing.Size(100, 22);
            this.CellPhoneField.TabIndex = 25;
            // 
            // LandlineField
            // 
            this.LandlineField.Location = new System.Drawing.Point(541, 541);
            this.LandlineField.Name = "LandlineField";
            this.LandlineField.Size = new System.Drawing.Size(100, 22);
            this.LandlineField.TabIndex = 26;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(534, 481);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 27;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSearchByCode
            // 
            this.BtnSearchByCode.Location = new System.Drawing.Point(742, 586);
            this.BtnSearchByCode.Name = "BtnSearchByCode";
            this.BtnSearchByCode.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchByCode.TabIndex = 28;
            this.BtnSearchByCode.Text = "Search by code";
            this.BtnSearchByCode.UseVisualStyleBackColor = true;
            this.BtnSearchByCode.Click += new System.EventHandler(this.BtnSearchByCode_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(731, 481);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 29;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(327, 481);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 30;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(151, 484);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 31;
            this.BtnDelete.Text = "delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearchById
            // 
            this.BtnSearchById.Location = new System.Drawing.Point(614, 586);
            this.BtnSearchById.Name = "BtnSearchById";
            this.BtnSearchById.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchById.TabIndex = 32;
            this.BtnSearchById.Text = "Search by Inpot";
            this.BtnSearchById.UseVisualStyleBackColor = true;
            this.BtnSearchById.Click += new System.EventHandler(this.BtnSearchById_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 644);
            this.Controls.Add(this.BtnSearchById);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnSearchByCode);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LandlineField);
            this.Controls.Add(this.CellPhoneField);
            this.Controls.Add(this.StreetField);
            this.Controls.Add(this.NumberField);
            this.Controls.Add(this.CityField);
            this.Controls.Add(this.LblLandline);
            this.Controls.Add(this.LblCellPhone);
            this.Controls.Add(this.LblStreet);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.BtnPrv);
            this.Controls.Add(this.BtnNxt);
            this.Controls.Add(this.CodeField);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.DTimeField);
            this.Controls.Add(this.PnlMaritalStatus);
            this.Controls.Add(this.PnlGender);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.AgeField);
            this.Controls.Add(this.LNameField);
            this.Controls.Add(this.FNameField);
            this.Controls.Add(this.LblBirthday);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblLName);
            this.Controls.Add(this.LblFName);
            this.Name = "form1";
            this.Text = "Form1";
            this.PnlGender.ResumeLayout(false);
            this.PnlGender.PerformLayout();
            this.PnlMaritalStatus.ResumeLayout(false);
            this.PnlMaritalStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFName;
        private System.Windows.Forms.Label LblLName;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblBirthday;
        private System.Windows.Forms.TextBox FNameField;
        private System.Windows.Forms.TextBox LNameField;
        private System.Windows.Forms.TextBox AgeField;
        private System.Windows.Forms.TextBox IdField;
        private System.Windows.Forms.Panel PnlGender;
        private System.Windows.Forms.RadioButton RdBtnFemale;
        private System.Windows.Forms.RadioButton RdBtnMale;
        private System.Windows.Forms.Panel PnlMaritalStatus;
        private System.Windows.Forms.RadioButton RdBtnWidower;
        private System.Windows.Forms.RadioButton RdBtnDivorced;
        private System.Windows.Forms.RadioButton RdBtnMarried;
        private System.Windows.Forms.RadioButton RdBtnSingle;
        private System.Windows.Forms.DateTimePicker DTimeField;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.TextBox CodeField;
        private System.Windows.Forms.Button BtnNxt;
        private System.Windows.Forms.Button BtnPrv;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.Label LblCellPhone;
        private System.Windows.Forms.Label LblLandline;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.TextBox NumberField;
        private System.Windows.Forms.TextBox StreetField;
        private System.Windows.Forms.TextBox CellPhoneField;
        private System.Windows.Forms.TextBox LandlineField;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSearchByCode;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearchById;
    }
}

