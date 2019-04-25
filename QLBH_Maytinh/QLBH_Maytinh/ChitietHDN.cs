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
    public partial class ChitietHDN : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public ChitietHDN()
        {
            InitializeComponent();
        }

        public ChitietHDN(string ma, string manv, string ngaynhap, string tongtien,string tennv)
        {
            InitializeComponent();
            txt_mahdn.Text = ma;
            txt_manv.Text = manv;
            //date_chitiethdn.Text = ngaynhap;
            txt_tongtien.Text = tongtien;
            txt_tennv.Text = tennv;
        }

        public string set_mahdn { set { txt_mahdn.Text = value; } }
        public string set_ngaynhap { set { date_chitiethdn.Text = value; } }
        public string set_tongtien { set { txt_tongtien.Text = value; } }
        public string set_manv { set { txt_manv.Text = value; } }
        //public string set_tennv { set { txt_matennv.Text = value; } }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void load_datagrid()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlselect = "Select hanghoa.mahh,tenhh,slnhap,gianhap,thanhtien from hanghoa inner join hanghoa_nhap on hanghoa.mahh = hanghoa_nhap.mahh where mahdn ='"+txt_mahdn.Text+"'";
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
                        datagrid_chitiethdn.Columns["slnhap"].HeaderText = "Số lượng";
                        datagrid_chitiethdn.Columns["gianhap"].HeaderText = "Giá nhập";
                        datagrid_chitiethdn.Columns["thanhtien"].HeaderText = "Thành tiền";
                    }
                }
            }
        }
        //private void load_tennv()
        //{
        //    using (SqlConnection cnn = new SqlConnection(constr))
        //    {
        //        string sqlselect = "select tennv from nhanvien where manv='" + txt_manv + "'";
        //        using (SqlCommand cmd = new SqlCommand(sqlselect, cnn))
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            cnn.Open();
        //            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //            {
        //                DataTable dt = new DataTable();
        //                da.Fill(dt);
        //                txt_tennv.Text = dt.Rows[0].ToString();
        //            }
        //        }
        //    }
        //}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChitietHDN_Load(object sender, EventArgs e)
        {
            load_datagrid();
            //load_tennv();
            date_chitiethdn.Format = DateTimePickerFormat.Custom;
            date_chitiethdn.CustomFormat = "dd/MM/yyyy";
            txt_mahdn.Enabled = txt_manv.Enabled = txt_tennv.Enabled = txt_tongtien.Enabled = date_chitiethdn.Enabled = false;
        }
    }
}
