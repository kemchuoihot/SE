using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Management
{
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UserControl7_Load(object sender, EventArgs e)
        {
            ngayThongKe.Format = DateTimePickerFormat.Custom;
            ngayThongKe.CustomFormat = "MM/yyyy";
            ngayThongKe.ShowUpDown = true;
        }
         private void fillDSNhap(string ngaynhap)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ID_Product AS MaSanPhamNhap,Name_Product AS TenSanPhamNhap, Amount AS SoLuongNhap, Price AS DonGiaNhap, Total_Money AS TongTienNhap FROM Good_Received_Note where Date_In like '%" + ngaynhap + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataDsNhap.DataSource = dt;
            int tongTien = 0;
            //tinh tong tien nhap
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongTien += Convert.ToInt32(dt.Rows[i]["TongTienNhap"].ToString());
            }
            txtTienNhap.Text = tongTien.ToString();

        }

        private void fillDSXuat(string ngayxuat)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ID_Product AS MaSanPhamXuat,Name_Product AS TenSanPhamXuat, Amount AS SoLuongXuat, Price AS DonGiaXuat, Total_Money AS TongTienXuat FROM GOOD_DELIVERY_NOTE where Date_out like '%" + ngayxuat + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int tongTienXuat = 0;
            dataDsXuat.DataSource = dt;
            //Tinh tong tien xuat
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongTienXuat += Convert.ToInt32(dt.Rows[i]["TongTienXuat"].ToString());
            }
            txtTienXuat.Text = tongTienXuat.ToString();
        }

        

        private void btnXemTK_Click_1(object sender, EventArgs e)
        {
            string ngay = ngayThongKe.Value.Date.ToString("yyyy-MM");
            fillDSNhap(ngay);
            fillDSXuat(ngay);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Custorm Bill";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataDsNhap);
            printer.PrintDataGridView(dataDsXuat);
            dataDsNhap.ClearSelection();
            dataDsXuat.ClearSelection();
        }
    }
}
