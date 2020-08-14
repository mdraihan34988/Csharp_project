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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void BloodStoke_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            Admin h1 = new Admin();
            h1.Show();
        }
    }
}
