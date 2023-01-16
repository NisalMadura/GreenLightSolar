namespace F_Project
{
    partial class released_order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.datagridViewCompleteOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_oid = new System.Windows.Forms.TextBox();
            this.btn_viewall = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_pcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cusId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewCompleteOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(1, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 1);
            this.panel1.TabIndex = 75;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(863, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 34);
            this.btn_exit.TabIndex = 74;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::F_Project.Properties.Resources.icons8_back_30;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Gray;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(5, 68);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 40);
            this.btn_back.TabIndex = 73;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(285, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 27);
            this.label2.TabIndex = 72;
            this.label2.Text = "Completed Orders Details";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.datagridViewCompleteOrder);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(387, 170);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(475, 320);
            this.guna2GroupBox1.TabIndex = 77;
            this.guna2GroupBox1.Text = "Complete Order Details";
            // 
            // datagridViewCompleteOrder
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.datagridViewCompleteOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridViewCompleteOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridViewCompleteOrder.BackgroundColor = System.Drawing.Color.White;
            this.datagridViewCompleteOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridViewCompleteOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewCompleteOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridViewCompleteOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datagridViewCompleteOrder.ColumnHeadersHeight = 19;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridViewCompleteOrder.DefaultCellStyle = dataGridViewCellStyle12;
            this.datagridViewCompleteOrder.EnableHeadersVisualStyles = false;
            this.datagridViewCompleteOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewCompleteOrder.Location = new System.Drawing.Point(3, 42);
            this.datagridViewCompleteOrder.Name = "datagridViewCompleteOrder";
            this.datagridViewCompleteOrder.RowHeadersVisible = false;
            this.datagridViewCompleteOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridViewCompleteOrder.Size = new System.Drawing.Size(472, 259);
            this.datagridViewCompleteOrder.TabIndex = 0;
            this.datagridViewCompleteOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewCompleteOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridViewCompleteOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridViewCompleteOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridViewCompleteOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridViewCompleteOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewCompleteOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewCompleteOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridViewCompleteOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridViewCompleteOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewCompleteOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridViewCompleteOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridViewCompleteOrder.ThemeStyle.HeaderStyle.Height = 19;
            this.datagridViewCompleteOrder.ThemeStyle.ReadOnly = false;
            this.datagridViewCompleteOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewCompleteOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewCompleteOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewCompleteOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagridViewCompleteOrder.ThemeStyle.RowsStyle.Height = 22;
            this.datagridViewCompleteOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewCompleteOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_print
            // 
            this.btn_print.Image = global::F_Project.Properties.Resources.icons8_print_44;
            this.btn_print.Location = new System.Drawing.Point(812, 124);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(50, 40);
            this.btn_print.TabIndex = 78;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = global::F_Project.Properties.Resources.icons8_search_28;
            this.btn_search.Location = new System.Drawing.Point(533, 115);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 31);
            this.btn_search.TabIndex = 81;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.AutoRoundedCorners = true;
            this.txt_search.BorderColor = System.Drawing.Color.Gainsboro;
            this.txt_search.BorderRadius = 19;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(263, 105);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_search.PlaceholderText = "Enter Order ID";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(263, 41);
            this.txt_search.TabIndex = 80;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 85;
            this.label12.Text = "Order ID";
            // 
            // btn_add
            // 
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BorderRadius = 16;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(89, 372);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(174, 34);
            this.btn_add.TabIndex = 92;
            this.btn_add.Text = "Add Complete Order";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_oid
            // 
            this.txt_oid.Location = new System.Drawing.Point(157, 187);
            this.txt_oid.Name = "txt_oid";
            this.txt_oid.Size = new System.Drawing.Size(130, 20);
            this.txt_oid.TabIndex = 94;
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
            this.btn_viewall.Location = new System.Drawing.Point(607, 115);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(76, 31);
            this.btn_viewall.TabIndex = 95;
            this.btn_viewall.Text = "View All";
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // txt_pcode
            // 
            this.txt_pcode.Location = new System.Drawing.Point(159, 224);
            this.txt_pcode.Name = "txt_pcode";
            this.txt_pcode.ReadOnly = true;
            this.txt_pcode.Size = new System.Drawing.Size(130, 20);
            this.txt_pcode.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Customer ID";
            // 
            // txt_cusId
            // 
            this.txt_cusId.Location = new System.Drawing.Point(178, 257);
            this.txt_cusId.Name = "txt_cusId";
            this.txt_cusId.ReadOnly = true;
            this.txt_cusId.Size = new System.Drawing.Size(111, 20);
            this.txt_cusId.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 86;
            this.label11.Text = "Location";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 87;
            this.label13.Text = "Status";
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(145, 288);
            this.txt_location.Name = "txt_location";
            this.txt_location.ReadOnly = true;
            this.txt_location.Size = new System.Drawing.Size(145, 20);
            this.txt_location.TabIndex = 89;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(143, 324);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(144, 20);
            this.txt_status.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Package Code";
            // 
            // released_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 568);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.txt_oid);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_pcode);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_cusId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "released_order";
            this.Text = "released_order";
            this.Load += new System.EventHandler(this.released_order_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewCompleteOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2DataGridView datagridViewCompleteOrder;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GradientButton btn_add;
        private System.Windows.Forms.TextBox txt_oid;
        private Guna.UI2.WinForms.Guna2GradientButton btn_viewall;
        private System.Windows.Forms.TextBox txt_pcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cusId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label1;
    }
}