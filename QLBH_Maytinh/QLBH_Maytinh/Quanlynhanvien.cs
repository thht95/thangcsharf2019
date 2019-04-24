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
    public partial class Quanlynhanvien : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Quanlynhanvien()
        {
            InitializeComponent();
        }

        private void lb_tennv_Click(object sender, EventArgs e)
        {

        }

        private void lb_diachi_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load_datagrid()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select manv,tennv,ngaysinh,case gioitinh when N'Nam' then 'true' when N'Nữ' then 'false' end as 'gioitinh',diachi,sdt,cmnd from nhanvien", cnn))
                // 
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        datagrid_nhanvien.DataSource = dt;

                        //datagrid_nhanvien.Columns["manv"].HeaderText = "Mã NV";
                        //datagrid_nhanvien.Columns["tennv"].HeaderText = "Họ tên";
                        //datagrid_nhanvien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                        //datagrid_nhanvien.Columns["gioitinh"].HeaderText = "Giới tính";
                        //datagrid_nhanvien.Columns["diachi"].HeaderText = "Địa chỉ";
                        //datagrid_nhanvien.Columns["sdt"].HeaderText = "SĐT";
                        //datagrid_nhanvien.Columns["cmnd"].HeaderText = "CMND";
                    }
                }
            }
        }
        private void themnv()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("themnv", cnn))
                {
                    cnn.Open();
                    string[] a = datetime_nv.Value.Date.ToString().Split('/');
                    string b = a[1] + "/" + a[0] + "/" + a[2];
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manv", txt_manv.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@tennv", txt_tennv.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngaysinh", b);
                    cmd.Parameters.AddWithValue("@gioitinh", rdbtn_nam.Checked == true ? "nam" : "nu");
                    cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@cmnd", mtxt_cmnd.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text.Trim().ToString());
                    cmd.ExecuteNonQuery();

                }
            }
        }
        private int checkmanv()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSelect = ("select * from nhanvien where manv='" + txt_manv.Text+"'");
                using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            rd.Close();
                            return 0;
                        }
                        cnn.Close();
                        return 1;
                    }
                }
            }
        }
        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {
            txt_manv.Clear();
            txt_tennv.Clear();
            this.datetime_nv.Value = DateTime.Now;
            rdbtn_nam.Checked = true;
            txt_diachi.Clear();
            txt_sdt.Clear();
            mtxt_cmnd.Clear();
            btn_sua.Enabled = btn_xoa.Enabled = false;
            load_datagrid();
            datetime_nv.Format = DateTimePickerFormat.Custom;
            datetime_nv.CustomFormat = "dd/MM/yyyy";
        }
        private int xoanv()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("xoanv", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manv", btn_xoa.Tag);
                    int i = cmd.ExecuteNonQuery();
                    //Form1_Load(sender, e);
                    return i;
                }
            }
        }
        private int suasv()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sua_nv", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manv", btn_sua.Tag);
                    cmd.Parameters.AddWithValue("@tennv", txt_tennv.Text.Trim());
                    string[] a = datetime_nv.Value.Date.ToString().Split('/');
                    string b = a[1] + "/" + a[0] + "/" + a[2];
                    cmd.Parameters.AddWithValue("@ngaysinh", b);
                    cmd.Parameters.AddWithValue("@gioitinh", rdbtn_nam.Checked == true ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@cmnd", mtxt_cmnd.Text.Trim().ToString());
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (checkmanv() == 1)
            {
                themnv();
                MessageBox.Show("Thêm nhân viên thành công");
                load_datagrid();
            }
            else
                MessageBox.Show("Mã nhân viên đã tồn tại");
        }

        private void txt_manv_Validating(object sender, CancelEventArgs e)
        {
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            Quanlynhanvien_Load(sender,e);
        }

        private void datagrid_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Tag = btn_xoa.Tag = datagrid_nhanvien.Rows[e.RowIndex].Cells["manv"].Value.ToString();
            btn_sua.Enabled = btn_xoa.Enabled = true;
            txt_manv.Text = (datagrid_nhanvien.Rows[e.RowIndex].Cells["manv"].Value.ToString());
            txt_tennv.Text = (datagrid_nhanvien.Rows[e.RowIndex].Cells["tennv"].Value.ToString());
            datetime_nv.Text = (datagrid_nhanvien.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString());
            if (datagrid_nhanvien.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString().Trim().Equals("true") == true)
            {
                rdbtn_nam.Checked = true;

            }
            else
            {

                rdbtn_nu.Checked = true;
            }
            txt_diachi.Text = (datagrid_nhanvien.Rows[e.RowIndex].Cells["diachi"].Value.ToString());
            txt_sdt.Text = (datagrid_nhanvien.Rows[e.RowIndex].Cells["sdt"].Value.ToString());
            mtxt_cmnd.Text = (datagrid_nhanvien.Rows[e.RowIndex].Cells["cmnd"].Value.ToString());
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (xoanv() > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    load_datagrid();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                    load_datagrid();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (suasv() > 0)
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công");
                load_datagrid();
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại");
                load_datagrid();
            }
        }
        private DataTable Laydanhsach(string sFilter)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSelect = "Select manv,tennv,ngaysinh,gioitinh,diachi,sdt,cmnd from nhanvien where" + sFilter;
                using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable t = new DataTable("nhanvien");
                        da.Fill(t);
                        cnn.Close();
                        return t;
                    }
                }
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string sFilter = " 1>0 ";
            if (!string.IsNullOrEmpty(txt_manv.Text.Trim()))
            {
                sFilter += string.Format("and manv = '{0}'", txt_manv.Text.Trim().ToString());
                datagrid_nhanvien.DataSource = Laydanhsach(sFilter);
                txt_manv.Focus();
            }
            if (!string.IsNullOrEmpty(txt_tennv.Text.Trim()))
            {
                sFilter += string.Format("and tennv like N'%{0}%'", txt_tennv.Text.Trim().ToString());
                datagrid_nhanvien.DataSource = Laydanhsach(sFilter);
                txt_tennv.Focus();
            }


            if (!string.IsNullOrEmpty(txt_diachi.Text.Trim()))
            {
                sFilter += string.Format("and diachi like N'%{0}%'", txt_diachi.Text.Trim().ToString());
                datagrid_nhanvien.DataSource = Laydanhsach(sFilter);
                txt_diachi.Focus();
            }
            if (!string.IsNullOrEmpty(txt_sdt.Text.Trim()))
            {
                sFilter += string.Format("and sdt like N'%{0}%'", txt_sdt.Text.Trim().ToString());
                datagrid_nhanvien.DataSource = Laydanhsach(sFilter);
                txt_sdt.Focus();
            }
            if (!string.IsNullOrEmpty(mtxt_cmnd.Text.Trim()))
            {
                sFilter += string.Format("and cmnd like N'%{0}%'", mtxt_cmnd.Text.Trim().ToString());
                datagrid_nhanvien.DataSource = Laydanhsach(sFilter);
                mtxt_cmnd.Focus();
            }
        }
    }
}
