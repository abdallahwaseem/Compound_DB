using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Compound_DB.Login
{
    public partial class Login_Form : Form
    {
        // Make the form round
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        Login_Controller controllerObj;
        public Login_Form()
        {
            InitializeComponent();
            controllerObj = new Login_Controller();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text == "" || username_textbox.Text == "")
            {
                MessageBox.Show("Please enter username and password.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userCount = controllerObj.CheckUserInDB(username_textbox.Text);
            if (userCount == 0)
            {
                MessageBox.Show("Invalid username", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPass = "";
            hashedPass = hashingPass();
            string fetchedPassword = controllerObj.GetUserPassword(username_textbox.Text);

            if (fetchedPassword != hashedPass)
            {
                MessageBox.Show("Invalid password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string userType = controllerObj.GetUserType(username_textbox.Text);
            if (userType == "Manager")
            {
                string managerName = controllerObj.GetManagerName(username_textbox.Text);
                int managerId = controllerObj.GetManagerId(username_textbox.Text);


                Manager.Manager_Form f = new Manager.Manager_Form(managerId, managerName);
                f.Show();
                this.Hide();
            }
            else if (userType == "Resident")
            {
                int id = 1;
                string username = "a@rew.com";
                string name = "Abdallah";
                Resident.Resident_Form f = new Resident.Resident_Form(id, username, name);
                f.Show();
                this.Hide();
            }
            else if (userType == "Staff")
            {
                string staffName = controllerObj.GetStaffName(username_textbox.Text);
                int staffId = controllerObj.GetStaffId(username_textbox.Text);
                int staffDeptId = controllerObj.GetStaffDeptId(username_textbox.Text);
                string staffDeptName = controllerObj.GetStaffDeptName(staffDeptId);

                Compound_Staff.Staff_Form f = new Compound_Staff.Staff_Form(staffId, staffName, username_textbox.Text, staffDeptId, staffDeptName);
                f.Show();
                this.Hide();
            }
            username_textbox.Clear();
            password_textbox.Clear();
        }

        private void clearFieldLabel_Click(object sender, EventArgs e)
        {
            username_textbox.Text = "";
            password_textbox.Text = "";
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }

        private string hashingPass()
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password_textbox.Text);
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
    }
}