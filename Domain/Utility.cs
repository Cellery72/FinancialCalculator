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
        public static List<Row> readCSV(string s)
        {
            List<Row> ls = new List<Row>();
            try {
                string temp = Path.GetFullPath(s);
                CsvFileDescription inputFileDescription = new CsvFileDescription
                {
                    EnforceCsvColumnAttribute = true,
                    SeparatorChar = ',',
                    FirstLineHasColumnNames = false
                };
                CsvContext cc = new CsvContext();
                IEnumerable<Row> products =
                    cc.Read<Row>(temp, inputFileDescription);

                foreach (Row y in products)
                {
                    ls.Add(y);
                }
            }
            catch(Exception ex)
            {
                ls = null;
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return ls;        
        }
    }
}
