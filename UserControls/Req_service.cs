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
    public partial class Req_service : UserControl
    {
        Resident_controller controllerObj;
        int R_id;
        string Email;
        string R_Name;
        DateTime dateNow;
        public Req_service(int id, string name, string email)
        {
            InitializeComponent();
            R_id = id;
            R_Name = name;
            Email = email;
            dateNow = DateTime.Now;
            controllerObj = new Resident_controller();
            RequestNum.Hide();
            RequestID.Hide();
            DataTable ServicesAvailable = controllerObj.GetServicesProvided();
            for (int j = 0; j < ServicesAvailable.Rows.Count; j++)
            {
                string text = ServicesAvailable.Rows[j]["Ser_Name"].ToString();
                this.Service_NameTxtbox.Items.Add(text);

            }
        }

        private void confrim_btn_Click(object sender, EventArgs e)
        {
            if (Service_NameTxtbox.Text=="")
            {
                MessageBox.Show("Please Enter Required Service");
                return;
            }
            if (Request_Date.Value < dateNow)
            {
                MessageBox.Show("Must Enter a date in the future");
                return;
            }
            DataTable dt = controllerObj.GetServiceID(Service_NameTxtbox.Text);
            int serID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            int SimilarReq = controllerObj.getSimilarRequests(Request_Date.Value, serID, R_id);
            if (SimilarReq!=0)
            {
                MessageBox.Show("Cant proceed: You have requested this Service before on the same date!!");
                return;
            }
            int Result = controllerObj.InsertInRequest(Request_Date.Value, serID, R_id);
            if (Result == 0)
            {
                MessageBox.Show("Request Failed!!");
            }
            else
            {
                MessageBox.Show("Request Sent Successfully");
            }
            DataTable AddedReqID = controllerObj.getAddedReqID(Request_Date.Value, serID, R_id);
            int reqID = Convert.ToInt32(AddedReqID.Rows[0]["ID"].ToString());
            RequestID.Text = reqID.ToString();
            RequestNum.Show();
            RequestID.Show();
        }

        private void Select_Required_Service_Click(object sender, EventArgs e)
        {

        }
    }
}
