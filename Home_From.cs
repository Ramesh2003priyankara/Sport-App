using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KickBlast
{
    public partial class Home_From : Form
    {

 
    

        String Username;
        public Home_From(String s)
        {
            InitializeComponent();
            Username = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Athlete_From A = new Athlete_From(Username);
            A.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Home_From H = new Home_From(Username);
            H.Show();
        }

        private void btnCoachRegistration_Click(object sender, EventArgs e)
        {

            Coach_Register_From CR = new Coach_Register_From(Username);
            CR.Show();
           

               
            }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_Plan_From TR=new Training_Plan_From();
            TR.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            LoginForm LF = new LoginForm();
            LF.Show();
        }

        private void Home_From_Load(object sender, EventArgs e)
        {

        }

        private void btnCompetitionFee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Competition_from co =new Competition_from();
            co.Show();
        }

        private void btnSearchDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Deails SD = new Search_Deails();
            SD.Show();
        }
    }
}
