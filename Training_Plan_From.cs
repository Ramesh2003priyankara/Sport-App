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
    public partial class Training_Plan_From : Form
    {
     
        public Training_Plan_From()
        {
            InitializeComponent();
        }
        String Username;


        private void Training_Plan_From_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_sepriyankara_KickblastDataSet5.AthletesDetails' table. You can move, or remove it, as needed.
            this.athletesDetailsTableAdapter1.Fill(this._sepriyankara_KickblastDataSet5.AthletesDetails);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight, Cost, hr,nh;
            hr = 90.50;
            string Category;
            int week = 0;
            int Month = 0;



            weight = Double.Parse(txtweight.Text);

            //category
            if (weight >= 66 && weight <= 72)
            {
                Category  ="Beginner";
            }
            else if (weight >= 73 && weight <= 90)
            {
                Category = "Intermediate";
            }
            else if (weight >= 91)
            {
               Category= "Elite";
            }
            else
            {
                Category= "Weight category not defined";
            }
            lblCategory.Text = Category.ToString();

            //weekly fee
            if (weight >= 66 && weight <= 72)
            {
                week = 250;
                Month = 1000;
            }
            else if (weight >= 73 && weight <= 90)
            {
                week = 300;
                Month = 1200;
            }
            else if (weight >= 91)
            {
               week = 350;
               Month= 1400;
            }

            else
            {
                MessageBox.Show("Invalid week fee");
            }
            lblWeeklyfee.Text = week.ToString();
            lblMonthlyfee.Text=Month.ToString();
            
            
            //calculate Private hour
            nh = double.Parse(txtNumberofhour.Text);
            Cost = hr * nh;
           lblFeecost.Text=Cost.ToString();

        }
      




        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRegno.Clear();
            txtweight.Clear();
            txtNumberofhour.Clear();
            lblCategory.Text =string.Empty;
            lblWeeklyfee.Text=string.Empty;
            lblMonthlyfee.Text=string.Empty ;
            lblFeecost.Text = string.Empty ;
           
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_From H = new Home_From(Username);
            H.Show();
        }
    }
}
