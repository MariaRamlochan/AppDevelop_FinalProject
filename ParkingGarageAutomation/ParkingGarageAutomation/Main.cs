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
            string[] values = GetTextBoxValues();

           var record = new Records( values[(int)TextBoxIndices.First], values[(int)TextBoxIndices.Last]);
            fileWriter.WriteLine($"{record.FirstName}, " + $"{record.LastName}");
        }
    }
}
