using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Models
{
    public class Member
    {
        public string Name { get; set; }
        public int Id{ get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public string Blood_Group { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Gender { get; set; }
        public string Mobile_Number { get; set; }
        public string  Address { get; set; }
        public string Gmail { get; set; }
        public string Profession { get; set; }
        public byte[] Profile_Picture { get; set; }


    }
}
