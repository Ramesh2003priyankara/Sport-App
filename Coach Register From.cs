using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KickBlast
{
    public partial class Coach_Register_From : Form
    {
       
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
                adapter = new SqlDataAdapter("SELECT * FROM Coachregtable", connection);

                // Fill the DataGridView
                adapter.Fill(dataTable);
                dataGridViewCoach.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error ");
            }
    }
        String Username;
        public Coach_Register_From(String s)
        {
          

        InitializeComponent();
            LoadData();
            Username = s;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Coachregtable(CoachRegno, Name, Dob, Gender, Age, Emailaddress, Contactno) " +
                                                 "VALUES (@CoachRegno, @Name, @Dob, @Gender, @Age, @Emailaddress, @Contactno)", connection);
                cmd.Parameters.AddWithValue("@CoachRegno", numericUpDownCoachregno.Value);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Dob", dateTimePickerDob.Value);
                cmd.Parameters.AddWithValue("@Gender", radioButtonMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Emailaddress", txtEmailaddress.Text);
                cmd.Parameters.AddWithValue("@Contactno", txtContactno.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Coach registered successfully!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering Coach: " + ex.Message);
            }
           
        }

        private void Coach_Register_From_Load(object sender, EventArgs e)
        {
            if (Username == "Guest")
            {
                btnDelete.Hide();
                btnUpdate.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            numericUpDownCoachregno.Value = 0;
            txtName.Text = "";
            dateTimePickerDob.Value = DateTime.Now;
            txtAge.Text = "";
            radioButtonMale.Checked = true;
            txtEmailaddress.Text = "";
            txtContactno.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Coachregtable SET Name=@Name, Dob=@Dob, Gender=@Gender, " +
                    "Age=@Age, EmailAddress=@Email, ContactNo=@ContactNo  WHERE CoachRegno=@CoachRegno", connection);

                cmd.Parameters.AddWithValue("@CoachRegno", numericUpDownCoachregno.Value);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Dob", dateTimePickerDob.Value);
                cmd.Parameters.AddWithValue("@Gender", radioButtonMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmailaddress.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContactno.Text);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Coach information updated!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating coach: " + ex.Message);
                connection.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Coachregtable WHERE CoachRegno = @CoachRegno", connection);

                cmd.Parameters.AddWithValue("@CoachRegno", numericUpDownCoachregno.Value);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Coach deleted successfully!");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid deleting Coach ");
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_From HF = new Home_From(Username);
            HF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
