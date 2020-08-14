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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h1 = new HomePage();
            h1.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodBank h1 = new BloodBank();
            h1.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
