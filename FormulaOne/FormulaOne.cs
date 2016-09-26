/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * FormulaOne by Craig McKay <craig@southesk.com>
 * 
 * Who      When         Issue          Description
 * craig    26-Sep-2016  #1             File created
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System;
using System.Windows.Forms;

namespace FormulaOne
{
    static class FormulaOne
    {
        /// <summary>
        /// The main entry point for the FormulaOne application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RaceTime());
        }
    }
}
