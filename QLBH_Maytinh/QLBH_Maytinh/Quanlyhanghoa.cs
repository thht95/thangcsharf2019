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
    public partial class Quanlyhanghoa : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Quanlyhanghoa()
        {
            InitializeComponent();
        }
        private void load_datagrid()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select mahh,tenhh,loaihang,soluong,tenncc from hanghoa,nhacungcap where hanghoa.mancc=nhacungcap.mancc", cnn))
                // 
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        datagrid_hanghoa.DataSource = dt;
                    }
                }
            }
        }
        private void lb_ncc_Click(object sender, EventArgs e)
        {

        }

        private void cb_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Quanlyhanghoa_Load(object sender, EventArgs e)
        {
            txt_mahang.Clear();
            txt_tenhang.Clear();
            txt_nhomhang.Clear();
            txt_soluong.Clear();
            load_datagrid();
            cbbox_load();
            btn_sua.Enabled = btn_xoa.Enabled = false;
            txt_soluong.Enabled = true;
        }
        private int checkmahh()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSelect = ("select * from hanghoa where mahh='" + txt_mahang.Text + "'");
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
        private void themhh()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("pr_nhaphang", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahh",txt_mahang.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@tenhh", txt_tenhang.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@loaihang", txt_nhomhang.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@soluong", txt_soluong.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@mancc", cb_nhacungcap.SelectedValue.ToString());  /**/
                    cmd.ExecuteNonQuery();

                }
            }
        }
        private void datagrid_hanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Tag = btn_xoa.Tag = datagrid_hanghoa.Rows[e.RowIndex].Cells["mahh"].Value.ToString();
            btn_sua.Enabled = btn_xoa.Enabled = true;
            txt_mahang.Text = (datagrid_hanghoa.Rows[e.RowIndex].Cells["mahh"].Value.ToString());
            txt_tenhang.Text = (datagrid_hanghoa.Rows[e.RowIndex].Cells["tenhh"].Value.ToString());
            txt_nhomhang.Text = (datagrid_hanghoa.Rows[e.RowIndex].Cells["loaihang"].Value.ToString());
            txt_soluong.Text = (datagrid_hanghoa.Rows[e.RowIndex].Cells["soluong"].Value.ToString());
            cb_nhacungcap.Text =
                datagrid_hanghoa.Rows[e.RowIndex].Cells["tenncc"].Value.ToString();
        }
        private void cbbox_load()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from nhacungcap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cb_nhacungcap.DataSource = dt;
                        cb_nhacungcap.DisplayMember = "tenncc";
                        cb_nhacungcap.ValueMember = "mancc";

                    }
                }
            }
        }
        private int suahh()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("update_hh", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahh", btn_sua.Tag);
                    cmd.Parameters.AddWithValue("@tenhh", txt_tenhang.Text.Trim());
                    cmd.Parameters.AddWithValue("@loaihang", txt_nhomhang.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(txt_soluong.Text.Trim().ToString()));
                    cmd.Parameters.AddWithValue("@mancc", cb_nhacungcap.SelectedValue.ToString());
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checkmahh() == 1)
            {
                themhh();
                MessageBox.Show("Thêm hàng hóa thành công");
                load_datagrid();
            }
            else
            {
                MessageBox.Show("Mã hàng hóa đã tồn tại");
            }
                
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (suahh() > 0)
            {
                MessageBox.Show("Sửa thông tin hàng hóa thành công");
                load_datagrid();
            }
            else
            {
                MessageBox.Show("Sửa thông tin hàng hóa thất bại");
                load_datagrid();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            Quanlyhanghoa_Load(sender,e);
        }
        private int xoanv()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("xoahh", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahh", btn_xoa.Tag);
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
                if (xoanv() > 0)
                {
                    MessageBox.Show("Xóa hàng hóa thành công");
                    load_datagrid();
                }
                else
                {
                    MessageBox.Show("Xóa hàng hóa thất bại");
                    load_datagrid();
                }
            }
        }
        private DataTable Laydanhsach(string sFilter)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSelect = "Select mahh,tenhh,loaihang,soluong,tenncc from hanghoa inner join nhacungcap on hanghoa.mancc=nhacungcap.mancc where" + sFilter;
                using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable t = new DataTable("hanghoa");
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
            if (!string.IsNullOrEmpty(txt_mahang.Text.Trim()))
            {
                sFilter += string.Format("and mahh = '{0}'",txt_mahang.Text.Trim().ToString());
                datagrid_hanghoa.DataSource = Laydanhsach(sFilter);
                txt_mahang.Focus();
            }
            if (!string.IsNullOrEmpty(txt_tenhang.Text.Trim()))
            {
                sFilter += string.Format("and tenhh like N'%{0}%'", txt_tenhang.Text.Trim().ToString());
                datagrid_hanghoa.DataSource = Laydanhsach(sFilter);
                txt_tenhang.Focus();
            }
            if (!string.IsNullOrEmpty(txt_nhomhang.Text.Trim()))
            {
                sFilter += string.Format("and loaihang = '{0}'", txt_nhomhang.Text.Trim().ToString());
                datagrid_hanghoa.DataSource = Laydanhsach(sFilter);
                txt_nhomhang.Focus();
            }
            if (!string.IsNullOrEmpty(cb_nhacungcap.Text.Trim()))
            {
                sFilter += string.Format("and tenncc = '{0}'", cb_nhacungcap.Text.ToString());
                datagrid_hanghoa.DataSource = Laydanhsach(sFilter);
                cb_nhacungcap.Focus();
            }
        }
    }
}

