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
            parkingSlotRequestsIdsComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row[0];
                parkingSlotRequestsIdsComboBox.Items.Add(item);
            }
        }

        private void assignParkingSlotRequest_Click(object sender, EventArgs e)
        {
            if (parkingSlotRequestsIdsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a request id first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(parkingSlotRequestsIdsComboBox.SelectedItem.ToString(), out int reqId);

            DataTable dt = controllerObj.GetEmptyParkingSlotsIds(reqId);
            //parkingSlotRequestsIdsComboBox.Items.Clear();
            // Check if is there no requests
            if (dt == null)
            {
                MessageBox.Show("There are no available parking slots in your building", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int parkingId = 0;
            foreach (DataRow row in dt.Rows)
            {
                object item = row[0];
                parkingId = (int)item;
                break;
                //parkingSlotRequestsIdsComboBox.Items.Add(item);
            }

        }
    }
}
