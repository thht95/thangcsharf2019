namespace QLBH_Maytinh
{
    partial class Quanlyhanghoa
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
            this.lb_mahang = new System.Windows.Forms.Label();
            this.lb_tenhang = new System.Windows.Forms.Label();
            this.lb_nhomhang = new System.Windows.Forms.Label();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.lb_ncc = new System.Windows.Forms.Label();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.txt_nhomhang = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.cb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.datagrid_hanghoa = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_hanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_mahang
            // 
            this.lb_mahang.AutoSize = true;
            this.lb_mahang.Location = new System.Drawing.Point(29, 16);
            this.lb_mahang.Name = "lb_mahang";
            this.lb_mahang.Size = new System.Drawing.Size(49, 13);
            this.lb_mahang.TabIndex = 0;
            this.lb_mahang.Text = "Mã hàng";
            // 
            // lb_tenhang
            // 
            this.lb_tenhang.AutoSize = true;
            this.lb_tenhang.Location = new System.Drawing.Point(25, 52);
            this.lb_tenhang.Name = "lb_tenhang";
            this.lb_tenhang.Size = new System.Drawing.Size(53, 13);
            this.lb_tenhang.TabIndex = 1;
            this.lb_tenhang.Text = "Tên hàng";
            // 
            // lb_nhomhang
            // 
            this.lb_nhomhang.AutoSize = true;
            this.lb_nhomhang.Location = new System.Drawing.Point(16, 88);
            this.lb_nhomhang.Name = "lb_nhomhang";
            this.lb_nhomhang.Size = new System.Drawing.Size(62, 13);
            this.lb_nhomhang.TabIndex = 2;
            this.lb_nhomhang.Text = "Nhóm hàng";
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Location = new System.Drawing.Point(29, 124);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(49, 13);
            this.lb_soluong.TabIndex = 3;
            this.lb_soluong.Text = "Số lượng";
            // 
            // lb_ncc
            // 
            this.lb_ncc.AutoSize = true;
            this.lb_ncc.Location = new System.Drawing.Point(3, 160);
            this.lb_ncc.Name = "lb_ncc";
            this.lb_ncc.Size = new System.Drawing.Size(75, 13);
            this.lb_ncc.TabIndex = 4;
            this.lb_ncc.Text = "Nhà cung cấp";
            this.lb_ncc.Click += new System.EventHandler(this.lb_ncc_Click);
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(87, 12);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(193, 20);
            this.txt_mahang.TabIndex = 5;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(87, 48);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(193, 20);
            this.txt_tenhang.TabIndex = 6;
            // 
            // txt_nhomhang
            // 
            this.txt_nhomhang.Location = new System.Drawing.Point(87, 84);
            this.txt_nhomhang.Name = "txt_nhomhang";
            this.txt_nhomhang.Size = new System.Drawing.Size(193, 20);
            this.txt_nhomhang.TabIndex = 7;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(87, 120);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(193, 20);
            this.txt_soluong.TabIndex = 8;
            // 
            // cb_nhacungcap
            // 
            this.cb_nhacungcap.FormattingEnabled = true;
            this.cb_nhacungcap.Location = new System.Drawing.Point(87, 156);
            this.cb_nhacungcap.Name = "cb_nhacungcap";
            this.cb_nhacungcap.Size = new System.Drawing.Size(193, 21);
            this.cb_nhacungcap.TabIndex = 9;
            this.cb_nhacungcap.SelectedIndexChanged += new System.EventHandler(this.cb_nhacungcap_SelectedIndexChanged);
            // 
            // datagrid_hanghoa
            // 
            this.datagrid_hanghoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_hanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_hanghoa.Location = new System.Drawing.Point(6, 186);
            this.datagrid_hanghoa.Name = "datagrid_hanghoa";
            this.datagrid_hanghoa.Size = new System.Drawing.Size(602, 264);
            this.datagrid_hanghoa.TabIndex = 10;
            this.datagrid_hanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_hanghoa_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(328, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 34);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(483, 12);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 34);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(328, 68);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 34);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(328, 124);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(115, 34);
            this.btn_boqua.TabIndex = 14;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(483, 68);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(115, 34);
            this.btn_timkiem.TabIndex = 15;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // Quanlyhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 462);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.datagrid_hanghoa);
            this.Controls.Add(this.cb_nhacungcap);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_nhomhang);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.lb_ncc);
            this.Controls.Add(this.lb_soluong);
            this.Controls.Add(this.lb_nhomhang);
            this.Controls.Add(this.lb_tenhang);
            this.Controls.Add(this.lb_mahang);
            this.Name = "Quanlyhanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hàng hóa";
            this.Load += new System.EventHandler(this.Quanlyhanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_hanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_mahang;
        private System.Windows.Forms.Label lb_tenhang;
        private System.Windows.Forms.Label lb_nhomhang;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label lb_ncc;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.TextBox txt_nhomhang;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ComboBox cb_nhacungcap;
        private System.Windows.Forms.DataGridView datagrid_hanghoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_timkiem;
    }
}