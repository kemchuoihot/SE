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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void fillListBox()
        {
            SqlConnection sa = new SqlConnection();
            sa.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            //cmd.Connection = sa;
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
            //SqlCommand cmd = new SqlCommand();

            cmd.Connection = sa;
            cmd.CommandText = "SELECT DISTINCT Code FROM Good_Received_Note";
            sa.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listStock.Items.Add(dr.GetString(0));
            }
            sa.Close();
        }
        private void fillName(string mpx)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "SELECT DISTINCT Name_Employee,Date_In FROM Good_Received_Note where Code ='" + mpx + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tenNhanVien.Text = dr.GetString(0);
                ngayNhapKho.Value = dr.GetDateTime(1);
            }
            con.Close();
        }

        public void fill_grid(string mpn)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Number_Product, ID_Product,Name_Product, Amount,Price,Total_Money FROM Good_Received_Note where Code = '" + mpn + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataDanhSachPhieuNhap.DataSource = dt;
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
            if (!this.DesignMode)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                fillListBox();
                listStock.SelectedIndex = 0;
                string curItem = listStock.SelectedItem.ToString();
                fillName(curItem);
                fill_grid(curItem);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to Delete Note ?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
                SqlCommand cmd = con.CreateCommand();
                string curItem = listStock.SelectedItem.ToString();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Good_Received_Note where Code = '" + curItem + "'";
                con.Open();
                cmd.ExecuteNonQuery();

                Dashboard frm = new Dashboard();
                this.Dispose();
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }


        private void dataDanhSachPhieuNhap_MouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void listStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listStock.SelectedItem.ToString();
            maPhieuNhap.Text = curItem;
            fillName(curItem);
            fill_grid(curItem);
        }

        private void dataDanhSachPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            int id1;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            if (e.RowIndex > -1)
            {
                id = dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Number_Product"].Value.ToString();
                if (id == "")
                {
                    id1 = 0;
                }
                else
                {
                    id1 = Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Number_Product"].Value.ToString());
                }

                if (id1 == 0)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Good_Received_Note(Code,Name_Employee,Date_In,ID_Product,Name_Product,Amount,Price,Total_Money) values ('" + maPhieuNhap.Text.ToString() + "'" +
                                    ",N'" + tenNhanVien.Text.ToString() + "','" +
                                     ngayNhapKho.Value.Date.ToString("yyyyMMdd") + "'" +
                                    ",'" + dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["ID_Product"].Value.ToString() + "'" +
                                    ",N'" + dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Name_Product"].Value.ToString() + "'" +
                                    "," + 0 +
                                     "," + 0 +
                                       "," + 0 + ")";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    string curItem = listStock.SelectedItem.ToString();
                    fill_grid(curItem);
                }
                else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Good_Received_Note set Code ='" + maPhieuNhap.Text.ToString() + "'," +
                        "Name_Employee=N'" + tenNhanVien.Text.ToString() + "'," +
                        "Date_In='" + ngayNhapKho.Value.Date.ToString("yyyyMMdd") + "'," +
                        "ID_Product='" + dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["ID_Product"].Value.ToString() + "'," +
                        "Name_Product=N'" + dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Name_Product"].Value.ToString() + "'," +
                        "Amount=" + Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Amount"].Value.ToString()) + "," +
                        "Price=" + Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Price"].Value.ToString()) + "," +
                        "Total_Money=" + (dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Total_Money"].Value = Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Amount"].Value.ToString()) * Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["Price"].Value.ToString())) + " " +
                        "Where Number_Product = " + id1 + "";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    string curItem = listStock.SelectedItem.ToString();
                    fill_grid(curItem);

                }
            }
        }
    }
}
