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
    public partial class Rp_Thongkehangbanchay : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Rp_Thongkehangbanchay()
        {
            InitializeComponent();
        }

        private void Rp_Thongkehangbanchay_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_rp_hanghoabanchay";
                //cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Rp_Hangbanchay rp = new Rp_Hangbanchay();
                rp.SetDataSource(dt);
                //try
                //{
                //    rp.SetParameterValue("diachi", txt_diachi.Text.ToString());
                //}
                //catch { MessageBox.Show("Lỗi"); }

                rphangbanchay.ReportSource = rp;
            }
        }
    }
}
