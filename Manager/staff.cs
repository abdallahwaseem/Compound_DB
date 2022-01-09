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
            phonenumTextBox.MaxLength = 11;
            newphonenumtextBox.MaxLength = 11;
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
            else if (passwordTextbox.Text.Length < 6)
            {
                MessageBox.Show("Please enter at least 6 characters in your password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (phonenumTextBox.Text.Length < 11)
            {
                MessageBox.Show("Please enter a valid phone number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            if (failedChecks)
            {
                return;
            }

            int.TryParse(DeptIDComboBox.Text, out int Dept_ID);
            float.TryParse(salaryTextBox.Text, out float Salary);

            string Bdate = BdateTimePicker.Value.Year.ToString() + "-" + BdateTimePicker.Value.Month.ToString() + "-" + BdateTimePicker.Value.Day.ToString();
            int result0 = controllerObj.InsertLoginDetailsStaff(usernameTextBox.Text, passwordTextbox.Text, user_type);
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

        private void staffidcomboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_Username("Staff");
            staffidcomboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["Login_Username"];
                staffidcomboBox.Items.Add(item);
            }
        }

        private void deletestaffBtn_Click(object sender, EventArgs e)
        {
            {
                if (staffidcomboBox.Text == "")
                {
                    MessageBox.Show("Please, Enter the Name.");
                    return;

                }
                int result = controllerObj.DeleteStaff(staffidcomboBox.Text);
                if (result == 0)
                {
                    MessageBox.Show("No rows are deleted");
                }
                else
                {
                    MessageBox.Show("The row is deleted successfully!");
                }
            }
        }
        private void updatestaffnamecomboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_Username("Staff");
            updatestaffnamecomboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["Login_Username"];
                updatestaffnamecomboBox.Items.Add(item);
            }
        }

        private void newDeptIDcomboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDept_Name();
            newDeptIDcomboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["D_Name"];
                newDeptIDcomboBox.Items.Add(item);
            }
        }

        private void updatephoneBtn_Click(object sender, EventArgs e)
        {
            
            if (updatestaffnamecomboBox.Text == "")
            {
                MessageBox.Show("Please, Enter the Staff Name.");
                return;

            }
            if (newphonenumtextBox.Text == "")
            {
                MessageBox.Show("Please, Enter The new Phone Number.");
                return;

            }
            bool failedChecks = false;
            if (newphonenumtextBox.Text.Length < 11)
            {
                MessageBox.Show("Please enter a valid phone number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            if (failedChecks)
            {
                return;
            }


            int result = controllerObj.UpdateStaffPhoneNumber(newphonenumtextBox.Text, updatestaffnamecomboBox.Text);
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void updsalaryBtn_Click(object sender, EventArgs e)
        {
            if (updatestaffnamecomboBox.Text == "")
            {
                MessageBox.Show("Please, Enter the Staff Name.");
                return;

            }
            if (newsalaryTextbox.Text == "")
            {
                MessageBox.Show("Please, Enter the new Salary.");
                return;

            }
            float.TryParse(newsalaryTextbox.Text, out float salary);

            int result = controllerObj.UpdateStaffSalary(salary,updatestaffnamecomboBox.Text);
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void updatedeptBtn_Click(object sender, EventArgs e)
        {
            if (newDeptIDcomboBox.Text == "")
            {
                MessageBox.Show("Please, Enter the Department ID.");
                return;

            }
            if (updatestaffnamecomboBox.Text == "")
            {
                MessageBox.Show("Please, Enter the Staff Name.");
                return;

            }
            int result = controllerObj.UpdateStaffDepartment(newDeptIDcomboBox.Text, updatestaffnamecomboBox.Text);
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void staffmemberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phonenumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void newsalaryTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void newphonenumtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

