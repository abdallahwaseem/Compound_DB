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
    public partial class Entrance_code : UserControl
    {
        Resident_controller controllerObj;
        int R_id;
        string Email;
        string R_Name;
        DateTime dateNow;
        public Entrance_code(int id, string name, string email)
        {
            InitializeComponent();
            R_id = id;
            R_Name = name;
            Email = email;
            dateNow = DateTime.Now;
            controllerObj = new Resident_controller();
            EntranceCode.Hide();
            CodeTxtbox.Hide();
        }

        private void Entrance_code_Load(object sender, EventArgs e)
        {

        }

        private void confrim_btn_Click(object sender, EventArgs e)
        {
            if (Visitor_NametxtBox.Text=="")
            {
                MessageBox.Show("Please Enter visitor Name");
                return;
            }
            if (Visit_Datepicker.Value < dateNow)
            {
                MessageBox.Show("Must Enter a date in the future");
                return;
            }
            int SimilarCode = controllerObj.getSimilarEntranceCodes(R_id, Visitor_NametxtBox.Text, Visit_Datepicker.Value);
            if (SimilarCode != 0)
            {
                MessageBox.Show("Cant proceed: You have an existing code for same visitor on the same date!!");
                return;
            }
            int Result = controllerObj.InsertInEntranceReq(R_id, Visitor_NametxtBox.Text, Visit_Datepicker.Value);
            if (Result == 0)
            {
                MessageBox.Show("Entrance code failure");
                return;
            }
            else
            {
                MessageBox.Show("Entrance code created");
            }
            DataTable Entrance_code = controllerObj.getEntranceCode(R_id, Visitor_NametxtBox.Text, Visit_Datepicker.Value);
            //int.TryParse(Entrance_code.Rows[0]["Entrance_Code"].ToString(), out int code);
            int code = Convert.ToInt32(Entrance_code.Rows[0]["Entrance_Code"].ToString());
            CodeTxtbox.Text = code.ToString();
            EntranceCode.Show();
            CodeTxtbox.Show();
        }

        private void Visitor_NametxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("numbers not allowed");
            }
        }
    }
}
