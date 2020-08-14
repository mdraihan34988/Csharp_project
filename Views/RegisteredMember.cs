using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankSystem.Controllers;

namespace BloodBankSystem.Views
{
    public partial class RegisteredMember : Form
    {
        public RegisteredMember()
        {
            InitializeComponent();
        }
        public RegisteredMember(dynamic member)
        {
            InitializeComponent();
           // labelName.Text = member.Name;
            //labelBloodGroup.Text = member.Blood_Group;
           // MemoryStream ms = new MemoryStream(member.Profile_Picture);
            //pictureBoxProfile.Image = Image.FromStream(ms);


        }

        private void BloodRequest_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodRequest bq = new BloodRequest();
            bq.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodDonate bd =new BloodDonate();
            bd.Show();
        }

        private void Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
