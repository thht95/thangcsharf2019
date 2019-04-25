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
    public partial class ChitietHDX : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public ChitietHDX()
        {
            InitializeComponent();
        }
        public ChitietHDX(string ma, string manv, string ngayxuat, string tongtien, string tennv, string tenkh, string diachikh, string sdtkh)
        {
            InitializeComponent();
            txt_mahdx.Text = ma;
            txt_manv.Text = manv;
         //   date_chitiethdx.Text = ngayxuat;
            txt_tongtien.Text = tongtien;
            txt_tennv.Text = tennv;
            txt_tenkh.Text = tenkh;
            txt_diachikh.Text = diachikh;
            txt_sdtkh.Text = sdtkh;
        }

        private void load_datagrid()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlselect = "Select hanghoa.mahh,tenhh,slxuat,giaxuat,thanhtien from hanghoa inner join hanghoa_xuat on hanghoa.mahh = hanghoa_xuat.mahh where mahdx ='" + txt_mahdx.Text + "'";
                using (SqlCommand cmd = new SqlCommand(sqlselect, cnn))
                // 
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        datagrid_chitiethdn.DataSource = dt;

                        datagrid_chitiethdn.Columns["mahh"].HeaderText = "Mã hàng";
                        datagrid_chitiethdn.Columns["tenhh"].HeaderText = "Tên hàng";
                        datagrid_chitiethdn.Columns["slxuat"].HeaderText = "Số lượng";
                        datagrid_chitiethdn.Columns["giaxuat"].HeaderText = "Giá xuất";
                        datagrid_chitiethdn.Columns["thanhtien"].HeaderText = "Thành tiền";
                    }
                }
            }
        }
        private void ChitietHDX_Load(object sender, EventArgs e)
        {
            load_datagrid();
            date_chitiethdx.Format = DateTimePickerFormat.Custom;
            date_chitiethdx.CustomFormat = "dd/MM/yyyy";
            txt_mahdx.Enabled = txt_manv.Enabled = txt_tennv.Enabled = txt_tongtien.Enabled = date_chitiethdx.Enabled
                = txt_tenkh.Enabled= txt_diachikh.Enabled = txt_sdtkh.Enabled= false;
        }

        private void txt_tenkh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
