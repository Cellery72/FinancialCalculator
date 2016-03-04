using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace Domain
{
    public class Spreadsheet
    {
        public Spreadsheet()
        {
        }

        [CsvColumn(Name="Date",FieldIndex = 1)]
        public DateTime Date { get; set; }

        [CsvColumn(Name = "Retailer", FieldIndex = 2)]
        public string Retailer { get; set; }

        [CsvColumn(Name = "Outbound", FieldIndex = 3)]
        public double Outbound { get; set; }

        [CsvColumn(Name = "Inbound", FieldIndex = 4)]
        public double Inbound { get; set; }

        [CsvColumn(Name = "Balance", FieldIndex = 5)]
        public double RunningBalance { get; set; }
    }
}
