using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCardGame
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void convertionButton_Click(object sender, EventArgs e)
        {
            string result = "";
            if (inputTextBox.Text.Length > 0 && CardGameCalc.sanitiseInput(inputTextBox.Text))
            {
                result = CardGameCalc.convertScore(inputTextBox.Text);
            }
            else
            {
                result = "Invalid input string";
            }
            messageLabel.Text = result;
        }
    }
}
