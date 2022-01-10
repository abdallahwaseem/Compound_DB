using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Compound_DB.Resident.UserControls;
using Compound_DB.UserControls;


namespace Compound_DB.Resident
{
    public partial class Resident_Form : Form
    {
        int R_id;
        string Email;
        string R_Name;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        public Resident_Form(int id, string name, string email)
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            sidePanel.Height = invoiceBtn.Height;
            sidePanel.Top = invoiceBtn.Top;
            sidePanel.Left = invoiceBtn.Left;
            invoiceBtn.BackColor = Color.FromArgb(46, 51, 73);
            R_id = id;
            R_Name = name;
            Email = email;
            userNameLabel.Text = R_Name;
            ID_label.Text = R_id.ToString();

        }

        private void Resident_Form_Load(object sender, EventArgs e)
        {

        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = invoiceBtn.Height;
            sidePanel.Top = invoiceBtn.Top;
            sidePanel.Left = invoiceBtn.Left;
            invoiceBtn.BackColor = Color.FromArgb(46, 51, 73);
            Invoices I = new Invoices(R_id, R_Name, Email);
            addUserControl(I);
        }
        private void invoiceBtn_Leave(object sender, EventArgs e)
        {
            invoiceBtn.BackColor = Color.FromArgb(0, 21, 64);
        }
        private void servicesBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = servicesBtn.Height;
            sidePanel.Top = servicesBtn.Top;
            sidePanel.Left = servicesBtn.Left;
            servicesBtn.BackColor = Color.FromArgb(46, 51, 73);
            Services S = new Services(R_id, R_Name, Email);
            addUserControl(S);

        }

        private void servicesBtn_Leave(object sender, EventArgs e)
        {
            servicesBtn.BackColor = Color.FromArgb(0, 21, 64);
        }

        private void entCodeBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = entCodeBtn.Height;
            sidePanel.Top = entCodeBtn.Top;
            sidePanel.Left = entCodeBtn.Left;
            entCodeBtn.BackColor = Color.FromArgb(46, 51, 73);
            Entrance_code E = new Entrance_code(R_id, R_Name, Email);
            addUserControl(E);
        }

        private void entCodeBtn_Leave(object sender, EventArgs e)
        {
            entCodeBtn.BackColor = Color.FromArgb(0, 21, 64);
        }

        private void sellUnitBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = TransferOwnershipBtn.Height;
            sidePanel.Top = TransferOwnershipBtn.Top;
            sidePanel.Left = TransferOwnershipBtn.Left;
            TransferOwnershipBtn.BackColor = Color.FromArgb(46, 51, 73);
            SellUnit SU = new SellUnit(R_id, R_Name, Email);
            addUserControl(SU);
        }

        private void sellUnitBtn_Leave(object sender, EventArgs e)
        {
            TransferOwnershipBtn.BackColor = Color.FromArgb(0, 21, 64);
        }

        private void parkingSlotBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = parkingSlotBtn.Height;
            sidePanel.Top = parkingSlotBtn.Top;
            sidePanel.Left = parkingSlotBtn.Left;
            parkingSlotBtn.BackColor = Color.FromArgb(46, 51, 73);
            ParkingSlot PS = new ParkingSlot(R_id, R_Name, Email);
            addUserControl(PS);
        }

        private void parkingSlotBtn_Leave(object sender, EventArgs e)
        {
            parkingSlotBtn.BackColor = Color.FromArgb(0, 21, 64);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
