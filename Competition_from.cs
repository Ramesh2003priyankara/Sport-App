using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;

namespace KickBlast
{
    public partial class Competition_from : Form
    {
        int Entry, Competition,Tot;

        public Competition_from()
        {
            InitializeComponent();
        }
        String Username;
        public Competition_from(String S)
        {
            InitializeComponent();
           
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAthleteRegno.Clear();
            txtCompetition.Clear();
            lblTotal.Text = string.Empty;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_From H = new Home_From(Username);
            H.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Competition_from_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_sepriyankara_KickblastDataSet6.AthletesDetails' table. You can move, or remove it, as needed.
            this.athletesDetailsTableAdapter2.Fill(this._sepriyankara_KickblastDataSet6.AthletesDetails);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Entry = 220;
          Competition= int.Parse(txtCompetition.Text);

            Tot = Entry * Competition;

           lblTotal.Text = Tot.ToString();
        }
    }
    
}
