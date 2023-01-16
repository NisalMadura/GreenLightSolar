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
    public partial class create_user : Form
    {
        public create_user()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }

        private void create_user_Load(object sender, EventArgs e)
        {
            ViewDetails();

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAdduser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_name.Clear();
            txt_userId.Clear();
            txt_tp.Clear();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
             con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");

            try
            {
                con.Open();
                cmd = new SqlCommand("insert into addUser values('" + txt_username.Text + "','" + txt_password.Text + "','" + comadduser.SelectedItem + "','" + txt_userId.Text + "','" + txt_name.Text + "','" + txt_tp.Text + "','" + txt_tp.Text + "')", con);
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
            //ViewDetails();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");

            con.Open();
            da = new SqlDataAdapter("Delete FROM addUser where UserID='" + txt_userId.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewAdduser.DataSource = dt;
            con.Close();
            ViewDetails();
        }
        public void ViewDetails()
        {
            string ConnectionString = (@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Quary = "SELECT*FROM addUser";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridViewAdduser.DataSource = table;
            con.Close();
        }
    }
}
