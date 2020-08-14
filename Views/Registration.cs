﻿using BloodBankSystem.Controllers;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem.Views
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

      



        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           this.Hide();
           Login f1 = new Login();
           f1.Show();
        }

        private void RadioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ResisterButtonClicked(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxRepass.Text)
            {
                string errors = "";
                errors += textBoxName.Text.Length == 0 ? "Please Provide Name": "";
                errors += textBoxPassword.Text.Length == 0 ? "\nPlease Provide Password" : "";
                errors += textBoxRepass.Text.Length == 0 ? "\nPlease provide Retype password" : "";
                errors += pictureBoxProfilePicture == null ? "\nPlease upload profile picture" : "";
                errors += textBoxUsername.Text.Length == 0 ? "\nPlease Provide User Name" : "";
                errors += textBoxAddress.Text.Length == 0 ? "\nPlease Provide Address" : "";
                errors += textBoxEmail.Text.Length == 0 ? "\nPlease Provide Gmail" : "";
                errors += comboBoxBloodGroup.Text == null ? "\nPlease Provide Blood Group":"";
                if (!radioButtonFemale.Checked && !radioButtonMale.Checked)
                    errors += "\nPlease Provide Gender";
                errors += (textBoxMobileNumber.Text.Length == 0 || textBoxMobileNumber.Text.Length != 11) ? "\nPlease Provide a Valid Mobile Number" : "";
                errors += textBoxProfession.Text.Length == 0 ? "\n Please Provide Profession" : "";

            if (errors.Length != 0)
                {
                    MessageBox.Show(errors, "Filled the flowing!");
                    return;
                }
                else
                {
                    string gend = radioButtonFemale.Checked ? "Female" : "Male";
                    Console.WriteLine(gend);

                    byte[] img = null;
                    string imgLoc = pictureBoxProfilePicture.ImageLocation;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    var res = ResisterController.ResisterMember(textBoxName.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxBloodGroup.Text, dateTimePickerDob.Value, textBoxMobileNumber.Text, textBoxProfession.Text, gend, textBoxEmail.Text, textBoxAddress.Text, img);
                    if (!res)
                    {

                    }
                    else
                    {
                        this.Hide();
                        Login f1 = new Login();
                        f1.Show();

                    }
                }
            }
            else
            {
                MessageBox.Show("Password and Re-enter password must be same!", "Allert");
            }//string name,string username,string pass,string blgrp,string dob,string mobnum,string prof,string gen,string mail,string add,Image pic
        }

        private void UploadButtonClicked(object sender, EventArgs e)
        {
            //upload
            String strFilePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               strFilePath = ofd.FileName.ToString();
               pictureBoxProfilePicture.ImageLocation = strFilePath;

            }
          
            
            
            
            
            
            //retrive
            ///



            //string query = "Select Profile_Picture from Members ";

            //SqlConnection conn = new SqlConnection("Server=desktop-5v4h2f1\\sqlexpress;Database=Blood_Bank_Management;User Id=sa;Password=123456;");
            //conn.Open();

            //byte[] img = null;
           
            //SqlCommand cmd = new SqlCommand(query, conn);
           
            //SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read();
            //if(reader.HasRows)
            //{
            //    img = (byte[])(reader[0]);
                       
                     
            //    MemoryStream ms = new MemoryStream(img);
            //   pictureBoxProfilePicture.Image = Image.FromStream(ms);
            //}
            //else
            //{

            //}
            //conn.Close();

        }
    }
}
