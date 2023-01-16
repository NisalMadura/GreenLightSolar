namespace F_Project
{
    partial class Payment_Details
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
            this.txt_paySearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.datagridViewPaymentDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_viewall = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewPaymentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_paySearch
            // 
            this.txt_paySearch.AutoRoundedCorners = true;
            this.txt_paySearch.BorderRadius = 13;
            this.txt_paySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_paySearch.DefaultText = "";
            this.txt_paySearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_paySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_paySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_paySearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_paySearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_paySearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paySearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_paySearch.Location = new System.Drawing.Point(262, 84);
            this.txt_paySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_paySearch.Name = "txt_paySearch";
            this.txt_paySearch.PasswordChar = '\0';
            this.txt_paySearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_paySearch.PlaceholderText = "Enter Payment Code";
            this.txt_paySearch.SelectedText = "";
            this.txt_paySearch.Size = new System.Drawing.Size(209, 29);
            this.txt_paySearch.TabIndex = 1;
            this.txt_paySearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.datagridViewPaymentDetails);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GroupBox1.Location = new System.Drawing.Point(110, 138);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(565, 305);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Customer Payment Details";
            // 
            // datagridViewPaymentDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridViewPaymentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridViewPaymentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridViewPaymentDetails.BackgroundColor = System.Drawing.Color.White;
            this.datagridViewPaymentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridViewPaymentDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewPaymentDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridViewPaymentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridViewPaymentDetails.ColumnHeadersHeight = 19;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridViewPaymentDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridViewPaymentDetails.EnableHeadersVisualStyles = false;
            this.datagridViewPaymentDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewPaymentDetails.Location = new System.Drawing.Point(3, 41);
            this.datagridViewPaymentDetails.Name = "datagridViewPaymentDetails";
            this.datagridViewPaymentDetails.RowHeadersVisible = false;
            this.datagridViewPaymentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridViewPaymentDetails.Size = new System.Drawing.Size(559, 261);
            this.datagridViewPaymentDetails.TabIndex = 0;
            this.datagridViewPaymentDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPaymentDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridViewPaymentDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridViewPaymentDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridViewPaymentDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridViewPaymentDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPaymentDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewPaymentDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridViewPaymentDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridViewPaymentDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewPaymentDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridViewPaymentDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridViewPaymentDetails.ThemeStyle.HeaderStyle.Height = 19;
            this.datagridViewPaymentDetails.ThemeStyle.ReadOnly = false;
            this.datagridViewPaymentDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPaymentDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewPaymentDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewPaymentDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.datagridViewPaymentDetails.ThemeStyle.RowsStyle.Height = 22;
            this.datagridViewPaymentDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewPaymentDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment Details";
            // 
            // btn_search
            // 
            this.btn_search.Image = global::F_Project.Properties.Resources.icons8_search_28;
            this.btn_search.Location = new System.Drawing.Point(477, 82);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 31);
            this.btn_search.TabIndex = 80;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_print
            // 
            this.btn_print.Image = global::F_Project.Properties.Resources.icons8_print_44;
            this.btn_print.Location = new System.Drawing.Point(641, 92);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(50, 40);
            this.btn_print.TabIndex = 81;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
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
            this.btn_viewall.Location = new System.Drawing.Point(550, 82);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(76, 31);
            this.btn_viewall.TabIndex = 85;
            this.btn_viewall.Text = "View All";
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // Payment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 501);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txt_paySearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment_Details";
            this.Text = "Payment_Details";
            this.Load += new System.EventHandler(this.Payment_Details_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewPaymentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_paySearch;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2DataGridView datagridViewPaymentDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btn_viewall;
    }
}