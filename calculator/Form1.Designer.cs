namespace calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.txtBxLeft = new System.Windows.Forms.TextBox();
            this.txtbxRight = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.cmbxAction = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultipl = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.Controls.Add(this.lblResult, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBxLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbxRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbxAction, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(209, 3);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 22);
            this.lblResult.TabIndex = 4;
            // 
            // txtBxLeft
            // 
            this.txtBxLeft.Location = new System.Drawing.Point(3, 3);
            this.txtBxLeft.Name = "txtBxLeft";
            this.txtBxLeft.Size = new System.Drawing.Size(70, 22);
            this.txtBxLeft.TabIndex = 0;
            this.txtBxLeft.Enter += new System.EventHandler(this.SelectedTextBox);
            // 
            // txtbxRight
            // 
            this.txtbxRight.Location = new System.Drawing.Point(109, 3);
            this.txtbxRight.Name = "txtbxRight";
            this.txtbxRight.Size = new System.Drawing.Size(64, 22);
            this.txtbxRight.TabIndex = 1;
            this.txtbxRight.Enter += new System.EventHandler(this.SelectedTextBox);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(179, 3);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(24, 23);
            this.btnEqual.TabIndex = 5;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // cmbxAction
            // 
            this.cmbxAction.FormattingEnabled = true;
            this.cmbxAction.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "^",
            "~"});
            this.cmbxAction.Location = new System.Drawing.Point(79, 3);
            this.cmbxAction.Name = "cmbxAction";
            this.cmbxAction.Size = new System.Drawing.Size(24, 24);
            this.cmbxAction.TabIndex = 6;
            this.cmbxAction.SelectedIndexChanged += new System.EventHandler(this.cmbxAction_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPlus, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn0, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnDivide, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnMinus, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMultipl, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnPoint, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 252);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(141, 129);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 23);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.ChainChars);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(72, 129);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(63, 23);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.ChainChars);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 129);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(63, 23);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.ChainChars);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(141, 66);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 23);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.ChainChars);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(72, 66);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 23);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ChainChars);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 66);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 23);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.ChainChars);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(141, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.ChainChars);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(72, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.ChainChars);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.ChainChars);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Location = new System.Drawing.Point(210, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.SelectedAction);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(72, 192);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(63, 23);
            this.btn0.TabIndex = 20;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.ChainChars);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(210, 192);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 21;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.SelectedAction);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(210, 66);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.SelectedAction);
            // 
            // btnMultipl
            // 
            this.btnMultipl.Location = new System.Drawing.Point(210, 129);
            this.btnMultipl.Name = "btnMultipl";
            this.btnMultipl.Size = new System.Drawing.Size(75, 23);
            this.btnMultipl.TabIndex = 23;
            this.btnMultipl.Text = "*";
            this.btnMultipl.UseVisualStyleBackColor = true;
            this.btnMultipl.Click += new System.EventHandler(this.SelectedAction);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(141, 192);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(63, 23);
            this.btnPoint.TabIndex = 24;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.ChainChars);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 589);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "calaulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBxLeft;
        private System.Windows.Forms.TextBox txtbxRight;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultipl;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.ComboBox cmbxAction;
        private System.Windows.Forms.Button btnClear;
    }
}

