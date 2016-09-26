/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * FormulaOne by Craig McKay <craig@southesk.com>
 * 
 * Who      When         Issue          Description
 * craig    26-Sep-2016  #              File created
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System.Windows.Forms;
using System.IO;
using FormulaOne.Model;
using FormulaOne.Data;

namespace FormulaOne
{
    public partial class RaceTime : Form
    {
        protected Drivers drivers;
        protected int currentDriver;

        public RaceTime()
        {
            InitializeComponent();
        }

        protected void NextDriver()
        {
            currentDriver++;
            if (currentDriver < drivers.Count)
            {
                lblDriver.Text = string.Format("Enter the time for {0} ({1} of {2})", drivers[currentDriver].Name, currentDriver+1, drivers.Count);
                txtTime.Text = "";
            }
            else
            {
                // Score the results
                drivers.Score();

                // Write results to new file
                CsvFile csvFile = new CsvFile(new FileInfo(txtOutput.Text));
                csvFile.Write(drivers);
                drivers = null;
                lblDriver.Text = "Race over!";
            }
        }

        private void btnGo_Click(object sender, System.EventArgs e)
        {
            FileInfo input = new FileInfo(txtInput.Text);
            if (!input.Exists)
            {
                MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CsvFile csvFile = new CsvFile(input);
            drivers = csvFile.Read();
            currentDriver = -1;
            NextDriver();
        }

        private void btnTime_Click(object sender, System.EventArgs e)
        {
            if (drivers != null)
            {
                drivers[currentDriver].Time = System.TimeSpan.Parse(txtTime.Text);
                NextDriver();
            }
        }
    }
}
