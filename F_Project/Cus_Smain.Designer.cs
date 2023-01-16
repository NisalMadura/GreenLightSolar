namespace F_Project
{
    partial class Cus_Smain
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
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_desktop = new Guna.UI2.WinForms.Guna2Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_payment = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ViewCus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Package = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AddOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CRegister = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.btn_payment);
            this.sidebar.Controls.Add(this.btn_ViewCus);
            this.sidebar.Controls.Add(this.btn_Package);
            this.sidebar.Controls.Add(this.btn_AddOrder);
            this.sidebar.Controls.Add(this.btn_CRegister);
            this.sidebar.Controls.Add(this.guna2Button2);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(235, 630);
            this.sidebar.MinimumSize = new System.Drawing.Size(55, 630);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(235, 630);
            this.sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.btn_menu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 103);
            this.panel2.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 90);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(232, 1);
            this.guna2Panel1.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(235, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(705, 62);
            this.guna2Panel2.TabIndex = 1;
            // 
            // panel_desktop
            // 
            this.panel_desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop.Location = new System.Drawing.Point(235, 62);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(705, 568);
            this.panel_desktop.TabIndex = 2;
            this.panel_desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_desktop_Paint);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer1_Tick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.Image = global::F_Project.Properties.Resources.icons8_logout_28;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(602, 6);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(100, 37);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::F_Project.Properties.Resources.Picture2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(108, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 53);
            this.panel1.TabIndex = 1;
            // 
            // btn_payment
            // 
            this.btn_payment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_payment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_payment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.Color.White;
            this.btn_payment.Image = global::F_Project.Properties.Resources.icons8_payment_28;
            this.btn_payment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_payment.Location = new System.Drawing.Point(3, 354);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(232, 45);
            this.btn_payment.TabIndex = 7;
            this.btn_payment.Text = "    Payment Details";
            this.btn_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_ViewCus
            // 
            this.btn_ViewCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ViewCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ViewCus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_ViewCus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ViewCus.ForeColor = System.Drawing.Color.White;
            this.btn_ViewCus.Image = global::F_Project.Properties.Resources.icons8_view_28;
            this.btn_ViewCus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ViewCus.Location = new System.Drawing.Point(3, 303);
            this.btn_ViewCus.Name = "btn_ViewCus";
            this.btn_ViewCus.Size = new System.Drawing.Size(232, 45);
            this.btn_ViewCus.TabIndex = 6;
            this.btn_ViewCus.Text = "    View Customers";
            this.btn_ViewCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ViewCus.Click += new System.EventHandler(this.btn_ViewCus_Click);
            // 
            // btn_Package
            // 
            this.btn_Package.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Package.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Package.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Package.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Package.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Package.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Package.ForeColor = System.Drawing.Color.White;
            this.btn_Package.Image = global::F_Project.Properties.Resources.icons8_package_28;
            this.btn_Package.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Package.Location = new System.Drawing.Point(3, 252);
            this.btn_Package.Name = "btn_Package";
            this.btn_Package.Size = new System.Drawing.Size(232, 45);
            this.btn_Package.TabIndex = 5;
            this.btn_Package.Text = "    Package Details";
            this.btn_Package.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Package.Click += new System.EventHandler(this.btn_Package_Click);
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_AddOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOrder.ForeColor = System.Drawing.Color.White;
            this.btn_AddOrder.Image = global::F_Project.Properties.Resources.icons8_add_property_301;
            this.btn_AddOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddOrder.Location = new System.Drawing.Point(3, 201);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(232, 45);
            this.btn_AddOrder.TabIndex = 4;
            this.btn_AddOrder.Text = "    Add Order";
            this.btn_AddOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // btn_CRegister
            // 
            this.btn_CRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_CRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRegister.ForeColor = System.Drawing.Color.White;
            this.btn_CRegister.Image = global::F_Project.Properties.Resources.icons8_cheque_30;
            this.btn_CRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CRegister.Location = new System.Drawing.Point(3, 150);
            this.btn_CRegister.Name = "btn_CRegister";
            this.btn_CRegister.Size = new System.Drawing.Size(232, 45);
            this.btn_CRegister.TabIndex = 3;
            this.btn_CRegister.Text = "    Customer Register";
            this.btn_CRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CRegister.Click += new System.EventHandler(this.btn_CRegister_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::F_Project.Properties.Resources.icons8_home_48;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(3, 99);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(232, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "    Home";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // btn_menu
            // 
            this.btn_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = global::F_Project.Properties.Resources.icons8_menu_30;
            this.btn_menu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_menu.Location = new System.Drawing.Point(3, 31);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(232, 45);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "    Menu";
            this.btn_menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_menu.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Cus_Smain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 630);
            this.Controls.Add(this.panel_desktop);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cus_Smain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CService_Main";
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_menu;
        private Guna.UI2.WinForms.Guna2Button btn_payment;
        private Guna.UI2.WinForms.Guna2Button btn_Package;
        private Guna.UI2.WinForms.Guna2Button btn_AddOrder;
        private Guna.UI2.WinForms.Guna2Button btn_CRegister;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panel_desktop;
        private System.Windows.Forms.Timer sidebarTimer;
        public Guna.UI2.WinForms.Guna2Button btn_ViewCus;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}