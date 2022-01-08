using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compound_DB.Resident.UserControls;


namespace Compound_DB.UserControls
{
    public partial class Services : UserControl
    {
        public Services()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer2.Controls.Clear();
            panelContainer2.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void Services_Load(object sender, EventArgs e)
        {

        }

        

        private void RedSerBtn_Click(object sender, EventArgs e)
        {
            Req_service rs = new Req_service();
            addUserControl(rs);
        }

        private void RateSerBtn_Click(object sender, EventArgs e)
        {
            Rate_service RateS = new Rate_service();
            addUserControl(RateS);
        }

        private void View_Req_btn_Click(object sender, EventArgs e)
        {
            View_Req VR = new View_Req();
            addUserControl(VR);
        }
    }
}
