using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            String input = inputTextBox.Text;  // gets user input

            char[] chars = input.ToCharArray(); // put string into char array
            
            for (int i = 0; i < chars.Length; ++i) // goes through the string array
            {
                if (chars[i] == ' ') //if the char at index i is blank
                {
                    chars[i + 1] = Char.ToUpper(chars[i + 1]); // change the next char to capital
                }
                else if (i == 0) // if the index is the first in the whole string, capitalize
                { 
                    chars[i] = Char.ToUpper(chars[i]); 
                }
            }

            outputTextBox.Text = new string(chars); // displays the text
        }
    }
}
