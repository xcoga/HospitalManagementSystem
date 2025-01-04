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
using System.Collections;

namespace HospitalManagement_Tutorial
{
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Xcoga\OneDrive\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
        public DoctorForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);  // Fill the DataTable with data

            DoctorGV.DataSource = dt;  // Assign DataTable to DataGridView
            Con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "Update DoctorTbl set DocName=@DocName, DocExp=@DocExp, DocPass=@DocPass where Docid=@DocID";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@DocID", DocID.Text);
                cmd.Parameters.AddWithValue("@DocName", DocName.Text);
                cmd.Parameters.AddWithValue("@DocExp", DocExperience.Text);
                cmd.Parameters.AddWithValue("@DocPass", DocPass.Text);
                if (DocID.Text == "" || DocName.Text == "" || DocExperience.Text == "" || DocPass.Text == "")
                {
                    MessageBox.Show("Please fill in all boxes!");
                }
                else
                {
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                    MessageBox.Show("Doctor Successfully Updated");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocID.Text == "")
            {
                MessageBox.Show("Please fill in the ID to remove!");
            }
            else
            {

                string query = "delete from DoctorTbl where Docid=@DocID";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@DocID", DocID.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                    MessageBox.Show("Doctor deleted!");

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO DoctorTbl (Docid, DocName, DocExp, DocPass) VALUES (@DocID, @DocName, @DocExp, @DocPass)";


            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@DocID", DocID.Text);
                cmd.Parameters.AddWithValue("@DocName", DocName.Text);
                cmd.Parameters.AddWithValue("@DocExp", DocExperience.Text);
                cmd.Parameters.AddWithValue("@DocPass", DocPass.Text);

                if (DocID.Text == "" || DocName.Text == "" || DocExperience.Text == "" || DocPass.Text == "")
                {
                    MessageBox.Show("Please fill in all boxes!");
                }
                else
                {
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                    MessageBox.Show("Doctor Successfully Added");
                }

            }

        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                DocID.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
                DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
                DocExperience.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
                DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
            

        }
    }
}
