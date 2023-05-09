namespace Mobile_Management
{
    partial class UserControl7
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl7));
            this.btnXemTK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ngayThongKe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienXuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataDsXuat = new System.Windows.Forms.DataGridView();
            this.dataDsNhap = new System.Windows.Forms.DataGridView();
            this.MaSanPhamNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPhamNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPhamXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPhamXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDsXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDsNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemTK
            // 
            this.btnXemTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            resources.ApplyResources(this.btnXemTK, "btnXemTK");
            this.btnXemTK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXemTK.Name = "btnXemTK";
            this.btnXemTK.UseVisualStyleBackColor = false;
            this.btnXemTK.Click += new System.EventHandler(this.btnXemTK_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label1.Name = "label1";
            // 
            // ngayThongKe
            // 
            this.ngayThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.ngayThongKe, "ngayThongKe");
            this.ngayThongKe.Name = "ngayThongKe";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label4.Name = "label4";
            // 
            // txtTienXuat
            // 
            resources.ApplyResources(this.txtTienXuat, "txtTienXuat");
            this.txtTienXuat.Name = "txtTienXuat";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTienNhap
            // 
            resources.ApplyResources(this.txtTienNhap, "txtTienNhap");
            this.txtTienNhap.Name = "txtTienNhap";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label5.Name = "label5";
            // 
            // dataDsXuat
            // 
            this.dataDsXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDsXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPhamXuat,
            this.TenSanPhamXuat,
            this.SoLuongXuat,
            this.DonGiaXuat,
            this.TongTienXuat});
            resources.ApplyResources(this.dataDsXuat, "dataDsXuat");
            this.dataDsXuat.Name = "dataDsXuat";
            this.dataDsXuat.RowTemplate.Height = 24;
            // 
            // dataDsNhap
            // 
            this.dataDsNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDsNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPhamNhap,
            this.TenSanPhamNhap,
            this.SoLuongNhap,
            this.DonGiaNhap,
            this.TongTienNhap});
            resources.ApplyResources(this.dataDsNhap, "dataDsNhap");
            this.dataDsNhap.Name = "dataDsNhap";
            this.dataDsNhap.RowTemplate.Height = 24;
            // 
            // MaSanPhamNhap
            // 
            this.MaSanPhamNhap.DataPropertyName = "MaSanPhamNhap";
            resources.ApplyResources(this.MaSanPhamNhap, "MaSanPhamNhap");
            this.MaSanPhamNhap.Name = "MaSanPhamNhap";
            // 
            // TenSanPhamNhap
            // 
            this.TenSanPhamNhap.DataPropertyName = "TenSanPhamNhap";
            resources.ApplyResources(this.TenSanPhamNhap, "TenSanPhamNhap");
            this.TenSanPhamNhap.Name = "TenSanPhamNhap";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            resources.ApplyResources(this.SoLuongNhap, "SoLuongNhap");
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            resources.ApplyResources(this.DonGiaNhap, "DonGiaNhap");
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // TongTienNhap
            // 
            this.TongTienNhap.DataPropertyName = "TongTienNhap";
            resources.ApplyResources(this.TongTienNhap, "TongTienNhap");
            this.TongTienNhap.Name = "TongTienNhap";
            // 
            // MaSanPhamXuat
            // 
            this.MaSanPhamXuat.DataPropertyName = "MaSanPhamXuat";
            resources.ApplyResources(this.MaSanPhamXuat, "MaSanPhamXuat");
            this.MaSanPhamXuat.Name = "MaSanPhamXuat";
            // 
            // TenSanPhamXuat
            // 
            this.TenSanPhamXuat.DataPropertyName = "TenSanPhamXuat";
            resources.ApplyResources(this.TenSanPhamXuat, "TenSanPhamXuat");
            this.TenSanPhamXuat.Name = "TenSanPhamXuat";
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuongXuat";
            resources.ApplyResources(this.SoLuongXuat, "SoLuongXuat");
            this.SoLuongXuat.Name = "SoLuongXuat";
            // 
            // DonGiaXuat
            // 
            this.DonGiaXuat.DataPropertyName = "DonGiaXuat";
            resources.ApplyResources(this.DonGiaXuat, "DonGiaXuat");
            this.DonGiaXuat.Name = "DonGiaXuat";
            // 
            // TongTienXuat
            // 
            this.TongTienXuat.DataPropertyName = "TongTienXuat";
            resources.ApplyResources(this.TongTienXuat, "TongTienXuat");
            this.TongTienXuat.Name = "TongTienXuat";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl7
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataDsXuat);
            this.Controls.Add(this.dataDsNhap);
            this.Controls.Add(this.txtTienXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTienNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXemTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngayThongKe);
            this.Name = "UserControl7";
            this.Load += new System.EventHandler(this.UserControl7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDsXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDsNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngayThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataDsXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPhamXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPhamXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienXuat;
        private System.Windows.Forms.DataGridView dataDsNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPhamNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPhamNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienNhap;
        private System.Windows.Forms.Button button1;
    }
}
