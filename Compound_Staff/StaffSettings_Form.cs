using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_DB.Compound_Staff
{
    public partial class StaffSettings_Form : Form
    {
        Staff_Controller controllerObj;
        string username;
        int staffId;
        string staffName;
        int departmentId;
        string departmentName;
        public StaffSettings_Form(int id, string name, string deptName, string staffUsername, int deptId)
        {
            InitializeComponent();
            staffId = id;
            staffName = name;
            departmentName = deptName;
            username = staffUsername;
            departmentId = deptId;

            controllerObj = new Staff_Controller();

        }
        private void StaffSettings_Form_Load(object sender, EventArgs e)
        {
            name_textbox.Text = staffName;
            //dob_textbox.Text = controllerObj.GetStaffDoB(staffId) == null ? "" : controllerObj.GetStaffDoB(staffId);
            phoneNum_textbox.Text = controllerObj.GetStaffPhoneNum(staffId) == null ? "" : controllerObj.GetStaffPhoneNum(staffId);
            double currentSalary = 0;
            DataTable dt = controllerObj.GetSalary(staffId);
            foreach (DataRow row in dt.Rows)
            {
                object item = row[0];
                currentSalary = (double)item;
            }
            salary_textbox.Text = currentSalary.ToString();
            rating_textbox.Text = controllerObj.GetStaffRating(staffId).ToString();
            //gender_textbox.Text = controllerObj.GetStaffGender(staffId).ToString() == null ? "" : controllerObj.GetStaffGender(staffId).ToString();
            deptName_textbox.Text = departmentName;

            username_textbox.Text = username;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Compound_Staff.Staff_Form f = new Compound_Staff.Staff_Form(staffId, staffName, username, departmentId, departmentName);
            f.Show();
            this.Hide();
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            Compound_Staff.ChangePassword_Form f = new ChangePassword_Form();
            f.Show();
            this.Hide();
        }

        
    }
}
