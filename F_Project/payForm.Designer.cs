namespace F_Project
{
    partial class payForm
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
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_packageNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_payNo = new System.Windows.Forms.TextBox();
            this.txt_cusID = new System.Windows.Forms.TextBox();
            this.dobPikerpayment = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(185, 290);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(138, 20);
            this.txt_amount.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Aquamarine;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Amount";
            // 
            // txt_packageNo
            // 
            this.txt_packageNo.Location = new System.Drawing.Point(188, 155);
            this.txt_packageNo.Name = "txt_packageNo";
            this.txt_packageNo.Size = new System.Drawing.Size(138, 20);
            this.txt_packageNo.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Aquamarine;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Package Code";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_exit.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(585, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 34);
            this.btn_exit.TabIndex = 58;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(123, 257);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(200, 20);
            this.txt_status.TabIndex = 57;
            // 
            // txt_payNo
            // 
            this.txt_payNo.Location = new System.Drawing.Point(188, 122);
            this.txt_payNo.Name = "txt_payNo";
            this.txt_payNo.Size = new System.Drawing.Size(138, 20);
            this.txt_payNo.TabIndex = 56;
            // 
            // txt_cusID
            // 
            this.txt_cusID.Location = new System.Drawing.Point(185, 189);
            this.txt_cusID.Name = "txt_cusID";
            this.txt_cusID.Size = new System.Drawing.Size(138, 20);
            this.txt_cusID.TabIndex = 55;
            // 
            // dobPikerpayment
            // 
            this.dobPikerpayment.Location = new System.Drawing.Point(123, 223);
            this.dobPikerpayment.Name = "dobPikerpayment";
            this.dobPikerpayment.Size = new System.Drawing.Size(200, 20);
            this.dobPikerpayment.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(232, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Payment";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_back.Image = global::F_Project.Properties.Resources.icons8_back_30;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_back.Location = new System.Drawing.Point(2, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(33, 40);
            this.btn_back.TabIndex = 49;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Payment No";
            // 
            // btn_pay
            // 
            this.btn_pay.AutoRoundedCorners = true;
            this.btn_pay.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_pay.BorderRadius = 19;
            this.btn_pay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pay.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.Black;
            this.btn_pay.Location = new System.Drawing.Point(63, 347);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(122, 41);
            this.btn_pay.TabIndex = 63;
            this.btn_pay.Text = "Pay";
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoRoundedCorners = true;
            this.btn_cancel.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_cancel.BorderRadius = 19;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(204, 347);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(122, 41);
            this.btn_cancel.TabIndex = 64;
            this.btn_cancel.Text = "Cancel";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_printPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // payForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F_Project.Properties.Resources._2018_11_29_1;
            this.ClientSize = new System.Drawing.Size(625, 428);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_packageNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_payNo);
            this.Controls.Add(this.txt_cusID);
            this.Controls.Add(this.dobPikerpayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payForm";
            this.Load += new System.EventHandler(this.payForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_packageNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_payNo;
        private System.Windows.Forms.TextBox txt_cusID;
        private System.Windows.Forms.DateTimePicker dobPikerpayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_pay;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cancel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}