using LogicLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Form1 : Form
    {
        private UserInputChecker userInputChecker;
        private StandardMessenger standardMessenger;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            standardMessenger = new StandardMessenger(StatusLabel, DistanceTextbox);
        }

        private void CalculateDistanceButton_Click(object sender, EventArgs e)
        {
            userInputChecker = new UserInputChecker(SecondFallenTextbox);
            bool isDecimal = userInputChecker.CanBeDecimal();

            if(isDecimal == true)
            {
                decimal seconds = decimal.Parse(SecondFallenTextbox.Text);
                decimal distance = PracticalMath.FallingDistance(seconds);
                standardMessenger.DisplayDistance(distance);
                standardMessenger.ProgramSuccessStatus();
            }
            else
            {
                standardMessenger.InvalidInputStatus();
            }
        }
    }
}
