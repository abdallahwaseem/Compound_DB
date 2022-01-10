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
    public partial class residentcontrol : UserControl
    {
        Manager_Controller controllerObj;
        public residentcontrol()
        {
            InitializeComponent();
            relationshipComboBox.DataSource = new string[] { "Father", "Mother", "Wife", "Husband" , "Son" , "Daughter" };
            resdphonenumTextBox.MaxLength = 11;
            resdnewphonenumTextbox.MaxLength = 11;
            controllerObj = new Manager_Controller();
        }

        private void BuildingIDComboBox_DropDown(object sender, EventArgs e)
        {
            var parent = this.Parent as Manager_Form;
            int mgr_ID = parent.GetManagerID();
            DataTable dt = controllerObj.GetBuilding_ID(mgr_ID);
            if (dt == null)
            {
                return;
            }
            BuildingIDComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["ID"];
                BuildingIDComboBox.Items.Add(item);
            }
        }

        private void unitidcomboBox_DropDown(object sender, EventArgs e)
        {
            if (BuildingIDComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Building ID first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(BuildingIDComboBox.SelectedItem.ToString(), out int buildingID);
            DataTable dt = controllerObj.GetUnit_ID(buildingID);
            if (dt == null)
            {
                return;
            }
            unitidcomboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["ID"];
                unitidcomboBox.Items.Add(item);
            }
        }

        private void insertresdButton_Click(object sender, EventArgs e)
        {
            string user_type = "Resident";
            char genderText = '\0';
            bool failedChecks = false;
            if (maleRadioBtn.Checked == true)
                genderText = 'M';
            else if (femaleRadioBtn.Checked == true)
                genderText = 'F';
            if (resdnameTextbox.Text == "")
            {
                MessageBox.Show("Please fill Resident Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (unitidcomboBox.Text == "")
            {
                MessageBox.Show("Please enter a Unit ID", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (resdusernameTextBox.Text == "")
            {
                MessageBox.Show("Please fill User Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (resdphonenumTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Phone Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }

            else if (genderText == '\0')
            {
                MessageBox.Show("Please select a gender", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (BuildingIDComboBox.Text == "")
            {
                MessageBox.Show("Please select Building ID", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (resdpasswordTextbox.Text == "")
            {
                MessageBox.Show("Please Enter a Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (resdpasswordTextbox.Text.Length < 6)
            {
                MessageBox.Show("Please enter at least 6 characters in your password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (resdphonenumTextBox.Text.Length < 11)
            {
                MessageBox.Show("Please enter a valid phone number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            if (failedChecks)
            {
                return;
            }

            int.TryParse(BuildingIDComboBox.Text, out int Building_ID);
            int.TryParse(unitidcomboBox.Text, out int Unit_ID);

            string Bdate = resdBdateTimePicker.Value.Year.ToString() + "-" + resdBdateTimePicker.Value.Month.ToString() + "-" + resdBdateTimePicker.Value.Day.ToString();
            int result0 = controllerObj.InsertLoginDetailsStaff(resdusernameTextBox.Text, resdpasswordTextbox.Text, user_type);
            int result1 = controllerObj.InsertResident(resdnameTextbox.Text, Bdate, genderText,resdphonenumTextBox.Text, resdusernameTextBox.Text,Building_ID,Unit_ID);
            if ( result1 == 1)
            {
                MessageBox.Show("The row is inserted successfully!");

            }
            else
            {
                MessageBox.Show("The insertion of a new Member failed");
            }
        }

        private void updateresdcomboBox_DropDown(object sender, EventArgs e)
        {
            var parent = this.Parent as Manager_Form;
            int mgr_ID = parent.GetManagerID();
            DataTable dt = controllerObj.Get_UsernameOccupant(mgr_ID);
            if (dt == null)
            {
                return;
            }
            updateresdnamecomboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["Login_Username"];
                updateresdnamecomboBox.Items.Add(item);
            }
        }

        private void updateresdBtn_Click(object sender, EventArgs e)
        {

            if (updateresdnamecomboBox.Text == "")
            {
                MessageBox.Show("Please, Enter the Resident Name.");
                return;

            }
            if (resdnewphonenumTextbox.Text == "")
            {
                MessageBox.Show("Please, Enter The new Phone Number.");
                return;

            }
            bool failedChecks = false;
            if (resdnewphonenumTextbox.Text.Length < 11)
            {
                MessageBox.Show("Please enter a valid phone number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            if (failedChecks)
            {
                return;
            }


            int result = controllerObj.UpdateResident(resdnewphonenumTextbox.Text, updateresdnamecomboBox.Text);
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void occupantresidentComboBox_DropDown(object sender, EventArgs e)
        {
            var parent = this.Parent as Manager_Form;
            int mgr_ID = parent.GetManagerID();
            DataTable dt = controllerObj.Get_UsernameOccupant(mgr_ID);
            if (dt == null)
            {
                return;
            }
            occupantresidentComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["Login_Username"];
                occupantresidentComboBox.Items.Add(item);
            }
        }

        private void insertanoccupantBtn_Click(object sender, EventArgs e)
        {
            bool failedChecks = false;
            if (occupantresidentComboBox.Text == "")
            {
                MessageBox.Show("Please fill Resident Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (occupantnameTextbox.Text == "")
            {
                MessageBox.Show("Please enter occupant name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (relationshipComboBox.Text == "")
            {
                MessageBox.Show("Please enter their relationship", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            if (failedChecks)
            {
                return;
            }

            int result = controllerObj.InsertOccupants(occupantresidentComboBox.Text,occupantnameTextbox.Text,relationshipComboBox.SelectedItem.ToString());
            if (result == 1)
            {
                MessageBox.Show("The row is inserted successfully!");

            }
            else
            {
                MessageBox.Show("The insertion of a new Member failed");
            }

        }

        private void resdnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void occupantnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void resdnewphonenumTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void resdphonenumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
