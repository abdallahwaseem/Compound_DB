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

namespace Compound_DB.Login
{
    public partial class Login_Form : Form
    {
        // Place holders for text box
        //Textbox myTxtbx = new Textbox();
        //myTxtbx.Text = "Enter text here...";
        //email_textbox.GotFocus += GotFocus.EventHandle(RemoveText);
        ////email_textBox.GotFocus += GotFocus.EventHandle(RemoveText);
        //myTxtbx.LostFocus += LostFocus.EventHandle(AddText);

        //public void RemoveText(object sender, EventArgs e)
        //{
        //    if (email_textbox.Text == "Enter text here...")
        //    {
        //        email_textbox.Text = "";
        //    }
        //}

        //public void AddText(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(myTxtbx.Text))
        //        myTxtbx.Text = "Enter text here...";
        //}

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

        Login_Controller loginCtrl;
        public Login_Form()
        {
            InitializeComponent();
            loginCtrl = new Login_Controller();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (email_textbox.Text == "" || email_textbox.Text == "")//validation part
            {
                MessageBox.Show("Please enter email and password.");
            }

            else
            {
                //id = logcontroller.getCustID(loginemail.Text).ToString();
                //name = logcontroller.getCustname(loginemail.Text);
                //email = loginemail.Text;
                int id = 1;
                string email = "a@rew.com";
                string name = "Abdallah";
                Resident.Resident_Form f = new Resident.Resident_Form(id, email, name);
                f.Show();
                this.Hide();

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
        }
    }
}
