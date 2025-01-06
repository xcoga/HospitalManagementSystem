using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement_Tutorial
{
    public partial class SplashForm : Form
    {
        int startpoint = 0;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            progressBar.Value = startpoint;

            if (progressBar.Value == 100)
            {


                Login login = new Login();
                login.Show();
                this.Hide();

                progressBar.Value = 0;
                timer1.Stop();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
