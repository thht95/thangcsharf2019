namespace QLBH_Maytinh
{
    partial class Quanlynhacungcap
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
            this.lb_mancc = new System.Windows.Forms.Label();
            this.lb_tenncc = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.datagrid_nhacungcap = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_nhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_mancc
            // 
            this.lb_mancc.AutoSize = true;
            this.lb_mancc.Location = new System.Drawing.Point(18, 17);
            this.lb_mancc.Name = "lb_mancc";
            this.lb_mancc.Size = new System.Drawing.Size(91, 13);
            this.lb_mancc.TabIndex = 0;
            this.lb_mancc.Text = "Mã nhà cung cấp";
            // 
            // lb_tenncc
            // 
            this.lb_tenncc.AutoSize = true;
            this.lb_tenncc.Location = new System.Drawing.Point(14, 55);
            this.lb_tenncc.Name = "lb_tenncc";
            this.lb_tenncc.Size = new System.Drawing.Size(95, 13);
            this.lb_tenncc.TabIndex = 1;
            this.lb_tenncc.Text = "Tên nhà cung cấp";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Location = new System.Drawing.Point(69, 92);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(40, 13);
            this.lb_diachi.TabIndex = 2;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(39, 129);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(70, 13);
            this.lb_sdt.TabIndex = 3;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(137, 13);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(179, 20);
            this.txt_mancc.TabIndex = 4;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(137, 51);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(179, 20);
            this.txt_tenncc.TabIndex = 5;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(137, 88);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(179, 20);
            this.txt_diachi.TabIndex = 6;
            this.txt_diachi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(137, 126);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(179, 20);
            this.txt_sdt.TabIndex = 7;
            // 
            // datagrid_nhacungcap
            // 
            this.datagrid_nhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_nhacungcap.Location = new System.Drawing.Point(336, 13);
            this.datagrid_nhacungcap.Name = "datagrid_nhacungcap";
            this.datagrid_nhacungcap.Size = new System.Drawing.Size(441, 239);
            this.datagrid_nhacungcap.TabIndex = 8;
            this.datagrid_nhacungcap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_nhacungcap_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(12, 168);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(96, 32);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(236, 168);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 32);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(124, 168);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(96, 32);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(181, 220);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(96, 32);
            this.btn_boqua.TabIndex = 12;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(62, 220);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(96, 32);
            this.btn_timkiem.TabIndex = 13;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // Quanlynhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 264);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.datagrid_nhacungcap);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_tenncc);
            this.Controls.Add(this.txt_mancc);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_diachi);
            this.Controls.Add(this.lb_tenncc);
            this.Controls.Add(this.lb_mancc);
            this.Name = "Quanlynhacungcap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.Quanlynhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_nhacungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_mancc;
        private System.Windows.Forms.Label lb_tenncc;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.DataGridView datagrid_nhacungcap;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_timkiem;
    }
}