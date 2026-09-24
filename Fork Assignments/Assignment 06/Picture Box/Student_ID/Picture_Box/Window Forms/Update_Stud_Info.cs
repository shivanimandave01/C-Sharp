using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box.Window_Forms
{
    public partial class Frm_Update_Stud_Info : Form
    {
        public Frm_Update_Stud_Info()
        {
            InitializeComponent();
        }

        private void btn_Remove_Photo_Click(object sender, EventArgs e)
        {
            pb_Photo.Image = null;
        }
    }
}
