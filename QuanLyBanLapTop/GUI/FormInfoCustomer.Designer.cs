﻿namespace GUI
{
    partial class FormInfoCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoCustomer));
            this.pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tb_detailsBill = new System.Windows.Forms.DataGridView();
            this.tb_bill = new System.Windows.Forms.DataGridView();
            this.btn_search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.inp_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titleProduct = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detailsBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.btn_back);
            this.pnlBody.Controls.Add(this.tb_detailsBill);
            this.pnlBody.Controls.Add(this.tb_bill);
            this.pnlBody.Controls.Add(this.btn_search);
            this.pnlBody.Controls.Add(this.inp_search);
            this.pnlBody.Controls.Add(this.label13);
            this.pnlBody.Controls.Add(this.label12);
            this.pnlBody.Controls.Add(this.txt_email);
            this.pnlBody.Controls.Add(this.txt_address);
            this.pnlBody.Controls.Add(this.txt_phone);
            this.pnlBody.Controls.Add(this.txt_name);
            this.pnlBody.Controls.Add(this.txt_id);
            this.pnlBody.Controls.Add(this.label7);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.txt_titleProduct);
            this.pnlBody.Location = new System.Drawing.Point(0, 4);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.ShadowDecoration.Parent = this.pnlBody;
            this.pnlBody.Size = new System.Drawing.Size(1173, 833);
            this.pnlBody.TabIndex = 0;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(34, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 29);
            this.label4.TabIndex = 113;
            this.label4.Text = "Chi tiết hoá đơn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.Animated = true;
            this.btn_back.BorderRadius = 10;
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Location = new System.Drawing.Point(17, 105);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(78, 35);
            this.btn_back.TabIndex = 112;
            this.btn_back.Text = "Trở về";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_detailsBill
            // 
            this.tb_detailsBill.AllowUserToResizeColumns = false;
            this.tb_detailsBill.AllowUserToResizeRows = false;
            this.tb_detailsBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_detailsBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_detailsBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_detailsBill.Location = new System.Drawing.Point(26, 581);
            this.tb_detailsBill.Name = "tb_detailsBill";
            this.tb_detailsBill.ReadOnly = true;
            this.tb_detailsBill.RowHeadersVisible = false;
            this.tb_detailsBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_detailsBill.RowTemplate.Height = 24;
            this.tb_detailsBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_detailsBill.Size = new System.Drawing.Size(1099, 211);
            this.tb_detailsBill.TabIndex = 111;
            this.tb_detailsBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_detailsBill_CellContentClick);
            // 
            // tb_bill
            // 
            this.tb_bill.AllowUserToResizeColumns = false;
            this.tb_bill.AllowUserToResizeRows = false;
            this.tb_bill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_bill.Location = new System.Drawing.Point(576, 209);
            this.tb_bill.Name = "tb_bill";
            this.tb_bill.ReadOnly = true;
            this.tb_bill.RowHeadersVisible = false;
            this.tb_bill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_bill.RowTemplate.Height = 24;
            this.tb_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_bill.Size = new System.Drawing.Size(549, 289);
            this.tb_bill.TabIndex = 110;
            this.tb_bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventClickCellBill);
            this.tb_bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_bill_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.Animated = true;
            this.btn_search.BorderRadius = 10;
            this.btn_search.CheckedState.Parent = this.btn_search;
            this.btn_search.CustomImages.Parent = this.btn_search;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.Parent = this.btn_search;
            this.btn_search.Location = new System.Drawing.Point(979, 519);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Parent = this.btn_search;
            this.btn_search.Size = new System.Drawing.Size(96, 40);
            this.btn_search.TabIndex = 108;
            this.btn_search.Text = "Tìm";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // inp_search
            // 
            this.inp_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_search.Animated = true;
            this.inp_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_search.BorderRadius = 6;
            this.inp_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_search.DefaultText = "";
            this.inp_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_search.DisabledState.Parent = this.inp_search;
            this.inp_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_search.FocusedState.Parent = this.inp_search;
            this.inp_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_search.ForeColor = System.Drawing.Color.White;
            this.inp_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_search.HoverState.Parent = this.inp_search;
            this.inp_search.Location = new System.Drawing.Point(697, 519);
            this.inp_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_search.Name = "inp_search";
            this.inp_search.PasswordChar = '\0';
            this.inp_search.PlaceholderText = "";
            this.inp_search.SelectedText = "";
            this.inp_search.ShadowDecoration.Parent = this.inp_search;
            this.inp_search.Size = new System.Drawing.Size(263, 44);
            this.inp_search.TabIndex = 107;
            this.inp_search.TextChanged += new System.EventHandler(this.inp_search_TextChanged);
            this.inp_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eventKeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(609, 531);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 37);
            this.label13.TabIndex = 106;
            this.label13.Text = "Từ khoá";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(760, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 37);
            this.label12.TabIndex = 104;
            this.label12.Text = "Hoá đơn đã mua";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.AutoSize = true;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_email.Location = new System.Drawing.Point(192, 425);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(64, 23);
            this.txt_email.TabIndex = 103;
            this.txt_email.Text = "label11";
            this.txt_email.Click += new System.EventHandler(this.txt_email_Click);
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.AutoSize = true;
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_address.Location = new System.Drawing.Point(192, 375);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(64, 23);
            this.txt_address.TabIndex = 102;
            this.txt_address.Text = "label10";
            this.txt_address.Click += new System.EventHandler(this.txt_address_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phone.AutoSize = true;
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_phone.Location = new System.Drawing.Point(192, 324);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(55, 23);
            this.txt_phone.TabIndex = 101;
            this.txt_phone.Text = "label9";
            this.txt_phone.Click += new System.EventHandler(this.txt_phone_Click);
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_name.Location = new System.Drawing.Point(192, 279);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(55, 23);
            this.txt_name.TabIndex = 100;
            this.txt_name.Text = "label8";
            this.txt_name.Click += new System.EventHandler(this.txt_name_Click);
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id.AutoSize = true;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_id.Location = new System.Drawing.Point(192, 232);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(55, 23);
            this.txt_id.TabIndex = 99;
            this.txt_id.Text = "label4";
            this.txt_id.Click += new System.EventHandler(this.txt_id_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(64, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 38);
            this.label7.TabIndex = 98;
            this.label7.Text = "SĐT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(47, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 34);
            this.label6.TabIndex = 97;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(54, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 96;
            this.label5.Text = "Địa chỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(41, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tên KH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(41, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 38);
            this.label3.TabIndex = 94;
            this.label3.Text = "Mã KH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(127, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 93;
            this.label1.Text = "Thông tin khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_titleProduct
            // 
            this.txt_titleProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_titleProduct.AutoSize = true;
            this.txt_titleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titleProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_titleProduct.Location = new System.Drawing.Point(473, 114);
            this.txt_titleProduct.Name = "txt_titleProduct";
            this.txt_titleProduct.Size = new System.Drawing.Size(307, 32);
            this.txt_titleProduct.TabIndex = 58;
            this.txt_titleProduct.Text = "Thông tin khách hàng";
            this.txt_titleProduct.Click += new System.EventHandler(this.txt_titleProduct_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(0, 2);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1188, 72);
            this.guna2Panel2.TabIndex = 133;
            // 
            // FormInfoCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1174, 848);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInfoCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInfoCustomer";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detailsBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label txt_titleProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Label txt_address;
        private System.Windows.Forms.Label txt_phone;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox inp_search;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2GradientButton btn_search;
        private System.Windows.Forms.DataGridView tb_bill;
        private System.Windows.Forms.DataGridView tb_detailsBill;
        private Guna.UI2.WinForms.Guna2GradientButton btn_back;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}