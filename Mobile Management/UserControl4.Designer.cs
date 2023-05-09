namespace Mobile_Management
{
    partial class UserControl4
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
            this.ngayNhapKho = new System.Windows.Forms.DateTimePicker();
            this.tenNhanVien = new System.Windows.Forms.TextBox();
            this.maPhieuNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dsNhap = new System.Windows.Forms.DataGridView();
            this.Number_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayNhapKho
            // 
            this.ngayNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngayNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayNhapKho.Location = new System.Drawing.Point(139, 182);
            this.ngayNhapKho.Margin = new System.Windows.Forms.Padding(2);
            this.ngayNhapKho.Name = "ngayNhapKho";
            this.ngayNhapKho.Size = new System.Drawing.Size(244, 20);
            this.ngayNhapKho.TabIndex = 15;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tenNhanVien.Location = new System.Drawing.Point(139, 136);
            this.tenNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.tenNhanVien.Multiline = true;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.Size = new System.Drawing.Size(244, 31);
            this.tenNhanVien.TabIndex = 14;
            // 
            // maPhieuNhap
            // 
            this.maPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maPhieuNhap.Location = new System.Drawing.Point(139, 98);
            this.maPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.maPhieuNhap.Multiline = true;
            this.maPhieuNhap.Name = "maPhieuNhap";
            this.maPhieuNhap.Size = new System.Drawing.Size(244, 32);
            this.maPhieuNhap.TabIndex = 13;
            this.maPhieuNhap.TextChanged += new System.EventHandler(this.maPhieuNhap_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(13, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date_In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(196, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 33);
            this.label4.TabIndex = 19;
            this.label4.Text = "Create Good Received Note";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(506, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsNhap
            // 
            this.dsNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number_Product,
            this.ID_Product,
            this.Name_Product,
            this.Amount,
            this.Price,
            this.Total_Money});
            this.dsNhap.Location = new System.Drawing.Point(0, 258);
            this.dsNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dsNhap.Name = "dsNhap";
            this.dsNhap.RowHeadersVisible = false;
            this.dsNhap.RowHeadersWidth = 51;
            this.dsNhap.RowTemplate.Height = 24;
            this.dsNhap.Size = new System.Drawing.Size(809, 244);
            this.dsNhap.TabIndex = 20;
            this.dsNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDanhSachPhieuNhap_CellContentClick);
            this.dsNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsNhap_CellValueChanged);
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
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dsNhap);
            this.Controls.Add(this.ngayNhapKho);
            this.Controls.Add(this.tenNhanVien);
            this.Controls.Add(this.maPhieuNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(811, 551);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker ngayNhapKho;
        private System.Windows.Forms.TextBox tenNhanVien;
        private System.Windows.Forms.TextBox maPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dsNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Money;
    }
}
