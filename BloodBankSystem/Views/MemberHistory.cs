using BloodBankSystem.Controllers;
using BloodBankSystem.Models;
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
    public partial class MemberHistory : Form
    {
        Member mem;
        public MemberHistory()
        {
            InitializeComponent();
        }
        public MemberHistory(dynamic member)
        {
            InitializeComponent();
            this.mem = member;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember f1 = new RegisteredMember(mem);
            f1.Show();
        }

        private void MemberHistoryFromCLosinfEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AmountPaidButtonClick(object sender, EventArgs e)
        {
            dataGridViewHistory.DataSource = null;
            var result = RequestController.GetMemberBalance(mem.Username);
            labelBalance.Text = result.ToString()+" BDT";
        }

        private void RequestHIstoryButtonClick(object sender, EventArgs e)
        {
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var request = RequestController.GetAllMemberRequest(mem.Username);
            dataGridViewHistory.DataSource = request;
        }

        private void buttonDonor_Click(object sender, EventArgs e)
        {
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var donor = BloodDonorController.GetAllDonateHistory(mem.Username);
            dataGridViewHistory.DataSource = donor;
        }
    }
}
