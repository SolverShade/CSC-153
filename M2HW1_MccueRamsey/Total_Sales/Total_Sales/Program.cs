using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesLibrary;

/*
* 1/27/2020
* CSC 153
* Ramsey Mccue
* Description - Obtains decimal values from a txt document and displays them in WinFourms
*/

namespace Total_Sales
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SalesFourm());
        }
    }
}
