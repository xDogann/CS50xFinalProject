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
    public partial class Awake_Form : Form
    {

        int timeInteger = 0;

        public Awake_Form()
        {
            InitializeComponent();
        }

        private void Awake_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeInteger++;

            if (timeInteger == 100)
            {
                timer1.Stop();
                LogInPage loginPage = new LogInPage();
                this.Hide();
                loginPage.Show();
            }
        }
    }
}
