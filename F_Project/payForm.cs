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
    public partial class payForm : Form
    {
        public payForm()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void btn_pay_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into PaymentDetails values('" + txt_payNo.Text + "','" + txt_packageNo.Text + "','" + txt_cusID.Text + "','" + dobPikerpayment.Value + "')", con);
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
        }

        private void printDocument1_printPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 80;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("WELLCOME TO GREEN LIGHT SOLAR LANKA", new Font("Courier New", 20), new SolidBrush(Color.Black), startx, starty);
            offset = offset + 20;
            graphics.DrawString("...................................................", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 10;
            graphics.DrawString("...................................................", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            string top = "      Date : " + DateTime.Now.Date.ToString("dd/MM/yyyy");
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("      Package No : "+txt_payNo.Text,font, new SolidBrush(Color.Black), startx , starty + offset);
            offset = offset + 20;
            graphics.DrawString("      Payment NO : "+txt_packageNo.Text,font,  new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("      Customer ID : " + txt_cusID.Text , font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("      Status : " + txt_status.Text , font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("...................................................", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("      Amount : " + txt_amount.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("...................................................", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString(" Thank You For Visit Our Company " , font, new SolidBrush(Color.Black), startx, starty + offset);
            
           
        }

        private void payForm_Load(object sender, EventArgs e)
        {

        }
    }
}
