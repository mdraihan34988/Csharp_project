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
    public partial class BloodDonate : Form
    {
        public BloodDonate()
        {
            InitializeComponent();
        }

      

       

     

       

        private void BloodDonate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       



        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerLastTimeDonate.Value= System.DateTime.Today;
        }

        private void SubmitButtonClicked(object sender, EventArgs e)
        {

        }

        private void BackButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember f1 = new RegisteredMember();
            f1.Show();
        }

        private void HomeButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }
    }
}
