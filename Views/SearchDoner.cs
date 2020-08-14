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
    public partial class SearchDoner : Form
    {
        public SearchDoner()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchDoner_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
