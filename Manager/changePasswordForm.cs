using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_DB.Manager
{
    public partial class changePasswordForm : Form
    {
        Login.Login_Controller controllerObj;
        int managerId = 0;
        string mgruserName = "";
        string managerName = "";
        public changePasswordForm(int mgr_ID,string mgr_Name,string username)
        {
            InitializeComponent();
            controllerObj = new Login.Login_Controller();
            managerId = mgr_ID;
            managerName = mgr_Name;
            mgruserName = username;
        }
        private string hashingPass(string inputString)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(inputString);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void updatePass_btn_Click(object sender, EventArgs e)
        {
            if (currentPassTextBox.Text == "" || newPassTextBox.Text == "" || confirmPassTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields first.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string currentHashedPass = hashingPass(currentPassTextBox.Text);
            string fetchedPassword = controllerObj.GetUserPassword(mgruserName);
            if (currentHashedPass != fetchedPassword)
            {
                MessageBox.Show("Incorrect password.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPassTextBox.Text != confirmPassTextBox.Text)
            {
                MessageBox.Show("Confirm password does not match.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string passwordToBeSet = hashingPass(newPassTextBox.Text);
            int result = controllerObj.ChangePassword(mgruserName, passwordToBeSet);
            if (result == 0)
            {
                MessageBox.Show("Failed to changed password. Please check with your manger.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Password changed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            managerSettingsForm form = new managerSettingsForm(managerId, managerName,mgruserName);
            form.Show();
            this.Hide();
        }
    }
}
