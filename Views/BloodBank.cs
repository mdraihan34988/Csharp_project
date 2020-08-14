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
    public partial class BloodBank : Form
    {
        public BloodBank()
        {
            InitializeComponent();
        }

        private void BloodBank_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

       

       

       

       

        private void loginButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            Admin a1 = new Admin();
            a1.Show();

        }

        private void HomeButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();

        }

        private void BackButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }
    }
}
