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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }
        private void fillListBox()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT DISTINCT Code2 FROM Purchase_Order";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listOrder.Items.Add(dr.GetString(0));
            }
            con.Close();
        }
        private void fillGrid(string mdh)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  Id_Product,Name_Product, Amount,Price,Total_Money FROM Purchase_Order where Code2 = '" + mdh + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataDonHang.DataSource = dt;
        }
        private void UserControl6_Load(object sender, EventArgs e)
        {
            fillListBox();
            if (listOrder.Items.Count > 0)
            {
                listOrder.SelectedIndex = 0;
                string curItem = listOrder.SelectedItem.ToString();
                fillGrid(curItem);
                getInfo(curItem);
            }
            else
            {
                MessageBox.Show("List is empty");
            }
        }

        private void btnChuyenPhieuXuat_Click(object sender, EventArgs e)
        {
            string curItem = listOrder.SelectedItem.ToString();

            for (int i = 0; i < (dataDonHang.Rows.Count - 1); i++)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
                SqlCommand cmd = new SqlCommand(@"INSERT INTO GOOD_DELIVERY_NOTE(Code1,Customer,Phone,Address,Date_out,ID_Product,Name_Product,Amount,Price,Total_Money,Pay,Ship) values ('" + maDon.Text.ToString() + "'" +
                                        ",N'" + tenDaiLy.Text.ToString() + "','" +
                                         soDienThoai.Text.ToString() + "'" +
                                         ",N'" + diaChi.Text.ToString() + "'," +
                                         "'" + ngayDatHang.Value.Date.ToString("yyyyMMdd") + "'" +
                                        ",'" + dataDonHang.Rows[i].Cells["ID_Product"].Value.ToString() + "'" +
                                        ",N'" + dataDonHang.Rows[i].Cells["Name_Product"].Value.ToString() + "'" +
                                        "," + Convert.ToInt32(dataDonHang.Rows[i].Cells["Amount"].Value.ToString()) +
                                         "," + Convert.ToInt32(dataDonHang.Rows[i].Cells["Price"].Value.ToString()) +
                                           "," + Convert.ToInt32(dataDonHang.Rows[i].Cells["Total_Money"].Value.ToString()) + ",N'Unpaid',N'Delivery in progress')", con);

                SqlCommand cmd2 = con.CreateCommand();

                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "DELETE FROM Purchase_Order where Code2 ='" + curItem + "'";


                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                con.Close();
            }
            MessageBox.Show("Data Successful!");
            //this.Close();
            Dashboard ds = new Dashboard();
            ds.Show();
        }
        private void getInfo(string mdh)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Clear();
            SqlDataAdapter da = new SqlDataAdapter();
            
            DataTable dt = new DataTable("INFO");

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT DISTINCT Code2,Name_City,Address,Phone,Date_Order,Pay FROM Purchase_Order where Code2 = '" + mdh + "'";
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                maDon.Text = dt.Rows[0]["Code2"].ToString();
                tenDaiLy.Text = dt.Rows[0]["Name_City"].ToString();
                soDienThoai.Text = dt.Rows[0]["Phone"].ToString();
                diaChi.Text = dt.Rows[0]["Address"].ToString();
                ngayDatHang.Text = dt.Rows[0]["Date_Order"].ToString();
                htThanhToan.Text = dt.Rows[0]["Pay"].ToString();
            }

        }

        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listOrder.SelectedItem.ToString();
            fillGrid(curItem);
            getInfo(curItem);
        }
    }
}
