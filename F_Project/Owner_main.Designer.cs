namespace F_Project
{
    partial class Owner_main
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
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_income = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_createUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_completeOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_stockDetails = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_payment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_pendingOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_cDetails = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel_dashboard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel8.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer1_Tick);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::F_Project.Properties.Resources.abstract_background_red_and_white_free_vector;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.sidebar);
            this.panel8.Controls.Add(this.panel_dashboard);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1106, 593);
            this.panel8.TabIndex = 10;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.btn_menu);
            this.sidebar.Controls.Add(this.btn_income);
            this.sidebar.Controls.Add(this.btn_createUser);
            this.sidebar.Controls.Add(this.btn_completeOrder);
            this.sidebar.Controls.Add(this.btn_stockDetails);
            this.sidebar.Controls.Add(this.btn_payment);
            this.sidebar.Controls.Add(this.btn_pendingOrder);
            this.sidebar.Controls.Add(this.btn_cDetails);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(205, 568);
            this.sidebar.MinimumSize = new System.Drawing.Size(58, 568);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(205, 568);
            this.sidebar.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.SystemColors.Control;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_menu.Image = global::F_Project.Properties.Resources.menuOWNER;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(12, 33);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(92, 44);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Menu";
            this.btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_income
            // 
            this.btn_income.AutoRoundedCorners = true;
            this.btn_income.BorderRadius = 19;
            this.btn_income.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_income.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_income.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_income.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_income.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_income.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_income.ForeColor = System.Drawing.Color.White;
            this.btn_income.Image = global::F_Project.Properties.Resources.icons8_income_64;
            this.btn_income.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_income.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_income.Location = new System.Drawing.Point(12, 435);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(179, 41);
            this.btn_income.TabIndex = 8;
            this.btn_income.Text = "    Income Details";
            this.btn_income.Click += new System.EventHandler(this.btn_income_Click);
            // 
            // btn_createUser
            // 
            this.btn_createUser.AutoRoundedCorners = true;
            this.btn_createUser.BorderRadius = 19;
            this.btn_createUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_createUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_createUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_createUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_createUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_createUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_createUser.ForeColor = System.Drawing.Color.White;
            this.btn_createUser.Image = global::F_Project.Properties.Resources.icons8_add_user_group_woman_man_40;
            this.btn_createUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_createUser.Location = new System.Drawing.Point(12, 110);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(179, 41);
            this.btn_createUser.TabIndex = 1;
            this.btn_createUser.Text = "Create User ";
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // btn_completeOrder
            // 
            this.btn_completeOrder.AutoRoundedCorners = true;
            this.btn_completeOrder.BorderRadius = 19;
            this.btn_completeOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_completeOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_completeOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_completeOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_completeOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_completeOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_completeOrder.ForeColor = System.Drawing.Color.White;
            this.btn_completeOrder.Image = global::F_Project.Properties.Resources.icons8_done_64;
            this.btn_completeOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_completeOrder.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_completeOrder.Location = new System.Drawing.Point(12, 382);
            this.btn_completeOrder.Name = "btn_completeOrder";
            this.btn_completeOrder.Size = new System.Drawing.Size(179, 41);
            this.btn_completeOrder.TabIndex = 6;
            this.btn_completeOrder.Text = "      Complete Orders";
            this.btn_completeOrder.Click += new System.EventHandler(this.btn_completeOrder_Click);
            // 
            // btn_stockDetails
            // 
            this.btn_stockDetails.AutoRoundedCorners = true;
            this.btn_stockDetails.BorderRadius = 19;
            this.btn_stockDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_stockDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_stockDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_stockDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_stockDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_stockDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_stockDetails.ForeColor = System.Drawing.Color.White;
            this.btn_stockDetails.Image = global::F_Project.Properties.Resources.icons8_shopping_cart_64;
            this.btn_stockDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_stockDetails.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_stockDetails.Location = new System.Drawing.Point(12, 273);
            this.btn_stockDetails.Name = "btn_stockDetails";
            this.btn_stockDetails.Size = new System.Drawing.Size(179, 41);
            this.btn_stockDetails.TabIndex = 4;
            this.btn_stockDetails.Text = "Stock Details";
            this.btn_stockDetails.Click += new System.EventHandler(this.btn_stockDetails_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.AutoRoundedCorners = true;
            this.btn_payment.BorderRadius = 19;
            this.btn_payment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_payment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_payment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_payment.ForeColor = System.Drawing.Color.White;
            this.btn_payment.Image = global::F_Project.Properties.Resources.icons8_cash_in_hand_60;
            this.btn_payment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_payment.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_payment.Location = new System.Drawing.Point(12, 219);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(179, 41);
            this.btn_payment.TabIndex = 3;
            this.btn_payment.Text = "      Payment Details";
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_pendingOrder
            // 
            this.btn_pendingOrder.AutoRoundedCorners = true;
            this.btn_pendingOrder.BorderRadius = 19;
            this.btn_pendingOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pendingOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pendingOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pendingOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pendingOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pendingOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_pendingOrder.ForeColor = System.Drawing.Color.White;
            this.btn_pendingOrder.Image = global::F_Project.Properties.Resources.icons8_order_history_48;
            this.btn_pendingOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_pendingOrder.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_pendingOrder.Location = new System.Drawing.Point(12, 327);
            this.btn_pendingOrder.Name = "btn_pendingOrder";
            this.btn_pendingOrder.Size = new System.Drawing.Size(179, 41);
            this.btn_pendingOrder.TabIndex = 5;
            this.btn_pendingOrder.Text = "    Pending Orders";
            this.btn_pendingOrder.Click += new System.EventHandler(this.guna2GradientButton5_Click);
            // 
            // btn_cDetails
            // 
            this.btn_cDetails.AutoRoundedCorners = true;
            this.btn_cDetails.BorderRadius = 19;
            this.btn_cDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_cDetails.ForeColor = System.Drawing.Color.White;
            this.btn_cDetails.Image = global::F_Project.Properties.Resources.icons8_stock_641;
            this.btn_cDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_cDetails.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_cDetails.Location = new System.Drawing.Point(12, 166);
            this.btn_cDetails.Name = "btn_cDetails";
            this.btn_cDetails.Size = new System.Drawing.Size(179, 41);
            this.btn_cDetails.TabIndex = 2;
            this.btn_cDetails.Text = "      Customer Details";
            this.btn_cDetails.Click += new System.EventHandler(this.btn_cDetails_Click);
            // 
            // panel_dashboard
            // 
            this.panel_dashboard.BackgroundImage = global::F_Project.Properties.Resources.new_dphoto;
            this.panel_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_dashboard.Location = new System.Drawing.Point(60, 92);
            this.panel_dashboard.Name = "panel_dashboard";
            this.panel_dashboard.Size = new System.Drawing.Size(1046, 501);
            this.panel_dashboard.TabIndex = 1;
            this.panel_dashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_dashboard_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Location = new System.Drawing.Point(57, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 59);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::F_Project.Properties.Resources.Picture2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(290, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 53);
            this.panel2.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::F_Project.Properties.Resources.icons8_back_30;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Location = new System.Drawing.Point(7, 6);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(41, 47);
            this.btn_back.TabIndex = 2;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(211, 59);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(695, 484);
            this.dashboard.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.Image = global::F_Project.Properties.Resources.icons8_logout_28;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(937, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(100, 37);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Teal;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(340, 27);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(87, 29);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "GREEN ";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Owner_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 593);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Owner_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner_main";
            this.panel8.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_createUser;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btn_payment;
        private Guna.UI2.WinForms.Guna2GradientButton btn_stockDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btn_pendingOrder;
        private Guna.UI2.WinForms.Guna2GradientButton btn_completeOrder;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel dashboard;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel_dashboard;
        private System.Windows.Forms.Button btn_back;
        private Guna.UI2.WinForms.Guna2GradientButton btn_income;
        private System.Windows.Forms.Panel panel2;
    }
}