namespace FinancialCalculator
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
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblSpent = new System.Windows.Forms.Label();
            this.lblRecieved = new System.Windows.Forms.Label();
            this.spent = new System.Windows.Forms.Label();
            this.recieved = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retailer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(260, 24);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(298, 26);
            this.tbFile.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(564, 21);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(87, 33);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblSpent
            // 
            this.lblSpent.AutoSize = true;
            this.lblSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpent.Location = new System.Drawing.Point(86, 98);
            this.lblSpent.Name = "lblSpent";
            this.lblSpent.Size = new System.Drawing.Size(148, 29);
            this.lblSpent.TabIndex = 2;
            this.lblSpent.Text = "Total Spent";
            // 
            // lblRecieved
            // 
            this.lblRecieved.AutoSize = true;
            this.lblRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieved.Location = new System.Drawing.Point(289, 98);
            this.lblRecieved.Name = "lblRecieved";
            this.lblRecieved.Size = new System.Drawing.Size(190, 29);
            this.lblRecieved.TabIndex = 3;
            this.lblRecieved.Text = "Total Recieved";
            // 
            // spent
            // 
            this.spent.AutoSize = true;
            this.spent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spent.ForeColor = System.Drawing.Color.Red;
            this.spent.Location = new System.Drawing.Point(141, 139);
            this.spent.Name = "spent";
            this.spent.Size = new System.Drawing.Size(0, 32);
            this.spent.TabIndex = 4;
            // 
            // recieved
            // 
            this.recieved.AutoSize = true;
            this.recieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieved.ForeColor = System.Drawing.Color.Green;
            this.recieved.Location = new System.Drawing.Point(366, 139);
            this.recieved.Name = "recieved";
            this.recieved.Size = new System.Drawing.Size(0, 32);
            this.recieved.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Most Frequent Retailer";
            // 
            // retailer
            // 
            this.retailer.AutoSize = true;
            this.retailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailer.ForeColor = System.Drawing.Color.MediumBlue;
            this.retailer.Location = new System.Drawing.Point(666, 149);
            this.retailer.Name = "retailer";
            this.retailer.Size = new System.Drawing.Size(0, 32);
            this.retailer.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 434);
            this.Controls.Add(this.retailer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recieved);
            this.Controls.Add(this.spent);
            this.Controls.Add(this.lblRecieved);
            this.Controls.Add(this.lblSpent);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblSpent;
        private System.Windows.Forms.Label lblRecieved;
        private System.Windows.Forms.Label spent;
        private System.Windows.Forms.Label recieved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label retailer;
    }
}

