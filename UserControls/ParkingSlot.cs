using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_DB.Resident.UserControls
{
    public partial class ParkingSlot : UserControl
    {
        Resident_controller controllerObj;
        int R_id;
        string Email;
        string R_Name;
        DateTime dateNow;
        public ParkingSlot(int id, string name, string email)
        {
            InitializeComponent();
            R_id = id;
            R_Name = name;
            Email = email;
            dateNow = DateTime.Now;
            controllerObj = new Resident_controller();
            DataTable dt = controllerObj.viewResidentparkingSlots(R_id);
            ParkingSlotsGrid.DataSource = dt;
            ParkingSlotsGrid.Refresh();
        }

        private void ParkingSlot_Load(object sender, EventArgs e)
        {

        }

        private void confrim_btn_Click(object sender, EventArgs e)
        {
            if (RequestP_Date.Value < dateNow)
            {
                MessageBox.Show("Must Enter a date in the future");
                return;
            }
            
            DataTable dt = controllerObj.GetServiceID("Parking Slot");
            
            if (dt!=null)
            {
                int serID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                int SimilarReq = controllerObj.ResidentpendingParkingslotReq(RequestP_Date.Value, serID, R_id);
                if (SimilarReq != 0)
                {
                    MessageBox.Show("Cant proceed: You have a pending request for a parking slot on the same date!!");
                    return;
                }
                int Result = controllerObj.InsertInRequest(RequestP_Date.Value, serID, R_id);
                if (Result == 0)
                {
                    MessageBox.Show("Request Failed!!");
                }
                else
                {
                    MessageBox.Show("Request Sent Successfully");
                }
            }
            else
            {
                MessageBox.Show("Service not available");
            }
        }
    }
}
