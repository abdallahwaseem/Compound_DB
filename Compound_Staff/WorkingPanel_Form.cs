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
    public partial class WorkingPanel_Form : UserControl
    {
        Staff_Controller controllerObj;
        public WorkingPanel_Form()
        {
            InitializeComponent();
            controllerObj = new Staff_Controller();
        }
        private void searchRequestsBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetMyRequestsDetails(1);
            requestsGrid.DataSource = dt;
            requestsGrid.Refresh();
        }
    }
}
