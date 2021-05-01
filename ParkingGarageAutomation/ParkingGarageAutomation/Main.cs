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
        public Main()
        {
            InitializeComponent();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter fileWriter = new StreamWriter("client.txt"))
            {
                fileWriter.WriteLine("{0}, {1}", fNameTextBox.Text, lNameTextBox.Text);
                fNameTextBox.Clear();
                lNameTextBox.Clear();
            }
        }
    }

}
