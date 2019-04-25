namespace QLBH_Maytinh
{
    partial class DanhsachHDN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mahdn = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.date_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.datagrid_hdn = new System.Windows.Forms.DataGridView();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_hdn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // txt_mahdn
            // 
            this.txt_mahdn.Location = new System.Drawing.Point(92, 16);
            this.txt_mahdn.Name = "txt_mahdn";
            this.txt_mahdn.Size = new System.Drawing.Size(200, 20);
            this.txt_mahdn.TabIndex = 4;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(92, 74);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(200, 20);
            this.txt_manv.TabIndex = 5;
            // 
            // date_ngaynhap
            // 
            this.date_ngaynhap.Location = new System.Drawing.Point(92, 45);
            this.date_ngaynhap.Name = "date_ngaynhap";
            this.date_ngaynhap.Size = new System.Drawing.Size(200, 20);
            this.date_ngaynhap.TabIndex = 6;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(92, 103);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(200, 20);
            this.txt_tongtien.TabIndex = 7;
            // 
            // datagrid_hdn
            // 
            this.datagrid_hdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_hdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid_hdn.Location = new System.Drawing.Point(307, 16);
            this.datagrid_hdn.Name = "datagrid_hdn";
            this.datagrid_hdn.Size = new System.Drawing.Size(628, 220);
            this.datagrid_hdn.TabIndex = 8;
            this.datagrid_hdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_hdn_CellClick);
            this.datagrid_hdn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_hdn_CellContentClick);
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.Location = new System.Drawing.Point(28, 140);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(107, 38);
            this.btn_xemchitiet.TabIndex = 9;
            this.btn_xemchitiet.Text = "Xem chi tiết";
            this.btn_xemchitiet.UseVisualStyleBackColor = true;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemchitiet_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(173, 140);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 38);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_baocao
            // 
            this.btn_baocao.Location = new System.Drawing.Point(28, 198);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(107, 38);
            this.btn_baocao.TabIndex = 11;
            this.btn_baocao.Text = "Báo cáo";
            this.btn_baocao.UseVisualStyleBackColor = true;
//            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(173, 198);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(107, 38);
            this.btn_boqua.TabIndex = 12;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // DanhsachHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 249);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_baocao);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xemchitiet);
            this.Controls.Add(this.datagrid_hdn);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.date_ngaynhap);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.txt_mahdn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhsachHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn nhập";
            this.Load += new System.EventHandler(this.DanhsachHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_hdn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mahdn;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.DateTimePicker date_ngaynhap;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.DataGridView datagrid_hdn;
        private System.Windows.Forms.Button btn_xemchitiet;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Button btn_boqua;
    }
}