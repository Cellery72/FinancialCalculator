using System;
using Domain;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace FinancialCalculator
{
    public partial class Form1 : Form
    {
        private DateTime today = DateTime.Now;

        
        public Form1()
        {
            InitializeComponent();
        }

        
        // ******************************
        // ~~~~~~ Event Handlers ~~~~~~~~
        // ******************************
        private void btnUpload_Click(object sender, EventArgs e)
        {
            Spreadsheet spred = new Spreadsheet(tbFile.Text);
            //int highestValue = spred.retailers.Values.Max();
        }


    }
}
