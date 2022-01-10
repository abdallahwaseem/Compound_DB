using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compound_DB.Resident;

namespace Compound_DB.UserControls
{
    public partial class View_Req : UserControl
    {
        Resident_controller controllerObj;
        int R_id;
        string Email;
        string R_Name;
        public View_Req(int id, string name, string email)
        {
            InitializeComponent();
            R_id = id;
            R_Name = name;
            Email = email;
            controllerObj = new Resident_controller();
            DataTable dt = controllerObj.ViewRequests(R_id);
            Req_Grid.DataSource = dt;
            Req_Grid.Refresh();
        }

        private void View_Req_Load(object sender, EventArgs e)
        {

        }

        private void Req_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
