namespace QLBH_Maytinh
{
    partial class Rp_Thongkehangbanchay
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
            this.rphangbanchay = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rphangbanchay
            // 
            this.rphangbanchay.ActiveViewIndex = -1;
            this.rphangbanchay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rphangbanchay.Cursor = System.Windows.Forms.Cursors.Default;
            this.rphangbanchay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rphangbanchay.Location = new System.Drawing.Point(0, 0);
            this.rphangbanchay.Name = "rphangbanchay";
            this.rphangbanchay.Size = new System.Drawing.Size(1107, 488);
            this.rphangbanchay.TabIndex = 0;
            // 
            // Rp_Thongkehangbanchay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 488);
            this.Controls.Add(this.rphangbanchay);
            this.Name = "Rp_Thongkehangbanchay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hàng bán chạy nhất";
            this.Load += new System.EventHandler(this.Rp_Thongkehangbanchay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rphangbanchay;
    }
}