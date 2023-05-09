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
    public partial class UserControl4 : UserControl
    {
        
        public UserControl4()
        {
            InitializeComponent();
        }

        private void maPhieuNhap_TextChanged(object sender, EventArgs e)
        {

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

        private void dataDanhSachPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dsNhap.Rows[e.RowIndex].Cells["Price"].Value != null && dsNhap.Rows[e.RowIndex].Cells["Amount"].Value != null)
                {

                    string soluong = dsNhap.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                    string dongia = dsNhap.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                    if (testInput(soluong, dongia))
                    {
                        dsNhap.Rows[e.RowIndex].Cells["Total_Money"].Value = Convert.ToInt32(dsNhap.Rows[e.RowIndex].Cells["Amount"].Value.ToString()) * Convert.ToInt32(dsNhap.Rows[e.RowIndex].Cells["Amount"].Value.ToString());

                    }
                    else
                    {
                        MessageBox.Show("Please Enter Price and Amount.");
                        dsNhap.Refresh();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tenNhanVien.Text.ToString() == "" || maPhieuNhap.Text.ToString() == "" || dsNhap.Rows[0].Cells["ID_Product"].Value.ToString() == "" || dsNhap.Rows[0].Cells["Name_Product"].Value.ToString() == "")
            {
                MessageBox.Show("Please enter full information.");
            }
            else
            {
                for (int i = 0; i < (dsNhap.Rows.Count - 1); i++)
                {
                    SqlConnection sqlCon = new SqlConnection();
                    sqlCon.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Good_Received_Note(Code,Name_Employee,Date_In,ID_Product,Name_Product,Amount,Price,Total_Money) values ('" + maPhieuNhap.Text.ToString() + "'" +
                                            ",N'" + tenNhanVien.Text.ToString() + "','" +
                                             ngayNhapKho.Value.Date.ToString("yyyyMMdd") + "'" +
                                            ",'" + dsNhap.Rows[i].Cells["ID_Product"].Value.ToString() + "'" +
                                            ",N'" + dsNhap.Rows[i].Cells["Name_Product"].Value.ToString() + "'" +
                                            "," + Convert.ToInt32(dsNhap.Rows[i].Cells["Amount"].Value.ToString()) +
                                             "," + Convert.ToInt32(dsNhap.Rows[i].Cells["Price"].Value.ToString()) +
                                               "," + Convert.ToInt32(dsNhap.Rows[i].Cells["Total_Money"].Value.ToString()) + ")"
                                               , sqlCon);
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
                MessageBox.Show("Data Successful!");
                //this.lose();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }
    }
}
