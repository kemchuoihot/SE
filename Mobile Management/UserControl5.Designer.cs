namespace Mobile_Management
{
    partial class UserControl5
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
            this.Total_Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Number_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDanhSachXuat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tenNguoiNhan = new System.Windows.Forms.TextBox();
            this.soDienThoai = new System.Windows.Forms.TextBox();
            this.diaChi = new System.Windows.Forms.TextBox();
            this.ngayXuatKho = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTTGiaoHang = new System.Windows.Forms.ComboBox();
            this.comboTTThanhToan = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.maPhieuXuat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // Total_Money
            // 
            this.Total_Money.DataPropertyName = "Total_Money";
            this.Total_Money.HeaderText = "Total Money";
            this.Total_Money.MinimumWidth = 6;
            this.Total_Money.Name = "Total_Money";
            this.Total_Money.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // ID_Product
            // 
            this.ID_Product.DataPropertyName = "ID_Product";
            this.ID_Product.HeaderText = "ID Product";
            this.ID_Product.MinimumWidth = 6;
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID_Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Product.Width = 125;
            // 
            // Name_Product
            // 
            this.Name_Product.DataPropertyName = "Name_Product";
            this.Name_Product.HeaderText = "Name Product";
            this.Name_Product.MinimumWidth = 6;
            this.Name_Product.Name = "Name_Product";
            this.Name_Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Name_Product.Width = 125;
            // 
            // Number_Product
            // 
            this.Number_Product.DataPropertyName = "Number_Product";
            this.Number_Product.HeaderText = "Number Product";
            this.Number_Product.MinimumWidth = 6;
            this.Number_Product.Name = "Number_Product";
            this.Number_Product.Visible = false;
            this.Number_Product.Width = 125;
            // 
            // dataDanhSachXuat
            // 
            this.dataDanhSachXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number_Product,
            this.Name_Product,
            this.ID_Product,
            this.Amount,
            this.Price,
            this.Total_Money});
            this.dataDanhSachXuat.Location = new System.Drawing.Point(2, 278);
            this.dataDanhSachXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dataDanhSachXuat.Name = "dataDanhSachXuat";
            this.dataDanhSachXuat.RowHeadersVisible = false;
            this.dataDanhSachXuat.RowHeadersWidth = 51;
            this.dataDanhSachXuat.RowTemplate.Height = 24;
            this.dataDanhSachXuat.Size = new System.Drawing.Size(755, 245);
            this.dataDanhSachXuat.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(130, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 61);
            this.label1.TabIndex = 43;
            this.label1.Text = "CREATE GOOD DELIVERY NOTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Code1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(20, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(20, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Address";
            // 
            // tenNguoiNhan
            // 
            this.tenNguoiNhan.Location = new System.Drawing.Point(113, 144);
            this.tenNguoiNhan.Margin = new System.Windows.Forms.Padding(2);
            this.tenNguoiNhan.Name = "tenNguoiNhan";
            this.tenNguoiNhan.Size = new System.Drawing.Size(166, 20);
            this.tenNguoiNhan.TabIndex = 49;
            // 
            // soDienThoai
            // 
            this.soDienThoai.Location = new System.Drawing.Point(113, 179);
            this.soDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.Size = new System.Drawing.Size(166, 20);
            this.soDienThoai.TabIndex = 50;
            // 
            // diaChi
            // 
            this.diaChi.Location = new System.Drawing.Point(113, 216);
            this.diaChi.Margin = new System.Windows.Forms.Padding(2);
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(166, 20);
            this.diaChi.TabIndex = 51;
            // 
            // ngayXuatKho
            // 
            this.ngayXuatKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayXuatKho.Location = new System.Drawing.Point(510, 105);
            this.ngayXuatKho.Margin = new System.Windows.Forms.Padding(2);
            this.ngayXuatKho.Name = "ngayXuatKho";
            this.ngayXuatKho.Size = new System.Drawing.Size(120, 20);
            this.ngayXuatKho.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(383, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Date Out";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(383, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Delivery State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(383, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Payment";
            // 
            // comboTTGiaoHang
            // 
            this.comboTTGiaoHang.FormattingEnabled = true;
            this.comboTTGiaoHang.Location = new System.Drawing.Point(510, 142);
            this.comboTTGiaoHang.Margin = new System.Windows.Forms.Padding(2);
            this.comboTTGiaoHang.Name = "comboTTGiaoHang";
            this.comboTTGiaoHang.Size = new System.Drawing.Size(120, 21);
            this.comboTTGiaoHang.TabIndex = 57;
            // 
            // comboTTThanhToan
            // 
            this.comboTTThanhToan.FormattingEnabled = true;
            this.comboTTThanhToan.Location = new System.Drawing.Point(508, 179);
            this.comboTTThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.comboTTThanhToan.Name = "comboTTThanhToan";
            this.comboTTThanhToan.Size = new System.Drawing.Size(122, 21);
            this.comboTTThanhToan.TabIndex = 58;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXacNhan.Location = new System.Drawing.Point(420, 216);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(151, 42);
            this.btnXacNhan.TabIndex = 61;
            this.btnXacNhan.Text = "Confirm";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // maPhieuXuat
            // 
            this.maPhieuXuat.Location = new System.Drawing.Point(113, 102);
            this.maPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.maPhieuXuat.Name = "maPhieuXuat";
            this.maPhieuXuat.Size = new System.Drawing.Size(166, 20);
            this.maPhieuXuat.TabIndex = 62;
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maPhieuXuat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dataDanhSachXuat);
            this.Controls.Add(this.comboTTThanhToan);
            this.Controls.Add(this.comboTTGiaoHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ngayXuatKho);
            this.Controls.Add(this.diaChi);
            this.Controls.Add(this.soDienThoai);
            this.Controls.Add(this.tenNguoiNhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(755, 551);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Product;
        private System.Windows.Forms.DataGridViewComboBoxColumn Name_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Product;
        private System.Windows.Forms.DataGridView dataDanhSachXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tenNguoiNhan;
        private System.Windows.Forms.TextBox soDienThoai;
        private System.Windows.Forms.TextBox diaChi;
        private System.Windows.Forms.DateTimePicker ngayXuatKho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTTGiaoHang;
        private System.Windows.Forms.ComboBox comboTTThanhToan;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox maPhieuXuat;
    }
}
