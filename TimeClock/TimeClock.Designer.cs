namespace TimeClock
{
    partial class TimeClock
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
            this.timeClockGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.timeClockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // timeClockGrid
            // 
            this.timeClockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeClockGrid.Location = new System.Drawing.Point(12, 12);
            this.timeClockGrid.Name = "timeClockGrid";
            this.timeClockGrid.RowHeadersWidth = 51;
            this.timeClockGrid.RowTemplate.Height = 24;
            this.timeClockGrid.Size = new System.Drawing.Size(382, 386);
            this.timeClockGrid.TabIndex = 0;
            // 
            // TimeClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 409);
            this.Controls.Add(this.timeClockGrid);
            this.Name = "TimeClock";
            this.Text = "TimeClock";
            ((System.ComponentModel.ISupportInitialize)(this.timeClockGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView timeClockGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}