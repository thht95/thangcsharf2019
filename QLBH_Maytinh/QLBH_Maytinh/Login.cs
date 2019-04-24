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
    public partial class Login : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }
        private string getID(string username, string pass)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                string id = "";
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM account WHERE username ='" + username + "' and password='" + pass + "'", cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            id = dr["username"].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
                }
                finally
                {
                    cnn.Close();
                }
                return id;
            }
        }
        public static string ID_USER = "";


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Close();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            ID_USER = getID(txt_username.Text, txt_password.Text);
            if (ID_USER != "")
            {
                Form_Main frm = new Form_Main();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
        }
    }


}
