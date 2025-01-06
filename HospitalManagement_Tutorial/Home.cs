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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void doctorPicture_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void doctorLabel_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void patientPicture_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void diagnosisPicture_Click(object sender, EventArgs e)
        {
            DiagnosisForm diagnosisForm = new DiagnosisForm();
            diagnosisForm.Show();
            this.Hide();
        }

        private void diagnosisLabel_Click(object sender, EventArgs e)
        {
            DiagnosisForm diagnosisForm = new DiagnosisForm();
            diagnosisForm.Show();
            this.Hide();
        }
    }
}
