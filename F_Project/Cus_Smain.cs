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
    public partial class Cus_Smain : Form
    {
        

        bool sidebarExpand;
        public Cus_Smain()
        {
            InitializeComponent();
           panel_desktop.BackgroundImage = Properties.Resources.bk1;
            
            Timer tims = new Timer();
            tims.Interval = 1000;
            
            tims.Tick += new EventHandler(changeImage);
            tims.Start();

        }

        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            //b1.Add(Properties.Resources.bk1);
            b1.Add(Properties.Resources.bk2);
            b1.Add(Properties.Resources.bk3);
            b1.Add(Properties.Resources.bk4);
            b1.Add(Properties.Resources.bk5);
            b1.Add(Properties.Resources.bk6);
            int index = DateTime.Now.Second % b1.Count;
            panel_desktop.BackgroundImage = b1[index];
         
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
            panel_desktop.Controls.Add(chiledForm);
            panel_desktop.Tag = chiledForm;
            chiledForm.BringToFront();
            chiledForm.Show();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_CRegister_Click(object sender, EventArgs e)
        {
            openChiledform(new Cus_register());
            
            //panel_desktop.Show();
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            openChiledform(new add_Order());
            
        }

        private void btn_Package_Click(object sender, EventArgs e)
        {
            openChiledform(new Package_Details());
           
        }

        private void btn_ViewCus_Click(object sender, EventArgs e)
        {
            openChiledform(new View_Customer());
            
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            openChiledform(new Payment_Details());
            
        }

        private void panel_desktop_Paint(object sender, PaintEventArgs e)
        {
            
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            //panel_desktop.Show();
            //currentChiledForm.Hide();
        }
    }
}
