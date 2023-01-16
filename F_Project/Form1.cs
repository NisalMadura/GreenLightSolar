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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string con = (@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    if (txt_username.Text == "" && txt_password.Text == "")
                    {
                        MessageBox.Show("Please enter your user name and password");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(con);
                        SqlCommand cmd = new SqlCommand("select * from StorekeeperElogin where UserName=@UserName and SEPassword=@SEPassword", conn);
                        cmd.Parameters.AddWithValue("@UserName", txt_username.Text);
                        cmd.Parameters.AddWithValue("@SEPassword", txt_password.Text);
                        conn.Open();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        ad.Fill(ds);
                        conn.Close();
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 1)
                        {
                            Store_keeperMainpage yy = new Store_keeperMainpage();
                            yy.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Fail");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 0)
                {
                    if (txt_username.Text == "" && txt_password.Text == "")
                    {
                        MessageBox.Show("Please enter your user name and password");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(con);
                        SqlCommand cmd = new SqlCommand("select * from customerServicelogin where UserName=@UserName and EPassword=@EPassword", conn);
                        cmd.Parameters.AddWithValue("@UserName", txt_username.Text);
                        cmd.Parameters.AddWithValue("@EPassword", txt_password.Text);
                        conn.Open();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        ad.Fill(ds);
                        conn.Close();
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 1)
                        {
                            Cus_Smain cserMain = new Cus_Smain();
                            cserMain.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Fail");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    if (txt_username.Text == "" && txt_password.Text == "")
                    {
                        MessageBox.Show("Please enter your user name and password");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(con);
                        SqlCommand cmd = new SqlCommand("select * from adminlogin where adminUserName=@adminUserName and adminPassword=@adminPassword", conn);
                        cmd.Parameters.AddWithValue("@adminUserName", txt_username.Text);
                        cmd.Parameters.AddWithValue("@adminPassword", txt_password.Text);
                        conn.Open();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        ad.Fill(ds);
                        conn.Close();
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 1)
                        {
                            Owner_main xx = new Owner_main();
                            xx.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Fail");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Are you admin or user ?");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
