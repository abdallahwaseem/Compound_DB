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
    public partial class Statistics_Form : Form
    {
        public Statistics_Form()
        {
            InitializeComponent();
        }

        private void staff_stat_btn_Click(object sender, EventArgs e)
        {
            Staff_Report_Form form = new Staff_Report_Form();
            form.Show();
            this.Hide();
        }

        private void inv_statistics_btn_Click(object sender, EventArgs e)
        {
            Invoice_Report_Form form = new Invoice_Report_Form();
            form.Show();
            this.Hide();
        }
    }
}
