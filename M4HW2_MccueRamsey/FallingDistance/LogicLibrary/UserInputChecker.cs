using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicLibrary
{
    public class UserInputChecker
    {
        public TextBox InputBox; 
        public UserInputChecker(TextBox inputBox)
        {
            InputBox = inputBox;
        }

        public bool CanBeDecimal()
        {
            string inputText = InputBox.Text;
            bool isDecimal = decimal.TryParse(inputText, out decimal extractedDecimal);

            return isDecimal;
        }
    }
}
