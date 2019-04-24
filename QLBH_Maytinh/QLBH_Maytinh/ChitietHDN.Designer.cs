namespace QLBH_Maytinh
{
    partial class ChitietHDN
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mahdn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_chitiethdn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.datagrid_chitiethdn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_chitiethdn)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã hóa đơn nhập";
            // 
            // txt_mahdn
            // 
            this.txt_mahdn.Location = new System.Drawing.Point(110, 15);
            this.txt_mahdn.Name = "txt_mahdn";
            this.txt_mahdn.Size = new System.Drawing.Size(200, 20);
            this.txt_mahdn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(433, 50);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(200, 20);
            this.txt_tennv.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tổng tiền";
            // 
            // date_chitiethdn
            // 
            this.date_chitiethdn.Location = new System.Drawing.Point(110, 50);
            this.date_chitiethdn.Name = "date_chitiethdn";
            this.date_chitiethdn.Size = new System.Drawing.Size(200, 20);
            this.date_chitiethdn.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã nhân viên";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(433, 15);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(200, 20);
            this.txt_manv.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên nhân viên";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(110, 87);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(200, 20);
            this.txt_tongtien.TabIndex = 14;
            // 
            // datagrid_chitiethdn
            // 
            this.datagrid_chitiethdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_chitiethdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_chitiethdn.Location = new System.Drawing.Point(15, 128);
            this.datagrid_chitiethdn.Name = "datagrid_chitiethdn";
            this.datagrid_chitiethdn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_chitiethdn.Size = new System.Drawing.Size(618, 228);
            this.datagrid_chitiethdn.TabIndex = 15;
            this.datagrid_chitiethdn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ChitietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 366);
            this.Controls.Add(this.datagrid_chitiethdn);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_chitiethdn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mahdn);
            this.Controls.Add(this.label5);
            this.Name = "ChitietHDN";
            this.Text = "Chi tiết hóa đơn nhập";
            this.Load += new System.EventHandler(this.ChitietHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_chitiethdn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mahdn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_chitiethdn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.DataGridView datagrid_chitiethdn;
    }
}