using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Project
{
    public partial class customerReport : Form
    {
        public customerReport()
        {
            InitializeComponent();
        }

        private void customerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.cusRegister' table. You can move, or remove it, as needed.
            this.cusRegisterTableAdapter.Fill(this.DataSet1.cusRegister);

            this.reportViewer1.RefreshReport();
        }
    }
}
