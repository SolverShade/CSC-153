using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Math;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NetPriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal wholeSalePrice = decimal.Parse(EnterWholeSalePriceTextBox.Text);

                decimal markUpWholeNumber = decimal.Parse(EnterMarkUpPercentageTextBox.Text);
                decimal markUpPercent = BusinessMath.ConvertWholeNumberToPercent(markUpWholeNumber);

                decimal netPrice = BusinessMath.CalculateMarkUp(wholeSalePrice, markUpPercent);

                NetPriceTextBox.Text = netPrice.ToString() + "$";
                StatusLabel.Text = "Status: Success";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Status: "+ ex.Message;
            }
        }
    }
}
