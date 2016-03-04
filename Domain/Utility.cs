using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace Domain
{
    public static class Utility
    {
        public static List<Spreadsheet> readCSV(string s)
        {
            List<Spreadsheet> ls = new List<Spreadsheet>();
            try {
                string temp = Path.GetFullPath(s);
                CsvFileDescription inputFileDescription = new CsvFileDescription
                {
                    EnforceCsvColumnAttribute = true,
                    SeparatorChar = ',',
                    FirstLineHasColumnNames = false
                };
                CsvContext cc = new CsvContext();
                IEnumerable<Spreadsheet> products =
                    cc.Read<Spreadsheet>(temp, inputFileDescription);

                foreach (Spreadsheet y in products)
                {
                    ls.Add(y);
                }
            }
            catch(Exception ex)
            {
                ls = null;
                Console.WriteLine(ex.Message);
            }
            return ls;        
        }
    }
}
