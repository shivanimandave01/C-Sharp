using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box.Window_Forms
{
    public partial class Frm_Search : Form
    {
        public Frm_Search()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_Stud_Id.Text != "")
            {
                Helper_Classes.Sql_Connection.SconStart();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Helper_Classes.Sql_Connection.SCon;
                cmd.CommandText = "Select * from Student_Info where Student_Id =@SId";

                cmd.Parameters.Add("SId", SqlDbType.NVarChar).Value = tb_Stud_Id.Text;

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    lbl_tb_Id.Text = DR.GetString(DR.GetOrdinal("Student_ID"));
                    lbl_tb_Name.Text= DR.GetString(DR.GetOrdinal("Student_Name"));
                    lbl_tb_Course.Text= DR.GetString(DR.GetOrdinal("Course"));
                    lbl_tb_Branch.Text = DR.GetString(DR.GetOrdinal("Branch"));
                    lbl_tb_Year.Text = DR.GetString(DR.GetOrdinal("Year"));
                    lbl_tb_Mob_No.Text = (DR["Mobile_No"].ToString());
                    lbl_tb_DOB.Text = (DR["DOB"].ToString());
                    if (DR["Photo"] != DBNull.Value)
                    {
                        byte[] img = (byte[])DR["Photo"];

                        using (MemoryStream ms = new MemoryStream(img))
                        {
                            pb_Photo.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pb_Photo.Image = null;
                    }
                }

                MessageBox.Show("Invalid Student ID", "Error");

                Helper_Classes.Sql_Connection.SconStop();

            }
            else
            {
                MessageBox.Show("Enter Student Id", "Fill");
            }
        }
    }
}
