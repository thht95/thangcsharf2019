namespace QLBH_Maytinh
{
    partial class DanhsachHDX
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
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.datagrid_hdx = new System.Windows.Forms.DataGridView();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.date_ngayxuat = new System.Windows.Forms.DateTimePicker();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_mahdx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_hdx)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(163, 194);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(107, 38);
            this.btn_boqua.TabIndex = 25;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_baocao
            // 
            this.btn_baocao.Location = new System.Drawing.Point(18, 194);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(107, 38);
            this.btn_baocao.TabIndex = 24;
            this.btn_baocao.Text = "Báo cáo";
            this.btn_baocao.UseVisualStyleBackColor = true;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(163, 136);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 38);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.Location = new System.Drawing.Point(18, 136);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(107, 38);
            this.btn_xemchitiet.TabIndex = 22;
            this.btn_xemchitiet.Text = "Xem chi tiết";
            this.btn_xemchitiet.UseVisualStyleBackColor = true;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemchitiet_Click);
            // 
            // datagrid_hdx
            // 
            this.datagrid_hdx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_hdx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid_hdx.Location = new System.Drawing.Point(297, 12);
            this.datagrid_hdx.MultiSelect = false;
            this.datagrid_hdx.Name = "datagrid_hdx";
            this.datagrid_hdx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_hdx.Size = new System.Drawing.Size(759, 220);
            this.datagrid_hdx.TabIndex = 21;
            this.datagrid_hdx.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_hdx_CellClick);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(82, 99);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(200, 20);
            this.txt_tongtien.TabIndex = 20;
            // 
            // date_ngayxuat
            // 
            this.date_ngayxuat.Location = new System.Drawing.Point(82, 41);
            this.date_ngayxuat.Name = "date_ngayxuat";
            this.date_ngayxuat.Size = new System.Drawing.Size(200, 20);
            this.date_ngayxuat.TabIndex = 19;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(82, 70);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(200, 20);
            this.txt_manv.TabIndex = 18;
            // 
            // txt_mahdx
            // 
            this.txt_mahdx.Location = new System.Drawing.Point(82, 12);
            this.txt_mahdx.Name = "txt_mahdx";
            this.txt_mahdx.Size = new System.Drawing.Size(200, 20);
            this.txt_mahdx.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã HĐX";
            // 
            // DanhsachHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 243);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_baocao);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xemchitiet);
            this.Controls.Add(this.datagrid_hdx);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.date_ngayxuat);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.txt_mahdx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhsachHDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn xuất";
            this.Load += new System.EventHandler(this.DanhsachHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_hdx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xemchitiet;
        private System.Windows.Forms.DataGridView datagrid_hdx;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.DateTimePicker date_ngayxuat;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_mahdx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}