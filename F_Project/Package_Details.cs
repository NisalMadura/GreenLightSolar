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
    public partial class Package_Details : Form
    {
        public Package_Details()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Package_Details_Load(object sender, EventArgs e)
        {
            string ConnectionString = (@"Data Source=DESKTOP-FI935L9\MSSQLSERVER01;Initial Catalog=Project2;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Quary = "SELECT*FROM Packages";
            SqlCommand cmd = new SqlCommand(Quary, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridViewPackageView.DataSource = table;
            con.Close();
        }
    }
}
