using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace BloodBankSystem.Models
{
    public class Members
    {
        SqlConnection conn;
        SqlCommand cmd;
        string query;
        Byte[] ImageByteArray;
        public Members()
        {
             conn = new SqlConnection("Server=desktop-5v4h2f1\\sqlexpress;Database=Blood_Bank_Management;User Id=sa;Password=123456;");
        }

        public bool ResisterMember(Member member)
        {
            int result = 0;
            try
            {
                           
                conn.Open();
                byte[] img = member.Profile_Picture;

                query = "INSERT INTO Members (Username,Name,Password,Blood_Group,Date_Of_Birth,Gender,Profession,Mobile_Number,Gmail,Address,Profile_Picture) " +
                                        "VALUES('" + member.Username + "','" +member.Name+ "','" + member.Password + "','" + member.Blood_Group + "','" + member.Date_Of_Birth +
                                        "','" + member.Gender + "','" + member.Profession + "','" + member.Mobile_Number + "','" + member.Gmail +
                                         "','" + member.Address + "',@img)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                result = cmd.ExecuteNonQuery();
                conn.Close();
                
            }
            catch(Exception)
            {
                MessageBox.Show("User Name Already exists!","Alert");
                conn.Close();
            }
            if (result != 0) return true;
            else return false;
        }
        public Member ValidityMember(string uname,string pass)
        {
            Member member = null;
            try
            {
                conn.Open();
                string query = "SELECT * FROM Members WHERE Username='" + uname + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    member = new Member();

                    member.Name = reader.GetString(reader.GetOrdinal("Name"));
                    member.Profile_Picture = (byte[])(reader[reader.GetOrdinal("Profile_Picture")]);
                    member.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    member.Username = reader.GetString(reader.GetOrdinal("Username"));




                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();
            }


            return member;

        }
    }
}
