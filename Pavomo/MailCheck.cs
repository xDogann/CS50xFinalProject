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
using System.Net.Mail;
using System.Net;


namespace Pavomo
{
    public partial class Pamovo : Form
    {
        SqlConnection connection;

        static Random random = new Random();
        int rand_code = random.Next(10000, 99999);

        public Pamovo()
        {
            InitializeComponent();
        }

        private void MailCheck_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Database.connectionString);
            sendMail();
        }

        private void logInText_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogInPage loginPage = new LogInPage();
            loginPage.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (mailCheckBox.Text == rand_code.ToString())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into p_account(username, name, email, password) values ('" + Cryptlogy.Encryption(SignUp_Form.username, 2) + "','" + Cryptlogy.Encryption(SignUp_Form.name, 2) + "','" + Cryptlogy.Encryption(SignUp_Form.email, 2) + "','" + Cryptlogy.Encryption(SignUp_Form.password, 2) + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("You Have Successfully Registered! Please Login Now", "Pavomo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LogInPage signinPage_Form = new LogInPage();
                signinPage_Form.Show();

                
            }
            else
            {
                MessageBox.Show("Entered Code Incorrect! Please Check Your Code Again!", "Pavomo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sendMail()
        {
            SmtpClient client = new SmtpClient();
            MailMessage message = new MailMessage();

            client.Credentials = new NetworkCredential("abdussamed.dgn@hotmail.com", "Abdussamed78");

            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;

            message.To.Add(SignUp_Form.email);
            message.From = new MailAddress("abdussamed.dgn@hotmail.com", "Pavomo");
            message.Subject = "Mail Verification";
            message.Body = "Your Verification Code: " + rand_code;
            client.Send(message);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
