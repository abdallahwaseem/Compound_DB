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
        public Entrance_code()
        {
            InitializeComponent();
            EntranceCode.Hide();
            CodeTxtbox.Hide();
        }

        private void Entrance_code_Load(object sender, EventArgs e)
        {

        }

        private void confrim_btn_Click(object sender, EventArgs e)
        {
            EntranceCode.Show();
            CodeTxtbox.Show();
        }
    }
}
