using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            String input = numberTextBox.Text; // input from text box

            if (input != String.Empty)
            {
                for (int i = 0; i < input.Length; ++i) // 1st letter
                {
                    for (int a = 0; a < input.Length; ++a) // second letter
                    {
                        for (int k = 0; k < input.Length; ++k) // 3rd letter
                        {
                            if (i == a || i == k || a == k) continue; // checks if the loops are at the same number, disregard

                            String word = Convert.ToString(input[i]) + Convert.ToString(input[a]) + Convert.ToString(input[k]); // some weird magic, taking string to char to string again
                            resultListBox.Items.Add(word); // add word to list box for output
                        }
                    }

                }
            }
        }

    }
}
