using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement_Tutorial
{
    public partial class DiagnosisForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Xcoga\OneDrive\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
        public DiagnosisForm()
        {
            InitializeComponent();
            populate();
            populatePatientIdCombo();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);  // Fill the DataTable with data

            DiagnosisGV.DataSource = dt;  // Assign DataTable to DataGridView
            Con.Close();

        }

        void populatePatientIdCombo()
        {
            string query = "SELECT PatId FROM PatientTbl";

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                // Clear existing items before adding new ones
                PatientIdTb.Items.Clear();

                while (rdr.Read())
                {
                    PatientIdTb.Items.Add(rdr["PatId"].ToString());
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }

        void fetchPatientName()
        {
            string query = "SELECT PatName FROM PatientTbl WHERE PatId = @PatId";

            // Validate PatientId input
            if (string.IsNullOrWhiteSpace(PatientIdTb.Text) || PatientIdTb.Text == "PatientID")
            {
                MessageBox.Show("Please fill in PatientID!");
                return; // Exit the function early
            }

            try
            {
                Con.Open();
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@PatId", PatientIdTb.Text);
                    object result = cmd.ExecuteScalar(); // Fetches a single value

                    if (result != null) // If patient exists
                    {
                        PatientNameTb.Text = result.ToString(); // Update textbox
                    }
                    else
                    {
                        MessageBox.Show("Patient not found!");
                        PatientNameTb.Text = ""; // Clear the textbox if no patient found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO DiagnosisTbl (DiagId, PatId, PatName, Symptoms, Diagnosis, Medicines)" +
                " VALUES (@DiagId, @PatId, @PatName, @Symptoms, @Diagnosis, @Medicines)";

            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@DiagId", DiagIdTb.Text);
                cmd.Parameters.AddWithValue("@PatId", PatientIdTb.Text);
                cmd.Parameters.AddWithValue("@PatName", PatientNameTb.Text);
                cmd.Parameters.AddWithValue("@Symptoms", SymptomsTb.Text);
                cmd.Parameters.AddWithValue("@Diagnosis", DiagnosisTb.Text);
                cmd.Parameters.AddWithValue("@Medicines", MedicinesTb.Text);

                // Validate input fields
                if (string.IsNullOrWhiteSpace(PatientIdTb.Text) ||
                    PatientIdTb.Text == "PatientID" ||
                    string.IsNullOrWhiteSpace(PatientNameTb.Text) ||
                    string.IsNullOrWhiteSpace(SymptomsTb.Text) ||
                    string.IsNullOrWhiteSpace(DiagnosisTb.Text) ||
                    string.IsNullOrWhiteSpace(MedicinesTb.Text)
                    )
                {
                    MessageBox.Show("Please fill in all boxes!");
                }
                else
                {
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                    MessageBox.Show("Diagnosis Successfully Added");
                }
            }
        }

        private void PatientIdTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchPatientName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DiagIdTb.Text))
            {
                MessageBox.Show("Please fill in the ID to remove!");
            }
            else
            {

                string query = "delete from DiagnosisTbl where DiagId=@DiagId";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@DiagId", DiagIdTb.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                    MessageBox.Show("Diagnosis deleted!");

                }

            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

             DiagIdTb.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
             PatientIdTb.Text = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
             PatientNameTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
             SymptomsTb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
             DiagnosisTb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
             MedicinesTb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
           

        }
    }
}
