using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Compound_DB.Compound_Staff
{
    public partial class Staff_Form : Form
    {
        string username;
        int staffId;
        string staffName;
        int departmentId;
        string deparmentName;
        public Staff_Form(int id, string inputStaffName,string inputUsername, int deptId, string deptName)
        {
            departmentId = deptId;
            deparmentName = deptName;
            username = inputUsername;
            staffName = inputStaffName;
            staffId = id;
            InitializeComponent();
        }
        private void Staff_Form_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = staffName;
            deptLabel.Text = deparmentName;
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Login.Login_Form form = new Login.Login_Form();
            form.Show();
            this.Hide();
        }

        
    }
}
