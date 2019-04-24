namespace QLBH_Maytinh
{
    partial class Rp_Hoadonnhap
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
            this.rphoadonnhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rphoadonnhap
            // 
            this.rphoadonnhap.ActiveViewIndex = -1;
            this.rphoadonnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rphoadonnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.rphoadonnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rphoadonnhap.Location = new System.Drawing.Point(0, 0);
            this.rphoadonnhap.Name = "rphoadonnhap";
            this.rphoadonnhap.Size = new System.Drawing.Size(1128, 469);
            this.rphoadonnhap.TabIndex = 0;
            // 
            // Rp_Hoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 469);
            this.Controls.Add(this.rphoadonnhap);
            this.IsMdiContainer = true;
            this.Name = "Rp_Hoadonnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rp_Hoadonnhap";
            this.Load += new System.EventHandler(this.Rp_Hoadonnhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rphoadonnhap;
    }
}