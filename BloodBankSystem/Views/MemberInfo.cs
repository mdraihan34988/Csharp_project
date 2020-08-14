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
    public partial class MemberInfo : Form
    {
        public MemberInfo()
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

        private void MemberInfoFromClosingEventClick(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MemberInfoLoad(object sender, EventArgs e)
        {
            var member = ResisterController.GetAllMember();
            dataGridViewMember.DataSource = member;
        }
    }
}
