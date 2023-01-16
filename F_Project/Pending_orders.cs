
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
    public partial class Pending_orders : Form
    {
        public static Pending_orders formInstance;
        public Button btn;
        public Button btnx;
        public Pending_orders()
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

        private void btn_print_Click(object sender, EventArgs e)
        {
            
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Pending Orders Details Report";
            printer.SubTitle = String.Format("Date:  {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(datagridViewPendingOrder);

        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;



        private void Pending_orders_Load(object sender, EventArgs e)
        {

            ViewDetails();

        }
        public void ViewDetails()
        {
            string ConnectionString = (@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Quary = "SELECT*FROM AddOder_tabel";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            datagridViewPendingOrder.DataSource = table;
            con.Close();
        }


        private void btn_addcomplete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView(object sender, MouseEventArgs e)
        {
            
        }

        private void datagridViewPendingOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void combselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void combselect_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            ViewDetails();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");

            con.Open();
            da = new SqlDataAdapter("SELECT*FROM AddOder_tabel where Order_ID='" +txt_search.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridViewPendingOrder.DataSource = dt;
            con.Close();
        }
    }
}
