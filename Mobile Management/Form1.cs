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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sa = new SqlConnection();
            sa.ConnectionString = "data source = MSI; database = MANAGEMENT;integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sa;
            cmd.CommandText = "select * from loginTable where username ='" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password.Please check it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkPass.Checked ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
