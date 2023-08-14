
namespace PetShop.Forms
{
    partial class FormSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelNcc = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dvgNCC = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dcmNCC_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmNCC_serialkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmNCC_tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmNCC_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmNCC_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmNCC_SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtdiachincc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tenncc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_sdtncc = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNCCreset = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelnhaplohang = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dvgLoHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dcmLH_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmLH_lohangkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmLH_tenlh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmLH_ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmLH_nhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcmLH_SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddConsignment = new Guna.UI2.WinForms.Guna2Button();
            this.btnResetConsignment = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLH_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_ngaynhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnbackPanel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.PanelNcc.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNCC)).BeginInit();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelnhaplohang.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLoHang)).BeginInit();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelNcc);
            this.panel1.Controls.Add(this.panelnhaplohang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 608);
            this.panel1.TabIndex = 1;
            // 
            // PanelNcc
            // 
            this.PanelNcc.Controls.Add(this.panel10);
            this.PanelNcc.Controls.Add(this.panel9);
            this.PanelNcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNcc.Location = new System.Drawing.Point(0, 0);
            this.PanelNcc.Name = "PanelNcc";
            this.PanelNcc.Size = new System.Drawing.Size(993, 608);
            this.PanelNcc.TabIndex = 5;
            this.PanelNcc.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dvgNCC);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 128);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(993, 480);
            this.panel10.TabIndex = 1;
            // 
            // dvgNCC
            // 
            this.dvgNCC.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dvgNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgNCC.BackgroundColor = System.Drawing.Color.White;
            this.dvgNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dvgNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgNCC.ColumnHeadersHeight = 40;
            this.dvgNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcmNCC_Num,
            this.dcmNCC_serialkey,
            this.dcmNCC_tenncc,
            this.dcmNCC_diachi,
            this.dcmNCC_sdt,
            this.dcmNCC_SL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgNCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgNCC.EnableHeadersVisualStyles = false;
            this.dvgNCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgNCC.Location = new System.Drawing.Point(0, 0);
            this.dvgNCC.Name = "dvgNCC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgNCC.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy;
            this.dvgNCC.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgNCC.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNCC.RowTemplate.Height = 30;
            this.dvgNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgNCC.Size = new System.Drawing.Size(993, 480);
            this.dvgNCC.TabIndex = 0;
            this.dvgNCC.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dvgNCC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgNCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgNCC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgNCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgNCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgNCC.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgNCC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgNCC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dvgNCC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgNCC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgNCC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgNCC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgNCC.ThemeStyle.HeaderStyle.Height = 40;
            this.dvgNCC.ThemeStyle.ReadOnly = false;
            this.dvgNCC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgNCC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgNCC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvgNCC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvgNCC.ThemeStyle.RowsStyle.Height = 30;
            this.dvgNCC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgNCC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvgNCC.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgNCC_CellContentDoubleClick);
            this.dvgNCC.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgNCC_CellEndEdit);
            // 
            // dcmNCC_Num
            // 
            this.dcmNCC_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmNCC_Num.FillWeight = 330.0485F;
            this.dcmNCC_Num.HeaderText = "STT";
            this.dcmNCC_Num.MinimumWidth = 60;
            this.dcmNCC_Num.Name = "dcmNCC_Num";
            this.dcmNCC_Num.ReadOnly = true;
            // 
            // dcmNCC_serialkey
            // 
            this.dcmNCC_serialkey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmNCC_serialkey.HeaderText = "Mã nhà cung cấp";
            this.dcmNCC_serialkey.MinimumWidth = 150;
            this.dcmNCC_serialkey.Name = "dcmNCC_serialkey";
            this.dcmNCC_serialkey.ReadOnly = true;
            // 
            // dcmNCC_tenncc
            // 
            this.dcmNCC_tenncc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmNCC_tenncc.FillWeight = 51.57007F;
            this.dcmNCC_tenncc.HeaderText = "Tên nhà cung cấp";
            this.dcmNCC_tenncc.MinimumWidth = 400;
            this.dcmNCC_tenncc.Name = "dcmNCC_tenncc";
            // 
            // dcmNCC_diachi
            // 
            this.dcmNCC_diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmNCC_diachi.FillWeight = 9.190723F;
            this.dcmNCC_diachi.HeaderText = "Địa chỉ";
            this.dcmNCC_diachi.MinimumWidth = 200;
            this.dcmNCC_diachi.Name = "dcmNCC_diachi";
            // 
            // dcmNCC_sdt
            // 
            this.dcmNCC_sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmNCC_sdt.FillWeight = 9.190723F;
            this.dcmNCC_sdt.HeaderText = "Số điện thoại";
            this.dcmNCC_sdt.MinimumWidth = 150;
            this.dcmNCC_sdt.Name = "dcmNCC_sdt";
            // 
            // dcmNCC_SL
            // 
            this.dcmNCC_SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmNCC_SL.HeaderText = "Số lượng lô hàng";
            this.dcmNCC_SL.MinimumWidth = 130;
            this.dcmNCC_SL.Name = "dcmNCC_SL";
            this.dcmNCC_SL.ReadOnly = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tableLayoutPanel1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(993, 128);
            this.panel9.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Controls.Add(this.txtdiachincc, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_tenncc, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_sdtncc, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNCCreset, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddSupplier, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtdiachincc
            // 
            this.txtdiachincc.BorderRadius = 15;
            this.txtdiachincc.BorderThickness = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.txtdiachincc, 2);
            this.txtdiachincc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachincc.DefaultText = "";
            this.txtdiachincc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiachincc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiachincc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachincc.DisabledState.Parent = this.txtdiachincc;
            this.txtdiachincc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachincc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdiachincc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachincc.FocusedState.Parent = this.txtdiachincc;
            this.txtdiachincc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachincc.ForeColor = System.Drawing.Color.Red;
            this.txtdiachincc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachincc.HoverState.Parent = this.txtdiachincc;
            this.txtdiachincc.Location = new System.Drawing.Point(581, 21);
            this.txtdiachincc.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtdiachincc.Name = "txtdiachincc";
            this.txtdiachincc.PasswordChar = '\0';
            this.txtdiachincc.PlaceholderText = "";
            this.txtdiachincc.SelectedText = "";
            this.txtdiachincc.ShadowDecoration.Parent = this.txtdiachincc;
            this.txtdiachincc.Size = new System.Drawing.Size(324, 33);
            this.txtdiachincc.TabIndex = 2;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.BorderRadius = 15;
            this.txt_tenncc.BorderThickness = 2;
            this.txt_tenncc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenncc.DefaultText = "";
            this.txt_tenncc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenncc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenncc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenncc.DisabledState.Parent = this.txt_tenncc;
            this.txt_tenncc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tenncc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenncc.FocusedState.Parent = this.txt_tenncc;
            this.txt_tenncc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenncc.ForeColor = System.Drawing.Color.Red;
            this.txt_tenncc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenncc.HoverState.Parent = this.txt_tenncc;
            this.txt_tenncc.Location = new System.Drawing.Point(174, 21);
            this.txt_tenncc.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.PasswordChar = '\0';
            this.txt_tenncc.PlaceholderText = "";
            this.txt_tenncc.SelectedText = "";
            this.txt_tenncc.ShadowDecoration.Parent = this.txt_tenncc;
            this.txt_tenncc.Size = new System.Drawing.Size(273, 33);
            this.txt_tenncc.TabIndex = 1;
            // 
            // txt_sdtncc
            // 
            this.txt_sdtncc.BorderRadius = 15;
            this.txt_sdtncc.BorderThickness = 2;
            this.txt_sdtncc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdtncc.DefaultText = "";
            this.txt_sdtncc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sdtncc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sdtncc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdtncc.DisabledState.Parent = this.txt_sdtncc;
            this.txt_sdtncc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdtncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sdtncc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdtncc.FocusedState.Parent = this.txt_sdtncc;
            this.txt_sdtncc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtncc.ForeColor = System.Drawing.Color.Red;
            this.txt_sdtncc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdtncc.HoverState.Parent = this.txt_sdtncc;
            this.txt_sdtncc.Location = new System.Drawing.Point(174, 72);
            this.txt_sdtncc.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txt_sdtncc.Name = "txt_sdtncc";
            this.txt_sdtncc.PasswordChar = '\0';
            this.txt_sdtncc.PlaceholderText = "";
            this.txt_sdtncc.SelectedText = "";
            this.txt_sdtncc.ShadowDecoration.Parent = this.txt_sdtncc;
            this.txt_sdtncc.Size = new System.Drawing.Size(273, 33);
            this.txt_sdtncc.TabIndex = 3;
            // 
            // btnNCCreset
            // 
            this.btnNCCreset.BackColor = System.Drawing.Color.Transparent;
            this.btnNCCreset.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnNCCreset.BorderRadius = 15;
            this.btnNCCreset.CheckedState.Parent = this.btnNCCreset;
            this.btnNCCreset.CustomImages.Parent = this.btnNCCreset;
            this.btnNCCreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNCCreset.FillColor = System.Drawing.Color.Khaki;
            this.btnNCCreset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCCreset.ForeColor = System.Drawing.Color.Black;
            this.btnNCCreset.HoverState.Parent = this.btnNCCreset;
            this.btnNCCreset.Location = new System.Drawing.Point(760, 68);
            this.btnNCCreset.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnNCCreset.Name = "btnNCCreset";
            this.btnNCCreset.ShadowDecoration.Parent = this.btnNCCreset;
            this.btnNCCreset.Size = new System.Drawing.Size(139, 41);
            this.btnNCCreset.TabIndex = 4;
            this.btnNCCreset.Text = "Làm mới";
            this.btnNCCreset.Click += new System.EventHandler(this.btnNCCreset_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddSupplier.BorderRadius = 15;
            this.btnAddSupplier.CheckedState.Parent = this.btnAddSupplier;
            this.btnAddSupplier.CustomImages.Parent = this.btnAddSupplier;
            this.btnAddSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSupplier.FillColor = System.Drawing.Color.Gold;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.Black;
            this.btnAddSupplier.HoverState.Parent = this.btnAddSupplier;
            this.btnAddSupplier.Location = new System.Drawing.Point(587, 68);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.ShadowDecoration.Parent = this.btnAddSupplier;
            this.btnAddSupplier.Size = new System.Drawing.Size(153, 41);
            this.btnAddSupplier.TabIndex = 0;
            this.btnAddSupplier.Text = "Thêm nhà cung cấp";
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.guna2HtmlLabel1, 2);
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 27);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(147, 33);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Tên nhà cung cấp(*)";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(506, 27);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(68, 33);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Địa chỉ(*)";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.guna2HtmlLabel3, 2);
            this.guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(51, 78);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(116, 33);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "Số điện thoại(*)";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelnhaplohang
            // 
            this.panelnhaplohang.Controls.Add(this.panel8);
            this.panelnhaplohang.Controls.Add(this.panel7);
            this.panelnhaplohang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelnhaplohang.Location = new System.Drawing.Point(0, 0);
            this.panelnhaplohang.Name = "panelnhaplohang";
            this.panelnhaplohang.Size = new System.Drawing.Size(993, 608);
            this.panelnhaplohang.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dvgLoHang);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 110);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(993, 498);
            this.panel8.TabIndex = 2;
            // 
            // dvgLoHang
            // 
            this.dvgLoHang.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dvgLoHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgLoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgLoHang.BackgroundColor = System.Drawing.Color.White;
            this.dvgLoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgLoHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgLoHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dvgLoHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgLoHang.ColumnHeadersHeight = 40;
            this.dvgLoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgLoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcmLH_stt,
            this.dcmLH_lohangkey,
            this.dcmLH_tenlh,
            this.dcmLH_ngay,
            this.dcmLH_nhacungcap,
            this.dcmLH_SL});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgLoHang.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvgLoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgLoHang.EnableHeadersVisualStyles = false;
            this.dvgLoHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgLoHang.Location = new System.Drawing.Point(0, 0);
            this.dvgLoHang.Name = "dvgLoHang";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgLoHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgLoHang.RowHeadersVisible = false;
            this.dvgLoHang.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvgLoHang.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgLoHang.RowTemplate.Height = 30;
            this.dvgLoHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgLoHang.Size = new System.Drawing.Size(993, 498);
            this.dvgLoHang.TabIndex = 0;
            this.dvgLoHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dvgLoHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgLoHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgLoHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgLoHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgLoHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgLoHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgLoHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgLoHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dvgLoHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgLoHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgLoHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgLoHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgLoHang.ThemeStyle.HeaderStyle.Height = 40;
            this.dvgLoHang.ThemeStyle.ReadOnly = false;
            this.dvgLoHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgLoHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgLoHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvgLoHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvgLoHang.ThemeStyle.RowsStyle.Height = 30;
            this.dvgLoHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgLoHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvgLoHang.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgLoHang_CellContentDoubleClick);
            this.dvgLoHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgLoHang_CellEndEdit);
            // 
            // dcmLH_stt
            // 
            this.dcmLH_stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmLH_stt.HeaderText = "STT";
            this.dcmLH_stt.Name = "dcmLH_stt";
            // 
            // dcmLH_lohangkey
            // 
            this.dcmLH_lohangkey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmLH_lohangkey.HeaderText = "Mã lô hàng";
            this.dcmLH_lohangkey.Name = "dcmLH_lohangkey";
            this.dcmLH_lohangkey.ReadOnly = true;
            // 
            // dcmLH_tenlh
            // 
            this.dcmLH_tenlh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmLH_tenlh.HeaderText = "Tên";
            this.dcmLH_tenlh.Name = "dcmLH_tenlh";
            // 
            // dcmLH_ngay
            // 
            this.dcmLH_ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmLH_ngay.HeaderText = "Ngày";
            this.dcmLH_ngay.Name = "dcmLH_ngay";
            // 
            // dcmLH_nhacungcap
            // 
            this.dcmLH_nhacungcap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmLH_nhacungcap.HeaderText = "Nhà cung cấp";
            this.dcmLH_nhacungcap.Name = "dcmLH_nhacungcap";
            this.dcmLH_nhacungcap.ReadOnly = true;
            // 
            // dcmLH_SL
            // 
            this.dcmLH_SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcmLH_SL.HeaderText = "Số lượng sản phẩm";
            this.dcmLH_SL.Name = "dcmLH_SL";
            this.dcmLH_SL.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(993, 110);
            this.panel7.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddConsignment, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnResetConsignment, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtLH_name, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtp_ngaynhap, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnbackPanel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.05608F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.59813F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(993, 110);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAddConsignment
            // 
            this.btnAddConsignment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddConsignment.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddConsignment.BorderRadius = 12;
            this.btnAddConsignment.BorderThickness = 3;
            this.btnAddConsignment.CheckedState.Parent = this.btnAddConsignment;
            this.btnAddConsignment.CustomImages.Parent = this.btnAddConsignment;
            this.btnAddConsignment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddConsignment.FillColor = System.Drawing.Color.GhostWhite;
            this.btnAddConsignment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConsignment.ForeColor = System.Drawing.Color.Black;
            this.btnAddConsignment.HoverState.Parent = this.btnAddConsignment;
            this.btnAddConsignment.Location = new System.Drawing.Point(272, 61);
            this.btnAddConsignment.Margin = new System.Windows.Forms.Padding(25, 6, 25, 8);
            this.btnAddConsignment.Name = "btnAddConsignment";
            this.btnAddConsignment.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddConsignment.ShadowDecoration.Parent = this.btnAddConsignment;
            this.btnAddConsignment.Size = new System.Drawing.Size(198, 41);
            this.btnAddConsignment.TabIndex = 1;
            this.btnAddConsignment.Text = "Thêm lô";
            this.btnAddConsignment.Click += new System.EventHandler(this.btnAddConsignment_Click);
            // 
            // btnResetConsignment
            // 
            this.btnResetConsignment.BackColor = System.Drawing.Color.Transparent;
            this.btnResetConsignment.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnResetConsignment.BorderRadius = 12;
            this.btnResetConsignment.BorderThickness = 3;
            this.btnResetConsignment.CheckedState.Parent = this.btnResetConsignment;
            this.btnResetConsignment.CustomImages.Parent = this.btnResetConsignment;
            this.btnResetConsignment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetConsignment.FillColor = System.Drawing.Color.GhostWhite;
            this.btnResetConsignment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetConsignment.ForeColor = System.Drawing.Color.Black;
            this.btnResetConsignment.HoverState.Parent = this.btnResetConsignment;
            this.btnResetConsignment.Location = new System.Drawing.Point(668, 61);
            this.btnResetConsignment.Margin = new System.Windows.Forms.Padding(25, 6, 25, 8);
            this.btnResetConsignment.Name = "btnResetConsignment";
            this.btnResetConsignment.PressedColor = System.Drawing.Color.Transparent;
            this.btnResetConsignment.ShadowDecoration.Parent = this.btnResetConsignment;
            this.btnResetConsignment.Size = new System.Drawing.Size(198, 41);
            this.btnResetConsignment.TabIndex = 3;
            this.btnResetConsignment.Text = "Làm mới";
            this.btnResetConsignment.Click += new System.EventHandler(this.btnResetConsignment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(535, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày nhập(*)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(134, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên lô hàng(*)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLH_name
            // 
            this.txtLH_name.BackColor = System.Drawing.Color.Transparent;
            this.txtLH_name.BorderRadius = 15;
            this.txtLH_name.BorderThickness = 2;
            this.txtLH_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLH_name.DefaultText = "";
            this.txtLH_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLH_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLH_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLH_name.DisabledState.Parent = this.txtLH_name;
            this.txtLH_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLH_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLH_name.FillColor = System.Drawing.Color.LemonChiffon;
            this.txtLH_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLH_name.FocusedState.Parent = this.txtLH_name;
            this.txtLH_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLH_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLH_name.HoverState.Parent = this.txtLH_name;
            this.txtLH_name.Location = new System.Drawing.Point(250, 13);
            this.txtLH_name.Name = "txtLH_name";
            this.txtLH_name.PasswordChar = '\0';
            this.txtLH_name.PlaceholderText = "";
            this.txtLH_name.SelectedText = "";
            this.txtLH_name.ShadowDecoration.Parent = this.txtLH_name;
            this.txtLH_name.Size = new System.Drawing.Size(242, 39);
            this.txtLH_name.TabIndex = 7;
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_ngaynhap.BorderRadius = 15;
            this.dtp_ngaynhap.BorderThickness = 2;
            this.dtp_ngaynhap.CheckedState.Parent = this.dtp_ngaynhap;
            this.dtp_ngaynhap.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaynhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_ngaynhap.FillColor = System.Drawing.Color.LemonChiffon;
            this.dtp_ngaynhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaynhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtp_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaynhap.HoverState.Parent = this.dtp_ngaynhap;
            this.dtp_ngaynhap.Location = new System.Drawing.Point(646, 13);
            this.dtp_ngaynhap.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaynhap.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.ShadowDecoration.Parent = this.dtp_ngaynhap;
            this.dtp_ngaynhap.Size = new System.Drawing.Size(242, 39);
            this.dtp_ngaynhap.TabIndex = 8;
            this.dtp_ngaynhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_ngaynhap.Value = new System.DateTime(2023, 8, 12, 0, 0, 0, 0);
            // 
            // btnbackPanel
            // 
            this.btnbackPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnbackPanel.BorderColor = System.Drawing.Color.DarkRed;
            this.btnbackPanel.BorderRadius = 12;
            this.btnbackPanel.CheckedState.Parent = this.btnbackPanel;
            this.btnbackPanel.CustomImages.Parent = this.btnbackPanel;
            this.btnbackPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnbackPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbackPanel.ForeColor = System.Drawing.Color.Black;
            this.btnbackPanel.HoverState.Parent = this.btnbackPanel;
            this.btnbackPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnbackPanel.Image")));
            this.btnbackPanel.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnbackPanel.ImageSize = new System.Drawing.Size(35, 35);
            this.btnbackPanel.Location = new System.Drawing.Point(3, 4);
            this.btnbackPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.btnbackPanel.Name = "btnbackPanel";
            this.tableLayoutPanel3.SetRowSpan(this.btnbackPanel, 2);
            this.btnbackPanel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnbackPanel.ShadowDecoration.Parent = this.btnbackPanel;
            this.btnbackPanel.Size = new System.Drawing.Size(40, 41);
            this.btnbackPanel.TabIndex = 2;
            this.btnbackPanel.Click += new System.EventHandler(this.btnbackPanel_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 608);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.panel1.ResumeLayout(false);
            this.PanelNcc.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgNCC)).EndInit();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelnhaplohang.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLoHang)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelNcc;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2DataGridView dvgNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmNCC_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmNCC_serialkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmNCC_tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmNCC_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmNCC_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmNCC_SL;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtdiachincc;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenncc;
        private Guna.UI2.WinForms.Guna2TextBox txt_sdtncc;
        private Guna.UI2.WinForms.Guna2Button btnNCCreset;
        private Guna.UI2.WinForms.Guna2Button btnAddSupplier;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Panel panelnhaplohang;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2DataGridView dvgLoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmLH_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmLH_lohangkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmLH_tenlh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmLH_ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmLH_nhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcmLH_SL;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btnAddConsignment;
        private Guna.UI2.WinForms.Guna2Button btnResetConsignment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtLH_name;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngaynhap;
        private Guna.UI2.WinForms.Guna2CircleButton btnbackPanel;
    }
}