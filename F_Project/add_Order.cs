using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace F_Project
{
    public partial class add_Order : Form
    {
        public add_Order()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Package_Details pdetails = new Package_Details();
            pdetails.Show();
            this.Hide();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into AddOder_tabel values('" + txt_pcode.Text + "','" + txt_cusId.Text + "','" + txt_oId.Text + "','" + txt_location.Text + "','" + txt_status.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    // MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    payForm pay = new payForm();
                    pay.Show();
                }
                else
                    MessageBox.Show("Not Successful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void add_Order_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            txt_pcode.Clear();
            txt_cusId.Clear();
            txt_oId.Clear();
            txt_location.Clear();
            txt_status.Clear();
        }
    }
}
