using DGVPrinterHelper;
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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void getInfo(string mpx)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
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

            cmd.CommandText = "SELECT DISTINCT Code1,Customer,Phone,Address,Date_out,Ship,Pay FROM GOOD_DELIVERY_NOTE where Code1 = '" + mpx + "'";
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                maPhieuXuat.Text = dt.Rows[0]["Code1"].ToString();
                tenNguoiNhan.Text = dt.Rows[0]["Customer"].ToString();
                soDienThoai.Text = dt.Rows[0]["Phone"].ToString();
                diaChi.Text = dt.Rows[0]["Address"].ToString();
                ngayXuatKho.Text = dt.Rows[0]["Date_out"].ToString();
                comboTTThanhToan.Text = dt.Rows[0]["Pay"].ToString();
                comboTTGiaoHang.Text = dt.Rows[0]["Ship"].ToString();

            }


            string curItem = listOut.SelectedItem.ToString();
            fillGrid(curItem);
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            fillListBox();
            listOut.SelectedIndex = 0;
            string curItem = listOut.SelectedItem.ToString();
            fillCombo();
            getInfo(curItem);
            comboTTGiaoHang.Items.Add("Processing");
            comboTTGiaoHang.Items.Add("Delivery in progress");
            comboTTGiaoHang.Items.Add("Successful delivery");
            comboTTThanhToan.Items.Add("Unpaid");
            comboTTThanhToan.Items.Add("Paid");
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            cmd.CommandText = "SELECT DISTINCT Code1 FROM GOOD_DELIVERY_NOTE";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listOut.Items.Add(dr.GetString(0));
            }
            con.Close();
        }

        private void fillGrid(string mpx)
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
            cmd.CommandText = "SELECT Number_Product, Name_Product,ID_Product, Amount,Price,Total_Money FROM GOOD_DELIVERY_NOTE where Code1 = '" + mpx + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataDanhSachXuat.DataSource = dt;
        }


        private void fillCombo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }


            con.Open();

            SqlCommand lenh = new SqlCommand("SELECT DISTINCT Name_Product  From GOOD_DELIVERY_NOTE", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("SP");
            da.Fill(dt);
            Name_Product.ValueMember = "Name_Product";
            Name_Product.DisplayMember = "Name_Product";
            Name_Product.DataSource = dt;

        }
        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete Note ?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
                SqlCommand cmd = con.CreateCommand();
                string curItem = listOut.SelectedItem.ToString();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM GOOD_DELIVERY_NOTE where Code1 = '" + curItem + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                Dashboard objFrmGrafik = new Dashboard();
                this.Dispose();
                objFrmGrafik.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void dataDanhSachXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            int id1;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            if (e.RowIndex > -1)
            {
                id = dataDanhSachXuat.Rows[e.RowIndex].Cells["Number_Product"].Value.ToString();
                if (id == "")
                {
                    id1 = 0;
                }
                else
                {
                    id1 = Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["Number_Product"].Value.ToString());
                }

                if (id1 == 0) 
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO GOOD_DELIVERY_NOTE(Code1,Customer,Phone,Address,Date_out,ID_Product,Name_Product,Amount, Price,Total_Money) values ('" + maPhieuXuat.Text.ToString() + "'" +
                                    ",N'" + tenNguoiNhan.Text.ToString() + "','" +
                                     soDienThoai.Text.ToString() + "'" +
                                    ",N'" + diaChi.Text.ToString() + "'" +
                                    ",'" + ngayXuatKho.Value.Date.ToString("yyyyMMdd") + "'" +
                                    ",'" + dataDanhSachXuat.Rows[e.RowIndex].Cells["ID_Product"].Value.ToString() +
                                     "',N'" + Convert.ToString((dataDanhSachXuat.Rows[e.RowIndex].Cells["Name_Product"] as DataGridViewComboBoxCell).FormattedValue.ToString()) +
                                       "'," + 0 +
                                        "," + 0 +
                                         "," + 0 + ")";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    string curItem = listOut.SelectedItem.ToString();
                    fillGrid(curItem);
                }
                else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE GOOD_DELIVERY_NOTE set Code1 ='" + maPhieuXuat.Text.ToString() + "'," +
                        "Customer=N'" + tenNguoiNhan.Text.ToString() + "'," +
                        "Phone='" + soDienThoai.Text.ToString() + "'," +
                        "Address=N'" + diaChi.Text.ToString() + "'," +
                        "Date_out='" + ngayXuatKho.Value.Date.ToString("yyyyMMdd") + "'," +
                        "ID_Product='" + dataDanhSachXuat.Rows[e.RowIndex].Cells["ID_Product"].Value.ToString() + "'," +
                        "Name_Product=N'" + Convert.ToString((dataDanhSachXuat.Rows[e.RowIndex].Cells["Name_Product"] as DataGridViewComboBoxCell).FormattedValue.ToString()) + "'," +
                        "Amount=" + Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["Amount"].Value.ToString()) + "," +
                         "Price=" + Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["Price"].Value.ToString()) + "," +
                        "Total_Money=" + (dataDanhSachXuat.Rows[e.RowIndex].Cells["Total_Money"].Value = Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["Amount"].Value.ToString()) * Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["Price"].Value.ToString())) + " " + "Where Number_Product = " + id1 + "";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    string curItem = listOut.SelectedItem.ToString();
                    fillGrid(curItem);
                }
            }
        }

        private void listOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listOut.SelectedItem.ToString();
            fillCombo();
            getInfo(curItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string curItem = listOut.SelectedItem.ToString();
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Custorm Bill";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataDanhSachXuat);

            dataDanhSachXuat.ClearSelection();




        }

        private void dataDanhSachXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
