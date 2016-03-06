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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblSpent = new System.Windows.Forms.Label();
            this.lblRecieved = new System.Windows.Forms.Label();
            this.spent = new System.Windows.Forms.Label();
            this.recieved = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retailer = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.ucCalendar1 = new FinancialCalculator.UCCalendar();
            this.btnPrevYear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(45, 11);
            this.tbFile.Margin = new System.Windows.Forms.Padding(2);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(200, 20);
            this.tbFile.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(249, 8);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(89, 25);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblSpent
            // 
            this.lblSpent.AutoSize = true;
            this.lblSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpent.Location = new System.Drawing.Point(21, 48);
            this.lblSpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpent.Name = "lblSpent";
            this.lblSpent.Size = new System.Drawing.Size(102, 20);
            this.lblSpent.TabIndex = 2;
            this.lblSpent.Text = "Total Spent";
            // 
            // lblRecieved
            // 
            this.lblRecieved.AutoSize = true;
            this.lblRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieved.Location = new System.Drawing.Point(11, 119);
            this.lblRecieved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecieved.Name = "lblRecieved";
            this.lblRecieved.Size = new System.Drawing.Size(128, 20);
            this.lblRecieved.TabIndex = 3;
            this.lblRecieved.Text = "Total Recieved";
            // 
            // spent
            // 
            this.spent.AutoSize = true;
            this.spent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spent.ForeColor = System.Drawing.Color.Red;
            this.spent.Location = new System.Drawing.Point(58, 74);
            this.spent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.spent.Name = "spent";
            this.spent.Size = new System.Drawing.Size(0, 24);
            this.spent.TabIndex = 4;
            // 
            // recieved
            // 
            this.recieved.AutoSize = true;
            this.recieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieved.ForeColor = System.Drawing.Color.Green;
            this.recieved.Location = new System.Drawing.Point(62, 145);
            this.recieved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recieved.Name = "recieved";
            this.recieved.Size = new System.Drawing.Size(0, 24);
            this.recieved.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Most Frequent Retailer";
            // 
            // retailer
            // 
            this.retailer.AutoSize = true;
            this.retailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailer.ForeColor = System.Drawing.Color.MediumBlue;
            this.retailer.Location = new System.Drawing.Point(82, 192);
            this.retailer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retailer.Name = "retailer";
            this.retailer.Size = new System.Drawing.Size(0, 24);
            this.retailer.TabIndex = 7;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(1327, 8);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(93, 37);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "2016";
            // 
            // ucCalendar1
            // 
            this.ucCalendar1.Location = new System.Drawing.Point(350, 48);
            this.ucCalendar1.Name = "ucCalendar1";
            this.ucCalendar1.Size = new System.Drawing.Size(1196, 823);
            this.ucCalendar1.TabIndex = 8;
            // 
            // btnPrevYear
            // 
            this.btnPrevYear.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPrevYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrevYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPrevYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevYear.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevYear.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevYear.Image")));
            this.btnPrevYear.Location = new System.Drawing.Point(1424, 4);
            this.btnPrevYear.Name = "btnPrevYear";
            this.btnPrevYear.Size = new System.Drawing.Size(61, 44);
            this.btnPrevYear.TabIndex = 10;
            this.btnPrevYear.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1260, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 44);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 883);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrevYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.ucCalendar1);
            this.Controls.Add(this.retailer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recieved);
            this.Controls.Add(this.spent);
            this.Controls.Add(this.lblRecieved);
            this.Controls.Add(this.lblSpent);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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
        private UCCalendar ucCalendar1;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnPrevYear;
        private System.Windows.Forms.Button button1;
    }
}

