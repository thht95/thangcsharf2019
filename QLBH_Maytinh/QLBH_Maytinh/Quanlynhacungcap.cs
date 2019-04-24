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
    public partial class Quanlynhacungcap : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Quanlynhacungcap()
        {
            InitializeComponent();
        }
        private void load_datagrid()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from nhacungcap", cnn))
                // 
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        datagrid_nhacungcap.DataSource = dt;
                    }
                }
            }
        }

        private void Quanlynhacungcap_Load(object sender, EventArgs e)
        {
            txt_sdt.Clear();
            txt_mancc.Clear();
            txt_tenncc.Clear();
            txt_diachi.Clear();
            load_datagrid();
            btn_sua.Enabled = btn_xoa.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagrid_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Tag = btn_xoa.Tag = datagrid_nhacungcap.Rows[e.RowIndex].Cells["mancc"].Value.ToString();
            btn_sua.Enabled = btn_xoa.Enabled = true;
            txt_mancc.Text = (datagrid_nhacungcap.Rows[e.RowIndex].Cells["mancc"].Value.ToString());
            txt_tenncc.Text = (datagrid_nhacungcap.Rows[e.RowIndex].Cells["tenncc"].Value.ToString());
            txt_diachi.Text = (datagrid_nhacungcap.Rows[e.RowIndex].Cells["diachi"].Value.ToString());
            txt_sdt.Text = (datagrid_nhacungcap.Rows[e.RowIndex].Cells["sdt"].Value.ToString());
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            Quanlynhacungcap_Load(sender,e);
        }
        private void themncc()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("them_NCC", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@tenncc", txt_tenncc.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text.Trim().ToString());
                    cmd.ExecuteNonQuery();

                }
            }
        }
        private int checkmancc()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSelect = ("select * from nhacungcap where mancc='" + txt_mancc.Text + "'");
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checkmancc() == 1)
            {
                themncc();
                MessageBox.Show("Thêm nhà cung cấp thành công");
                load_datagrid();
            }
            else
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại");
            }

        }
        private int suancc()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("update_ncc", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mancc", btn_sua.Tag);
                    cmd.Parameters.AddWithValue("@tenncc", txt_tenncc.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text.Trim().ToString());
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }
            }
        }
        private int xoancc()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("xoa_ncc", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mancc", btn_xoa.Tag);
                    int i = cmd.ExecuteNonQuery();
                    //Form1_Load(sender, e);
                    return i;
                }
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (suancc() > 0)
            {
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công");
                load_datagrid();
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhà cung cấp thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (xoancc() > 0)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    load_datagrid();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }
            }
        }
        private DataTable Laydanhsach(string sFilter)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSelect = "Select * from nhacungcap where" + sFilter;
                using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable t = new DataTable("nhacungcap");
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
            if (!string.IsNullOrEmpty(txt_mancc.Text.Trim()))
            {
                sFilter += string.Format("and mancc = '{0}'", txt_mancc.Text.Trim().ToString());
                datagrid_nhacungcap.DataSource = Laydanhsach(sFilter);
                txt_mancc.Focus();
            }
            if (!string.IsNullOrEmpty(txt_tenncc.Text.Trim()))
            {
                sFilter += string.Format("and tenncc like N'%{0}%'", txt_tenncc.Text.Trim().ToString());
                datagrid_nhacungcap.DataSource = Laydanhsach(sFilter);
                txt_tenncc.Focus();
            }
            if (!string.IsNullOrEmpty(txt_diachi.Text.Trim()))
            {
                sFilter += string.Format("and diachi like N'%{0}%'", txt_diachi.Text.Trim().ToString());
                datagrid_nhacungcap.DataSource = Laydanhsach(sFilter);
                txt_diachi.Focus();
            }
            if (!string.IsNullOrEmpty(txt_sdt.Text.Trim()))
            {
                sFilter += string.Format("and sdt = '{0}'", txt_sdt.Text.Trim().ToString());
                datagrid_nhacungcap.DataSource = Laydanhsach(sFilter);
                txt_sdt.Focus();
            }
        }
    }
}
