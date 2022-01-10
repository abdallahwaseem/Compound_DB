using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Compound_DB.Compound_Staff
{
    public partial class Staff_Form : Form
    {
        string username;
        int staffId;
        string staffName;
        int departmentId;
        string departmentName;
        public Staff_Form(int id, string inputStaffName,string inputUsername, int deptId, string deptName)
        {
            InitializeComponent();
            sidePanel.Height = workingPanelBtn.Height;
            sidePanel.Top = workingPanelBtn.Top;
            sidePanel.Left = workingPanelBtn.Left;
            workingPanel_ControlForm1.BringToFront();
            departmentId = deptId;
            departmentName = deptName;
            username = inputUsername;
            staffName = inputStaffName;
            staffId = id;
        }

        public int GetStaffId()
        {
            return staffId;
        }
        public int GetDeparmentId()
        {
            return departmentId;
        }
        private void Staff_Form_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = staffName;
            deptLabel.Text = departmentName;
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Login.Login_Form form = new Login.Login_Form();
            form.Show();
            this.Hide();
        }

        private void workingPanelBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = workingPanelBtn.Height;
            sidePanel.Top = workingPanelBtn.Top;
            sidePanel.Left = workingPanelBtn.Left;
            workingPanel_ControlForm1.BringToFront();
            workingPanelBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void workingPanelBtn_Leave(object sender, EventArgs e)
        {
            workingPanelBtn.BackColor = Color.FromArgb(4, 57, 109);
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = servicesBtn.Height;
            sidePanel.Top = servicesBtn.Top;
            sidePanel.Left = servicesBtn.Left;
            myRequest_ControlForm1.BringToFront();
            servicesBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void servicesBtn_Leave(object sender, EventArgs e)
        {
            servicesBtn.BackColor = Color.FromArgb(4, 57, 109);
        }
        private void parkingBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = parkingBtn.Height;
            sidePanel.Top = parkingBtn.Top;
            sidePanel.Left = parkingBtn.Left;
            parkingSlotRequests_Form1.BringToFront();
            parkingBtn.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void parkingBtn_Leave(object sender, EventArgs e)
        {
            parkingBtn.BackColor = Color.FromArgb(4, 57, 109);
        }

        private void requestRaiseBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = requestRaiseBtn.Height;
            sidePanel.Top = requestRaiseBtn.Top;
            sidePanel.Left = requestRaiseBtn.Left;
            raiseRequest_Form1.BringToFront();
            requestRaiseBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void requestRaiseBtn_Leave(object sender, EventArgs e)
        {
            requestRaiseBtn.BackColor = Color.FromArgb(4, 57, 109);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            StaffSettings_Form form = new StaffSettings_Form(staffId, staffName, departmentName, username, departmentId);
            form.Show();
            this.Hide();
        }

    }
}
