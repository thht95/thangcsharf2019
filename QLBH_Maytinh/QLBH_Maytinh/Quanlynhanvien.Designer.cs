namespace QLBH_Maytinh
{
    partial class Quanlynhanvien
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
            this.lb_manv = new System.Windows.Forms.Label();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_cmnd = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.mtxt_cmnd = new System.Windows.Forms.MaskedTextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.datagrid_nhanvien = new System.Windows.Forms.DataGridView();
            this.rdbtn_nam = new System.Windows.Forms.RadioButton();
            this.rdbtn_nu = new System.Windows.Forms.RadioButton();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.datetime_nv = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(16, 12);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(72, 13);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã nhân viên";
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Location = new System.Drawing.Point(12, 45);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(76, 13);
            this.lb_tennv.TabIndex = 1;
            this.lb_tennv.Text = "Tên nhân viên";
            this.lb_tennv.Click += new System.EventHandler(this.lb_tennv_Click);
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Location = new System.Drawing.Point(34, 82);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lb_ngaysinh.TabIndex = 2;
            this.lb_ngaysinh.Text = "Ngày sinh";
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Location = new System.Drawing.Point(41, 118);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(47, 13);
            this.lb_gioitinh.TabIndex = 3;
            this.lb_gioitinh.Text = "Giới tính";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Location = new System.Drawing.Point(48, 153);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(40, 13);
            this.lb_diachi.TabIndex = 4;
            this.lb_diachi.Text = "Địa chỉ";
            this.lb_diachi.Click += new System.EventHandler(this.lb_diachi_Click);
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(18, 192);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(70, 13);
            this.lb_sdt.TabIndex = 5;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // lb_cmnd
            // 
            this.lb_cmnd.AutoSize = true;
            this.lb_cmnd.Location = new System.Drawing.Point(49, 228);
            this.lb_cmnd.Name = "lb_cmnd";
            this.lb_cmnd.Size = new System.Drawing.Size(39, 13);
            this.lb_cmnd.TabIndex = 6;
            this.lb_cmnd.Text = "CMND";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(99, 8);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(171, 20);
            this.txt_manv.TabIndex = 7;
            this.txt_manv.Validating += new System.ComponentModel.CancelEventHandler(this.txt_manv_Validating);
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(99, 41);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(171, 20);
            this.txt_tennv.TabIndex = 8;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(99, 149);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(171, 20);
            this.txt_diachi.TabIndex = 11;
            // 
            // mtxt_cmnd
            // 
            this.mtxt_cmnd.Location = new System.Drawing.Point(99, 224);
            this.mtxt_cmnd.Mask = "000000000";
            this.mtxt_cmnd.Name = "mtxt_cmnd";
            this.mtxt_cmnd.Size = new System.Drawing.Size(169, 20);
            this.mtxt_cmnd.TabIndex = 13;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(99, 188);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(169, 20);
            this.txt_sdt.TabIndex = 14;
            // 
            // datagrid_nhanvien
            // 
            this.datagrid_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_nhanvien.Location = new System.Drawing.Point(301, 8);
            this.datagrid_nhanvien.Name = "datagrid_nhanvien";
            this.datagrid_nhanvien.Size = new System.Drawing.Size(746, 236);
            this.datagrid_nhanvien.TabIndex = 15;
            this.datagrid_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_nhanvien_CellClick);
            this.datagrid_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rdbtn_nam
            // 
            this.rdbtn_nam.AutoSize = true;
            this.rdbtn_nam.Location = new System.Drawing.Point(99, 116);
            this.rdbtn_nam.Name = "rdbtn_nam";
            this.rdbtn_nam.Size = new System.Drawing.Size(47, 17);
            this.rdbtn_nam.TabIndex = 16;
            this.rdbtn_nam.TabStop = true;
            this.rdbtn_nam.Text = "Nam";
            this.rdbtn_nam.UseVisualStyleBackColor = true;
            // 
            // rdbtn_nu
            // 
            this.rdbtn_nu.AutoSize = true;
            this.rdbtn_nu.Location = new System.Drawing.Point(204, 116);
            this.rdbtn_nu.Name = "rdbtn_nu";
            this.rdbtn_nu.Size = new System.Drawing.Size(39, 17);
            this.rdbtn_nu.TabIndex = 17;
            this.rdbtn_nu.TabStop = true;
            this.rdbtn_nu.Text = "Nữ";
            this.rdbtn_nu.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(146, 282);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 34);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(301, 282);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 34);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(608, 282);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(97, 34);
            this.btn_boqua.TabIndex = 20;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(761, 282);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 34);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // datetime_nv
            // 
            this.datetime_nv.Location = new System.Drawing.Point(99, 77);
            this.datetime_nv.Name = "datetime_nv";
            this.datetime_nv.Size = new System.Drawing.Size(171, 20);
            this.datetime_nv.TabIndex = 22;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(454, 282);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(97, 34);
            this.btn_timkiem.TabIndex = 23;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // Quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 346);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.datetime_nv);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.rdbtn_nu);
            this.Controls.Add(this.rdbtn_nam);
            this.Controls.Add(this.datagrid_nhanvien);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.mtxt_cmnd);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.lb_cmnd);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_diachi);
            this.Controls.Add(this.lb_gioitinh);
            this.Controls.Add(this.lb_ngaysinh);
            this.Controls.Add(this.lb_tennv);
            this.Controls.Add(this.lb_manv);
            this.Name = "Quanlynhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Quanlynhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_cmnd;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.MaskedTextBox mtxt_cmnd;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.DataGridView datagrid_nhanvien;
        private System.Windows.Forms.RadioButton rdbtn_nam;
        private System.Windows.Forms.RadioButton rdbtn_nu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DateTimePicker datetime_nv;
        private System.Windows.Forms.Button btn_timkiem;
    }
}