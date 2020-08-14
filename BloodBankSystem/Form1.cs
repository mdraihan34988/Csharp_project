using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_eclips1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            
            Login l1=new Login();
            l1.Show();
       
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SearchDoner s1 = new SearchDoner();
            s1.Show();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            BloodBank b1 = new BloodBank();
            b1.Show();
        }
    }
}
