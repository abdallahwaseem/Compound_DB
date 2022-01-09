using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_DB.Compound_Staff
{
    public partial class MyRequest_ControlForm : UserControl
    {
        Staff_Controller controllerObj;

        public MyRequest_ControlForm()
        {
            InitializeComponent();
            controllerObj = new Staff_Controller();
        }

        private void searchMyRequestsBtn_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int staffId = parent.GetStaffId();
            DataTable dt = controllerObj.GetMyRequestsDetails(staffId);
            myRequestsGrid.DataSource = dt;
            myRequestsGrid.Refresh();
        }

        private void myRequestsIdsComboBox_DropDown(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int staffId = parent.GetStaffId();
            DataTable dt = controllerObj.GetMyRequestsDetails(staffId);
            myRequestsIdsComboBox.Items.Clear();
            // Check if is there no requests
            if (dt == null)
            {
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                object item = row[0];
                myRequestsIdsComboBox.Items.Add(item);
            }
        }
        private void requestCompleted_Click(object sender, EventArgs e)
        {
            if (myRequestsIdsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a request id first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parent = this.Parent as Staff_Form;
            int staffId = parent.GetStaffId();
            int.TryParse(myRequestsIdsComboBox.SelectedItem.ToString(), out int reqId);
            int result = controllerObj.CompleteRequest(staffId, reqId);
            if (result == 0)
            {
                MessageBox.Show("Failed to set request as completed. Please check with your manger.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Request completed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showCompletedRequestsBtn_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int staffId = parent.GetStaffId();
            DataTable dt = controllerObj.GetMyCompletedRequestsDetails(staffId);
            myRequestsGrid.DataSource = dt;
            myRequestsGrid.Refresh();
        }
    }
}
