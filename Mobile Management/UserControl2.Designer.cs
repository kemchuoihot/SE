namespace Mobile_Management
{
    partial class UserControl2
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Number_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.maPhieuNhap = new System.Windows.Forms.TextBox();
            this.tenNhanVien = new System.Windows.Forms.TextBox();
            this.ngayNhapKho = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listStock = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(419, 268);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(272, 54);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete Note";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataDanhSachPhieuNhap
            // 
            this.dataDanhSachPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number_Product,
            this.ID_Product,
            this.Name_Product,
            this.Amount,
            this.Price,
            this.Total_Money});
            this.dataDanhSachPhieuNhap.Location = new System.Drawing.Point(3, 332);
            this.dataDanhSachPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDanhSachPhieuNhap.Name = "dataDanhSachPhieuNhap";
            this.dataDanhSachPhieuNhap.RowHeadersVisible = false;
            this.dataDanhSachPhieuNhap.RowHeadersWidth = 51;
            this.dataDanhSachPhieuNhap.RowTemplate.Height = 24;
            this.dataDanhSachPhieuNhap.Size = new System.Drawing.Size(1004, 300);
            this.dataDanhSachPhieuNhap.TabIndex = 14;
            this.dataDanhSachPhieuNhap.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataDanhSachPhieuNhap_MouseUp);
            this.dataDanhSachPhieuNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDanhSachPhieuNhap_CellValueChanged);
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
            // ID_Product
            // 
            this.ID_Product.DataPropertyName = "ID_Product";
            this.ID_Product.HeaderText = "ID Product";
            this.ID_Product.MinimumWidth = 6;
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Width = 125;
            // 
            // Name_Product
            // 
            this.Name_Product.DataPropertyName = "Name_Product";
            this.Name_Product.HeaderText = "Name Product";
            this.Name_Product.MinimumWidth = 6;
            this.Name_Product.Name = "Name_Product";
            this.Name_Product.Width = 135;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Total_Money
            // 
            this.Total_Money.DataPropertyName = "Total_Money";
            this.Total_Money.HeaderText = "Total Money";
            this.Total_Money.MinimumWidth = 6;
            this.Total_Money.Name = "Total_Money";
            this.Total_Money.Width = 125;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(329, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 108);
            this.label4.TabIndex = 22;
            this.label4.Text = "Good Received Note";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maPhieuNhap
            // 
            this.maPhieuNhap.Enabled = false;
            this.maPhieuNhap.Location = new System.Drawing.Point(419, 126);
            this.maPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maPhieuNhap.Name = "maPhieuNhap";
            this.maPhieuNhap.Size = new System.Drawing.Size(271, 22);
            this.maPhieuNhap.TabIndex = 21;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.Enabled = false;
            this.tenNhanVien.Location = new System.Drawing.Point(419, 176);
            this.tenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.Size = new System.Drawing.Size(271, 22);
            this.tenNhanVien.TabIndex = 20;
            // 
            // ngayNhapKho
            // 
            this.ngayNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngayNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayNhapKho.Location = new System.Drawing.Point(419, 223);
            this.ngayNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayNhapKho.Name = "ngayNhapKho";
            this.ngayNhapKho.Size = new System.Drawing.Size(189, 22);
            this.ngayNhapKho.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(273, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date_In";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(273, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name_Employee";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(273, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code";
            // 
            // listStock
            // 
            this.listStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStock.FormattingEnabled = true;
            this.listStock.HorizontalScrollbar = true;
            this.listStock.ItemHeight = 16;
            this.listStock.Location = new System.Drawing.Point(871, 20);
            this.listStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(63, 308);
            this.listStock.TabIndex = 15;
            this.listStock.SelectedIndexChanged += new System.EventHandler(this.listStock_SelectedIndexChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataDanhSachPhieuNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maPhieuNhap);
            this.Controls.Add(this.tenNhanVien);
            this.Controls.Add(this.ngayNhapKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStock);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1007, 678);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataDanhSachPhieuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maPhieuNhap;
        private System.Windows.Forms.TextBox tenNhanVien;
        private System.Windows.Forms.DateTimePicker ngayNhapKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Money;
    }
}
