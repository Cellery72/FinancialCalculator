namespace FinancialCalculator
{
    partial class UCDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbDate = new System.Windows.Forms.PictureBox();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDate
            // 
            this.pbDate.BackColor = System.Drawing.Color.Black;
            this.pbDate.Location = new System.Drawing.Point(0, 3);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(150, 150);
            this.pbDate.TabIndex = 0;
            this.pbDate.TabStop = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Black;
            this.lblNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(3, 3);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(55, 37);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "31";
            // 
            // UCDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.pbDate);
            this.Name = "UCDay";
            this.Size = new System.Drawing.Size(162, 151);
            this.Load += new System.EventHandler(this.UCDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDate;
        private System.Windows.Forms.Label lblNumber;
    }
}
