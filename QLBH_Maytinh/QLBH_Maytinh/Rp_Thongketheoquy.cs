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
    public partial class Thống_kê_doanh_thu_theo_quý : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Thống_kê_doanh_thu_theo_quý()
        {
            InitializeComponent();
        }

        private void Thống_kê_doanh_thu_theo_quý_Load(object sender, EventArgs e)
        {

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_rp_tktheoquy";
                cmd.Parameters.AddWithValue("@nam", Convert.ToInt32(mtxt_nam.Text.ToString()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Doanhthu_quy rp = new Doanhthu_quy();
                rp.SetDataSource(dt);
                try
                {
                    rp.SetParameterValue("nam", Convert.ToInt32(mtxt_nam.Text.ToString()));
                }
                catch { MessageBox.Show("Lỗi"); }

                rpdoanhthutheoquy.ReportSource = rp;
            }
        }
    }
}
