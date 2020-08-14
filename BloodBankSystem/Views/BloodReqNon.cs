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
    public partial class BloodReqNon : Form
    {
        public BloodReqNon()
        {
            InitializeComponent();
        }

        private void BloodReqNon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     
      
       

        

      
       
      

        private void RequestButtonClick(object sender, EventArgs e)
        {
            string user = textBoxUsrname.Text;
            string reqtype;
            int quantity = Int32.Parse(textBoxQuantity.Text);
            string membertype = textBoxMemberStatus.Text;
            string bloodgroup = comboBoxBloodGroup.SelectedItem.ToString();
            var result = BloodStockController.CheckRequest( bloodgroup, quantity);
            if (result != 0)
            {
                reqtype = "Accepted";
                MessageBox.Show("Request Accepted. \n"+"Your service charge is : "+quantity*100, "Success");
            }
            else
            {
                reqtype = "Rejected";
                MessageBox.Show("Request Rejected", "Failed");
            }
             RequestController.InsertRequest(user, membertype, reqtype, bloodgroup, quantity);
            buttonBack.PerformClick();
                

        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }
    }
}
