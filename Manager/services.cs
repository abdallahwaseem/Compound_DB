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

    public partial class services : UserControl
    {
        Manager_Controller controllerObj;
        public services()
        {
            InitializeComponent();
            controllerObj = new Manager_Controller();
        }

        private void deptIDcomboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDept_ID();
            deptIDcomboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["ID"];
                deptIDcomboBox.Items.Add(item);
            }
        }

        private void addservicesBtn_Click(object sender, EventArgs e)
        {
            bool failedChecks = false;
            if (sernameTextbox.Text == "")
            {
                MessageBox.Show("Please fill Service Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            else if (deptIDcomboBox.Text == "")
            {
                MessageBox.Show("Please Enter a department ID ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failedChecks = true;
            }
            if (failedChecks)
            {
                return;
            }
            int.TryParse(deptIDcomboBox.Text, out int Dept_ID);
            float.TryParse(priTextbox.Text, out float Price_Float);
            string priceText = (priTextbox.Text == "") ? "NULL" : priTextbox.Text;
            int result = controllerObj.InsertService(sernameTextbox.Text, Price_Float,Dept_ID);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new service failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void sernamecomboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetSer_Name();
            sernamecomboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["Ser_Name"];
                sernamecomboBox.Items.Add(item);
            }

        }

        private void updatepriceBtn_Click(object sender, EventArgs e)
        {
            if (sernamecomboBox.Text == "")
            {
                MessageBox.Show("Please, Enter A Service Name.");
                return;

            }
            if (updatepriceTextbox.Text == "")
            {
                MessageBox.Show("Please, Enter A Price.");
                return;

            }
            float.TryParse(updatepriceTextbox.Text, out float Price_Float);


            int result = controllerObj.UpdatePriceService(Price_Float,sernamecomboBox.Text);
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

    }
}
