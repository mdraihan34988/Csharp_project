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
    public partial class BloodRequest : Form
    {
        Member mem;
        public BloodRequest()
        {
            InitializeComponent();
        }
        public BloodRequest(dynamic member)
        {
            InitializeComponent();
            this.mem = member;


        }



        private void BloodRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember f1 = new RegisteredMember(mem);
            f1.Show();
        }

        private void RequestButtonClick(object sender, EventArgs e)
        {
            string username = mem.Username;
            string memtype = "Registered";
            int quantity = Int32.Parse(textBoxQuantity.Text);
            string reqtype;
            string bloodgroup = comboBoxBloodGroup.SelectedItem.ToString();
            var result = BloodStockController.CheckRequest(bloodgroup, quantity);
            if (result != 0)
            {
                reqtype = "Accepted";
                MessageBox.Show("Request Accepted \n" + "Your service charge is : " + quantity * 50, "Success");
                comboBoxBloodGroup.Text = null;
                textBoxQuantity.Text = null;
            }
            else
            {
                reqtype = "Rejected";
                MessageBox.Show("Request Rejected", "Failed");
                textBoxQuantity.Text = null;
            }
            RequestController.InsertRequest(username, memtype, reqtype, bloodgroup, quantity);
            
        }
    }
}
