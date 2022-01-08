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

        private void Login_Form_Load(object sender, EventArgs e)
        {

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
            // Use input string to calculate MD5 hash
            string hashedPass;
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
                hashedPass = sb.ToString();
            }
            string fetchedPassword = controllerObj.GetUserPassword(username_textbox.Text);

            if (fetchedPassword != hashedPass)
            {
                MessageBox.Show("Invalid password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string userType = controllerObj.GetUserType(username_textbox.Text);
            if (userType == "Manager")
            {
                Manager.Manager_Form f = new Manager.Manager_Form();
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
            //id = logcontroller.getCustID(loginemail.Text).ToString();
            //name = logcontroller.getCustname(loginemail.Text);
            //email = loginemail.Text;




            //int r = loginCtrl.checkuser(loginemail.Text);
            //if (r == 0)
            //    MessageBox.Show("you're not a user yet sign up now for free !");

            //else
            //{
            //    string x = logcontroller.getpassword(loginemail.Text);
            //    if (x != loginpassword.Text)
            //        MessageBox.Show("Your Password is Incorrect");
            //    else
            //    {
            //        usertype = logcontroller.getusertype(loginemail.Text);
            //        if (usertype == "Publisher")
            //        {
            //            id = logcontroller.getpubID(loginemail.Text).ToString();
            //            name = logcontroller.getpubname(loginemail.Text);
            //            email = loginemail.Text;

            //            PublisherForm f = new PublisherForm(id, name, email);//for admin
            //            f.Show();
            //            this.Hide();
            //        }
            //        else if (usertype == "Admin" || usertype == "Manager" || usertype == "Employee")
            //        {
            //            id = logcontroller.getEmpID(loginemail.Text).ToString();
            //            name = logcontroller.getEmpname(loginemail.Text);
            //            email = loginemail.Text;
            //            Empolyee f = new Empolyee(email, id, name, usertype);
            //            f.Show();
            //            this.Hide();
            //        }
            //        else if (usertype == "Customer")
            //        {
            //            id = logcontroller.getCustID(loginemail.Text).ToString();
            //            name = logcontroller.getCustname(loginemail.Text);
            //            email = loginemail.Text;
            //            CustomerForm f = new CustomerForm(email, id, name);
            //            f.Show();
            //            this.Hide();
            //        }

            //    }
            //}
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
    }
}
// Hashing trial
/*byte[] salt;
new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

var pbkdf2 = new Rfc2898DeriveBytes(password_textbox.Text, salt, 100000);
byte[] hash = pbkdf2.GetBytes(20);

byte[] hashBytes = new byte[36];
Array.Copy(salt, 0, hashBytes, 0, 16);
Array.Copy(hash, 0, hashBytes, 16, 20);

string savedPasswordHash = Convert.ToBase64String(hashBytes);

MessageBox.Show(savedPasswordHash);


*//* Extract the bytes *//*
byte[] hashBytes2 = Convert.FromBase64String(savedPasswordHash);
*//* Get the salt *//*
byte[] salt2 = new byte[16];
Array.Copy(hashBytes2, 0, salt2, 0, 16);
*//* Compute the hash on the password the user entered *//*
var pbkdf22 = new Rfc2898DeriveBytes(password_textbox.Text, salt2, 100000);
byte[] hash2 = pbkdf2.GetBytes(20);
*//* Compare the results *//*
bool checker = false;
for (int i = 0; i < 20; i++)
    if (hashBytes2[i + 16] != hash2[i])
    {
        checker = true;
        throw new UnauthorizedAccessException();
    }
if (checker)
{
    MessageBox.Show("Error");
}
else
{
    MessageBox.Show("No Error");
}*/