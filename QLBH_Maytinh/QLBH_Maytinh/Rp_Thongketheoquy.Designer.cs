namespace QLBH_Maytinh
{
    partial class Thống_kê_doanh_thu_theo_quý
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
            this.rpdoanhthutheoquy = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.mtxt_nam = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // rpdoanhthutheoquy
            // 
            this.rpdoanhthutheoquy.ActiveViewIndex = -1;
            this.rpdoanhthutheoquy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpdoanhthutheoquy.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpdoanhthutheoquy.Location = new System.Drawing.Point(12, 76);
            this.rpdoanhthutheoquy.Name = "rpdoanhthutheoquy";
            this.rpdoanhthutheoquy.Size = new System.Drawing.Size(1067, 389);
            this.rpdoanhthutheoquy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập vào năm";
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(361, 26);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 3;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // mtxt_nam
            // 
            this.mtxt_nam.Location = new System.Drawing.Point(216, 28);
            this.mtxt_nam.Mask = "0000";
            this.mtxt_nam.Name = "mtxt_nam";
            this.mtxt_nam.Size = new System.Drawing.Size(138, 20);
            this.mtxt_nam.TabIndex = 4;
            // 
            // Thống_kê_doanh_thu_theo_quý
            // 
            this.AcceptButton = this.btn_in;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 477);
            this.Controls.Add(this.mtxt_nam);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpdoanhthutheoquy);
            this.Name = "Thống_kê_doanh_thu_theo_quý";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu theo quý";
            this.Load += new System.EventHandler(this.Thống_kê_doanh_thu_theo_quý_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpdoanhthutheoquy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.MaskedTextBox mtxt_nam;
    }
}