using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public class StandardMessenger
    {
        public Label StatusLabel;
        public TextBox ResultBox;
        const string STATUSPREFIX = "Status: ";
        public StandardMessenger(Label statusLabel, TextBox resultBox)
        {
            StatusLabel = statusLabel;
            ResultBox = resultBox;
        }

        public void InvalidInputStatus()
        {
            StatusLabel.Text = STATUSPREFIX + "Enter seconds as an integer or decimal value"; 
        }

        public void ProgramSuccessStatus() 
        {
            StatusLabel.Text = STATUSPREFIX + "Success!";
        }

        public void DisplayDistance(decimal distance)
        {
            ResultBox.Text = distance.ToString() + " Meters";
        }
    }
}
