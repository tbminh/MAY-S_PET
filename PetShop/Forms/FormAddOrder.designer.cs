
namespace PetShop.Forms
{
    partial class FormAddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrder));
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNote = new Guna.UI.WinForms.GunaLabel();
            this.txt_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_sdt = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Ten = new Guna.UI.WinForms.GunaLabel();
            this.txt_ten = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBarcode = new Guna.UI.WinForms.GunaLabel();
            this.lbl_ngaytaikham = new Guna.UI.WinForms.GunaLabel();
            this.chkb_taikham = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.txt_tenpet = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_tenpet = new Guna.UI.WinForms.GunaLabel();
            this.datatime_ngaytaikham = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfor_In_Out = new Guna.UI.WinForms.GunaLabel();
            this.btnback = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradient2Panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.guna2Panel1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(536, 487);
            this.gunaGradient2Panel1.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 1;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel4);
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(536, 487);
            this.guna2Panel1.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Controls.Add(this.lblNote, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txt_sdt, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_sdt, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Ten, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_ten, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblBarcode, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_ngaytaikham, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.chkb_taikham, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txt_tenpet, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtNote, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tenpet, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.datatime_ngaytaikham, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(536, 386);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(4, 320);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(179, 66);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "Ghi Chú";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_sdt
            // 
            this.txt_sdt.BorderRadius = 5;
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.DefaultText = "";
            this.txt_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.DisabledState.Parent = this.txt_sdt;
            this.txt_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.FocusedState.Parent = this.txt_sdt;
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.txt_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.HoverState.Parent = this.txt_sdt;
            this.txt_sdt.Location = new System.Drawing.Point(194, 70);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.PlaceholderText = "";
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.ShadowDecoration.Parent = this.txt_sdt;
            this.txt_sdt.Size = new System.Drawing.Size(335, 52);
            this.txt_sdt.TabIndex = 9;
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sdt.ForeColor = System.Drawing.Color.White;
            this.lbl_sdt.Location = new System.Drawing.Point(4, 64);
            this.lbl_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(179, 64);
            this.lbl_sdt.TabIndex = 1;
            this.lbl_sdt.Text = "Số Điện Thoại (*)";
            this.lbl_sdt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.ForeColor = System.Drawing.Color.White;
            this.lbl_Ten.Location = new System.Drawing.Point(4, 0);
            this.lbl_Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(179, 64);
            this.lbl_Ten.TabIndex = 1;
            this.lbl_Ten.Text = "Tên Khách Hàng (*)";
            this.lbl_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ten
            // 
            this.txt_ten.BorderRadius = 5;
            this.txt_ten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ten.DefaultText = "";
            this.txt_ten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ten.DisabledState.Parent = this.txt_ten;
            this.txt_ten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ten.FocusedState.Parent = this.txt_ten;
            this.txt_ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.txt_ten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ten.HoverState.Parent = this.txt_ten;
            this.txt_ten.Location = new System.Drawing.Point(194, 6);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.PasswordChar = '\0';
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.SelectedText = "";
            this.txt_ten.ShadowDecoration.Parent = this.txt_ten;
            this.txt_ten.Size = new System.Drawing.Size(335, 52);
            this.txt_ten.TabIndex = 0;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lblBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(4, 128);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(179, 64);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Nhắc Lịch ";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ngaytaikham
            // 
            this.lbl_ngaytaikham.AutoSize = true;
            this.lbl_ngaytaikham.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ngaytaikham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ngaytaikham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaytaikham.ForeColor = System.Drawing.Color.White;
            this.lbl_ngaytaikham.Location = new System.Drawing.Point(4, 192);
            this.lbl_ngaytaikham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ngaytaikham.Name = "lbl_ngaytaikham";
            this.lbl_ngaytaikham.Size = new System.Drawing.Size(179, 64);
            this.lbl_ngaytaikham.TabIndex = 1;
            this.lbl_ngaytaikham.Text = "Chọn Ngày";
            this.lbl_ngaytaikham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkb_taikham
            // 
            this.chkb_taikham.BaseColor = System.Drawing.Color.White;
            this.chkb_taikham.CheckedOffColor = System.Drawing.Color.White;
            this.chkb_taikham.CheckedOnColor = System.Drawing.Color.Black;
            this.chkb_taikham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkb_taikham.FillColor = System.Drawing.Color.White;
            this.chkb_taikham.Location = new System.Drawing.Point(200, 147);
            this.chkb_taikham.Margin = new System.Windows.Forms.Padding(13, 4, 4, 25);
            this.chkb_taikham.Name = "chkb_taikham";
            this.chkb_taikham.Size = new System.Drawing.Size(20, 20);
            this.chkb_taikham.TabIndex = 8;
            this.chkb_taikham.CheckedChanged += new System.EventHandler(this.chkb_taikham_CheckedChanged);
            // 
            // txt_tenpet
            // 
            this.txt_tenpet.BorderRadius = 5;
            this.txt_tenpet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenpet.DefaultText = "";
            this.txt_tenpet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenpet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenpet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenpet.DisabledState.Parent = this.txt_tenpet;
            this.txt_tenpet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenpet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tenpet.Enabled = false;
            this.txt_tenpet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_tenpet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenpet.FocusedState.Parent = this.txt_tenpet;
            this.txt_tenpet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenpet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.txt_tenpet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenpet.HoverState.Parent = this.txt_tenpet;
            this.txt_tenpet.Location = new System.Drawing.Point(194, 262);
            this.txt_tenpet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_tenpet.Name = "txt_tenpet";
            this.txt_tenpet.PasswordChar = '\0';
            this.txt_tenpet.PlaceholderText = "";
            this.txt_tenpet.SelectedText = "";
            this.txt_tenpet.ShadowDecoration.Parent = this.txt_tenpet;
            this.txt_tenpet.Size = new System.Drawing.Size(335, 52);
            this.txt_tenpet.TabIndex = 11;
            // 
            // txtNote
            // 
            this.txtNote.BorderRadius = 5;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.Parent = this.txtNote;
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Enabled = false;
            this.txtNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.FocusedState.Parent = this.txtNote;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.HoverState.Parent = this.txtNote;
            this.txtNote.Location = new System.Drawing.Point(194, 326);
            this.txtNote.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.ShadowDecoration.Parent = this.txtNote;
            this.txtNote.Size = new System.Drawing.Size(335, 54);
            this.txtNote.TabIndex = 12;
            // 
            // lbl_tenpet
            // 
            this.lbl_tenpet.AutoSize = true;
            this.lbl_tenpet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tenpet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tenpet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenpet.ForeColor = System.Drawing.Color.White;
            this.lbl_tenpet.Location = new System.Drawing.Point(4, 256);
            this.lbl_tenpet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tenpet.Name = "lbl_tenpet";
            this.lbl_tenpet.Size = new System.Drawing.Size(179, 64);
            this.lbl_tenpet.TabIndex = 13;
            this.lbl_tenpet.Text = "Tên Thú Cưng";
            this.lbl_tenpet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datatime_ngaytaikham
            // 
            this.datatime_ngaytaikham.BackColor = System.Drawing.Color.Transparent;
            this.datatime_ngaytaikham.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datatime_ngaytaikham.BorderRadius = 20;
            this.datatime_ngaytaikham.CheckedState.Parent = this.datatime_ngaytaikham;
            this.datatime_ngaytaikham.CustomFormat = "dd/MM/yyyy";
            this.datatime_ngaytaikham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datatime_ngaytaikham.Enabled = false;
            this.datatime_ngaytaikham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datatime_ngaytaikham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatime_ngaytaikham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datatime_ngaytaikham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datatime_ngaytaikham.HoverState.Parent = this.datatime_ngaytaikham;
            this.datatime_ngaytaikham.Location = new System.Drawing.Point(191, 196);
            this.datatime_ngaytaikham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datatime_ngaytaikham.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datatime_ngaytaikham.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datatime_ngaytaikham.Name = "datatime_ngaytaikham";
            this.datatime_ngaytaikham.ShadowDecoration.Parent = this.datatime_ngaytaikham;
            this.datatime_ngaytaikham.Size = new System.Drawing.Size(341, 56);
            this.datatime_ngaytaikham.TabIndex = 10;
            this.datatime_ngaytaikham.Value = new System.DateTime(2023, 4, 24, 13, 42, 21, 705);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 47);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(536, 47);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnAdd.BaseColor2 = System.Drawing.Color.Violet;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(356, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnAdd.OnHoverBaseColor2 = System.Drawing.Color.SeaGreen;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(168, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Tạo Đơn";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInfor_In_Out);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 54);
            this.panel1.TabIndex = 0;
            // 
            // lblInfor_In_Out
            // 
            this.lblInfor_In_Out.AutoSize = true;
            this.lblInfor_In_Out.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor_In_Out.ForeColor = System.Drawing.Color.White;
            this.lblInfor_In_Out.Location = new System.Drawing.Point(113, 2);
            this.lblInfor_In_Out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblInfor_In_Out.Name = "lblInfor_In_Out";
            this.lblInfor_In_Out.Size = new System.Drawing.Size(342, 46);
            this.lblInfor_In_Out.TabIndex = 30;
            this.lblInfor_In_Out.Text = "Thông Tin Đơn Hàng";
            this.lblInfor_In_Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfor_In_Out.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // btnback
            // 
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageSize = new System.Drawing.Size(40, 40);
            this.btnback.Location = new System.Drawing.Point(0, 0);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnback.MaximumSize = new System.Drawing.Size(73, 68);
            this.btnback.Name = "btnback";
            this.btnback.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnback.OnHoverImage")));
            this.btnback.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnback.Size = new System.Drawing.Size(56, 54);
            this.btnback.TabIndex = 29;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 487);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddOrder";
            this.Text = "FormAddOrder";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI.WinForms.GunaLabel lblNote;
        private Guna.UI2.WinForms.Guna2TextBox txt_sdt;
        private Guna.UI.WinForms.GunaLabel lbl_sdt;
        private Guna.UI.WinForms.GunaLabel lbl_Ten;
        private Guna.UI2.WinForms.Guna2TextBox txt_ten;
        private Guna.UI.WinForms.GunaLabel lblBarcode;
        private Guna.UI.WinForms.GunaLabel lbl_ngaytaikham;
        private Guna.UI.WinForms.GunaMediumCheckBox chkb_taikham;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenpet;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private Guna.UI.WinForms.GunaLabel lbl_tenpet;
        private Guna.UI2.WinForms.Guna2DateTimePicker datatime_ngaytaikham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lblInfor_In_Out;
        private Guna.UI.WinForms.GunaImageButton btnback;
        private Guna.UI.WinForms.GunaGradientButton btnAdd;
    }
}