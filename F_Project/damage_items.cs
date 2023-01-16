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
    public partial class damage_items : Form
    {
        public damage_items()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void btn_back_Click(object sender, EventArgs e)
        {
            Store_keeperMainpage smain = new Store_keeperMainpage();
            smain.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into DamageItems values('" + txt_InvoiceNo.Text + "','" + txt_ItemCode.Text + "','" + txt_ItemName.Text + "','" + dobpikerDitem.Value + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void damage_items_Load(object sender, EventArgs e)
        {
            ViewDetails();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void ViewDetails()
        {
            string ConnectionString = (@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Quary = "SELECT*FROM DamageItem_table";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridViewDItem.DataSource = table;
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_InvoiceNo.Clear();
            txt_ItemCode.Clear();
            txt_ItemName.Clear();
        }
    }
}
