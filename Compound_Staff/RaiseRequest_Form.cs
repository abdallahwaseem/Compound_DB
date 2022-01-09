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
    public partial class RaiseRequest_Form : UserControl
    {
        Staff_Controller controllerObj;
        //int mgrId = 0;
        //int staffId = 0;
        public RaiseRequest_Form()
        {
            InitializeComponent();
            controllerObj = new Staff_Controller();
            //var parent = this.Parent as Staff_Form;
            //int staffId = parent.GetStaffId();
            //int mgrId = controllerObj.GetManagerId(staffId);
        }

        private void showReqStateBtn_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int staffId = parent.GetStaffId();
            DataTable dt = controllerObj.GetRaiseRequests(staffId);
            raiseRequestsGrid.DataSource = dt;
            if (dt == null)
            {
                MessageBox.Show("There isn't any raise request requested", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            raiseRequestsGrid.Refresh();
        }

        private void submitRaiseReqBtn_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Staff_Form;
            int staffId = parent.GetStaffId();
            int mgrId = controllerObj.GetManagerId(staffId);
            if (float.TryParse(newSalaryAmountTextBox.Text, out float newSalary))
            {
                DataTable dataTable = controllerObj.CheckIfRequestedBefore(staffId);
                if (dataTable != null)
                {
                    MessageBox.Show("You already have a pending request", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                double currentSalary = 0;
                DataTable dt = controllerObj.GetSalary(staffId);
                foreach (DataRow row in dt.Rows)
                {
                    object item = row[0];
                    currentSalary = (double)item;
                }
                MessageBox.Show(currentSalary.ToString());
                if (newSalary < currentSalary)
                {
                    MessageBox.Show("New salary cannot be less than old salary", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = controllerObj.RequestRaise(staffId, mgrId, newSalary);
                if (result == 0)
                {
                    MessageBox.Show("Failed to request raise. Please check with your manger.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Raise request completed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Salary must be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }
    }
}
