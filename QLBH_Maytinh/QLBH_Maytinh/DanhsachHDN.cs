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
    public partial class DanhsachHDN : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public DanhsachHDN()
        {
            InitializeComponent();
        }
        private void load_datagrid()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select mahdn,ngaynhap, hoadonnhap.manv,nhanvien.tennv, tongtien from hoadonnhap,nhanvien where hoadonnhap.manv = nhanvien.manv", cnn))
                // 
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        datagrid_hdn.DataSource = dt;

                        //datagrid_hdn.Columns["mahdn"].HeaderText = "Mã hóa đơn nhập";
                        //datagrid_hdn.Columns["ngaynhap"].HeaderText = "Ngày nhập";
                        //datagrid_hdn.Columns["manv"].HeaderText = "Mã nhân viên";
                        //datagrid_hdn.Columns["tennv"].HeaderText = "Tên nhân viên";
                        //datagrid_hdn.Columns["tongtien"].HeaderText = "Tổng tiền";
                    }
                }
            }
        }
        private int xoahdn()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Xoa_HD_Nhap", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahdn", btn_xoa.Tag);
                    int i = cmd.ExecuteNonQuery();
                    //Form1_Load(sender, e);
                    return i;
                }
            }
        }
        private void datagrid_hdn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhsachHDN_Load(object sender, EventArgs e)
        {
            txt_tongtien.Enabled = txt_manv.Enabled = date_ngaynhap.Enabled = txt_mahdn.Enabled = false;
            txt_mahdn.Clear();
            txt_manv.Clear();
            txt_tongtien.Clear();
            this.date_ngaynhap.Value = DateTime.Now;
            load_datagrid();
            date_ngaynhap.Format = DateTimePickerFormat.Custom;
            date_ngaynhap.CustomFormat = "dd/MM/yyyy";
            btn_xemchitiet.Enabled = btn_xoa.Enabled = false;
        }
        string manv,ngaynhap,tongtien,tennv;
        
        private void datagrid_hdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_xemchitiet.Tag = btn_xoa.Tag = datagrid_hdn.Rows[e.RowIndex].Cells["mahdn"].Value.ToString();
            btn_xemchitiet.Enabled = btn_xoa.Enabled = true;
            txt_mahdn.Text = (datagrid_hdn.Rows[e.RowIndex].Cells["mahdn"].Value.ToString());
            date_ngaynhap.Text = (datagrid_hdn.Rows[e.RowIndex].Cells["ngaynhap"].Value.ToString());
            txt_tongtien.Text = (datagrid_hdn.Rows[e.RowIndex].Cells["tongtien"].Value.ToString());
            txt_manv.Text = (datagrid_hdn.Rows[e.RowIndex].Cells["manv"].Value.ToString());
            manv = txt_manv.Text;
            ngaynhap = date_ngaynhap.Text;
            tongtien = txt_tongtien.Text;
            tennv = (datagrid_hdn.Rows[e.RowIndex].Cells["tennv"].Value.ToString());
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            DanhsachHDN_Load(sender,e);
        }
        public string get_mahdn { get { return txt_mahdn.Text; } }
        public string get_ngaynhap { get { return date_ngaynhap.Text.ToString(); } }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (xoahdn() > 0)
                {
                    MessageBox.Show("Xóa hóa đơn nhập thành công");
                    load_datagrid();
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn nhập thất bại");
                    load_datagrid();
                }
            }
        }

        //private void btn_baocao_Click(object sender, EventArgs e)
        //{
        //    Rp_Hoadonnhap frm = new Rp_Hoadonnhap(txt_mahdn.Text.ToString(),tennv.ToString(),txt_tongtien.Text.ToString(), date_ngaynhap.Text.ToString());
        //    frm.ShowDialog();
        //}

        public string get_tongtien { get { return txt_tongtien.Text; } }
        public string get_manv { get { return txt_manv.Text; } }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            ChitietHDN frm = new ChitietHDN(btn_xemchitiet.Tag.ToString() , manv.ToString(), ngaynhap.ToString(),tongtien.ToString(),tennv.ToString());
            //frm.set_mahdn = get_mahdn;//gán giá trị của thuộc tính mã hóa đơn của DSHĐN cho txt_mahdn của ChitietHDN
            //frm.set_ngaynhap = get_ngaynhap;
            //frm.set_tongtien = get_tongtien;
            //frm.set_manv = get_manv;
            frm.ShowDialog();
        }
    }
}
