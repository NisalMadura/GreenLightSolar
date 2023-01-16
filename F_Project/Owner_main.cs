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
    public partial class Owner_main : Form
    {
        bool sidebarExpand;
        public Owner_main()
        {
            InitializeComponent();
        }
        private Form currentChiledForm;
        private void openChiledform(Form chiledForm)
        {
            if (currentChiledForm != null)
            {
                currentChiledForm.Close();
            }
            currentChiledForm = chiledForm;
            chiledForm.TopLevel = false;
            chiledForm.FormBorderStyle = FormBorderStyle.None;
            chiledForm.Dock = DockStyle.Fill;
            panel_dashboard.Controls.Add(chiledForm);
            panel_dashboard.Tag = chiledForm;
            chiledForm.BringToFront();
            chiledForm.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            openChiledform(new Pending_orders());
            sidebarTimer.Start();
            panel_dashboard.Show();

            Pending_orders.formInstance.btn.Hide();
            Pending_orders.formInstance.btnx.Hide();

        }

        private void btn_createUser_Click(object sender, EventArgs e)
        {
            openChiledform(new create_user());
            sidebarTimer.Start();
            panel_dashboard.Show();
          //  btn_back.Visible = true;
        }

        private void btn_cDetails_Click(object sender, EventArgs e)
        {
            openChiledform(new View_Customer());
            sidebarTimer.Start();
            panel_dashboard.Show();
          //  btn_back.Visible = true;
        }

        private void sidebarTimer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
           // btn_back.Visible = true;
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            panel_dashboard.Hide();
            
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            openChiledform(new Payment_Details());
            sidebarTimer.Start();
            panel_dashboard.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 log = new Form1();
            log.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_stockDetails_Click(object sender, EventArgs e)
        {
            openChiledform(new store_details());
            sidebarTimer.Start();
            panel_dashboard.Show();

            store_details.formInstance.btn.Hide();
            store_details.formInstance.btnx.Hide();

        }

        private void btn_completeOrder_Click(object sender, EventArgs e)
        {
            openChiledform(new released_order());
            sidebarTimer.Start();
            panel_dashboard.Show();

            released_order.formInstance.btn.Hide();
            released_order.formInstance.btnx.Hide();

        }

        private void btn_income_Click(object sender, EventArgs e)
        {
            openChiledform(new income());
            sidebarTimer.Start();
            panel_dashboard.Show();
        }

        private void panel_dashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
