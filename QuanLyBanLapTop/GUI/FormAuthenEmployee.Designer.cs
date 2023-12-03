namespace GUI
{
    partial class FormAuthenEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthenEmployee));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tb_employee = new System.Windows.Forms.DataGridView();
            this.txt_title = new System.Windows.Forms.Label();
            this.radAdmin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radEmployee = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.inp_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tb_employee);
            this.guna2Panel1.Controls.Add(this.txt_title);
            this.guna2Panel1.Controls.Add(this.radAdmin);
            this.guna2Panel1.Controls.Add(this.radEmployee);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.inp_search);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton7);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1116, 815);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // tb_employee
            // 
            this.tb_employee.AllowUserToResizeColumns = false;
            this.tb_employee.AllowUserToResizeRows = false;
            this.tb_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_employee.Location = new System.Drawing.Point(222, 200);
            this.tb_employee.Name = "tb_employee";
            this.tb_employee.ReadOnly = true;
            this.tb_employee.RowHeadersVisible = false;
            this.tb_employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_employee.RowTemplate.Height = 24;
            this.tb_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_employee.Size = new System.Drawing.Size(671, 292);
            this.tb_employee.TabIndex = 138;
            this.tb_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_employee_CellContentClick);
            // 
            // txt_title
            // 
            this.txt_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_title.Location = new System.Drawing.Point(429, 71);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(176, 32);
            this.txt_title.TabIndex = 137;
            this.txt_title.Text = "Phân quyền";
            // 
            // radAdmin
            // 
            this.radAdmin.Animated = true;
            this.radAdmin.AutoSize = true;
            this.radAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.radAdmin.CheckedState.BorderThickness = 0;
            this.radAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.radAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radAdmin.CheckedState.InnerOffset = -4;
            this.radAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAdmin.FlatAppearance.BorderSize = 0;
            this.radAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radAdmin.ForeColor = System.Drawing.Color.White;
            this.radAdmin.Location = new System.Drawing.Point(544, 517);
            this.radAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(99, 32);
            this.radAdmin.TabIndex = 132;
            this.radAdmin.Tag = "";
            this.radAdmin.Text = "Quản lý";
            this.radAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radAdmin.UncheckedState.BorderThickness = 2;
            this.radAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radEmployee
            // 
            this.radEmployee.Animated = true;
            this.radEmployee.AutoSize = true;
            this.radEmployee.Checked = true;
            this.radEmployee.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.radEmployee.CheckedState.BorderThickness = 0;
            this.radEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.radEmployee.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radEmployee.CheckedState.InnerOffset = -4;
            this.radEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radEmployee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radEmployee.ForeColor = System.Drawing.Color.White;
            this.radEmployee.Location = new System.Drawing.Point(387, 517);
            this.radEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.radEmployee.Name = "radEmployee";
            this.radEmployee.Size = new System.Drawing.Size(120, 32);
            this.radEmployee.TabIndex = 131;
            this.radEmployee.TabStop = true;
            this.radEmployee.Tag = "";
            this.radEmployee.Text = "Nhân viên";
            this.radEmployee.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radEmployee.UncheckedState.BorderThickness = 2;
            this.radEmployee.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radEmployee.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radEmployee.CheckedChanged += new System.EventHandler(this.radEmployee_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 521);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 129;
            this.label1.Text = "Vai trò:";
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
            this.inp_search.Location = new System.Drawing.Point(387, 131);
            this.inp_search.Margin = new System.Windows.Forms.Padding(5);
            this.inp_search.Name = "inp_search";
            this.inp_search.PasswordChar = '\0';
            this.inp_search.PlaceholderText = "Nhập tên NV để tìm kiếm";
            this.inp_search.SelectedText = "";
            this.inp_search.ShadowDecoration.Parent = this.inp_search;
            this.inp_search.Size = new System.Drawing.Size(336, 44);
            this.inp_search.TabIndex = 126;
            this.inp_search.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2GradientButton7
            // 
            this.guna2GradientButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton7.Animated = true;
            this.guna2GradientButton7.BorderRadius = 10;
            this.guna2GradientButton7.CheckedState.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.CustomImages.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton7.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton7.HoverState.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Location = new System.Drawing.Point(666, 514);
            this.guna2GradientButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton7.Name = "guna2GradientButton7";
            this.guna2GradientButton7.ShadowDecoration.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Size = new System.Drawing.Size(96, 39);
            this.guna2GradientButton7.TabIndex = 125;
            this.guna2GradientButton7.Text = "Lưu";
            this.guna2GradientButton7.Click += new System.EventHandler(this.guna2GradientButton7_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // FormAuthenEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1116, 757);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAuthenEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý bán Laptop";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton7;
        private Guna.UI2.WinForms.Guna2TextBox inp_search;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton radEmployee;
        private Guna.UI2.WinForms.Guna2RadioButton radAdmin;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.DataGridView tb_employee;
    }
}