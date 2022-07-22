using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavomo
{
    public partial class inception : Form
    {
        public inception()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
    
          
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
