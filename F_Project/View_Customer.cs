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
using DGVPrinterHelper;

namespace F_Project
{
    public partial class View_Customer : Form
    {
        public View_Customer()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;



        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }
        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {
            

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Details Report";
            printer.SubTitle = String.Format("Date:  {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(datagridViewCustomerDetails);
           
           
        }

        private void printDocument_print(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        
        }

        private void View_Customer_Load(object sender, EventArgs e)
        {
            ViewDetails();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
            
            con.Open();
            da = new SqlDataAdapter("SELECT*FROM cusRegister where Cus_code='" + txt_search.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridViewCustomerDetails.DataSource = dt;
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
            string Quary = "SELECT*FROM cusRegister";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            datagridViewCustomerDetails.DataSource = table;
            con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            customerReport C = new customerReport();
            C.Show();
           
       
        }
    }
}
