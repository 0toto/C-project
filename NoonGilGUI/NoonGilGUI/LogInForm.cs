using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoonGilGUI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            exitButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.BorderSize = 0;
            signUpButton.FlatAppearance.BorderSize = 0; 
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signingUp = new SignUpForm();
            signingUp.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
