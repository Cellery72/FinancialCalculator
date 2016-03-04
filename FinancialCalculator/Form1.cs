using System;
using Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinancialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            double[] x = calcSpent(Utility.readCSV(tbFile.Text));
            spent.Text = x[0].ToString();
            recieved.Text = x[1].ToString();
        }
        private double[] calcSpent(List<Spreadsheet> x)
        {
            double[] str = new double[3];
            foreach(Spreadsheet s in x)
            {
                str[0] += s.outbound;
                str[1] += s.inbound;
            }
            return str;
        }


    }
}
