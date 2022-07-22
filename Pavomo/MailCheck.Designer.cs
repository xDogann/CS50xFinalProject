
namespace Pavomo
{
    partial class Pamovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pamovo));
            this.Background = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mailCheckBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logInText = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mailCheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logInText);
            this.panel1.Location = new System.Drawing.Point(533, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 344);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(26, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "*Check Your Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(92, 263);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "log in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Gold;
            this.loginButton.Font = new System.Drawing.Font("Impact", 20.2F);
            this.loginButton.Location = new System.Drawing.Point(179, 244);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(113, 50);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Verify";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mailCheckBox
            // 
            this.mailCheckBox.BackColor = System.Drawing.Color.Black;
            this.mailCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.mailCheckBox.Location = new System.Drawing.Point(79, 167);
            this.mailCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mailCheckBox.Name = "mailCheckBox";
            this.mailCheckBox.Size = new System.Drawing.Size(216, 13);
            this.mailCheckBox.TabIndex = 3;
            this.mailCheckBox.Text = "Verification Code";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Impact", 5F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(48, 190);
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
            this.logInText.Location = new System.Drawing.Point(68, 63);
            this.logInText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logInText.Name = "logInText";
            this.logInText.Size = new System.Drawing.Size(208, 51);
            this.logInText.TabIndex = 0;
            this.logInText.Text = "Email Check";
            this.logInText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logInText.Click += new System.EventHandler(this.logInText_Click);
            // 
            // Pamovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pamovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailCheck";
            this.Load += new System.EventHandler(this.MailCheck_Load);
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mailCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logInText;
        private System.Windows.Forms.Label label2;
    }
}