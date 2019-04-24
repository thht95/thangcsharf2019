namespace QLBH_Maytinh
{
    partial class Rp_Nhanvien_Diachi
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
            this.rpnhanviendiachi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rpnhanviendiachi
            // 
            this.rpnhanviendiachi.ActiveViewIndex = -1;
            this.rpnhanviendiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpnhanviendiachi.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpnhanviendiachi.Location = new System.Drawing.Point(7, 65);
            this.rpnhanviendiachi.Name = "rpnhanviendiachi";
            this.rpnhanviendiachi.Size = new System.Drawing.Size(1017, 406);
            this.rpnhanviendiachi.TabIndex = 0;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(305, 17);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 1;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập vào địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(120, 19);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(165, 20);
            this.txt_diachi.TabIndex = 3;
            // 
            // Rp_Nhanvien_Diachi
            // 
            this.AcceptButton = this.btn_in;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 476);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.rpnhanviendiachi);
            this.Name = "Rp_Nhanvien_Diachi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhân viên theo địa chỉ";
            this.Load += new System.EventHandler(this.Rp_Nhanvien_Diachi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpnhanviendiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Button btn_in;
    }
}