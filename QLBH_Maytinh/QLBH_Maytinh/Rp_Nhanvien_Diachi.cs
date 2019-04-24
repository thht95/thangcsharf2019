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
    
    public partial class Rp_Nhanvien_Diachi : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["QLBH_Maytinh"].ConnectionString;
        public Rp_Nhanvien_Diachi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "nhanvien_noio";
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Rp_Nhanvien_Noio rp = new Rp_Nhanvien_Noio();
                rp.SetDataSource(dt);
                try
                {
                    rp.SetParameterValue("diachi", txt_diachi.Text.ToString());
                }
                catch { MessageBox.Show("Lỗi"); }

                //rpnhanviendiachi.ReportSource = rp;
            }
           
        }

        private void Rp_Nhanvien_Diachi_Load(object sender, EventArgs e)
        {

        }
    }
}
