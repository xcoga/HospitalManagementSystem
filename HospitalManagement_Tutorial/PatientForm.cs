using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement_Tutorial
{
    public partial class PatientForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Xcoga\OneDrive\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
        public PatientForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);  // Fill the DataTable with data

            patientGV.DataSource = dt;  // Assign DataTable to DataGridView
            Con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO PatientTbl (PatId, PatName, PatAddress, PatPhone, PatAge, PatGender, PatBlood, PatDisease)" +
                " VALUES (@PatId, @PatName, @PatAddress, @PatPhone, @PatAge, @PatGender, @PatBlood, @PatDisease)";


            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@PatId", PatID.Text);
                cmd.Parameters.AddWithValue("@PatName", PatName.Text);
                cmd.Parameters.AddWithValue("@PatAddress", PatAddress.Text);
                cmd.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
                cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                cmd.Parameters.AddWithValue("@PatGender", PatGender.Text);
                cmd.Parameters.AddWithValue("@PatBlood", PatBlood.Text);
                cmd.Parameters.AddWithValue("@PatDisease", PatDisease.Text);

                if (string.IsNullOrWhiteSpace(PatID.Text) ||
                    string.IsNullOrWhiteSpace(PatName.Text) ||
                    string.IsNullOrWhiteSpace(PatAddress.Text) ||
                    string.IsNullOrWhiteSpace(PatPhone.Text) ||
                    string.IsNullOrWhiteSpace(PatAge.Text) ||
                    PatGender.Text == "Gender" ||
                    PatBlood.Text == "BloodGroup"||
                    string.IsNullOrWhiteSpace(PatDisease.Text))
                {
                    MessageBox.Show("Please fill in all boxes!");
                }
                else
                {
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                    MessageBox.Show("Patient Successfully Added");
                }

            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
