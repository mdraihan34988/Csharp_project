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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void BloodRequest_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BloodRequest bq = new BloodRequest();
            bq.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BloodDonate bd =new BloodDonate();
            bd.Show();
        }
    }
}
