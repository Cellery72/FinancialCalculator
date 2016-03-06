namespace FinancialCalculator
{
    partial class UCMonth
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
            this.ucWeek1 = new FinancialCalculator.UCWeek();
            this.ucWeek2 = new FinancialCalculator.UCWeek();
            this.ucWeek3 = new FinancialCalculator.UCWeek();
            this.ucWeek4 = new FinancialCalculator.UCWeek();
            this.ucWeek5 = new FinancialCalculator.UCWeek();
            this.SuspendLayout();
            // 
            // ucWeek1
            // 
            this.ucWeek1.Location = new System.Drawing.Point(3, 2);
            this.ucWeek1.Name = "ucWeek1";
            this.ucWeek1.Size = new System.Drawing.Size(1104, 156);
            this.ucWeek1.TabIndex = 0;
            // 
            // ucWeek2
            // 
            this.ucWeek2.Location = new System.Drawing.Point(3, 153);
            this.ucWeek2.Name = "ucWeek2";
            this.ucWeek2.Size = new System.Drawing.Size(1104, 156);
            this.ucWeek2.TabIndex = 1;
            // 
            // ucWeek3
            // 
            this.ucWeek3.Location = new System.Drawing.Point(3, 303);
            this.ucWeek3.Name = "ucWeek3";
            this.ucWeek3.Size = new System.Drawing.Size(1104, 156);
            this.ucWeek3.TabIndex = 2;
            // 
            // ucWeek4
            // 
            this.ucWeek4.Location = new System.Drawing.Point(3, 450);
            this.ucWeek4.Name = "ucWeek4";
            this.ucWeek4.Size = new System.Drawing.Size(1104, 156);
            this.ucWeek4.TabIndex = 3;
            // 
            // ucWeek5
            // 
            this.ucWeek5.Location = new System.Drawing.Point(3, 601);
            this.ucWeek5.Name = "ucWeek5";
            this.ucWeek5.Size = new System.Drawing.Size(1104, 156);
            this.ucWeek5.TabIndex = 4;
            // 
            // UCMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucWeek5);
            this.Controls.Add(this.ucWeek4);
            this.Controls.Add(this.ucWeek3);
            this.Controls.Add(this.ucWeek2);
            this.Controls.Add(this.ucWeek1);
            this.Name = "UCMonth";
            this.Size = new System.Drawing.Size(1113, 762);
            this.ResumeLayout(false);

        }

        #endregion

        private UCWeek ucWeek1;
        private UCWeek ucWeek2;
        private UCWeek ucWeek3;
        private UCWeek ucWeek4;
        private UCWeek ucWeek5;
    }
}
