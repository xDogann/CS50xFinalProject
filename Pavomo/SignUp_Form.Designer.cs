
namespace Pavomo
{
    partial class SignUp_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Form));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.Background = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logInText = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Black;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.ForeColor = System.Drawing.Color.Gold;
            this.nameBox.Location = new System.Drawing.Point(79, 161);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(216, 13);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "Name";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // Background
            // 
            this.Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Background.BackgroundImage")));
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Controls.Add(this.pictureBox3);
            this.Background.Controls.Add(this.panel1);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(960, 585);
            this.Background.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(927, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logInText);
            this.panel1.Location = new System.Drawing.Point(536, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 500);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Impact", 5F);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(47, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 1);
            this.label3.TabIndex = 17;
            this.label3.Text = "_";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(51, 242);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(51, 287);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.Black;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.ForeColor = System.Drawing.Color.Gold;
            this.passwordBox.Location = new System.Drawing.Point(77, 292);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(216, 13);
            this.passwordBox.TabIndex = 16;
            this.passwordBox.Text = "Password";
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.Black;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.ForeColor = System.Drawing.Color.Gold;
            this.emailBox.Location = new System.Drawing.Point(79, 247);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(216, 13);
            this.emailBox.TabIndex = 14;
            this.emailBox.Text = "Email";
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
            this.emailBox.Leave += new System.EventHandler(this.emailBox_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Impact", 5F);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(48, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 1);
            this.label4.TabIndex = 13;
            this.label4.Text = "_";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Impact", 5F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(47, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 1);
            this.label2.TabIndex = 11;
            this.label2.Text = "_";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(152, 428);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log In";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Impact", 15.2F);
            this.button1.Location = new System.Drawing.Point(179, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.Black;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.ForeColor = System.Drawing.Color.Gold;
            this.usernameBox.Location = new System.Drawing.Point(77, 206);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(216, 13);
            this.usernameBox.TabIndex = 6;
            this.usernameBox.Text = "Username";
            this.usernameBox.Enter += new System.EventHandler(this.usernameBox_Enter);
            this.usernameBox.Leave += new System.EventHandler(this.usernameBox_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Impact", 5F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(48, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 1);
            this.label1.TabIndex = 2;
            this.label1.Text = "_";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logInText
            // 
            this.logInText.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logInText.ForeColor = System.Drawing.Color.Gold;
            this.logInText.Location = new System.Drawing.Point(100, 58);
            this.logInText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logInText.Name = "logInText";
            this.logInText.Size = new System.Drawing.Size(139, 51);
            this.logInText.TabIndex = 0;
            this.logInText.Text = "Sign Up";
            this.logInText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pavomo";
            this.Load += new System.EventHandler(this.SignIn_Form_Load);
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logInText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
    }
}