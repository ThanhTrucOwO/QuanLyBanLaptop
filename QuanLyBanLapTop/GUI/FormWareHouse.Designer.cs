namespace GUI
{
    partial class FormWareHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            this.tb_detailsP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tb_receipt = new Guna.UI2.WinForms.Guna2DataGridView();
            this.inp_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_detailPromotion = new System.Windows.Forms.Label();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_exportReceipt = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_addCoupon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_Promotion = new System.Windows.Forms.Label();
            this.txt_titlePromotion = new System.Windows.Forms.Label();
            this.guna2Panel22 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detailsP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_receipt)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.CausesValidation = false;
            this.pnlBody.Controls.Add(this.guna2Panel22);
            this.pnlBody.Controls.Add(this.tb_detailsP);
            this.pnlBody.Controls.Add(this.tb_receipt);
            this.pnlBody.Controls.Add(this.inp_search);
            this.pnlBody.Controls.Add(this.txt_detailPromotion);
            this.pnlBody.Controls.Add(this.guna2GradientButton3);
            this.pnlBody.Controls.Add(this.btn_exportReceipt);
            this.pnlBody.Controls.Add(this.btn_addCoupon);
            this.pnlBody.Controls.Add(this.txt_Promotion);
            this.pnlBody.Controls.Add(this.txt_titlePromotion);
            this.pnlBody.Location = new System.Drawing.Point(3, 0);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.ShadowDecoration.Parent = this.pnlBody;
            this.pnlBody.Size = new System.Drawing.Size(1188, 828);
            this.pnlBody.TabIndex = 1;
            // 
            // tb_detailsP
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.tb_detailsP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.tb_detailsP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_detailsP.BackgroundColor = System.Drawing.Color.White;
            this.tb_detailsP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_detailsP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tb_detailsP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_detailsP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.tb_detailsP.ColumnHeadersHeight = 35;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tb_detailsP.DefaultCellStyle = dataGridViewCellStyle21;
            this.tb_detailsP.EnableHeadersVisualStyles = false;
            this.tb_detailsP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tb_detailsP.Location = new System.Drawing.Point(27, 520);
            this.tb_detailsP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_detailsP.Name = "tb_detailsP";
            this.tb_detailsP.ReadOnly = true;
            this.tb_detailsP.RowHeadersVisible = false;
            this.tb_detailsP.RowHeadersWidth = 62;
            this.tb_detailsP.RowTemplate.Height = 28;
            this.tb_detailsP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_detailsP.Size = new System.Drawing.Size(1102, 256);
            this.tb_detailsP.TabIndex = 128;
            this.tb_detailsP.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tb_detailsP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tb_detailsP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tb_detailsP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tb_detailsP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tb_detailsP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tb_detailsP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tb_detailsP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tb_detailsP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_detailsP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tb_detailsP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_detailsP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tb_detailsP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tb_detailsP.ThemeStyle.HeaderStyle.Height = 35;
            this.tb_detailsP.ThemeStyle.ReadOnly = true;
            this.tb_detailsP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tb_detailsP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tb_detailsP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_detailsP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tb_detailsP.ThemeStyle.RowsStyle.Height = 28;
            this.tb_detailsP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tb_detailsP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tb_receipt
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.tb_receipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.tb_receipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_receipt.BackgroundColor = System.Drawing.Color.White;
            this.tb_receipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_receipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tb_receipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_receipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.tb_receipt.ColumnHeadersHeight = 35;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tb_receipt.DefaultCellStyle = dataGridViewCellStyle24;
            this.tb_receipt.EnableHeadersVisualStyles = false;
            this.tb_receipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tb_receipt.Location = new System.Drawing.Point(27, 182);
            this.tb_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_receipt.Name = "tb_receipt";
            this.tb_receipt.ReadOnly = true;
            this.tb_receipt.RowHeadersVisible = false;
            this.tb_receipt.RowHeadersWidth = 62;
            this.tb_receipt.RowTemplate.Height = 28;
            this.tb_receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_receipt.Size = new System.Drawing.Size(847, 293);
            this.tb_receipt.TabIndex = 127;
            this.tb_receipt.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tb_receipt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tb_receipt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tb_receipt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tb_receipt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tb_receipt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tb_receipt.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tb_receipt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tb_receipt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_receipt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tb_receipt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_receipt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tb_receipt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tb_receipt.ThemeStyle.HeaderStyle.Height = 35;
            this.tb_receipt.ThemeStyle.ReadOnly = true;
            this.tb_receipt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tb_receipt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tb_receipt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_receipt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tb_receipt.ThemeStyle.RowsStyle.Height = 28;
            this.tb_receipt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tb_receipt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tb_receipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventClickCell);
            // 
            // inp_search
            // 
            this.inp_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.inp_search.Location = new System.Drawing.Point(425, 128);
            this.inp_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_search.Name = "inp_search";
            this.inp_search.PasswordChar = '\0';
            this.inp_search.PlaceholderText = "";
            this.inp_search.SelectedText = "";
            this.inp_search.ShadowDecoration.Parent = this.inp_search;
            this.inp_search.Size = new System.Drawing.Size(296, 39);
            this.inp_search.TabIndex = 126;
            this.inp_search.TextChanged += new System.EventHandler(this.inp_search_TextChanged);
            // 
            // txt_detailPromotion
            // 
            this.txt_detailPromotion.AutoSize = true;
            this.txt_detailPromotion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detailPromotion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_detailPromotion.Location = new System.Drawing.Point(31, 485);
            this.txt_detailPromotion.Name = "txt_detailPromotion";
            this.txt_detailPromotion.Size = new System.Drawing.Size(199, 23);
            this.txt_detailPromotion.TabIndex = 125;
            this.txt_detailPromotion.Text = "Chi tiết phiếu nhập kho";
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(732, 128);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(151, 39);
            this.guna2GradientButton3.TabIndex = 124;
            this.guna2GradientButton3.Text = "Tìm kiếm";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // btn_exportReceipt
            // 
            this.btn_exportReceipt.Animated = true;
            this.btn_exportReceipt.BorderRadius = 10;
            this.btn_exportReceipt.CheckedState.Parent = this.btn_exportReceipt;
            this.btn_exportReceipt.CustomImages.Parent = this.btn_exportReceipt;
            this.btn_exportReceipt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exportReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_exportReceipt.HoverState.Parent = this.btn_exportReceipt;
            this.btn_exportReceipt.Location = new System.Drawing.Point(919, 234);
            this.btn_exportReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exportReceipt.Name = "btn_exportReceipt";
            this.btn_exportReceipt.ShadowDecoration.Parent = this.btn_exportReceipt;
            this.btn_exportReceipt.Size = new System.Drawing.Size(200, 40);
            this.btn_exportReceipt.TabIndex = 123;
            this.btn_exportReceipt.Text = "Xuất PNK";
            this.btn_exportReceipt.Click += new System.EventHandler(this.btn_exportPromotion_Click);
            // 
            // btn_addCoupon
            // 
            this.btn_addCoupon.Animated = true;
            this.btn_addCoupon.BorderRadius = 10;
            this.btn_addCoupon.CheckedState.Parent = this.btn_addCoupon;
            this.btn_addCoupon.CustomImages.Parent = this.btn_addCoupon;
            this.btn_addCoupon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addCoupon.ForeColor = System.Drawing.Color.White;
            this.btn_addCoupon.HoverState.Parent = this.btn_addCoupon;
            this.btn_addCoupon.Location = new System.Drawing.Point(919, 180);
            this.btn_addCoupon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addCoupon.Name = "btn_addCoupon";
            this.btn_addCoupon.ShadowDecoration.Parent = this.btn_addCoupon;
            this.btn_addCoupon.Size = new System.Drawing.Size(200, 40);
            this.btn_addCoupon.TabIndex = 122;
            this.btn_addCoupon.Text = "Tạo PNK";
            this.btn_addCoupon.Click += new System.EventHandler(this.btn_addCoupon_Click_1);
            // 
            // txt_Promotion
            // 
            this.txt_Promotion.AutoSize = true;
            this.txt_Promotion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Promotion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_Promotion.Location = new System.Drawing.Point(31, 148);
            this.txt_Promotion.Name = "txt_Promotion";
            this.txt_Promotion.Size = new System.Drawing.Size(218, 23);
            this.txt_Promotion.TabIndex = 121;
            this.txt_Promotion.Text = "Thông tin phiếu nhập kho";
            this.txt_Promotion.Click += new System.EventHandler(this.txt_Promotion_Click);
            // 
            // txt_titlePromotion
            // 
            this.txt_titlePromotion.AutoSize = true;
            this.txt_titlePromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titlePromotion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_titlePromotion.Location = new System.Drawing.Point(458, 78);
            this.txt_titlePromotion.Name = "txt_titlePromotion";
            this.txt_titlePromotion.Size = new System.Drawing.Size(336, 32);
            this.txt_titlePromotion.TabIndex = 120;
            this.txt_titlePromotion.Text = "Quản lý phiếu nhập kho";
            // 
            // guna2Panel22
            // 
            this.guna2Panel22.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel22.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel22.Name = "guna2Panel22";
            this.guna2Panel22.ShadowDecoration.Parent = this.guna2Panel22;
            this.guna2Panel22.Size = new System.Drawing.Size(1188, 72);
            this.guna2Panel22.TabIndex = 129;
            // 
            // FormWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1194, 825);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWareHouse";
            this.Text = "FormWareHouse";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detailsP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_receipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2DataGridView tb_detailsP;
        private Guna.UI2.WinForms.Guna2DataGridView tb_receipt;
        private Guna.UI2.WinForms.Guna2TextBox inp_search;
        private System.Windows.Forms.Label txt_detailPromotion;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_exportReceipt;
        private Guna.UI2.WinForms.Guna2GradientButton btn_addCoupon;
        private System.Windows.Forms.Label txt_Promotion;
        private System.Windows.Forms.Label txt_titlePromotion;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel22;
    }
}