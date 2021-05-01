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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("client.txt"))
            {
                using (StreamReader streamReader = new StreamReader("client.txt"))
                {
                    fNameTextBox.Text = streamReader.ReadLine();
                    lNameTextBox.Text = streamReader.ReadLine();
                }
            }
        }
    }

}
