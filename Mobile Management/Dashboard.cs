using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Management
{
    
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
            userControl21.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            userControl61.Visible = true;
            userControl61.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl41.Visible = false;
            userControl51.Visible = false;
            userControl61.Visible=false;
            userControl71.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            userControl31.Visible = true;
            userControl31.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            userControl41.Visible = true;
            userControl41.BringToFront();
        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            userControl51.Visible = true;
            userControl51.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            userControl71.Visible = true;
            userControl71.BringToFront();
        }
    }
}
