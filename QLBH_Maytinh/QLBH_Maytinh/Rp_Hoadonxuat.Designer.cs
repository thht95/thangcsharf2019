namespace QLBH_Maytinh
{
    partial class Rp_Hoadonxuat
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
            this.rphoadonxuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rphoadonxuat
            // 
            this.rphoadonxuat.ActiveViewIndex = -1;
            this.rphoadonxuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rphoadonxuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.rphoadonxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rphoadonxuat.Location = new System.Drawing.Point(0, 0);
            this.rphoadonxuat.Name = "rphoadonxuat";
            this.rphoadonxuat.Size = new System.Drawing.Size(1138, 499);
            this.rphoadonxuat.TabIndex = 0;
            this.rphoadonxuat.Load += new System.EventHandler(this.rphoadonxuat_Load);
            // 
            // Rp_Hoadonxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 499);
            this.Controls.Add(this.rphoadonxuat);
            this.Name = "Rp_Hoadonxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo hóa đơn xuất";
            this.Load += new System.EventHandler(this.Rp_Hoadonxuat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rphoadonxuat;
    }
}