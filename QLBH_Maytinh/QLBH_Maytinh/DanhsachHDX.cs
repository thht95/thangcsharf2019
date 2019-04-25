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
    public partial class DanhsachHDX : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public DanhsachHDX()
        {
            InitializeComponent();
        }
        private void load_datagrid()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select mahdx,tenkh, diachikh,sdtkh, ngayxuat, hoadonxuat.manv, nhanvien.tennv, tongtien from hoadonxuat,nhanvien where hoadonxuat.manv = nhanvien.manv", cnn))
                // 
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        datagrid_hdx.DataSource = dt;

                        //datagrid_hdx.Columns["mahdx"].HeaderText = "Mã hóa đơn nhập";
                        //datagrid_hdx.Columns["tenkh"].HeaderText = "Tên KH";
                        //datagrid_hdx.Columns["diachikh"].HeaderText = "Địa chỉ KH";
                        //datagrid_hdx.Columns["sdtkh"].HeaderText = "SĐT KH";
                        //datagrid_hdx.Columns["ngayxuat"].HeaderText = "Ngày xuất";
                        //datagrid_hdx.Columns["manv"].HeaderText = "Mã nhân viên";
                        //datagrid_hdx.Columns["tennv"].HeaderText = "Tên nhân viên";
                        //datagrid_hdx.Columns["tongtien"].HeaderText = "Tổng tiền";
                    }
                }
            }
        }
        private void DanhsachHDX_Load(object sender, EventArgs e)
        {
            load_datagrid();
            txt_tongtien.Enabled = txt_manv.Enabled = date_ngayxuat.Enabled = txt_mahdx.Enabled = false;
            txt_mahdx.Clear();
            txt_manv.Clear();
            txt_tongtien.Clear();
            this.date_ngayxuat.Value = DateTime.Now;
            load_datagrid();
            date_ngayxuat.Format = DateTimePickerFormat.Custom;
            date_ngayxuat.CustomFormat = "dd/MM/yyyy";
            btn_xemchitiet.Enabled = btn_xoa.Enabled = false;
        }
        string tennv, tenkh, diachikh, sdtkh;

        private int xoahdx()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Xoa_HD_Xuat", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahdx", btn_xoa.Tag);
                    int i = cmd.ExecuteNonQuery();
                    //Form1_Load(sender, e);
                    return i;
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (xoahdx() > 0)
                {
                    MessageBox.Show("Xóa hóa đơn xuất thành công");
                    load_datagrid();
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn xuất thất bại");
                    load_datagrid();
                }
            }
        }

        //private void btn_baocao_Click(object sender, EventArgs e)
        //{
        //    Rp_Hoadonxuat frm = new Rp_Hoadonxuat(txt_mahdx.Text.ToString(),date_ngayxuat.Text.ToString(), tennv.ToString(),txt_tongtien.Text.ToString(), tenkh.ToString(), diachikh.ToString(), sdtkh.ToString());
        //    frm.ShowDialog();
        //}

        private void datagrid_hdx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_xemchitiet.Tag = btn_xoa.Tag = datagrid_hdx.Rows[e.RowIndex].Cells["mahdx"].Value.ToString();
            btn_xemchitiet.Enabled = btn_xoa.Enabled = true;
            txt_mahdx.Text = (datagrid_hdx.Rows[e.RowIndex].Cells["mahdx"].Value.ToString());
            date_ngayxuat.Text = (datagrid_hdx.Rows[e.RowIndex].Cells["ngayxuat"].Value.ToString());
            txt_tongtien.Text = (datagrid_hdx.Rows[e.RowIndex].Cells["tongtien"].Value.ToString());
            txt_manv.Text = (datagrid_hdx.Rows[e.RowIndex].Cells["manv"].Value.ToString());
            tennv = (datagrid_hdx.Rows[e.RowIndex].Cells["tennv"].Value.ToString());
            tenkh = (datagrid_hdx.Rows[e.RowIndex].Cells["tenkh"].Value.ToString());
            diachikh = (datagrid_hdx.Rows[e.RowIndex].Cells["diachikh"].Value.ToString());
            sdtkh = (datagrid_hdx.Rows[e.RowIndex].Cells["sdtkh"].Value.ToString());

        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            DanhsachHDX_Load(sender,e);
        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            ChitietHDX frm = new ChitietHDX(btn_xemchitiet.Tag.ToString(),
                txt_manv.Text, date_ngayxuat.Text,txt_tongtien.Text, tennv.ToString(),tenkh.ToString(),diachikh.ToString(),sdtkh.ToString());
            //string ma, string manv, string ngayxuat, string tongtien, string tennv, string tenkh, string diachikh, string sdtkh
            frm.ShowDialog();
        }
    }
}
