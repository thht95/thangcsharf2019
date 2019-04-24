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
    public partial class Banhang : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Banhang()
        {
            InitializeComponent();
        }

        private void Banhang_Load(object sender, EventArgs e)
        {
            cbbox_load();
            cbbox_load1();
            txt_nhacungcap.Enabled = false;
            txt_mahang.Enabled = false;
            txt_thanhtien.Enabled = false;
            txt_tongtien.Enabled = false;
            btn_xoads.Enabled = false;
            //btn_taohdn.Enabled = false;
            //buttonTao_Enable();
            date_hdx.Format = DateTimePickerFormat.Custom;
            date_hdx.CustomFormat = "dd/MM/yyyy";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int soluongkho;
        private void cb_tenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cb_tenhang.SelectedItem as DataRowView;
            if (row != null)
            {
                txt_mahang.Text = row["mahh"].ToString();
                txt_nhacungcap.Text = row["tenncc"].ToString();
                soluongkho = Convert.ToInt32(row["soluong"].ToString());
                btn_xoads.Enabled = false;
            }
        }
        private void cbbox_load()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from hanghoa,nhacungcap where hanghoa.mancc=nhacungcap.mancc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cb_tenhang.DataSource = dt;
                        cb_tenhang.DisplayMember = "tenhh";
                        cb_tenhang.ValueMember = "mahh";

                    }
                }
            }
        }
        private void cbbox_load1()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from nhanvien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cb_tennv.DataSource = dt;
                        cb_tennv.DisplayMember = "tennv";
                        cb_tennv.ValueMember = "manv";

                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_giaban_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_giaban.Text) && !String.IsNullOrEmpty(txt_slxuat.Text))
                txt_thanhtien.Text = (Convert.ToUInt32(txt_giaban.Text) * Convert.ToInt32(txt_slxuat.Text)).ToString();
        }

        private void txt_slxuat_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_giaban.Text) && !String.IsNullOrEmpty(txt_slxuat.Text))
                txt_thanhtien.Text = (Convert.ToUInt32(txt_giaban.Text) * Convert.ToInt32(txt_slxuat.Text)).ToString();
        }

        private void btn_themds_Click(object sender, EventArgs e)
        {
            int i = datagrid_hanghoaxuat.Rows.Count;
            if (txt_giaban.Text == "" || txt_slxuat.Text == "")
            {
                MessageBox.Show("Nhập vào giá và số lượng bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int kiemtra = 0;

                for (int j = 0; j < i; j++)
                {
                    if (txt_mahang.Text == datagrid_hanghoaxuat.Rows[j].Cells["mahh"].Value.ToString())
                    {
                        datagrid_hanghoaxuat.Rows[j].Cells["mahh"].Value = txt_mahang.Text;
                        datagrid_hanghoaxuat.Rows[j].Cells["tenhang"].Value = cb_tenhang.Text;
                        datagrid_hanghoaxuat.Rows[j].Cells["slxuat"].Value = Convert.ToInt32(datagrid_hanghoaxuat.Rows[j].Cells["slxuat"].Value.ToString()) + Convert.ToInt32(txt_slxuat.Text);
                        datagrid_hanghoaxuat.Rows[j].Cells["thanhtien"].Value = Convert.ToInt32(datagrid_hanghoaxuat.Rows[j].Cells["thanhtien"].Value.ToString()) + Convert.ToInt32(txt_thanhtien.Text);

                        txt_tongtien.Text =
                            (Convert.ToInt32(txt_tongtien.Text) + Convert.ToInt32(txt_thanhtien.Text)).ToString();

                        datagrid_hanghoaxuat.Rows[j].Cells["nhacungcap"].Value = txt_nhacungcap.Text;
                        datagrid_hanghoaxuat.Rows[j].Cells["giaban"].Value = txt_giaban.Text;
                        kiemtra++;
                        txt_giaban.Clear();
                        txt_slxuat.Clear();
                        txt_thanhtien.Clear();
                    }

                }

                if (kiemtra == 0)
                {
                    datagrid_hanghoaxuat.Rows.Add();
                    datagrid_hanghoaxuat.Rows[i].Cells["mahh"].Value = txt_mahang.Text;
                    datagrid_hanghoaxuat.Rows[i].Cells["tenhang"].Value = cb_tenhang.Text;
                    datagrid_hanghoaxuat.Rows[i].Cells["nhacungcap"].Value = txt_nhacungcap.Text;
                    datagrid_hanghoaxuat.Rows[i].Cells["giaban"].Value = txt_giaban.Text;
                    datagrid_hanghoaxuat.Rows[i].Cells["slxuat"].Value = txt_slxuat.Text;
                    datagrid_hanghoaxuat.Rows[i].Cells["thanhtien"].Value = txt_thanhtien.Text;

                    txt_tongtien.Text = (Convert.ToInt32(txt_tongtien.Text) + Convert.ToInt32(txt_thanhtien.Text)).ToString();

                    i++;
                    txt_slxuat.Clear();
                    txt_giaban.Clear();
                    txt_thanhtien.Clear();
                }


            }
        }

        private void datagrid_hanghoaxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_xoads.Tag = datagrid_hanghoaxuat.Rows[e.RowIndex].Cells["mahh"].Value.ToString();
            btn_xoads.Enabled = true;
            txt_thanhtien.Text = (datagrid_hanghoaxuat.Rows[e.RowIndex].Cells["thanhtien"].Value.ToString());
        }

        private void btn_xoads_Click(object sender, EventArgs e)
        {
            if (datagrid_hanghoaxuat.Rows.Count != 0)
            {
                foreach (DataGridViewRow r in datagrid_hanghoaxuat.Rows)
                {
                    if (r.Cells[0].Value == btn_xoads.Tag)
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có chắc chắn xóa mặt hàng!", "Xóa hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            datagrid_hanghoaxuat.Rows.Remove(r);
                            txt_tongtien.Text = (Convert.ToInt32(txt_tongtien.Text) - Convert.ToInt32(txt_thanhtien.Text)).ToString();
                            btn_xoads.Enabled = false;
                            txt_thanhtien.Clear();
                            return;
                        }
                        else
                            return;
                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Close();
        }
        private void themhdx()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("them_HDX", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    string[] a = date_hdx.Value.Date.ToString().Split('/');
                    string b = a[1] + "/" + a[0] + "/" + a[2];
                    cmd.Parameters.AddWithValue("@mahdx", txt_mahdx.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@tenkh", txt_tenkh.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@diachikh", txt_diachi.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@sdtkh", txt_sdt.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@ngayxuat", b);
                    cmd.Parameters.AddWithValue("@manv", cb_tennv.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@tongtien", 0);
                    cmd.ExecuteNonQuery();


                }
            }
        }
        private void them_hh_xuat()
        {
            for (int i = 0; i < datagrid_hanghoaxuat.Rows.Count; i++)
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Them_HHX", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahdx", txt_mahdx.Text.Trim().ToString());
                        cmd.Parameters.AddWithValue("@mahh", datagrid_hanghoaxuat.Rows[i].Cells["mahh"].Value.ToString());
                        cmd.Parameters.AddWithValue("@giaxuat", datagrid_hanghoaxuat.Rows[i].Cells["giaban"].Value.ToString());
                        cmd.Parameters.AddWithValue("@slxuat", datagrid_hanghoaxuat.Rows[i].Cells["slxuat"].Value.ToString());
                        cmd.Parameters.AddWithValue("@thanhtien", 0);
                        cmd.ExecuteNonQuery();

                    }
                }

            }
        }
        private int checkmahdx()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSelect = ("select * from hoadonxuat where mahdx='" + txt_mahdx.Text + "'");
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

        private void btn_taohdx_Click(object sender, EventArgs e)
        {
            if (checkmahdx() == 1 && Convert.ToUInt32(txt_tongtien.Text.ToString()) > 0)
            {
                themhdx();
                them_hh_xuat();
                MessageBox.Show("Thêm hóa đơn xuất hàng thành công");
                Banhang_Load(sender, e);
                datagrid_hanghoaxuat.Rows.Clear();
                datagrid_hanghoaxuat.Refresh();
            }
            else
                MessageBox.Show("Mã hóa đơn xuất đã tồn tại hoặc không đủ điều kiện tạo hóa đơn!");
        }

        private void txt_slxuat_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(txt_slxuat.Text.Trim()) > soluongkho)
            {
                errorProvider1.SetError(txt_slxuat, "");
                MessageBox.Show("Số lượng hàng trong kho không đủ! Chỉ còn " + soluongkho.ToString(), "Thông báo");
                txt_slxuat.Focus();
            }
        }

        private void date_hdx_Validating(object sender, CancelEventArgs e)
        {
            if (date_hdx.Value > DateTime.Now)
            {
                errorProvider1.SetError(date_hdx, "Ngày nhập phải nhỏ hơn hoặc bằng ngày hiện tại!");
                date_hdx.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void txt_slxuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_giaban_Validating(object sender, CancelEventArgs e)
        {
            float i;
            try
            {
                i = Convert.ToUInt32(txt_giaban.Text.Trim().ToString());
                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(txt_giaban, "Giá bán phải là số thực!");
                txt_giaban.Focus();
            }
        }

        private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void datagrid_hanghoaxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public int getsl()
        //{
        //    using (SqlConnection cnn = new SqlConnection(constr))
        //    {
        //        string sqlSelect = ("select soluong from hanghoa where mahh='" + txt_mahang.Text.ToString() + "'");
        //        using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            cnn.Open();
        //            int i = cmd.ExecuteNonQuery();
        //            cnn.Close();
        //            return i;
        //        }
        //    }

        //}
    }
}