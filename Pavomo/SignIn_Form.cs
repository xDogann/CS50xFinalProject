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


namespace Pavomo
{
    public partial class LogInPage : Form
    {
        public static SqlConnection connection;

        bool isThere;
        public LogInPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Database.connectionString);
            label4.Hide();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ResetPassword resetPassword_Page = new ResetPassword();
            resetPassword_Page.Show();
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

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.Text = "";
                passwordBox.PasswordChar = '•';
            }
        }
        char? none = null;
        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.Text = "Password";
                passwordBox.PasswordChar = Convert.ToChar(none);
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("Select *from p_account", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (username == Cryptlogy.Decryption(reader["username"].ToString().TrimEnd(), 2) && password == Cryptlogy.Decryption(reader["password"].ToString().TrimEnd(), 2))
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                    label4.Show();
                    
                }
            }
            connection.Close(); 
            if (isThere)
            {
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp_Form Sigin_Form = new SignUp_Form();
            Sigin_Form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
