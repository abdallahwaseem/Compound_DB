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
    public partial class SellUnit : UserControl
    {
        Resident_controller controllerObj;
        int R_id;
        string Email;
        string R_Name;
        public SellUnit(int id, string name, string email)
        {
            InitializeComponent();
            R_id = id;
            R_Name = name;
            Email = email;
            controllerObj = new Resident_controller();
        }

        private void SellUnit_Load(object sender, EventArgs e)
        {

        }

        private void confrim_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GETBuildingandUnit(R_id);
            
            if (dt != null)
            {
                int BID = Convert.ToInt32(dt.Rows[0]["Building_ID"].ToString());
                int UID = Convert.ToInt32(dt.Rows[0]["Unit_ID"].ToString());

                int SimilarReq = controllerObj.getSimilarSellingReq(R_id);
                if (SimilarReq != 0)
                {
                    MessageBox.Show("Cant proceed: You have requested a transfer of ownership before !!");
                    return;
                }
                int Result = controllerObj.InsertInSellingReq(R_id, BID, UID);
                if (Result == 0)
                {
                    MessageBox.Show("Request Failed!!");
                }
                else
                {
                    MessageBox.Show("Request Sent Successfully");
                }
            }
            
        }
    }
}
