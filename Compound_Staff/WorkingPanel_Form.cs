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
    public partial class WorkingPanel_ControlForm : UserControl
    {
        Staff_Controller controllerObj;
        public WorkingPanel_ControlForm()
        {
            InitializeComponent();
            controllerObj = new Staff_Controller();
        }
        private void searchRequestsBtn_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int deptId = parent.GetDeparmentId();
            DataTable dt = controllerObj.GetAllRequestsDetails(deptId);
            requestsGrid.DataSource = dt;
            requestsGrid.Refresh();
        }

        private void acceptRequest_Click(object sender, EventArgs e)
        {
            if (requestsIdsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a request id to accept", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parent = this.Parent as Staff_Form;
            int staffId = parent.GetStaffId();
            int.TryParse(requestsIdsComboBox.SelectedItem.ToString(), out int reqId);
            int result = controllerObj.AcceptRequest(staffId, reqId);
            if (result == 0)
            {
                MessageBox.Show("Failed to accept request. Please check with your manger.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Request accepted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void requestsIdsComboBox_DropDown(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int deptId = parent.GetDeparmentId();
            DataTable dt = controllerObj.GetAllRequestsDetails(deptId);
            requestsIdsComboBox.Items.Clear();
            // Check if is there no requests
            
            if (dt == null)
            {
                return;
            }
            requestsIdsComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row[0];
                requestsIdsComboBox.Items.Add(item);
            }
        }
    }
}
