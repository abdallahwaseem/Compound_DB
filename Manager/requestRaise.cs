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
    public partial class requestRaise : UserControl
    {
        Manager_Controller controllerObj;
        int new_salary = 0;
        int staff_id = 0;
        public requestRaise()
        {
            InitializeComponent();
            controllerObj = new Manager_Controller();
        }

        private void viewrrequestsBtn_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Manager_Form;
            int mgr_ID = parent.GetManagerID();
            DataTable dt = controllerObj.SelectRaisingRequests(mgr_ID);
            if (dt == null)
            {
                return;
            }
            raisingreqdataGrid.DataSource = dt;
            raisingreqdataGrid.Refresh();
        }



        private void acceptReqBtn_Click(object sender, EventArgs e)
        {
            if (raisingstaffComboBox.Text == "")
            {
                MessageBox.Show("Please, Enter A Staff ID.");
                return;

            }
            int result = controllerObj.UpdateNewSalary(staff_id, new_salary);
            int result0 = controllerObj.AcceptRequest(Int32.Parse(raisingstaffComboBox.Text));
            if (result0 == 0 && result==0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully!");
            }
        }
        private void rejectBtn_Click(object sender, EventArgs e)
        {
            if (raisingstaffComboBox.Text == "")
            {
                MessageBox.Show("Please, Enter A Staff ID.");
                return;

            }
            int result = controllerObj.RejectRequest(Int32.Parse(raisingstaffComboBox.Text));
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully!");
            }
        }

        private void raisingstaffComboBox_DropDown(object sender, EventArgs e)
        {
            var parent = this.Parent as Manager_Form;
            int mgr_ID = parent.GetManagerID();
            DataTable dt = controllerObj.GetRaisingRequests(mgr_ID);
            if (dt == null)
            {
                return;
            }
            raisingstaffComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["Staff_ID"];
                raisingstaffComboBox.Items.Add(item);
            }
        }

    }
}
