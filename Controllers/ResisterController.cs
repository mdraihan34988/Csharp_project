using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankSystem.Models;

namespace BloodBankSystem.Controllers
{
    public class ResisterController
    {
        static Database db = new Database();

        public static bool ResisterMember(string name,string username,string pass,string blgrp,DateTime dob,string mobnum,string prof,string gen,string mail,string add,byte[] a)
        {
            Member m = new Member();
            m.Name = name;
            m.Username = username;
            m.Password = pass;
            m.Blood_Group = blgrp;
            m.Date_Of_Birth = dob;
            m.Mobile_Number = mobnum;
            m.Profession = prof;
            m.Gender = gen;
            m.Gmail = mail;
            m.Address = add;
            m.Profile_Picture =a;
            return db.Members.ResisterMember(m);
        }
    }
}
