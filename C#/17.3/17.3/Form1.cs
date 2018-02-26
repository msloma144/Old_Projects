using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _17._3
{
    public partial class Form1 : Form
    {
        private StreamWriter fileWriter; // writes data to file
        private StreamReader fileReader; // for bring in input

        private string fileName; // name of file to write to
        private string fileOpen; // name of file to open

        private List<string> inputs; // array for output to file

        public Form1()
        {
            InitializeComponent();
        }

        //Save as button
        private void saveAsButton_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to save file
            DialogResult result;// result of SaveFileDialog

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // let user create file
                result = fileChooser.ShowDialog();
                this.fileName = fileChooser.FileName; // name of file to save data
            } // end using

            saveButton.Enabled = false; // turn off save as button
            enterButton.Enabled = true; // turn on enter button
            closeFileButton.Enabled = true; // turn on close file button
            inputs = new List<string>();
        }

        //Method to clear all text boxes
        public void ClearTextBoxes()
        {
            // clears all boxes
            firstNameWriteBox.Text = "";
            lastNameWriteBox.Text = "";
            IDNumWriteBox.Text = "";
            classWriteBox.Text = "";
            gradeWriteBox.Text = "";
        } 

        //Enter Button Click
        private void enterButton_Click(object sender, EventArgs e)
        {
            // determine whether TextBox account field is empty
            if (firstNameWriteBox.Text != string.Empty && lastNameWriteBox.Text != string.Empty)
            {
                //checks if ID num is really a number
                int number;
                bool convertInt = Int32.TryParse(IDNumWriteBox.Text, out number);

                if (convertInt)
                {
                    inputs.Add(firstNameWriteBox.Text + ", " + lastNameWriteBox.Text + ": " + number + "  " + classWriteBox.Text + "  " + gradeWriteBox.Text + "\n");
                    try
                    {
                        using (fileWriter = new StreamWriter(fileName))
                        {
                            foreach (string input in inputs)
                            {
                                fileWriter.WriteLine(input); // write out each line
                            }
                        }
                    }

                    // notify user if error occurs during the output operation
                    catch (IOException)
                    {
                        MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // end catch 
                    catch (FormatException)
                    {
                        // notify user if error occurs regarding parameter format
                        MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // end catch
                }
                else
                {
                    MessageBox.Show("Please enter a number for the ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter first and last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClearTextBoxes(); // clear TextBox values

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // determine whether file exists
            if (fileWriter != null)
            {
                try
                {
                    // close StreamWriter and underlying file
                    fileWriter.Close();
                }
                // notify user of error closing file
                catch (IOException)
                {
                    MessageBox.Show("Cannot close file", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to open file

            DialogResult result;// result of SaveFileDialog
            resultBox.Items.Clear(); // clears the item box so it only displays the file

            using (OpenFileDialog fileChooser = new OpenFileDialog()) // open file
            {
                result = fileChooser.ShowDialog();
                this.fileOpen = fileChooser.FileName; // name of file to save data
            } 

            string line; // declare string for the lines from file
            int counter = 0; // counter for while loop

            using (fileReader = new StreamReader(fileOpen)) // sets up StreamReader
            {
                while ((line = fileReader.ReadLine()) != null) // reads in the lines
                {
                    resultBox.Items.Add(line); // displays the results in the list box
                    counter++;
                }
            }
        }
    }
}
