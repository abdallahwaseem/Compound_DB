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
    public partial class staff : UserControl
    {
        Manager_Controller controllerObj;
        public staff()
        {
            InitializeComponent();
            controllerObj = new Manager_Controller();
        }

        private void DeptIDComboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDept_ID();
            DeptIDComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["ID"];
                DeptIDComboBox.Items.Add(item);
            }
        }

        private void insertstaffButton_Click(object sender, EventArgs e)
        {
            string user_type = "Staff";
            char genderText = '\0';
            bool failedChecks = false;
            if (maleRadioBtn.Checked == true)
                genderText = 'M';
            else if (femaleRadioBtn.Checked == true)
                genderText = 'F';
            if (staffmemberTextbox.Text == "")
            {
                MessageBox.Show("Please fill Staff Member Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (salaryTextBox.Text == "")
            {
                MessageBox.Show("Please fill Salary", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please fill User Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (phonenumTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Phone Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }

            else if (genderText == '\0')
            {
                MessageBox.Show("Please select a gender", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (DeptIDComboBox.Text == "")
            {
                MessageBox.Show("Please select Department ID", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (passwordTextbox.Text == "")
            {
                MessageBox.Show("Please Enter a Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            if (failedChecks)
            {
                return;
            }

            int.TryParse(DeptIDComboBox.Text, out int Dept_ID);
            float.TryParse(salaryTextBox.Text, out float Salary);

            string Bdate = BdateTimePicker.Value.Year.ToString() + "-" + BdateTimePicker.Value.Month.ToString() + "-" + BdateTimePicker.Value.Day.ToString();
            int result0 = controllerObj.InsertLoginDetailsStaff(usernameTextBox.Text,passwordTextbox.Text,user_type);
            int result1 = controllerObj.InsertStaff(staffmemberTextbox.Text, Bdate, genderText, Dept_ID, Salary, phonenumTextBox.Text, usernameTextBox.Text);
            if (result1 == 1 && result0 == 1)
            {
                MessageBox.Show("The row is inserted successfully!");
           
            }
            else
            {
                MessageBox.Show("The insertion of a new Member failed");
            }
        }
    }
}
