namespace QLBH_Maytinh
{
    partial class Rp_Hangtonkho
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
            this.rphangton = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rphangton
            // 
            this.rphangton.ActiveViewIndex = -1;
            this.rphangton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rphangton.Cursor = System.Windows.Forms.Cursors.Default;
            this.rphangton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rphangton.Location = new System.Drawing.Point(0, 0);
            this.rphangton.Name = "rphangton";
            this.rphangton.Size = new System.Drawing.Size(1006, 503);
            this.rphangton.TabIndex = 0;
            // 
            // Rp_Hangtonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 503);
            this.Controls.Add(this.rphangton);
            this.Name = "Rp_Hangtonkho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hàng tồn";
            this.Load += new System.EventHandler(this.Rp_Hangtonkho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rphangton;
    }
}