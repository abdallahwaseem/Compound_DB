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
    public partial class managerSettingsForm : Form
    {
        Manager_Controller controllerObj;
        string username;
        int managerId;
        string managerName;

        public managerSettingsForm(int id,string name,string mgr_uname)
        {
            InitializeComponent();
            managerId = id;
            managerName = name;
            username = mgr_uname;
            controllerObj = new Manager_Controller();
        }

        private void managerSettingsForm_Load(object sender, EventArgs e)
        {
            name_textbox.Text = managerName;
            username_textbox.Text = username;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Manager.changePasswordForm f = new changePasswordForm(managerId, managerName, username);
            f.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Manager.Manager_Form f = new Manager.Manager_Form(managerId, managerName, username);
            f.Show();
            this.Hide();
        }
    }
}
