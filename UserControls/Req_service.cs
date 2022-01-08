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
        public Req_service()
        {
            InitializeComponent();
            RequestNum.Hide();
            RequestID.Hide();
        }

        private void confrim_btn_Click(object sender, EventArgs e)
        {
            RequestNum.Show();
            RequestID.Show();
        }
    }
}
