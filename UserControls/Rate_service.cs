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
    public partial class Rate_service : UserControl
    {
        Resident_controller controllerObj;
        int R_id;
        string Email;
        string R_Name;
        public Rate_service(int id, string name, string email)
        {
            InitializeComponent();
            R_id = id;
            R_Name = name;
            Email = email;
            controllerObj = new Resident_controller();
            DataTable resident_Requests = controllerObj.ViewRequests(R_id);
            for (int j = 0; j < resident_Requests.Rows.Count; j++)
            {
                string text = resident_Requests.Rows[j]["Request_Number"].ToString();
                this.req_listsComcobox.Items.Add(text);
                
            }

        }

        private void Rate_service_Load(object sender, EventArgs e)
        {

        }

        private void confrim_btn_Click(object sender, EventArgs e)
        {
            if (req_listsComcobox.Text=="" || feedback_comboBox.Text=="")
            {
                MessageBox.Show("Please Enter Specified Fields");
                return;
            }
            int Rating = 0;
            if (Star1.Checked) Rating = 1;
            else if (Star2.Checked) Rating = 2;
            else if (Star3.Checked) Rating = 3;
            else if (Star4.Checked) Rating = 4;
            else if (Star5.Checked) Rating = 5;
            else 
            { 
                MessageBox.Show("Please select worker rating ");
                return;
            };
            DataTable dt = controllerObj.GetRequestStatus(Int32.Parse(req_listsComcobox.Text));
            string Status = dt.Rows[0]["Req_Status"].ToString();
            if (Status != "Completed")
            {
                MessageBox.Show("Error: cant rate this request it is not yet Complete");
                return;
            }
            

            DataTable dt2 = controllerObj.GetAssignedStaff_ID(Int32.Parse(req_listsComcobox.Text));
            int staffID = Convert.ToInt32(dt2.Rows[0]["Assigned_Staff_ID"].ToString());

            DataTable dt3 = controllerObj.GetStaffRating(staffID);
            int staffRating = Convert.ToInt32(dt3.Rows[0]["Rating"].ToString());
            int update_value = (staffRating + Rating) / 2;

            int Result1 = controllerObj.UpdateRequestFeedback(Int32.Parse(req_listsComcobox.Text), feedback_comboBox.Text);
            int Result2 = controllerObj.UpdateStaffRating(staffID, update_value);
            if (Result1 == 0)
            {
                MessageBox.Show("Feedback Failed!!");
            }
            if (Result2 == 0)
            {
                MessageBox.Show("Worker Rating Failed!!");
            }
            if (Result1 != 0 && Result2 != 0)
            {
                MessageBox.Show("feedback Sent Successfully");
            }
        }
    }
}
