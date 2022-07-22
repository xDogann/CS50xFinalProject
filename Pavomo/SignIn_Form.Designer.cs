
namespace Pavomo
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.Background = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logInText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Background.BackgroundImage")));
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Controls.Add(this.pictureBox3);
            this.Background.Controls.Add(this.panel1);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1280, 720);
            this.Background.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1236, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // logInText
            // 
            this.logInText.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logInText.ForeColor = System.Drawing.Color.Gold;
            this.logInText.Location = new System.Drawing.Point(143, 72);
            this.logInText.Name = "logInText";
            this.logInText.Size = new System.Drawing.Size(157, 63);
            this.logInText.TabIndex = 0;
            this.logInText.Text = "Log In";
            this.logInText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Impact", 5F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(64, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 1);
            this.label1.TabIndex = 2;
            this.label1.Text = "_";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.Black;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.ForeColor = System.Drawing.Color.Gold;
            this.usernameBox.Location = new System.Drawing.Point(105, 219);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(288, 15);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Text = "Username";
            this.usernameBox.Enter += new System.EventHandler(this.usernameBox_Enter);
            this.usernameBox.Leave += new System.EventHandler(this.usernameBox_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.Black;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.ForeColor = System.Drawing.Color.Gold;
            this.passwordBox.Location = new System.Drawing.Point(103, 274);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(288, 15);
            this.passwordBox.TabIndex = 6;
            this.passwordBox.Text = "Password";
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(68, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Gold;
            this.loginButton.Font = new System.Drawing.Font("Impact", 20.2F);
            this.loginButton.Location = new System.Drawing.Point(239, 353);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(151, 62);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 5F);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(61, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "_________________________________________________________________________________" +
    "___________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Impact", 10.2F);
            this.button2.Location = new System.Drawing.Point(129, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 62);
            this.button2.TabIndex = 9;
            this.button2.Text = "Create New Account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(74, 377);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ı forgot my password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Impact", 5F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(63, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 1);
            this.label2.TabIndex = 11;
            this.label2.Text = "_";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logInText);
            this.panel1.Location = new System.Drawing.Point(715, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 616);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(53, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "*Username or password is incorrect!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pavomo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logInText;
    }
}

