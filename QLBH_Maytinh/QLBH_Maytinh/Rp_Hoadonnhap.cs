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
    public partial class Rp_Hoadonnhap : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Rp_Hoadonnhap()
        {
            InitializeComponent();
        }
        string mahoadon, tennhanvien, tongtienhoadon,ngaynhaphang;
        public Rp_Hoadonnhap(string mahdn, string tennv, string tongtien,string ngaynhap)
        {
            InitializeComponent();
            mahoadon = mahdn;
            tennhanvien = tennv;
            tongtienhoadon = tongtien;
            ngaynhaphang = ngaynhap;
        }
        private void Rp_Hoadonnhap_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_rp_hoadonnhap";
                cmd.Parameters.AddWithValue("@mahdn", mahoadon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Rp_HDN rp = new Rp_HDN();
                rp.SetDataSource(dt);
                try
                {
                    rp.SetParameterValue("mahdn", mahoadon);
                    rp.SetParameterValue("tennv", tennhanvien);
                    rp.SetParameterValue("tongtien", tongtienhoadon);
                    rp.SetParameterValue("ngaynhap", ngaynhaphang);
                }
                catch { MessageBox.Show("Lỗi"); }
                rphoadonnhap.ReportSource = rp;
            }
        }
    }
}
