using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Management
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            comboTTGiaoHang.Items.Add("Processing");
            comboTTGiaoHang.Items.Add("Delivery in progress");
            comboTTGiaoHang.Items.Add("Successful delivery");


            comboTTThanhToan.Items.Add("Unpaid");
            comboTTThanhToan.Items.Add("Paid");

            con.Open();

            SqlCommand lenh = new SqlCommand("SELECT DISTINCT Name_Product  From GOOD_DELIVERY_NOTE", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("SP");
            da.Fill(dt);
            Name_Product.ValueMember = "Name_Product";
            Name_Product.DisplayMember = "Name_Product";
            Name_Product.DataSource = dt;

            con.Close();
        }

        public bool testInput(string soluong, string dongia)
        {

            if (IsValidDecimalNumber(dongia).ToString() == "False" || IsValidDecimalNumber(soluong).ToString() == "False")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool IsValidDecimalNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;
            return !s.Any(c => !(char.IsDigit(c) || c == '.')) && !(s.Count(c => c == '.') > 1);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            

            if (maPhieuXuat.Text.ToString() == "" || tenNguoiNhan.Text.ToString() == "" || comboTTThanhToan.SelectedItem.ToString() == "" || comboTTGiaoHang.SelectedItem.ToString() == "" || soDienThoai.Text.ToString() == "" || diaChi.Text.ToString() == "" || dataDanhSachXuat.Rows[0].Cells["ID_Product"].Value.ToString() == "" || dataDanhSachXuat.Rows[0].Cells["Name_Product"].Value.ToString() == "" || dataDanhSachXuat.Rows[0].Cells["Amount"].Value.ToString() == "") 
            {
                MessageBox.Show("Please enter full information.");
            }
            else
            {

                for (int i = 0; i < (dataDanhSachXuat.Rows.Count - 1); i++)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-A7883S9; database = MANAGEMENT;integrated security = True ";
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO GOOD_DELIVERY_NOTE(Code1,Customer,Phone,Address,Date_out,ID_Product,Name_Product,Amount,Price,Total_Money,Pay,Ship) values ('" + maPhieuXuat.Text.ToString() + "'" +
                                            ",N'" + tenNguoiNhan.Text.ToString() + "','" +
                                             soDienThoai.Text.ToString() + "'" +
                                             ",N'" + diaChi.Text.ToString() + "'," +
                                             "'" + ngayXuatKho.Value.Date.ToString("yyyyMMdd") + "'" +
                                            ",'" + dataDanhSachXuat.Rows[i].Cells["ID_Product"].Value.ToString() + "'" +
                                            ",N'" + dataDanhSachXuat.Rows[i].Cells["Name_Product"].Value.ToString() + "'" +
                                            "," + Convert.ToInt32(dataDanhSachXuat.Rows[i].Cells["Amount"].Value.ToString()) +
                                             "," + Convert.ToInt32(dataDanhSachXuat.Rows[i].Cells["Price"].Value.ToString()) +
                                               "," + Convert.ToInt32(dataDanhSachXuat.Rows[i].Cells["Total_Money"].Value = Convert.ToInt32(dataDanhSachXuat.Rows[i].Cells["Price"].Value.ToString()) * Convert.ToInt32(dataDanhSachXuat.Rows[i].Cells["Amount"].Value.ToString())) + "" +
                                                "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Data Successful!");
                //this.Close();
                Dashboard fx = new Dashboard();
                fx.Show();
            }
        }
    }
}
