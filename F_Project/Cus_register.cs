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
    public partial class Cus_register : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        
        public Cus_register()
        {
            InitializeComponent();
        }

        private void Cus_register_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void sidebarTimer1_Tick(object sender, EventArgs e)
        {

        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into cusRegister values('" + txt_cusCode.Text + "','" + txt_cusNIC.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_address.Text + "','" + txt_email.Text + "','" + txt_tp.Text + "','" + txt_billNo.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Not Successful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cusCode.Clear();
            txt_cusNIC.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_tp.Clear();
            txt_billNo.Clear();
        }
    }
}
