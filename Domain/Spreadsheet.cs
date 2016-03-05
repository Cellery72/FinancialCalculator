using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Spreadsheet
    {
        public Spreadsheet() { }
        public Spreadsheet(string filename)
        {
            rows = Utility.readCSV(filename);
            populateRetailers();
        }

        protected List<Row> rows { get; set; }
        protected string[] columns = { "Date", "Retailer", "Outbound", "Inbound", "Running Balance" };
        public Dictionary<string, int> retailers = new Dictionary<string, int>();

        private void populateRetailers()
        {
            foreach (Row r in rows)
            {
                if (retailers.ContainsKey(r.Retailer))
                    retailers[r.Retailer]++;
                else
                    retailers.Add(r.Retailer, 0);
            }
        }


    }
}
