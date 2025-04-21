using Bank_Buisness;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SystemBank
{
    public class ClsGlobale
    {
        public static clsUsers CurrentUser = clsUsers.FindUserByUserNameAndPassword("","");

       

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

               
                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                string dataToSave = Username + "#//#" + Password;

                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath = currentDirectory + "\\data.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        

        public delegate void MyDelegate(int Permissions);
        //       public event MyDelegate D1;


        //       int Permissions { set; get; }
        //       bool Efect = true;


        //       void _Start(int Permissions)
        //       {
        //           if (Permissions != 0)
        //           {
        //               Efect = false;
        //           }
        //           if ((checkBox1.Checked = (Permissions == -1) ? true : false) == false)
        //           {
        //               checkBox11.Checked = ((Permissions & (int)clsCurrentUser.enPermissions.ShowAdminIfo) > 0) ? true : false;
        //               checkBox10.Checked = ((Permissions & 2) > 0) ? true : false;
        //               checkBox12.Checked = ((Permissions & 4) > 0) ? true : false;
        //               checkBox3.Checked = ((Permissions & 8) > 0) ? true : false;
        //               checkBox2.Checked = ((Permissions & 16) > 0) ? true : false;
        //               checkBox13.Checked = ((Permissions & 32) > 0) ? true : false;
        //               checkBox18.Checked = ((Permissions & 64) > 0) ? true : false;
        //               checkBox9.Checked = ((Permissions & 128) > 0) ? true : false;
        //               checkBox4.Checked = ((Permissions & 256) > 0) ? true : false;
        //               checkBox14.Checked = ((Permissions & 512) > 0) ? true : false;
        //               checkBox6.Checked = ((Permissions & 1024) > 0) ? true : false;
        //               checkBox5.Checked = ((Permissions & 2048) > 0) ? true : false;
        //               checkBox16.Checked = ((Permissions & 4096) > 0) ? true : false;
        //               checkBox17.Checked = ((Permissions & 8192) > 0) ? true : false;
        //               checkBox15.Checked = ((Permissions & 16384) > 0) ? true : false;
        //               checkBox7.Checked = ((Permissions & 32768) > 0) ? true : false;
        //           }
        //           Efect = true;
        //       }

        //       private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        //       {

        //       }

        //       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //       {

        //           Permissions = (checkBox1.Checked) ? -1 : 0;
        //           Efect = false;
        //           Settings();
        //           _Start(Permissions);
        //       }

        //       private void checkBox11_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox11.Checked) ? 1 : -1;
        //       }

        //       private void checkBox9_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox9.Checked) ? 128 : -128;
        //       }

        //       private void checkBox18_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox18.Checked) ? 64 : -64;
        //       }

        //       private void checkBox17_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox17.Checked) ? 8192 : -2;
        //       }

        //       private void checkBox16_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox16.Checked) ? 4096 : -4096;
        //       }

        //       private void checkBox15_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox15.Checked) ? 16384 : -16384;
        //       }

        //       private void checkBox14_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox14.Checked) ? 512 : -512;
        //       }

        //       private void checkBox13_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox13.Checked) ? 32 : -32;
        //       }

        //       private void checkBox12_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)

        //               Permissions += (checkBox12.Checked) ? 4 : -4;
        //       }

        //       private void checkBox10_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox10.Checked) ? 2 : -2;
        //       }

        //       private void checkBox6_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox6.Checked) ? 1024 : -1024;
        //       }

        //       private void checkBox5_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox5.Checked) ? 2048 : -2048;
        //       }



        //       private void checkBox3_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox3.Checked) ? 8 : -8;
        //       }

        //       private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox2.Checked) ? 16 : -16;
        //       }

        //       private void checkBox7_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox7.Checked) ? 32768 : -32768;
        //       }



        //       /*
        //        checkBox7 
        //        checkBox15
        //        checkBox11
        //        checkBox10
        //        checkBox12
        //        checkBox3 
        //        checkBox2 
        //        checkBox13
        //        checkBox18
        //        checkBox9 
        //        checkBox4 
        //        checkBox14
        //        checkBox6 
        //        checkBox5 
        //        checkBox16
        //        checkBox17
        //       */
        //       void Settings()
        //       {
        //           if (checkBox1.Checked)
        //           {
        //               Checked

        //checkBox7.Checked = false;
        //               checkBox15.Checked = false;
        //               checkBox11.Checked = false;
        //               checkBox10.Checked = false;
        //               checkBox12.Checked = false;
        //               checkBox3.Checked = false;
        //               checkBox2.Checked = false;
        //               checkBox13.Checked = false;
        //               checkBox18.Checked = false;
        //               checkBox9.Checked = false;
        //               checkBox4.Checked = false;
        //               checkBox14.Checked = false;
        //               checkBox6.Checked = false;
        //               checkBox5.Checked = false;
        //               checkBox16.Checked = false;
        //               checkBox17.Checked = false;

        //               Enabled

        //checkBox7.Enabled = false;
        //               checkBox15.Enabled = false;
        //               checkBox11.Enabled = false;
        //               checkBox10.Enabled = false;
        //               checkBox12.Enabled = false;
        //               checkBox3.Enabled = false;
        //               checkBox2.Enabled = false;
        //               checkBox13.Enabled = false;
        //               checkBox18.Enabled = false;
        //               checkBox9.Enabled = false;
        //               checkBox4.Enabled = false;
        //               checkBox14.Enabled = false;
        //               checkBox6.Enabled = false;
        //               checkBox5.Enabled = false;
        //               checkBox16.Enabled = false;
        //               checkBox17.Enabled = false;
        //           }
        //           else
        //           {
        //               checkBox7.Enabled = true;
        //               checkBox15.Enabled = true;
        //               checkBox11.Enabled = true;
        //               checkBox10.Enabled = true;
        //               checkBox12.Enabled = true;
        //               checkBox3.Enabled = true;
        //               checkBox2.Enabled = true;
        //               checkBox13.Enabled = true;
        //               checkBox18.Enabled = true;
        //               checkBox9.Enabled = true;
        //               checkBox4.Enabled = true;
        //               checkBox14.Enabled = true;
        //               checkBox6.Enabled = true;
        //               checkBox5.Enabled = true;
        //               checkBox16.Enabled = true;
        //               checkBox17.Enabled = true;
        //           }
        //       }

        //       private void checkBox4_CheckedChanged(object sender, EventArgs e)
        //       {
        //           if (Efect == true)
        //               Permissions += (checkBox4.Checked) ? 256 : -256;
        //       }

        //       private void button1_Click(object sender, EventArgs

        //      e)
        //       {
        //           MessageBox.Show("Permissions = " + Permissions.ToString());
        //       }

        //       private void button1_Click_1(object sender, EventArgs e)
        //       {
        //           this.Close();
        //       }
        //       private void btnOK_Click(object sender, EventArgs e)
        //       {
        //           D1.Invoke(Permissions);
        //           this.Close();
        //       }

        //       private void frmPermissions_Load(object sender, EventArgs e)
        //       {

        //       }

    }
}
