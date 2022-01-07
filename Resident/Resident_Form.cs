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

namespace Compound_DB.Resident
{
    public partial class Resident_Form : Form
    {
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
        public Resident_Form(int id, string name, string email)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            sidePanel.Height = invoiceBtn.Height;
            sidePanel.Top = invoiceBtn.Top;
            sidePanel.Left = invoiceBtn.Left;
            invoiceBtn.BackColor = Color.FromArgb(46, 51, 73);
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
        }
        private void invoiceBtn_Leave(object sender, EventArgs e)
        {
            invoiceBtn.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void servicesBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = servicesBtn.Height;
            sidePanel.Top = servicesBtn.Top;
            sidePanel.Left = servicesBtn.Left;
            servicesBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void servicesBtn_Leave(object sender, EventArgs e)
        {
            servicesBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void entCodeBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = entCodeBtn.Height;
            sidePanel.Top = entCodeBtn.Top;
            sidePanel.Left = entCodeBtn.Left;
            entCodeBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void entCodeBtn_Leave(object sender, EventArgs e)
        {
            entCodeBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void sellUnitBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = sellUnitBtn.Height;
            sidePanel.Top = sellUnitBtn.Top;
            sidePanel.Left = sellUnitBtn.Left;
            sellUnitBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void sellUnitBtn_Leave(object sender, EventArgs e)
        {
            sellUnitBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void parkingSlotBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = parkingSlotBtn.Height;
            sidePanel.Top = parkingSlotBtn.Top;
            sidePanel.Left = parkingSlotBtn.Left;
            parkingSlotBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void parkingSlotBtn_Leave(object sender, EventArgs e)
        {
            parkingSlotBtn.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
