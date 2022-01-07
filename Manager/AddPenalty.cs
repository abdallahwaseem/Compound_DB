using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_DB.Manager
{
    public partial class AddPenalty : UserControl
    {
        Manager_Controller controllerObj;
        public AddPenalty()
        {
            InitializeComponent();
            controllerObj = new Manager_Controller();
        }

        private void AddPenalty_Load(object sender, EventArgs e)
        {
            controllerObj = new Manager_Controller();
        }


        private void viewinvoicesBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectInvoices();
            invoicedataGridView.DataSource = dt;
            invoicedataGridView.Refresh();
        }

        private void showoverdueBtn_Click(object sender, EventArgs e)
        {
               DataTable dt = controllerObj.SelectInvoices();
            invoicedataGridView.DataSource = dt;
            invoicedataGridView.Refresh();

        }
    }
}
