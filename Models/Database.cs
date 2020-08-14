using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Models
{
    public class Database
    {
        public Members Members { get; set; }

        public Database()
        {
            Members = new Members();
        }
    }
}
