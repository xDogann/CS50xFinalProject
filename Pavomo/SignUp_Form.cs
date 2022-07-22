using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;



namespace Pavomo
{
    public partial class SignUp_Form : Form
    {
        SqlConnection connection;

        static public string username { get; set; }
        static public string name { get; set; }
        static public string email { get; set; }
        static public string password { get; set; }

        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = usernameBox.Text;
            name = nameBox.Text;
            email = emailBox.Text;
            password = passwordBox.Text;

            this.Hide();
            Pamovo mailCheckPage = new Pamovo();
            mailCheckPage.Show();
        }
        private void SignIn_Form_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Database.connectionString);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Name")
            {
                nameBox.Text = "";
            }

        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Name";
            }
        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Username")
            {
                usernameBox.Text = "";
            }
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {
                usernameBox.Text = "Username";
            }
        }

        private void emailBox_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "Email")
            {
                emailBox.Text = "";
            }
        }

        private void emailBox_Leave(object sender, EventArgs e)
        {
            if (emailBox.Text == "")
            {
                emailBox.Text = "Email";
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.Text = "";
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.Text = "Password";
            }
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogInPage loginPage = new LogInPage();
            loginPage.Show();

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}