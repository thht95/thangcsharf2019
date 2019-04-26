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
    public partial class Nhaphang : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Nhaphang()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_themds_Click(object sender, EventArgs e)
        {
            int i = datagrid_chitietnhap.Rows.Count;
            if (txt_gianhap.Text == "" || txt_slnhap.Text == "")
            {
                MessageBox.Show("Nhập vào giá và số lượng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int kiemtra = 0;

                for (int j = 0; j < i; j++)
                {
                    if (txt_mahang.Text == datagrid_chitietnhap.Rows[j].Cells["mahang"].Value.ToString())
                    {
                        datagrid_chitietnhap.Rows[j].Cells["mahang"].Value = txt_mahang.Text;
                        datagrid_chitietnhap.Rows[j].Cells["tenhang"].Value = cb_tenhang.Text;
                        datagrid_chitietnhap.Rows[j].Cells["slnhap"].Value = Convert.ToInt32(datagrid_chitietnhap.Rows[j].Cells["slnhap"].Value.ToString()) + Convert.ToInt32(txt_slnhap.Text);
                        datagrid_chitietnhap.Rows[j].Cells["thanhtien"].Value = Convert.ToInt32(datagrid_chitietnhap.Rows[j].Cells["thanhtien"].Value.ToString()) + Convert.ToInt32(txt_thanhtien.Text);
                        
                        txt_tongtien.Text =
                            (Convert.ToInt32(txt_tongtien.Text) + Convert.ToInt32(txt_thanhtien.Text)).ToString();

                        datagrid_chitietnhap.Rows[j].Cells["tenncc"].Value = txt_nhacungcap.Text;
                        datagrid_chitietnhap.Rows[j].Cells["gianhap"].Value = txt_gianhap.Text;
                        kiemtra++;
                        txt_gianhap.Clear();
                        txt_slnhap.Clear();
                        txt_thanhtien.Clear();
                    }
                          
                }

                if(kiemtra==0)
                {
                    datagrid_chitietnhap.Rows.Add();
                    datagrid_chitietnhap.Rows[i].Cells["mahang"].Value = txt_mahang.Text;
                    datagrid_chitietnhap.Rows[i].Cells["tenhang"].Value = cb_tenhang.Text;
                    datagrid_chitietnhap.Rows[i].Cells["tenncc"].Value = txt_nhacungcap.Text;
                    datagrid_chitietnhap.Rows[i].Cells["gianhap"].Value = txt_gianhap.Text;
                    datagrid_chitietnhap.Rows[i].Cells["slnhap"].Value = txt_slnhap.Text;
                    datagrid_chitietnhap.Rows[i].Cells["thanhtien"].Value = txt_thanhtien.Text;

                    txt_tongtien.Text = (Convert.ToInt32(txt_tongtien.Text) + Convert.ToInt32(txt_thanhtien.Text)).ToString();

                    i++;
                    txt_gianhap.Clear();
                    txt_slnhap.Clear();
                    txt_thanhtien.Clear();
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cb_tenhang.SelectedItem as DataRowView;
            if (row != null)
            {
                txt_mahang.Text = row["mahh"].ToString();
                txt_nhacungcap.Text = row["tenncc"].ToString();
                btn_xoakhoids.Enabled = false;
            }
        }

        private void Nhaphang_Load(object sender, EventArgs e)
        {
            cbbox_load();
            cbbox_load1();
            txt_nhacungcap.Enabled = false;
            txt_mahang.Enabled = false;
            txt_thanhtien.Enabled = false;
            txt_tongtien.Enabled = false;
            btn_xoakhoids.Enabled = false;
            //btn_taohdn.Enabled = false;
            //buttonTao_Enable();
            datetime_hdn.Format = DateTimePickerFormat.Custom;
            datetime_hdn.CustomFormat = "dd/MM/yyyy";
        }


        private void lb_tenhang_Click(object sender, EventArgs e)
        {

        }

        private void txt_tenhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gianhap_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_gianhap.Text) && !String.IsNullOrEmpty(txt_slnhap.Text))
                txt_thanhtien.Text = (Convert.ToUInt32(txt_gianhap.Text) * Convert.ToInt32(txt_slnhap.Text)).ToString();
        }

        private void txt_slnhap_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_gianhap.Text) && !String.IsNullOrEmpty(txt_slnhap.Text))
                txt_thanhtien.Text = (Convert.ToUInt32(txt_gianhap.Text) * Convert.ToInt32(txt_slnhap.Text)).ToString();

            if (!String.IsNullOrEmpty(txt_slnhap.Text))
                txt_slnhap.Text = int.Parse(txt_slnhap.Text) + "";
        }

        private void datagrid_chitietnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_xoakhoids.Tag = datagrid_chitietnhap.Rows[e.RowIndex].Cells["mahang"].Value.ToString();
            btn_xoakhoids.Enabled = true;
            //txt_mahang.Text = (datagrid_chitietnhap.Rows[e.RowIndex].Cells["mahang"].Value.ToString());
            //cb_tenhang.Text = (datagrid_chitietnhap.Rows[e.RowIndex].Cells["tenhang"].Value.ToString());
            //txt_nhacungcap.Text = (datagrid_chitietnhap.Rows[e.RowIndex].Cells["tenncc"].Value.ToString());
            //txt_gianhap.Text = (datagrid_chitietnhap.Rows[e.RowIndex].Cells["gianhap"].Value.ToString());
            //txt_slnhap.Text = (datagrid_chitietnhap.Rows[e.RowIndex].Cells["slnhap"].Value.ToString());
            txt_thanhtien.Text = (datagrid_chitietnhap.Rows[e.RowIndex].Cells["thanhtien"].Value.ToString());
        }

        private void btn_xoakhoids_Click(object sender, EventArgs e)
        {
            if (datagrid_chitietnhap.Rows.Count != 0)
            {
                foreach (DataGridViewRow r in datagrid_chitietnhap.Rows)
                {
                    if (r.Cells[0].Value == btn_xoakhoids.Tag)
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có chắc chắn xóa mặt hàng!", "Xóa hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            datagrid_chitietnhap.Rows.Remove(r);
                            txt_tongtien.Text = (Convert.ToInt32(txt_tongtien.Text) - Convert.ToInt32(txt_thanhtien.Text)).ToString();
                            btn_xoakhoids.Enabled = false;
                            txt_thanhtien.Clear();
                            return;
                        }
                        else
                            return;
                    }
                }
            }
        }
        private float Tinhtongtien()
        {
            float tongtien = 0;
            for (int i = 0; i < datagrid_chitietnhap.Rows.Count - 1; i++)
                tongtien += float.Parse(datagrid_chitietnhap.Rows[i].Cells["thanhtien"].Value.ToString());
            return tongtien;
        }
        private void themhdn()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("them_HDN", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                   //string[] a = datetime_hdn.Value.Date.ToString().Split('/');
                   // string b = a[1] + "/" + a[0] + "/" + a[2];
                    cmd.Parameters.AddWithValue("@mahdn", txt_mahdn.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@ngaynhap", Convert.ToDateTime(datetime_hdn.Value.ToString()));
                 //   cmd.Parameters.AddWithValue("@ngaynhap",b);
                    cmd.Parameters.AddWithValue("@manv", cb_tennv.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@tongtien",0);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        private void them_hh_nhap()
        {
            for (int i = 0; i < datagrid_chitietnhap.Rows.Count; i++)
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Them_HHN", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahdn", txt_mahdn.Text.Trim().ToString());
                        cmd.Parameters.AddWithValue("@mahh", datagrid_chitietnhap.Rows[i].Cells["mahang"].Value.ToString());
                        cmd.Parameters.AddWithValue("@gianhap", datagrid_chitietnhap.Rows[i].Cells["gianhap"].Value.ToString());
                        cmd.Parameters.AddWithValue("@slnhap", datagrid_chitietnhap.Rows[i].Cells["slnhap"].Value.ToString());
                        cmd.Parameters.AddWithValue("@thanhtien", 0);
                        cmd.ExecuteNonQuery();

                    }
                }
               
            }
        }
        private int checkmahdn()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSelect = ("select * from hoadonnhap where mahdn='" + txt_mahdn.Text + "'");
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

        private void btn_taohdn_Click(object sender, EventArgs e)
        {
            if (datetime_hdn.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày nhập không đc trong quá khứ");
            }
            else
            {
                if (checkmahdn() == 1 && Convert.ToUInt32(txt_tongtien.Text.ToString()) > 0)
                {
                    themhdn();
                    them_hh_nhap();
                    MessageBox.Show("Thêm hóa đơn nhập hàng thành công");
                    Nhaphang_Load(sender, e);
                    datagrid_chitietnhap.Rows.Clear();
                    datagrid_chitietnhap.Refresh();
                }
                else
                    MessageBox.Show("Mã hóa đơn nhập đã tồn tại hoặc không đủ điều kiện tạo hóa đơn!");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Close();
        }

        private void txt_gianhap_Validating(object sender, CancelEventArgs e)
        {
            float i;
            try
            {
                i = Convert.ToUInt32(txt_gianhap.Text.Trim().ToString());
                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(txt_gianhap, "Giá nhập phải là số thực!");
                txt_gianhap.Focus();
            }
        }

        private void txt_slnhap_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_slnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void datetime_hdn_Validating(object sender, CancelEventArgs e)
        {
            //if(datetime_hdn.Value >DateTime.Now)
            //{
            //    errorProvider1.SetError(datetime_hdn, "Ngày nhập phải nhỏ hơn hoặc bằng ngày hiện tại!");
            //    datetime_hdn.Focus();
            //}
            //else
            //errorProvider1.Clear();
        }

        private void txt_gianhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
