using DGVPrinterHelper;
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
    public partial class released_order : Form
    {
        public static released_order formInstance;
        public Button btn;
        public Button btnx;
        public released_order()
        {
            InitializeComponent();
            formInstance = this;
            btn = btn_back;
            btnx = btn_exit;
        }
       
        
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Complete Order Details Report";
            printer.SubTitle = String.Format("Date:  {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(datagridViewCompleteOrder);
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void released_order_Load(object sender, EventArgs e)
        {
            ViewDetails();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            /*try
            {
                con.Open();
                cmd = new SqlCommand("insert into CompleteOrder values('" + txt_pcode.Text + "','" + txt_cusId.Text + "','" + txt_oid.Text + "','" + txt_location.Text + "','" + txt_status.Text + "')", con);
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
           // con = new SqlConnection("Data Source=SANJAYA\\MSSQLSERVER01;Initial Catalog=Project;Integrated Security=True");

            con.Open();
            da = new SqlDataAdapter("Delete from AddOder_tabel where Order_ID='" + txt_oid.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            con.Close();*/


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");

            con.Open();
            da = new SqlDataAdapter("SELECT*FROM CompleteOrder where Order_ID='" + txt_search.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridViewCompleteOrder.DataSource = dt;
            con.Close();
        }
        public void ViewDetails()
        {
            string ConnectionString = (@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Quary = "SELECT*FROM CompleteOrder";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            datagridViewCompleteOrder.DataSource = table;
            con.Close();
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            ViewDetails();
        }
        /* public void cc()
{
con = new SqlConnection("Data Source=SANJAYA\\MSSQLSERVER01;Initial Catalog=Project;Integrated Security=True");
combselect.Items.Clear();
con.Open();
SqlCommand cmd = con.CreateCommand();
cmd.CommandType = CommandType.Text;
cmd.CommandText = "SELECT Order_ID FROM AddOder_tabel";
cmd.ExecuteNonQuery();
DataTable dt = new DataTable();
SqlDataAdapter da = new SqlDataAdapter(cmd);
da.Fill(dt);
foreach (DataRow dr in dt.Rows)
{
combselect.Items.Add(dr["Order_ID"].ToString());
}
con.Close();
}*/
    }
}
