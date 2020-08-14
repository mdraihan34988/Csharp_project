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
    public partial class Blood_Stock : Form
    {
        public Blood_Stock()
        {
            InitializeComponent();
        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void BloodStockFromClosingEventClicked(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BloodStockFormLoad(object sender, EventArgs e)
        {
            var bloodstock = BloodStockController.GetAllBloodGroup();
            dataGridViewStock.DataSource = bloodstock;
        }
    }
}
