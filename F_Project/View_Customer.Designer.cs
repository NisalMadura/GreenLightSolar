namespace F_Project
{
    partial class View_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.datagridViewCustomerDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_viewall = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.AutoRoundedCorners = true;
            this.txt_search.BorderRadius = 14;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(128, 103);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_search.PlaceholderText = "Enter Customer Code";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(241, 31);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.datagridViewCustomerDetails);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(95, 162);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(600, 276);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "Customers Details";
            // 
            // datagridViewCustomerDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridViewCustomerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridViewCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridViewCustomerDetails.BackgroundColor = System.Drawing.Color.White;
            this.datagridViewCustomerDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridViewCustomerDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewCustomerDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridViewCustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridViewCustomerDetails.ColumnHeadersHeight = 19;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridViewCustomerDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridViewCustomerDetails.EnableHeadersVisualStyles = false;
            this.datagridViewCustomerDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewCustomerDetails.Location = new System.Drawing.Point(4, 41);
            this.datagridViewCustomerDetails.Name = "datagridViewCustomerDetails";
            this.datagridViewCustomerDetails.RowHeadersVisible = false;
            this.datagridViewCustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridViewCustomerDetails.Size = new System.Drawing.Size(593, 232);
            this.datagridViewCustomerDetails.TabIndex = 0;
            this.datagridViewCustomerDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewCustomerDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridViewCustomerDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridViewCustomerDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridViewCustomerDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridViewCustomerDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewCustomerDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewCustomerDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridViewCustomerDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridViewCustomerDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewCustomerDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridViewCustomerDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridViewCustomerDetails.ThemeStyle.HeaderStyle.Height = 19;
            this.datagridViewCustomerDetails.ThemeStyle.ReadOnly = false;
            this.datagridViewCustomerDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewCustomerDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewCustomerDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewCustomerDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridViewCustomerDetails.ThemeStyle.RowsStyle.Height = 22;
            this.datagridViewCustomerDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewCustomerDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(138, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 1);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "View Customer Details";
            // 
            // btn_search
            // 
            this.btn_search.Image = global::F_Project.Properties.Resources.icons8_search_28;
            this.btn_search.Location = new System.Drawing.Point(375, 103);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 31);
            this.btn_search.TabIndex = 83;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_print
            // 
            this.btn_print.Image = global::F_Project.Properties.Resources.icons8_print_44;
            this.btn_print.Location = new System.Drawing.Point(645, 116);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(50, 40);
            this.btn_print.TabIndex = 82;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_print);
            // 
            // btn_viewall
            // 
            this.btn_viewall.AutoRoundedCorners = true;
            this.btn_viewall.BorderRadius = 14;
            this.btn_viewall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewall.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_viewall.ForeColor = System.Drawing.Color.White;
            this.btn_viewall.Location = new System.Drawing.Point(457, 103);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(76, 31);
            this.btn_viewall.TabIndex = 84;
            this.btn_viewall.Text = "View All";
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 14;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(539, 103);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(76, 31);
            this.guna2GradientButton1.TabIndex = 85;
            this.guna2GradientButton1.Text = "View All";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // View_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 501);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txt_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Customer";
            this.Text = "View_Customer";
            this.Load += new System.EventHandler(this.View_Customer_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2DataGridView datagridViewCustomerDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btn_viewall;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}