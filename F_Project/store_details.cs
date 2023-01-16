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
    public partial class store_details : Form
    {
        public static store_details formInstance;
        public Button btn;
        public Button btnx;
        public store_details()
        {
            InitializeComponent();
            formInstance = this;
            btn = btn_back;
            btnx = btn_exit;
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void store_details_Load(object sender, EventArgs e)
        {
            ViewDetails();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            printer.Title = "Stocks Details Report";
            String.Format("Date:  {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(datagridViewStock);
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
            string Quary = "SELECT*FROM addItem";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            datagridViewStock.DataSource = table;
            con.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");

            con.Open();
            da = new SqlDataAdapter("SELECT*FROM addItem where ItemCode='" + txt_search.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridViewStock.DataSource = dt;
            con.Close();
        }
    }
}
