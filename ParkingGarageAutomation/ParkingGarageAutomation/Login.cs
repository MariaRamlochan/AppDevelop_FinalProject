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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if ((idTextBox.Text == "101") && (passwordTextBox.Text == "101"))
            {
                using (StreamWriter fileWriter = new StreamWriter("employee.txt"))
                {
                    fileWriter.WriteLine(idTextBox.Text);
                }

                this.Hide();
                Main mainForm = new Main();
                mainForm.Show();
            } 
            else
            {
                MessageBox.Show("Login Details are INCORRECT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main();
            mainForm.Show();
        }
    }
}
