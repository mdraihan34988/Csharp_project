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
    public partial class BloodReqNon : Form
    {
        public BloodReqNon()
        {
            InitializeComponent();
        }

        private void BloodReqNon_FormClosing(object sender, FormClosingEventArgs e)
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
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void BloodReqNon_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

      
        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = System.DateTime.Today;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
