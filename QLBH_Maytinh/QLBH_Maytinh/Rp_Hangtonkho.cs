using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_Maytinh
{
    public partial class Rp_Hangtonkho : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Rp_Hangtonkho()
        {
            InitializeComponent();
        }

        private void Rp_Hangtonkho_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_rp_thongkehangton";
                //cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Rp_Hangton rp = new Rp_Hangton();
                rp.SetDataSource(dt);
                //try
                //{
                //    rp.SetParameterValue("diachi", txt_diachi.Text.ToString());
                //}
                //catch { MessageBox.Show("Lỗi"); }

                rphangton.ReportSource = rp;
            }
        }
    }
}
