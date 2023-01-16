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
    public partial class add_items : Form
    {
        public add_items()
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

        private void add_items_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
            ViewDetails();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into addItem values('"+txt_InvoiceNo.Text+"','"+txt_itemCode.Text+"','"+dateTimePickerAdd.Value+"','"+com_Item.SelectedValue+"','"+txt_model.Text+"','"+txt_qty.Text+"')", con);
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
            ViewDetails();


        }
        public void ViewDetails()
        {
            con.Open();
            da = new SqlDataAdapter("SELECT*FROM addItem", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewAddItem.DataSource = dt;
            con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            txt_InvoiceNo.Clear();
            txt_itemCode.Clear();
            txt_model.Clear();
            txt_qty.Clear();
        }
    }
}
