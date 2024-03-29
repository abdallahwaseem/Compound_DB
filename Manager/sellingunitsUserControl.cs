﻿using System;
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
    public partial class sellingunitsUserControl : UserControl
    {
        Manager_Controller controllerObj;

        public sellingunitsUserControl()
        {
            InitializeComponent();
            controllerObj = new Manager_Controller();
        }

        private void viewinvoicesBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectSellingRequests();
            sellingunitsdataGrid.DataSource = dt;
            sellingunitsdataGrid.Refresh();
        }

        private void sellingresdComboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetSellingRequest_ID();
            if (dt == null)
            {
                return;
            }
            sellingresdComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                object item = row["Resident_ID"];
                sellingresdComboBox.Items.Add(item);
            }
        }

        private void addpenaltyBtn_Click(object sender, EventArgs e)
        {
            if (sellingresdComboBox.Text == "")
            {
                MessageBox.Show("Please, Enter A Department Number.");
                return;

            }
            int result = controllerObj.SellUnit(Int32.Parse(sellingresdComboBox.Text));
            if (result == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }
        }
    }
}
