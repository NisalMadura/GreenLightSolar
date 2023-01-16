namespace F_Project
{
    partial class Pending_orders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.datagridViewPendingOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_viewall = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewPendingOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(-1, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 1);
            this.panel1.TabIndex = 71;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(861, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 34);
            this.btn_exit.TabIndex = 70;
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
            this.btn_back.Location = new System.Drawing.Point(3, 68);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 40);
            this.btn_back.TabIndex = 69;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(357, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 27);
            this.label2.TabIndex = 68;
            this.label2.Text = "Pending Orders";
            // 
            // btn_print
            // 
            this.btn_print.Image = global::F_Project.Properties.Resources.icons8_print_44;
            this.btn_print.Location = new System.Drawing.Point(819, 166);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(50, 40);
            this.btn_print.TabIndex = 78;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.datagridViewPendingOrder);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(213, 166);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(600, 243);
            this.guna2GroupBox1.TabIndex = 79;
            this.guna2GroupBox1.Text = "Pending Orders Details";
            // 
            // datagridViewPendingOrder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridViewPendingOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridViewPendingOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridViewPendingOrder.BackgroundColor = System.Drawing.Color.White;
            this.datagridViewPendingOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridViewPendingOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewPendingOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridViewPendingOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridViewPendingOrder.ColumnHeadersHeight = 19;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridViewPendingOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridViewPendingOrder.EnableHeadersVisualStyles = false;
            this.datagridViewPendingOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewPendingOrder.Location = new System.Drawing.Point(3, 41);
            this.datagridViewPendingOrder.Name = "datagridViewPendingOrder";
            this.datagridViewPendingOrder.RowHeadersVisible = false;
            this.datagridViewPendingOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridViewPendingOrder.Size = new System.Drawing.Size(594, 199);
            this.datagridViewPendingOrder.TabIndex = 0;
            this.datagridViewPendingOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPendingOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridViewPendingOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridViewPendingOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridViewPendingOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridViewPendingOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPendingOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewPendingOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridViewPendingOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridViewPendingOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewPendingOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridViewPendingOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridViewPendingOrder.ThemeStyle.HeaderStyle.Height = 19;
            this.datagridViewPendingOrder.ThemeStyle.ReadOnly = false;
            this.datagridViewPendingOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridViewPendingOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridViewPendingOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridViewPendingOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridViewPendingOrder.ThemeStyle.RowsStyle.Height = 22;
            this.datagridViewPendingOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridViewPendingOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridViewPendingOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridViewPendingOrder_CellContentClick);
            this.datagridViewPendingOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView);
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
            this.btn_viewall.Location = new System.Drawing.Point(591, 111);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(76, 31);
            this.btn_viewall.TabIndex = 89;
            this.btn_viewall.Text = "View All";
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(302, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 88;
            // 
            // btn_search
            // 
            this.btn_search.Image = global::F_Project.Properties.Resources.icons8_search_28;
            this.btn_search.Location = new System.Drawing.Point(520, 111);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 31);
            this.btn_search.TabIndex = 87;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.AutoRoundedCorners = true;
            this.txt_search.BorderColor = System.Drawing.Color.Gainsboro;
            this.txt_search.BorderRadius = 14;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(305, 111);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_search.PlaceholderText = "Enter Order ID";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(197, 31);
            this.txt_search.TabIndex = 86;
            // 
            // Pending_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F_Project.Properties.Resources._360_F_329144637_fLag9jYbaYQwo3apYr8OEzTrdUWWwXCR1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 568);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pending_orders";
            this.Text = "Pending_orders";
            this.Load += new System.EventHandler(this.Pending_orders_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewPendingOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_viewall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2DataGridView datagridViewPendingOrder;
    }
}