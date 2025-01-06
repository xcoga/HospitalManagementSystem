using System.Data.SqlClient;
using System.IO;

namespace HospitalManagement_Tutorial
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Xcoga\OneDrive\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_input_textbox.Text) ||
                string.IsNullOrWhiteSpace(password_input_textbox.Text))
            {
                MessageBox.Show("Fill in username or password!");
                return; // Exit the function if fields are empty
            }

            string query = "SELECT COUNT(*) FROM DoctorTbl WHERE DocName = @DocName AND DocPass = @DocPass";

            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@DocName", username_input_textbox.Text);
                cmd.Parameters.AddWithValue("@DocPass", password_input_textbox.Text);

                try
                {
                    Con.Open();
                    int userCount = (int)cmd.ExecuteScalar(); // Check if user exists

                    if (userCount > 0)
                    {
                        //User exists, navigate to home
                        Home H = new Home();
                        H.Show();
                        this.Hide();
                    }
                    else
                    {
                        //User does not exist, show an error message
                        MessageBox.Show("Invalid username or password!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    Con.Close(); // Ensure the connection is closed
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            username_input_textbox.Text = string.Empty;
            password_input_textbox.Text= string.Empty;
        }
    }
}