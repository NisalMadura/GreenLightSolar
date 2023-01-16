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
    public partial class Store_keeperMainpage : Form
    {
        public Store_keeperMainpage()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            add_items items = new add_items();
            items.Show();
            this.Hide();
        }

        private void btn_pendingOrder_Click(object sender, EventArgs e)
        {
            Pending_orders porder = new Pending_orders();
            porder.Show();
            this.Hide();
        }

        private void btn_releasedDetails_Click(object sender, EventArgs e)
        {
            released_order corder = new released_order();
            corder.Show();
            this.Hide();
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            store_details stock = new store_details();
            stock.Show();
            this.Hide();
        }

        private void btn_damage_Click(object sender, EventArgs e)
        {
            damage_items ditem = new damage_items();
            ditem.Show();
            this.Hide();
        }
    }
}
