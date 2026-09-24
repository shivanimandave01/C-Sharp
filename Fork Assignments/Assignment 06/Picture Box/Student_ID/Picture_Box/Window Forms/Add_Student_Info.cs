using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Picture_Box.Window_Forms;

namespace Picture_Box
{
    public partial class Frm_Add_Student_Info : Form
    {
        public Frm_Add_Student_Info()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FDL = new OpenFileDialog();

            FDL.Filter = "Image File *png,*jpg,*jpeg| *.jpg; *jpeg; *.png; *.bmp";

            if (FDL.ShowDialog() == DialogResult.OK)
            {
                pb_Photo.Image = Image.FromFile(FDL.FileName);
            }
        }

        private void btn_Browse_MouseHover(object sender, EventArgs e)
        {
            btn_Browse.Text = "Select Photo";
            btn_Browse.BackColor = Color.Red;
            btn_Browse.Width = 140;
        }

        private void btn_Browse_MouseLeave(object sender, EventArgs e)
        {
            btn_Browse.Text = "Browse";
            btn_Browse.BackColor = Color.Turquoise;
            btn_Browse.Width = 140;
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            Helper_Classes.Sql_Connection.SconStart();

            if(tb_Stud_Id.Text != "" && tb_Stud_Name.Text != "" && cmb_Course.SelectedIndex != -1 && cmb_Branch.SelectedIndex != -1 && cmb_Year.SelectedIndex != -1 && cmb_Gender.SelectedIndex != -1 && tb_Mobile_No.Text != "" && tb_Email_Id.Text != "" && tb_Address.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Helper_Classes.Sql_Connection.SCon;
                cmd.CommandText = "Insert into Student_Info values(@SId,@SNm,@DOB,@SCr,@SBr,@Yr,@Gdr,@SMno,@EId,@BGr,@ADR,@PH)";

                cmd.Parameters.Add("SId", SqlDbType.NVarChar).Value = tb_Stud_Id.Text;
                cmd.Parameters.Add("SNm", SqlDbType.VarChar).Value = tb_Stud_Name.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("SCr", SqlDbType.NVarChar).Value = cmb_Course.SelectedItem;
                cmd.Parameters.Add("SBr", SqlDbType.NVarChar).Value = cmb_Branch.SelectedItem;
                cmd.Parameters.Add("Yr", SqlDbType.NVarChar).Value = cmb_Year.SelectedItem;
                cmd.Parameters.Add("Gdr", SqlDbType.VarChar).Value = cmb_Gender.SelectedItem;
                cmd.Parameters.Add("SMno", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("EId", SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                cmd.Parameters.Add("BGr", SqlDbType.NVarChar).Value = cmb_Blood_Gr.SelectedItem;
                cmd.Parameters.Add("ADR", SqlDbType.NVarChar).Value = tb_Address.Text;

                ImageConverter IC = new ImageConverter();

                Byte[] ImgArray = (byte[])IC.ConvertTo(pb_Photo.Image, typeof(byte[]));

                cmd.Parameters.Add("PH", SqlDbType.Image).Value = ImgArray;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Information Save SuccessFully ", "SUCCESS");

                Helper_Classes.Sql_Connection.SconStop();
            }
            else
            {
                MessageBox.Show("Fill All Information of Student", "Failure");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Frm_Search obj = new Frm_Search();
            obj.Show();
            this.Hide();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Stud_Name.Clear();
            tb_Stud_Id.Clear();
            tb_Mobile_No.Clear();
            tb_Email_Id.Clear();
            tb_Address.Clear();
            cmb_Course.SelectedIndex = -1;
            cmb_Branch.SelectedIndex = -1;
            cmb_Gender.SelectedIndex = -1;
            cmb_Year.SelectedIndex = -1;
            cmb_Blood_Gr.SelectedIndex = -1;
            pb_Photo.Image = null;
        }
    }
}
