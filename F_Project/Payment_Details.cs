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
    public partial class Payment_Details : Form
    {
        public Payment_Details()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Payment Details Report";
            printer.SubTitle = String.Format("Date:  {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(datagridViewPaymentDetails);
        }

        private void Payment_Details_Load(object sender, EventArgs e)
        {
            /*string ConnectionString = ("Data Source=SANJAYA\\MSSQLSERVER01;Initial Catalog=Project;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Quary = "SELECT*FROM PaymentDetails";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
           datagridViewPaymentDetails.DataSource = table;
            con.Close();*/
            ViewDetails();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");

            con.Open();
            da = new SqlDataAdapter("SELECT*FROM PaymentDetails where payment_No='" + txt_paySearch.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridViewPaymentDetails.DataSource = dt;
            con.Close();
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            ViewDetails();
        }
        public void ViewDetails()
        {
            string ConnectionString = (@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Quary = "SELECT*FROM PaymentDetails";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            datagridViewPaymentDetails.DataSource = table;
            con.Close();
        }
    }
}
