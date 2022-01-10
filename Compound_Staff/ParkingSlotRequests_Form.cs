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
    public partial class ParkingSlotRequests_Form : UserControl
    {
        Staff_Controller controllerObj;

        public ParkingSlotRequests_Form()
        {
            InitializeComponent();
            controllerObj = new Staff_Controller();
        }

        private void searchParkingSlotRequestsBtn_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int deptId = parent.GetDeparmentId();
            DataTable dt = controllerObj.GetParkingSlotRequestsDetails(deptId);
            parkingSlotRequestsGrid.DataSource = dt;
            parkingSlotRequestsGrid.Refresh();

        }

        private void parkingSlotRequestsIdsComboBox_DropDown(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int deptId = parent.GetDeparmentId();
            DataTable dt = controllerObj.GetParkingSlotRequestsDetails(deptId);
            parkingSlotRequestsIdsComboBox.Items.Clear();
            // Check if is there no requests
            if (dt == null)
            {
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                object item = row[0];
                parkingSlotRequestsIdsComboBox.Items.Add(item);
            }
        }
        private void emptySlotsIdsComboBox_DropDown(object sender, EventArgs e)
        {
            if (parkingSlotRequestsIdsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a request id first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(parkingSlotRequestsIdsComboBox.SelectedItem.ToString(), out int reqId);

            DataTable dt = controllerObj.GetEmptyParkingSlotsIds(reqId);
            emptySlotsIdsComboBox.Items.Clear();
            // Check if is there no parking slots
            if (dt == null)
            {
                MessageBox.Show("There aren't any empty parking slots for this building", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                object item = row[0];
                emptySlotsIdsComboBox.Items.Add(item);
            }
        }

        private void searchEmptyParkingSlot_Click(object sender, EventArgs e)
        {
            if (parkingSlotRequestsIdsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a request id first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(parkingSlotRequestsIdsComboBox.SelectedItem.ToString(), out int reqId);
            DataTable dt = controllerObj.GetEmptyParkingSlotsIds(reqId);
            // Check if is there no parking slots
            if (dt == null)
            {
                MessageBox.Show("There aren't any empty parking slots for this building", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            parkingSlotRequestsGrid.DataSource = dt;
            parkingSlotRequestsGrid.Refresh();
        }
        private void assignParkingSlotRequest_Click(object sender, EventArgs e)
        {

            if (parkingSlotRequestsIdsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a request id first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(parkingSlotRequestsIdsComboBox.SelectedItem.ToString(), out int reqId);
            int residentId = controllerObj.GetResidentIdFromReqID(reqId);
            if (emptySlotsIdsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a parking slot id first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parent = this.Parent as Staff_Form;
            int staffId = parent.GetStaffId();
            int.TryParse(emptySlotsIdsComboBox.SelectedItem.ToString(), out int parkingSlotId);
            controllerObj.AssignParkingSlot(parkingSlotId, residentId);
            controllerObj.CompleteRequest(staffId, reqId);
            MessageBox.Show("Parking slot assigned successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
