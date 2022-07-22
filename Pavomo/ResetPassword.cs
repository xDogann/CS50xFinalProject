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
using System.Net.Mail;
using System.Net;

namespace Pavomo
{
    public partial class ResetPassword : Form
    {
        static Random random = new Random();
        int rand_code = random.Next(10000, 99999);
        SqlConnection connection;
       
        

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Database.connectionString);
            
            ResetPanel.Hide();
            verificationCodePanel.Hide();
            VerificationButton.Hide();
        }

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ContinueButton_Click(object sender, EventArgs e)
        {

            
            connection.Open();

            SqlCommand command = new SqlCommand("Select *from p_account", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (mailCheckBox.Text == Cryptlogy.Decryption(reader["email"].ToString().TrimEnd(), 2))
                {
                    verificationCodePanel.Show();
                    mailCheckBox.Enabled = false;
                    sendMail();
                    ContinueButton.Hide();
                    VerificationButton.Show();

                    
                    
                    break;
                }
            }
            connection.Close();
            
        }
        private void sendMail()
        {
            SmtpClient client = new SmtpClient();
            MailMessage message = new MailMessage();

            client.Credentials = new NetworkCredential("abdussamed.dgn@hotmail.com", "Abdussamed78");

            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;

            message.To.Add(mailCheckBox.Text);
            message.From = new MailAddress("abdussamed.dgn@hotmail.com", "Pavomo");
            message.Subject = "Mail Verification";
            message.Body = "Your Verification Code: " + rand_code;
            client.Send(message);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VerificationButton_Click(object sender, EventArgs e)
        {
            if (veri_pass.Text == rand_code.ToString())
            {
                R_MailPanel.Hide();
                ResetPanel.Show();
            }
            else
            {
                MessageBox.Show("Entered Code Incorrect! Please Check Your Code Again!", "Pavomo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetMyPasswordButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (NewPasswordBox.Text == Re_NewPasswordBox.Text)
            {
                
                SqlCommand command = new SqlCommand("Insert into p_account(password) values ('" + Cryptlogy.Encryption(NewPasswordBox.Text, 2) + "')", connection);
                command.ExecuteNonQuery();
                
                
                MessageBox.Show("Password Changed Successfully!", "Pavomo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                this.Hide();
                LogInPage signinPage_Form = new LogInPage();
                signinPage_Form.Show();

            }
            connection.Close();
        }
    }
}
