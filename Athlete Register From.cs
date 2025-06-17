using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KickBlast
{
    public partial class Athlete_From : Form
    {
        // Connection string - replace with your actual database connection
        private string connectionString = "Data Source=SEPRIYANKARA;Initial Catalog=sepriyankara.Kickblast;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        private void LoadData()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                dataTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM AthletesDetails", connection);

                // Fill the DataGridView
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        public Athlete_From()
        {
            InitializeComponent();
            LoadData();
        }
        String Username;
        public Athlete_From(String s)
        {
            InitializeComponent();
            LoadData();
            Username = s;
        }

        private void Athlete_From_Load(object sender, EventArgs e)
        {
            if (Username == "Guest")
            {
                btnDelete.Hide();
                btnUpdate.Hide();
            }
          


        }

        private void lblEmailAddress_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblContactno_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void lblDob_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblRegno_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO AthletesDetails(AthleteRegno, Name, Dob, Age, Gender, EmailAddress, Contactno) " +
                                                     "VALUES (@AthleteRegno, @Name, @Dob, @Age, @Gender, @EmailAddress, @Contactno)", connection);


                cmd.Parameters.AddWithValue("@AthleteRegno", numericUpDownRegno.Value);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Dob", dtpDob.Value);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Gender", radioButtonMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text);
                cmd.Parameters.AddWithValue("@Contactno", txtContactno.Text);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Athlete registered successfully!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering athlete: " + ex.Message);
                connection.Close();
            }
        }
        
       

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            numericUpDownRegno.Value = 0;
            txtName.Text = "";
            dtpDob.Value = DateTime.Now;
            txtAge.Text = "";
            radioButtonMale.Checked = true;
            txtEmailAddress.Text = "";
            txtContactno.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AthletesDetails SET Name=@Name, Dob=@Dob, Age=@Age, " +
                    "Gender=@Gender, EmailAddress=@Email, ContactNo=@Contact WHERE AthleteRegno=@AthleteRegno", connection);

                cmd.Parameters.AddWithValue("@AthleteRegno", numericUpDownRegno.Value);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Dob", dtpDob.Value);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Gender", radioButtonMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@Email", txtEmailAddress.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContactno.Text);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Athlete information updated!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating athlete: " + ex.Message);
                connection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM AthletesDetails WHERE AthleteRegno = @AthleteRegno", connection);

                cmd.Parameters.AddWithValue("@AthleteRegno", numericUpDownRegno.Value);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Athleted deleted successfully!");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid deleting Athleted ");
                connection.Close();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_From HF= new Home_From(Username);
            HF.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

