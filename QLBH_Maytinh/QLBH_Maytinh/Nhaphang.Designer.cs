namespace QLBH_Maytinh
{
    partial class Nhaphang
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
            this.components = new System.ComponentModel.Container();
            this.lb_mahdn = new System.Windows.Forms.Label();
            this.lb_ngaynhap = new System.Windows.Forms.Label();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.txt_mahdn = new System.Windows.Forms.TextBox();
            this.datetime_hdn = new System.Windows.Forms.DateTimePicker();
            this.cb_tennv = new System.Windows.Forms.ComboBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_mahang = new System.Windows.Forms.Label();
            this.lb_tenhang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.txt_nhacungcap = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.txt_slnhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tenhang = new System.Windows.Forms.ComboBox();
            this.btn_themds = new System.Windows.Forms.Button();
            this.btn_xoakhoids = new System.Windows.Forms.Button();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.datagrid_chitietnhap = new System.Windows.Forms.DataGridView();
            this.mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_taohdn = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_chitietnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_mahdn
            // 
            this.lb_mahdn.AutoSize = true;
            this.lb_mahdn.Location = new System.Drawing.Point(49, 32);
            this.lb_mahdn.Name = "lb_mahdn";
            this.lb_mahdn.Size = new System.Drawing.Size(49, 13);
            this.lb_mahdn.TabIndex = 0;
            this.lb_mahdn.Text = "Mã HĐN";
            // 
            // lb_ngaynhap
            // 
            this.lb_ngaynhap.AutoSize = true;
            this.lb_ngaynhap.Location = new System.Drawing.Point(39, 71);
            this.lb_ngaynhap.Name = "lb_ngaynhap";
            this.lb_ngaynhap.Size = new System.Drawing.Size(59, 13);
            this.lb_ngaynhap.TabIndex = 1;
            this.lb_ngaynhap.Text = "Ngày nhập";
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Location = new System.Drawing.Point(22, 108);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(76, 13);
            this.lb_tennv.TabIndex = 2;
            this.lb_tennv.Text = "Tên nhân viên";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(46, 146);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(52, 13);
            this.lb_tongtien.TabIndex = 3;
            this.lb_tongtien.Text = "Tổng tiền";
            // 
            // txt_mahdn
            // 
            this.txt_mahdn.Location = new System.Drawing.Point(117, 28);
            this.txt_mahdn.Name = "txt_mahdn";
            this.txt_mahdn.Size = new System.Drawing.Size(184, 20);
            this.txt_mahdn.TabIndex = 4;
            // 
            // datetime_hdn
            // 
            this.datetime_hdn.Location = new System.Drawing.Point(117, 67);
            this.datetime_hdn.Name = "datetime_hdn";
            this.datetime_hdn.Size = new System.Drawing.Size(184, 20);
            this.datetime_hdn.TabIndex = 5;
            this.datetime_hdn.Validating += new System.ComponentModel.CancelEventHandler(this.datetime_hdn_Validating);
            // 
            // cb_tennv
            // 
            this.cb_tennv.FormattingEnabled = true;
            this.cb_tennv.Location = new System.Drawing.Point(117, 104);
            this.cb_tennv.Name = "cb_tennv";
            this.cb_tennv.Size = new System.Drawing.Size(184, 21);
            this.cb_tennv.TabIndex = 6;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(117, 142);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(151, 20);
            this.txt_tongtien.TabIndex = 7;
            this.txt_tongtien.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.cb_tennv);
            this.groupBox1.Controls.Add(this.datetime_hdn);
            this.groupBox1.Controls.Add(this.txt_mahdn);
            this.groupBox1.Controls.Add(this.lb_tongtien);
            this.groupBox1.Controls.Add(this.lb_tennv);
            this.groupBox1.Controls.Add(this.lb_ngaynhap);
            this.groupBox1.Controls.Add(this.lb_mahdn);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(274, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Đồng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_mahang
            // 
            this.lb_mahang.AutoSize = true;
            this.lb_mahang.Location = new System.Drawing.Point(47, 69);
            this.lb_mahang.Name = "lb_mahang";
            this.lb_mahang.Size = new System.Drawing.Size(49, 13);
            this.lb_mahang.TabIndex = 9;
            this.lb_mahang.Text = "Mã hàng";
            // 
            // lb_tenhang
            // 
            this.lb_tenhang.AutoSize = true;
            this.lb_tenhang.Location = new System.Drawing.Point(43, 30);
            this.lb_tenhang.Name = "lb_tenhang";
            this.lb_tenhang.Size = new System.Drawing.Size(53, 13);
            this.lb_tenhang.TabIndex = 10;
            this.lb_tenhang.Text = "Tên hàng";
            this.lb_tenhang.Click += new System.EventHandler(this.lb_tenhang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá nhập";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số lượng";
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(102, 67);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(173, 20);
            this.txt_mahang.TabIndex = 15;
            this.txt_mahang.TextChanged += new System.EventHandler(this.txt_tenhang_TextChanged);
            // 
            // txt_nhacungcap
            // 
            this.txt_nhacungcap.Location = new System.Drawing.Point(102, 107);
            this.txt_nhacungcap.Name = "txt_nhacungcap";
            this.txt_nhacungcap.Size = new System.Drawing.Size(173, 20);
            this.txt_nhacungcap.TabIndex = 16;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(372, 29);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(123, 20);
            this.txt_gianhap.TabIndex = 17;
            this.txt_gianhap.TextChanged += new System.EventHandler(this.txt_gianhap_TextChanged);
            this.txt_gianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gianhap_KeyPress);
            this.txt_gianhap.Validating += new System.ComponentModel.CancelEventHandler(this.txt_gianhap_Validating);
            // 
            // txt_slnhap
            // 
            this.txt_slnhap.Location = new System.Drawing.Point(372, 67);
            this.txt_slnhap.Name = "txt_slnhap";
            this.txt_slnhap.Size = new System.Drawing.Size(123, 20);
            this.txt_slnhap.TabIndex = 18;
            this.txt_slnhap.TextChanged += new System.EventHandler(this.txt_slnhap_TextChanged);
            this.txt_slnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_slnhap_KeyPress);
            this.txt_slnhap.Validating += new System.ComponentModel.CancelEventHandler(this.txt_slnhap_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb_tenhang);
            this.groupBox2.Controls.Add(this.btn_themds);
            this.groupBox2.Controls.Add(this.btn_xoakhoids);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.lb_thanhtien);
            this.groupBox2.Controls.Add(this.txt_slnhap);
            this.groupBox2.Controls.Add(this.txt_gianhap);
            this.groupBox2.Controls.Add(this.txt_nhacungcap);
            this.groupBox2.Controls.Add(this.txt_mahang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lb_tenhang);
            this.groupBox2.Controls.Add(this.lb_mahang);
            this.groupBox2.Location = new System.Drawing.Point(352, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 199);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(501, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(501, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Đồng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(501, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Đồng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_tenhang
            // 
            this.cb_tenhang.FormattingEnabled = true;
            this.cb_tenhang.Location = new System.Drawing.Point(102, 28);
            this.cb_tenhang.Name = "cb_tenhang";
            this.cb_tenhang.Size = new System.Drawing.Size(173, 21);
            this.cb_tenhang.TabIndex = 26;
            this.cb_tenhang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_themds
            // 
            this.btn_themds.Location = new System.Drawing.Point(133, 146);
            this.btn_themds.Name = "btn_themds";
            this.btn_themds.Size = new System.Drawing.Size(116, 34);
            this.btn_themds.TabIndex = 24;
            this.btn_themds.Text = "Thêm vào danh sách";
            this.btn_themds.UseVisualStyleBackColor = true;
            this.btn_themds.Click += new System.EventHandler(this.btn_themds_Click);
            // 
            // btn_xoakhoids
            // 
            this.btn_xoakhoids.Location = new System.Drawing.Point(319, 146);
            this.btn_xoakhoids.Name = "btn_xoakhoids";
            this.btn_xoakhoids.Size = new System.Drawing.Size(116, 34);
            this.btn_xoakhoids.TabIndex = 23;
            this.btn_xoakhoids.Text = "Xóa khỏi danh sách";
            this.btn_xoakhoids.UseVisualStyleBackColor = true;
            this.btn_xoakhoids.Click += new System.EventHandler(this.btn_xoakhoids_Click);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(371, 105);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(124, 20);
            this.txt_thanhtien.TabIndex = 20;
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.AutoSize = true;
            this.lb_thanhtien.Location = new System.Drawing.Point(307, 108);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(58, 13);
            this.lb_thanhtien.TabIndex = 19;
            this.lb_thanhtien.Text = "Thành tiền";
            // 
            // datagrid_chitietnhap
            // 
            this.datagrid_chitietnhap.AllowUserToAddRows = false;
            this.datagrid_chitietnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_chitietnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_chitietnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahang,
            this.tenhang,
            this.tenncc,
            this.gianhap,
            this.slnhap,
            this.thanhtien});
            this.datagrid_chitietnhap.Location = new System.Drawing.Point(281, 226);
            this.datagrid_chitietnhap.MultiSelect = false;
            this.datagrid_chitietnhap.Name = "datagrid_chitietnhap";
            this.datagrid_chitietnhap.RowHeadersVisible = false;
            this.datagrid_chitietnhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_chitietnhap.Size = new System.Drawing.Size(644, 234);
            this.datagrid_chitietnhap.TabIndex = 20;
            this.datagrid_chitietnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_chitietnhap_CellClick);
            // 
            // mahang
            // 
            this.mahang.HeaderText = "Mã hàng";
            this.mahang.Name = "mahang";
            // 
            // tenhang
            // 
            this.tenhang.HeaderText = "Tên hàng";
            this.tenhang.Name = "tenhang";
            // 
            // tenncc
            // 
            this.tenncc.HeaderText = "Nhà cung cấp";
            this.tenncc.Name = "tenncc";
            // 
            // gianhap
            // 
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.Name = "gianhap";
            // 
            // slnhap
            // 
            this.slnhap.HeaderText = "Số lượng";
            this.slnhap.Name = "slnhap";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // btn_taohdn
            // 
            this.btn_taohdn.Location = new System.Drawing.Point(50, 268);
            this.btn_taohdn.Name = "btn_taohdn";
            this.btn_taohdn.Size = new System.Drawing.Size(176, 58);
            this.btn_taohdn.TabIndex = 21;
            this.btn_taohdn.Text = "Tạo hóa đơn";
            this.btn_taohdn.UseVisualStyleBackColor = true;
            this.btn_taohdn.Click += new System.EventHandler(this.btn_taohdn_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(50, 385);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(176, 35);
            this.btn_thoat.TabIndex = 22;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 473);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_taohdn);
            this.Controls.Add(this.datagrid_chitietnhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nhaphang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.Nhaphang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_chitietnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_mahdn;
        private System.Windows.Forms.Label lb_ngaynhap;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.TextBox txt_mahdn;
        private System.Windows.Forms.DateTimePicker datetime_hdn;
        private System.Windows.Forms.ComboBox cb_tennv;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_mahang;
        private System.Windows.Forms.Label lb_tenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.TextBox txt_nhacungcap;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.TextBox txt_slnhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_themds;
        private System.Windows.Forms.Button btn_xoakhoids;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.DataGridView datagrid_chitietnhap;
        private System.Windows.Forms.Button btn_taohdn;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cb_tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn slnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}