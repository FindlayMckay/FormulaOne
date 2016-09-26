/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * FormulaOne by Craig McKay <craig@southesk.com>
 * 
 * Who      When         Issue          Description
 * craig    26-Sep-2016  #              File created
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System.IO;
using FormulaOne.Model;

namespace FormulaOne.Data
{
    /// <summary>
    /// Reads and writes CSV files.
    /// </summary>
    public class CsvFile
    {
        protected FileInfo file;

        public CsvFile(FileInfo file)
        {
            this.file = file;
        }

        public Drivers Read()
        {
            Drivers drivers = new Drivers();

            StreamReader reader = new StreamReader(File.OpenRead(this.file.FullName));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                drivers.Add(new Driver(values[0]));
            }

            return drivers;
        }

        public void Write(Drivers drivers)
        {
            using (StreamWriter w = new StreamWriter(this.file.FullName))
            {
                foreach(Driver d in drivers)
                {              
                    string line = string.Format(@"{0},{1:mm\:ss\.fff},{2}", d.Name, d.Time, d.Points);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }
    }
}
