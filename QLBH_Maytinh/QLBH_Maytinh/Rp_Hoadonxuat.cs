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
    public partial class Rp_Hoadonxuat : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Rp_Hoadonxuat()
        {
            InitializeComponent();
        }
        string mahoadon,ngayhdx, tennhanvien, tongtienhoadon,tenkhachhang,diachikhachhang,sdtkhachhang;

        private void rphoadonxuat_Load(object sender, EventArgs e)
        {

        }

        public Rp_Hoadonxuat(string mahdx,string ngayxuat, string tennv, string tongtien, string tenkh, string diachikh, string sdtkh)
        {
            InitializeComponent();
            mahoadon = mahdx;
            ngayhdx = ngayxuat;
            tennhanvien = tennv;
            tongtienhoadon = tongtien;
            tenkhachhang = tenkh;
            diachikhachhang = diachikh;
            sdtkhachhang = sdtkh;

        }
        private void Rp_Hoadonxuat_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_rp_hoadonxuat";
                cmd.Parameters.AddWithValue("@mahdx", mahoadon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Rp_HDX rp = new Rp_HDX();
                rp.SetDataSource(dt);
                try
                {
                    rp.SetParameterValue("mahdx", mahoadon);
                    rp.SetParameterValue("ngayxuat", ngayhdx);
                    rp.SetParameterValue("tennv", tennhanvien);
                    rp.SetParameterValue("tongtien", tongtienhoadon);
                    rp.SetParameterValue("tenkh", tenkhachhang);
                    rp.SetParameterValue("diachikh", diachikhachhang);
                    rp.SetParameterValue("sdtkh", sdtkhachhang);
                }
                catch { MessageBox.Show("Lỗi"); }
                rphoadonxuat.ReportSource = rp;
            }
        }
    }
}
