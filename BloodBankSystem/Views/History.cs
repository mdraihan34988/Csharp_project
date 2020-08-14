using BloodBankSystem.Controllers;
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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h1 = new HomePage();
            h1.Show();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void HistoryFromClosingEventClick(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDonor_Click(object sender, EventArgs e)
        {
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var donor = BloodDonorController.GetAllDonor();
            dataGridViewHistory.DataSource = donor;
            
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var request = RequestController.GetAllRequest();
            dataGridViewHistory.DataSource = request;
        }

        private void BalanceButtonClick(object sender, EventArgs e)
        {
            dataGridViewHistory.DataSource = null;
            var result = RequestController.GetBalance();
            labelBalance.Text = result.ToString()+" BDT";
           
        }
    }
}
