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

namespace KickBlast
{
    public partial class Search_Deails : Form
    {
        private string connectionString = "Data Source=SEPRIYANKARA;Initial Catalog=sepriyankara.Kickblast;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Search_Deails()
        {
            InitializeComponent();
        }
        String Username;
        public Search_Deails(String s)
        {
            InitializeComponent();
        }

        private void Search_Deails_Load(object sender, EventArgs e)
        {
           

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            string searchTerm = txtSearch.Text.Trim();

            
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    
                    string query = "SELECT * FROM AthletesDetails WHERE AthleteRegno LIKE @SearchTerm";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                      
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                          
                            dataGridViewSearch.DataSource = dataTable;

                          
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No athletes found matching the search term.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
            }
            catch (Exception ex) 
            { 
            }
}

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           Home_From HF = new Home_From(Username);
            HF.Show();
        }
    }
}

