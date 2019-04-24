using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_Maytinh
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        public Boolean kiemtraHienMotform(string sFormname)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(sFormname))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýHàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Quanlyhanghoa")) return;
            else
            {
                Quanlyhanghoa frm = new Quanlyhanghoa();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Quanlynhanvien")) return;
            else
            {
                Quanlynhanvien frm = new Quanlynhanvien();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Quanlynhacungcap")) return;
            else
            {
                Quanlynhacungcap frm = new Quanlynhacungcap();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Nhaphang")) return;
            else
            {
                Nhaphang frm = new Nhaphang();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void xuấtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Banhang")) return;
            else
            {
                Banhang frm = new Banhang();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void danhSáchHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("DanhsachHDN")) return;
            else
            {
                DanhsachHDN frm = new DanhsachHDN();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void danhSáchHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("DanhsachHDX")) return;
            else
            {
                DanhsachHDX frm = new DanhsachHDX();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
                
        }

        private void thốngKêNhânViênTheoNơiỞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Nhanvien_noio")) return;
            else
            {
                Rp_Nhanvien_Diachi frm = new Rp_Nhanvien_Diachi();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void thốngKêTiềnBánHàngTheoQuýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Thống_kê_doanh_thu_theo_quý")) return;
            else
            {
                Thống_kê_doanh_thu_theo_quý frm = new Thống_kê_doanh_thu_theo_quý();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void thốngKêHàngCònTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Rp_Hangtonkho")) return;
            else
            {
                Rp_Hangtonkho frm = new Rp_Hangtonkho();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void thốngKêHàngBánChạyNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Rp_Thongkehangbanchay")) return;
            else
            {
                Rp_Thongkehangbanchay frm = new Rp_Thongkehangbanchay();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
