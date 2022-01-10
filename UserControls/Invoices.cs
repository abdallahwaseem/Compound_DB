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
    public partial class Invoices : UserControl
    {
        Resident_controller controllerObj;
        int R_id;
        string Email;
        string R_Name;
        public Invoices(int id, string name, string email)
        {
            InitializeComponent();
            R_id = id;
            R_Name = name;
            Email = email;
            controllerObj = new Resident_controller();
            PayLabel.Hide();
            amount_label.Hide();
            ConfirmBtn.Hide();
            DataTable dt = controllerObj.ViewInvoices(R_id);
            Invoices_Grid.DataSource = dt;
            Invoices_Grid.Refresh();
        }

        private void temp_Click(object sender, EventArgs e)
        {

        }

        private void Invoices_Load(object sender, EventArgs e)
        {

        }

        private void Invoices_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (Invoices_Grid.CurrentRow.Cells[2].Value.ToString()=="Paid")
            {
                MessageBox.Show("Invoice Already Paid");
                return;
            }
            int Invoice_id= Int16.Parse(Invoices_Grid.CurrentRow.Cells[0].Value.ToString());
            int Result=controllerObj.UpdateInvoiceStatus(Invoice_id, "Paid");
            if (Result == 0)
            {
                MessageBox.Show("Error in paying");
            }
            else
            {
                MessageBox.Show("Invoice is paid successfully");
            }

        }

        private void PendingRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewPendingInvoices(R_id);
            Invoices_Grid.DataSource = dt;
            Invoices_Grid.Refresh();
        }

        private void PaidRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewPaidInvoices(R_id);
            Invoices_Grid.DataSource = dt;
            Invoices_Grid.Refresh();
        }

        private void All_Invoices_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewInvoices(R_id);
            Invoices_Grid.DataSource = dt;
            Invoices_Grid.Refresh();

        }

        private void Invoices_Grid_Click(object sender, EventArgs e)
        {
            int Penalty = 0;
            int amount = Int16.Parse(Invoices_Grid.CurrentRow.Cells[4].Value.ToString());
            if (Invoices_Grid.CurrentRow.Cells[5].Value != DBNull.Value)
                Penalty = Int16.Parse(Invoices_Grid.CurrentRow.Cells[5].Value.ToString());
            String total_amount = (amount + Penalty).ToString();
            PayLabel.Show();
            amount_label.Text = total_amount;
            amount_label.Show();
            ConfirmBtn.Show();

        }
    }
}
