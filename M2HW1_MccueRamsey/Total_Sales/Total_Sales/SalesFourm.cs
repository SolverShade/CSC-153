using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesLibrary;

namespace Total_Sales
{
    public partial class SalesFourm : Form
    {
        public SalesFourm()
        {
            InitializeComponent();
        }

        //load in information using methods from the class library 
        private void SalesFourm_Load(object sender, EventArgs e)
        {
            decimal[] Sales = Operations.FetchDecimals("Sales.txt");
            decimal total = 0;

            SalesList.Items.Add("Sales:");

            foreach (decimal sale in Sales)
            {
                SalesList.Items.Add("$"+ sale);
                total += sale; 
            }

            SalesList.Items.Add("");
            SalesList.Items.Add("Total of sales:");
            SalesList.Items.Add("$" + total);
        }

        private void SalesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //no actions to preform 
        }

        private void SalesLabel_Click(object sender, EventArgs e)
        {
            //no actions to preform 
        }
    }
}
