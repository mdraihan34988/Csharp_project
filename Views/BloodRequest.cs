using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem.Views
{
    public partial class BloodRequest : Form
    {
        public BloodRequest()
        {
            InitializeComponent();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BloodRequest_Load(object sender, EventArgs e)
        {

        }

        private void BloodRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember f1 = new RegisteredMember();
            f1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = System.DateTime.Today;
        }

      
    }
}
