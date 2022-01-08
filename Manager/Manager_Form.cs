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


namespace Compound_DB.Manager
{
    public partial class Manager_Form : Form
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
        public Manager_Form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            sidePanel.Height = checkinvoiceBtn.Height;
            sidePanel.Top = checkinvoiceBtn.Top;
            sidePanel.Left = checkinvoiceBtn.Left;
            checkinvoiceBtn.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void checkinvoiceBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = checkinvoiceBtn.Height;
            sidePanel.Top = checkinvoiceBtn.Top;
            sidePanel.Left = checkinvoiceBtn.Left;
            checkinvoiceBtn.BackColor = Color.FromArgb(46, 51, 73);

        }


        private void addpenaltyBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = addpenaltyBtn.Height;
            sidePanel.Top = addpenaltyBtn.Top;
            sidePanel.Left = addpenaltyBtn.Left;
            addpenaltyBtn.BackColor = Color.FromArgb(46, 51, 73);
            addPenalty1.BringToFront();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = servicesBtn.Height;
            sidePanel.Top = servicesBtn.Top;
            sidePanel.Left = servicesBtn.Left;
            servicesBtn.BackColor = Color.FromArgb(46, 51, 73);
            services1.BringToFront();
        }

        private void sellUnitBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = sellUnitBtn.Height;
            sidePanel.Top = sellUnitBtn.Top;
            sidePanel.Left = sellUnitBtn.Left;
            sellUnitBtn.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = staffBtn.Height;
            sidePanel.Top = staffBtn.Top;
            sidePanel.Left = staffBtn.Left;
            staffBtn.BackColor = Color.FromArgb(46, 51, 73);
            staff1.BringToFront();

        }

        private void residenceBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = residenceBtn.Height;
            sidePanel.Top = residenceBtn.Top;
            sidePanel.Left = residenceBtn.Left;
            residenceBtn.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void checkinvoiceBtn_Leave(object sender, EventArgs e)
        {
            checkinvoiceBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void addpenaltyBtn_Leave(object sender, EventArgs e)
        {
            addpenaltyBtn.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void servicesBtn_Leave(object sender, EventArgs e)
        {
            servicesBtn.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void sellUnitBtn_Leave(object sender, EventArgs e)
        {
            sellUnitBtn.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void staffBtn_Leave(object sender, EventArgs e)
        {
            staffBtn.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void residenceBtn_Leave(object sender, EventArgs e)
        {
            residenceBtn.BackColor = Color.FromArgb(24, 30, 54);

        }

    }
}
