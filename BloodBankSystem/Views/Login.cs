using BloodBankSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      

     


       

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     
        private void LoginButtonClicked(object sender, EventArgs e)
        {
            var res = LoginController.ValidateMember(textBoxUser.Text, textBoxPass.Text);
            if(res!=  null)
            {
                this.Hide();
               new RegisteredMember(res).Show();

            }
            else
            {
                MessageBox.Show("Invalid User Name or Password", "Alert");
            }

            



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

        private void NewAccountLinkLabelClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration r1 = new Registration();
            r1.Show();
        }

        

        private void PasswordChangeClickEvent(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PasswordRecover a = new PasswordRecover();
            a.Show();
        }
    }
}
