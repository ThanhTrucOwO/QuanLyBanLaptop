namespace GUI
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inp_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inp_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inp_salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inp_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_service = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_reset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label9 = new System.Windows.Forms.Label();
            this.inp_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_topEmployee = new System.Windows.Forms.DataGridView();
            this.tb_employee = new System.Windows.Forms.DataGridView();
            this.date_birthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.error_id = new System.Windows.Forms.Label();
            this.error_name = new System.Windows.Forms.Label();
            this.error_phone = new System.Windows.Forms.Label();
            this.error_salary = new System.Windows.Forms.Label();
            this.txt_success = new System.Windows.Forms.Label();
            this.pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_employee = new System.Windows.Forms.Panel();
            this.cart_Quyen = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cart_employee = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.tb_topEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_employee)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel_employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_title
            // 
            this.txt_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_title.Location = new System.Drawing.Point(480, 98);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(260, 32);
            this.txt_title.TabIndex = 58;
            this.txt_title.Text = "Quản lý nhân viên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(122, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 99;
            this.label1.Text = "Thông tin nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(47, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 36);
            this.label3.TabIndex = 100;
            this.label3.Text = "Mã NV";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_id
            // 
            this.inp_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_id.Animated = true;
            this.inp_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_id.BorderRadius = 6;
            this.inp_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_id.DefaultText = "";
            this.inp_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_id.DisabledState.Parent = this.inp_id;
            this.inp_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_id.FocusedState.Parent = this.inp_id;
            this.inp_id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_id.ForeColor = System.Drawing.Color.White;
            this.inp_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_id.HoverState.Parent = this.inp_id;
            this.inp_id.Location = new System.Drawing.Point(156, 195);
            this.inp_id.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_id.Name = "inp_id";
            this.inp_id.PasswordChar = '\0';
            this.inp_id.PlaceholderText = "";
            this.inp_id.SelectedText = "";
            this.inp_id.ShadowDecoration.Parent = this.inp_id;
            this.inp_id.Size = new System.Drawing.Size(266, 36);
            this.inp_id.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(46, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 36);
            this.label2.TabIndex = 102;
            this.label2.Text = "Tên NV";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_name
            // 
            this.inp_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_name.Animated = true;
            this.inp_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_name.BorderRadius = 6;
            this.inp_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_name.DefaultText = "";
            this.inp_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_name.DisabledState.Parent = this.inp_name;
            this.inp_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_name.FocusedState.Parent = this.inp_name;
            this.inp_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_name.ForeColor = System.Drawing.Color.White;
            this.inp_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_name.HoverState.Parent = this.inp_name;
            this.inp_name.Location = new System.Drawing.Point(156, 236);
            this.inp_name.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_name.Name = "inp_name";
            this.inp_name.PasswordChar = '\0';
            this.inp_name.PlaceholderText = "";
            this.inp_name.SelectedText = "";
            this.inp_name.ShadowDecoration.Parent = this.inp_name;
            this.inp_name.Size = new System.Drawing.Size(266, 36);
            this.inp_name.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(52, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 36);
            this.label6.TabIndex = 106;
            this.label6.Text = "Lương ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_salary
            // 
            this.inp_salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_salary.Animated = true;
            this.inp_salary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_salary.BorderRadius = 6;
            this.inp_salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_salary.DefaultText = "";
            this.inp_salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_salary.DisabledState.Parent = this.inp_salary;
            this.inp_salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_salary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_salary.FocusedState.Parent = this.inp_salary;
            this.inp_salary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_salary.ForeColor = System.Drawing.Color.White;
            this.inp_salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_salary.HoverState.Parent = this.inp_salary;
            this.inp_salary.Location = new System.Drawing.Point(156, 359);
            this.inp_salary.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_salary.Name = "inp_salary";
            this.inp_salary.PasswordChar = '\0';
            this.inp_salary.PlaceholderText = "";
            this.inp_salary.SelectedText = "";
            this.inp_salary.ShadowDecoration.Parent = this.inp_salary;
            this.inp_salary.Size = new System.Drawing.Size(266, 36);
            this.inp_salary.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(73, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 36);
            this.label7.TabIndex = 108;
            this.label7.Text = "SĐT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_phone
            // 
            this.inp_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_phone.Animated = true;
            this.inp_phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_phone.BorderRadius = 6;
            this.inp_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_phone.DefaultText = "";
            this.inp_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_phone.DisabledState.Parent = this.inp_phone;
            this.inp_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_phone.FocusedState.Parent = this.inp_phone;
            this.inp_phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_phone.ForeColor = System.Drawing.Color.White;
            this.inp_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_phone.HoverState.Parent = this.inp_phone;
            this.inp_phone.Location = new System.Drawing.Point(155, 317);
            this.inp_phone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_phone.Name = "inp_phone";
            this.inp_phone.PasswordChar = '\0';
            this.inp_phone.PlaceholderText = "";
            this.inp_phone.SelectedText = "";
            this.inp_phone.ShadowDecoration.Parent = this.inp_phone;
            this.inp_phone.Size = new System.Drawing.Size(266, 36);
            this.inp_phone.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(36, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 110;
            this.label4.Text = "Ngày sinh";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(32, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 36);
            this.label8.TabIndex = 112;
            this.label8.Text = "Chức vụ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_service
            // 
            this.cbb_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbb_service.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.cbb_service.BorderRadius = 6;
            this.cbb_service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_service.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_service.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbb_service.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_service.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_service.FocusedState.Parent = this.cbb_service;
            this.cbb_service.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_service.ForeColor = System.Drawing.Color.White;
            this.cbb_service.HoverState.Parent = this.cbb_service;
            this.cbb_service.ItemHeight = 30;
            this.cbb_service.ItemsAppearance.Parent = this.cbb_service;
            this.cbb_service.Location = new System.Drawing.Point(156, 400);
            this.cbb_service.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbb_service.Name = "cbb_service";
            this.cbb_service.ShadowDecoration.Parent = this.cbb_service;
            this.cbb_service.Size = new System.Drawing.Size(266, 36);
            this.cbb_service.TabIndex = 113;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Animated = true;
            this.btn_add.BorderRadius = 10;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(63, 466);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(100, 37);
            this.btn_add.TabIndex = 115;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.Animated = true;
            this.btn_edit.BorderRadius = 10;
            this.btn_edit.CheckedState.Parent = this.btn_edit;
            this.btn_edit.CustomImages.Parent = this.btn_edit;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.HoverState.Parent = this.btn_edit;
            this.btn_edit.Location = new System.Drawing.Point(165, 466);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShadowDecoration.Parent = this.btn_edit;
            this.btn_edit.Size = new System.Drawing.Size(100, 37);
            this.btn_edit.TabIndex = 116;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Animated = true;
            this.btn_delete.BorderRadius = 10;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(267, 466);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(100, 37);
            this.btn_delete.TabIndex = 117;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.Animated = true;
            this.btn_reset.BorderRadius = 10;
            this.btn_reset.CheckedState.Parent = this.btn_reset;
            this.btn_reset.CustomImages.Parent = this.btn_reset;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.HoverState.Parent = this.btn_reset;
            this.btn_reset.Location = new System.Drawing.Point(369, 466);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.ShadowDecoration.Parent = this.btn_reset;
            this.btn_reset.Size = new System.Drawing.Size(100, 37);
            this.btn_reset.TabIndex = 118;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(636, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 37);
            this.label9.TabIndex = 119;
            this.label9.Text = "Từ khoá";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.inp_search.Location = new System.Drawing.Point(753, 496);
            this.inp_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_search.Name = "inp_search";
            this.inp_search.PasswordChar = '\0';
            this.inp_search.PlaceholderText = "";
            this.inp_search.SelectedText = "";
            this.inp_search.ShadowDecoration.Parent = this.inp_search;
            this.inp_search.Size = new System.Drawing.Size(267, 38);
            this.inp_search.TabIndex = 120;
            this.inp_search.TextChanged += new System.EventHandler(this.guna2TextBox7_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(780, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 37);
            this.label10.TabIndex = 121;
            this.label10.Text = "BXH nhân viên";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(52, 528);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 28);
            this.label11.TabIndex = 123;
            this.label11.Text = "Danh sách nhân viên";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_topEmployee
            // 
            this.tb_topEmployee.AllowUserToResizeColumns = false;
            this.tb_topEmployee.AllowUserToResizeRows = false;
            this.tb_topEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_topEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_topEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_topEmployee.Location = new System.Drawing.Point(611, 181);
            this.tb_topEmployee.Name = "tb_topEmployee";
            this.tb_topEmployee.ReadOnly = true;
            this.tb_topEmployee.RowHeadersVisible = false;
            this.tb_topEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_topEmployee.RowTemplate.Height = 24;
            this.tb_topEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_topEmployee.Size = new System.Drawing.Size(515, 295);
            this.tb_topEmployee.TabIndex = 124;
            // 
            // tb_employee
            // 
            this.tb_employee.AllowUserToResizeColumns = false;
            this.tb_employee.AllowUserToResizeRows = false;
            this.tb_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_employee.Location = new System.Drawing.Point(37, 561);
            this.tb_employee.Name = "tb_employee";
            this.tb_employee.ReadOnly = true;
            this.tb_employee.RowHeadersVisible = false;
            this.tb_employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_employee.RowTemplate.Height = 24;
            this.tb_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_employee.Size = new System.Drawing.Size(1089, 221);
            this.tb_employee.TabIndex = 125;
            this.tb_employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventClickCellEmployee);
            this.tb_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_employee_CellContentClick);
            // 
            // date_birthday
            // 
            this.date_birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_birthday.BorderRadius = 4;
            this.date_birthday.CheckedState.Parent = this.date_birthday;
            this.date_birthday.FillColor = System.Drawing.Color.DodgerBlue;
            this.date_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_birthday.HoverState.Parent = this.date_birthday;
            this.date_birthday.Location = new System.Drawing.Point(155, 278);
            this.date_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.date_birthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_birthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.ShadowDecoration.Parent = this.date_birthday;
            this.date_birthday.Size = new System.Drawing.Size(262, 34);
            this.date_birthday.TabIndex = 126;
            this.date_birthday.Value = new System.DateTime(2022, 10, 15, 17, 36, 30, 846);
            // 
            // error_id
            // 
            this.error_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.error_id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_id.ForeColor = System.Drawing.Color.Red;
            this.error_id.Location = new System.Drawing.Point(427, 197);
            this.error_id.Name = "error_id";
            this.error_id.Size = new System.Drawing.Size(182, 36);
            this.error_id.TabIndex = 127;
            this.error_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // error_name
            // 
            this.error_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.error_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_name.ForeColor = System.Drawing.Color.Red;
            this.error_name.Location = new System.Drawing.Point(424, 236);
            this.error_name.Name = "error_name";
            this.error_name.Size = new System.Drawing.Size(182, 36);
            this.error_name.TabIndex = 128;
            this.error_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // error_phone
            // 
            this.error_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.error_phone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_phone.ForeColor = System.Drawing.Color.Red;
            this.error_phone.Location = new System.Drawing.Point(424, 317);
            this.error_phone.Name = "error_phone";
            this.error_phone.Size = new System.Drawing.Size(182, 36);
            this.error_phone.TabIndex = 129;
            this.error_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // error_salary
            // 
            this.error_salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.error_salary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_salary.ForeColor = System.Drawing.Color.Red;
            this.error_salary.Location = new System.Drawing.Point(424, 359);
            this.error_salary.Name = "error_salary";
            this.error_salary.Size = new System.Drawing.Size(182, 36);
            this.error_salary.TabIndex = 130;
            this.error_salary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_success
            // 
            this.txt_success.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_success.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_success.ForeColor = System.Drawing.Color.Lime;
            this.txt_success.Location = new System.Drawing.Point(365, 525);
            this.txt_success.Name = "txt_success";
            this.txt_success.Size = new System.Drawing.Size(331, 36);
            this.txt_success.TabIndex = 131;
            this.txt_success.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.CausesValidation = false;
            this.pnlBody.Controls.Add(this.guna2Panel2);
            this.pnlBody.Controls.Add(this.txt_success);
            this.pnlBody.Controls.Add(this.error_salary);
            this.pnlBody.Controls.Add(this.error_phone);
            this.pnlBody.Controls.Add(this.error_name);
            this.pnlBody.Controls.Add(this.error_id);
            this.pnlBody.Controls.Add(this.date_birthday);
            this.pnlBody.Controls.Add(this.tb_employee);
            this.pnlBody.Controls.Add(this.tb_topEmployee);
            this.pnlBody.Controls.Add(this.label11);
            this.pnlBody.Controls.Add(this.label10);
            this.pnlBody.Controls.Add(this.inp_search);
            this.pnlBody.Controls.Add(this.label9);
            this.pnlBody.Controls.Add(this.btn_reset);
            this.pnlBody.Controls.Add(this.btn_delete);
            this.pnlBody.Controls.Add(this.btn_edit);
            this.pnlBody.Controls.Add(this.btn_add);
            this.pnlBody.Controls.Add(this.cbb_service);
            this.pnlBody.Controls.Add(this.label8);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.inp_phone);
            this.pnlBody.Controls.Add(this.label7);
            this.pnlBody.Controls.Add(this.inp_salary);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.inp_name);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.inp_id);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.txt_title);
            this.pnlBody.Location = new System.Drawing.Point(2, 4);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.ShadowDecoration.Parent = this.pnlBody;
            this.pnlBody.Size = new System.Drawing.Size(1163, 813);
            this.pnlBody.TabIndex = 0;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.panel_employee);
            this.guna2Panel2.Location = new System.Drawing.Point(-1, 5);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1188, 72);
            this.guna2Panel2.TabIndex = 132;
            // 
            // panel_employee
            // 
            this.panel_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel_employee.Controls.Add(this.cart_Quyen);
            this.panel_employee.Controls.Add(this.cart_employee);
            this.panel_employee.Location = new System.Drawing.Point(8, 17);
            this.panel_employee.Name = "panel_employee";
            this.panel_employee.Size = new System.Drawing.Size(1172, 38);
            this.panel_employee.TabIndex = 86;
            // 
            // cart_Quyen
            // 
            this.cart_Quyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cart_Quyen.Animated = true;
            this.cart_Quyen.BorderRadius = 10;
            this.cart_Quyen.CheckedState.Parent = this.cart_Quyen;
            this.cart_Quyen.CustomImages.Parent = this.cart_Quyen;
            this.cart_Quyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cart_Quyen.ForeColor = System.Drawing.Color.White;
            this.cart_Quyen.HoverState.Parent = this.cart_Quyen;
            this.cart_Quyen.Location = new System.Drawing.Point(157, 2);
            this.cart_Quyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cart_Quyen.Name = "cart_Quyen";
            this.cart_Quyen.ShadowDecoration.Parent = this.cart_Quyen;
            this.cart_Quyen.Size = new System.Drawing.Size(131, 36);
            this.cart_Quyen.TabIndex = 81;
            this.cart_Quyen.Text = "Phân quyền";
            // 
            // cart_employee
            // 
            this.cart_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cart_employee.Animated = true;
            this.cart_employee.BorderRadius = 10;
            this.cart_employee.CheckedState.Parent = this.cart_employee;
            this.cart_employee.CustomImages.Parent = this.cart_employee;
            this.cart_employee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cart_employee.ForeColor = System.Drawing.Color.White;
            this.cart_employee.HoverState.Parent = this.cart_employee;
            this.cart_employee.Location = new System.Drawing.Point(20, 2);
            this.cart_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cart_employee.Name = "cart_employee";
            this.cart_employee.ShadowDecoration.Parent = this.cart_employee;
            this.cart_employee.Size = new System.Drawing.Size(131, 36);
            this.cart_employee.TabIndex = 80;
            this.cart_employee.Text = "Nhân viên";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1164, 828);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEmployee";
            this.Text = "Quản lý bán Laptop";
            ((System.ComponentModel.ISupportInitialize)(this.tb_topEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_employee)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.panel_employee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private System.Windows.Forms.Label txt_success;
        private System.Windows.Forms.Label error_salary;
        private System.Windows.Forms.Label error_phone;
        private System.Windows.Forms.Label error_name;
        private System.Windows.Forms.Label error_id;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_birthday;
        private System.Windows.Forms.DataGridView tb_employee;
        private System.Windows.Forms.DataGridView tb_topEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox inp_search;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2GradientButton btn_reset;
        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private Guna.UI2.WinForms.Guna2GradientButton btn_edit;
        private Guna.UI2.WinForms.Guna2GradientButton btn_add;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_service;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox inp_phone;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox inp_salary;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox inp_name;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox inp_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_title;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel_employee;
        private Guna.UI2.WinForms.Guna2GradientButton cart_Quyen;
        private Guna.UI2.WinForms.Guna2GradientButton cart_employee;
    }
}