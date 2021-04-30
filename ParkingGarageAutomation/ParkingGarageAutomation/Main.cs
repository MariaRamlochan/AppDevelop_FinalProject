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

namespace ParkingGarageAutomation
{
    public partial class Main : Form
    {
        protected int TextBoxCount { get; set; } = 2;
        public enum TextBoxIndices { First, Last};

        private StreamWriter fileWriter;
        public Main()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
        }

        public void SaveFile()
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                        fileWriter = new StreamWriter(output);

                        checkInButton.Enabled = false;
                        checkOutButton.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Eror",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw (new ArgumentException($"There must be {TextBoxCount} string in the array", nameof(values)));
            }
            else
            {
                fNameTextBox.Text = values[(int)TextBoxIndices.First];
                lNameTextBox.Text = values[(int)TextBoxIndices.Last];
            }
        }

        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                fNameTextBox.Text, lNameTextBox.Text
            };
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            SaveFile();
            string[] values = GetTextBoxValues();

            var record = new Records(values[(int)TextBoxIndices.First], values[(int)TextBoxIndices.Last]);
           fileWriter.WriteLine($"{record.FirstName}, {record.LastName}");

            SetTextBoxValues(values);
            ClearTextBoxes();
        }
    }

    //I am me
}
