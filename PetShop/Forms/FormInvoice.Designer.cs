
namespace PetShop.Forms
{
    partial class FormInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.stt_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_dh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_invoice = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_thanh_toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_hen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_pet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_tongHD = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.radio_da_thanh_toan = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTime_den = new System.Windows.Forms.DateTimePicker();
            this.dateTime_tu = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.radio_dich_vu = new System.Windows.Forms.RadioButton();
            this.radio_dang_cho = new System.Windows.Forms.RadioButton();
            this.radio_tai_kham = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitleInvoice = new System.Windows.Forms.Label();
            this.printOrder = new System.Drawing.Printing.PrintDocument();
            this.printOrderDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printOrderDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).BeginInit();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 720);
            this.panel1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1155, 629);
            this.panel4.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1155, 629);
            this.panel6.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1155, 534);
            this.panel5.TabIndex = 14;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.dgv_detail, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.dgv_invoice, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1155, 534);
            this.tableLayoutPanel6.TabIndex = 13;
            // 
            // dgv_detail
            // 
            this.dgv_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt_dt,
            this.key_dt,
            this.ma_sp,
            this.ten_sp,
            this.gia_sp,
            this.so_luong,
            this.ma_dh,
            this.dang,
            this.tong});
            this.dgv_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_detail.Location = new System.Drawing.Point(3, 270);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.Size = new System.Drawing.Size(1149, 261);
            this.dgv_detail.TabIndex = 10;
            // 
            // stt_dt
            // 
            this.stt_dt.HeaderText = "STT";
            this.stt_dt.Name = "stt_dt";
            // 
            // key_dt
            // 
            this.key_dt.HeaderText = "Key";
            this.key_dt.Name = "key_dt";
            this.key_dt.Visible = false;
            // 
            // ma_sp
            // 
            this.ma_sp.HeaderText = "Mã SP";
            this.ma_sp.Name = "ma_sp";
            // 
            // ten_sp
            // 
            this.ten_sp.HeaderText = "Tên SP";
            this.ten_sp.Name = "ten_sp";
            // 
            // gia_sp
            // 
            this.gia_sp.HeaderText = "Giá SP";
            this.gia_sp.Name = "gia_sp";
            // 
            // so_luong
            // 
            this.so_luong.HeaderText = "Số Lượng";
            this.so_luong.Name = "so_luong";
            // 
            // ma_dh
            // 
            this.ma_dh.HeaderText = "MÃ ĐH";
            this.ma_dh.Name = "ma_dh";
            // 
            // dang
            // 
            this.dang.HeaderText = "Dạng";
            this.dang.Name = "dang";
            // 
            // tong
            // 
            this.tong.HeaderText = "Tổng";
            this.tong.Name = "tong";
            // 
            // dgv_invoice
            // 
            this.dgv_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_invoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.key,
            this.gia,
            this.ngay_thanh_toan,
            this.ten_kh,
            this.sdt,
            this.tk_nv,
            this.trang_thai,
            this.ngay_hen,
            this.ten_pet,
            this.ghi_chu});
            this.dgv_invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_invoice.Location = new System.Drawing.Point(3, 3);
            this.dgv_invoice.Name = "dgv_invoice";
            this.dgv_invoice.Size = new System.Drawing.Size(1149, 261);
            this.dgv_invoice.TabIndex = 9;
            this.dgv_invoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoice_CellClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // key
            // 
            this.key.HeaderText = "key";
            this.key.Name = "key";
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá ĐH";
            this.gia.Name = "gia";
            this.gia.Visible = false;
            // 
            // ngay_thanh_toan
            // 
            this.ngay_thanh_toan.HeaderText = "Ngày Thanh Toán";
            this.ngay_thanh_toan.Name = "ngay_thanh_toan";
            this.ngay_thanh_toan.Visible = false;
            // 
            // ten_kh
            // 
            this.ten_kh.HeaderText = "Tên KH";
            this.ten_kh.Name = "ten_kh";
            // 
            // sdt
            // 
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            // 
            // tk_nv
            // 
            this.tk_nv.HeaderText = "Nhân Vien";
            this.tk_nv.Name = "tk_nv";
            this.tk_nv.Visible = false;
            // 
            // trang_thai
            // 
            this.trang_thai.HeaderText = "Trạng Thái";
            this.trang_thai.Name = "trang_thai";
            // 
            // ngay_hen
            // 
            this.ngay_hen.HeaderText = "Ngày Hẹn ";
            this.ngay_hen.Name = "ngay_hen";
            this.ngay_hen.Visible = false;
            // 
            // ten_pet
            // 
            this.ten_pet.HeaderText = "Tên Pet";
            this.ten_pet.Name = "ten_pet";
            this.ten_pet.Visible = false;
            // 
            // ghi_chu
            // 
            this.ghi_chu.HeaderText = "Ghi Chú";
            this.ghi_chu.Name = "ghi_chu";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1155, 95);
            this.panel7.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.radio_da_thanh_toan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.radio_dich_vu, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radio_dang_cho, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radio_tai_kham, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1155, 95);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_tongHD, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblRevenue, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(948, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(204, 89);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // lbl_tongHD
            // 
            this.lbl_tongHD.AutoSize = true;
            this.lbl_tongHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.lbl_tongHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tongHD.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongHD.ForeColor = System.Drawing.Color.Red;
            this.lbl_tongHD.Location = new System.Drawing.Point(3, 44);
            this.lbl_tongHD.Name = "lbl_tongHD";
            this.lbl_tongHD.Size = new System.Drawing.Size(198, 45);
            this.lbl_tongHD.TabIndex = 8;
            this.lbl_tongHD.Text = "Tổng Doanh Thu";
            this.lbl_tongHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.lblRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Location = new System.Drawing.Point(3, 0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(198, 44);
            this.lblRevenue.TabIndex = 8;
            this.lblRevenue.Text = "Tổng Doanh Thu";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radio_da_thanh_toan
            // 
            this.radio_da_thanh_toan.AutoSize = true;
            this.radio_da_thanh_toan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.radio_da_thanh_toan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_da_thanh_toan.ForeColor = System.Drawing.Color.White;
            this.radio_da_thanh_toan.Location = new System.Drawing.Point(3, 3);
            this.radio_da_thanh_toan.Name = "radio_da_thanh_toan";
            this.radio_da_thanh_toan.Size = new System.Drawing.Size(86, 89);
            this.radio_da_thanh_toan.TabIndex = 2;
            this.radio_da_thanh_toan.TabStop = true;
            this.radio_da_thanh_toan.Text = "Thanh Toán";
            this.radio_da_thanh_toan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_da_thanh_toan.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(602, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(340, 89);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.dateTime_den, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateTime_tu, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(334, 38);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // dateTime_den
            // 
            this.dateTime_den.CustomFormat = "dd/MM/yyyy";
            this.dateTime_den.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTime_den.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_den.Location = new System.Drawing.Point(170, 3);
            this.dateTime_den.Name = "dateTime_den";
            this.dateTime_den.Size = new System.Drawing.Size(161, 29);
            this.dateTime_den.TabIndex = 11;
            // 
            // dateTime_tu
            // 
            this.dateTime_tu.CustomFormat = "dd/MM/yyyy";
            this.dateTime_tu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTime_tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_tu.Location = new System.Drawing.Point(3, 3);
            this.dateTime_tu.Name = "dateTime_tu";
            this.dateTime_tu.Size = new System.Drawing.Size(161, 29);
            this.dateTime_tu.TabIndex = 11;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.btn_tim, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnPrint, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(334, 39);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.Maroon;
            this.btn_tim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tim.ForeColor = System.Drawing.Color.White;
            this.btn_tim.Location = new System.Drawing.Point(3, 3);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(161, 33);
            this.btn_tim.TabIndex = 6;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderColor = System.Drawing.Color.Maroon;
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.FillColor = System.Drawing.Color.Maroon;
            this.btnPrint.FillColor2 = System.Drawing.Color.Maroon;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(170, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(161, 33);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In Hóa Đơn";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // radio_dich_vu
            // 
            this.radio_dich_vu.AutoSize = true;
            this.radio_dich_vu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.radio_dich_vu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_dich_vu.ForeColor = System.Drawing.Color.White;
            this.radio_dich_vu.Location = new System.Drawing.Point(187, 3);
            this.radio_dich_vu.Name = "radio_dich_vu";
            this.radio_dich_vu.Size = new System.Drawing.Size(86, 89);
            this.radio_dich_vu.TabIndex = 5;
            this.radio_dich_vu.TabStop = true;
            this.radio_dich_vu.Text = "Dịch Vụ";
            this.radio_dich_vu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_dich_vu.UseVisualStyleBackColor = false;
            // 
            // radio_dang_cho
            // 
            this.radio_dang_cho.AutoSize = true;
            this.radio_dang_cho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.radio_dang_cho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_dang_cho.ForeColor = System.Drawing.Color.White;
            this.radio_dang_cho.Location = new System.Drawing.Point(95, 3);
            this.radio_dang_cho.Name = "radio_dang_cho";
            this.radio_dang_cho.Size = new System.Drawing.Size(86, 89);
            this.radio_dang_cho.TabIndex = 3;
            this.radio_dang_cho.TabStop = true;
            this.radio_dang_cho.Text = "Đang Chờ";
            this.radio_dang_cho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_dang_cho.UseVisualStyleBackColor = false;
            // 
            // radio_tai_kham
            // 
            this.radio_tai_kham.AutoSize = true;
            this.radio_tai_kham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.radio_tai_kham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_tai_kham.ForeColor = System.Drawing.Color.White;
            this.radio_tai_kham.Location = new System.Drawing.Point(279, 3);
            this.radio_tai_kham.Name = "radio_tai_kham";
            this.radio_tai_kham.Size = new System.Drawing.Size(86, 89);
            this.radio_tai_kham.TabIndex = 4;
            this.radio_tai_kham.TabStop = true;
            this.radio_tai_kham.Text = "Tái Khám";
            this.radio_tai_kham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_tai_kham.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txt_tim, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPhone, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(371, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 89);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // txt_tim
            // 
            this.txt_tim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(3, 3);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(219, 35);
            this.txt_tim.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(3, 44);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(219, 45);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Tìm Theo SĐT";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 91);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitleInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 91);
            this.panel2.TabIndex = 11;
            // 
            // lblTitleInvoice
            // 
            this.lblTitleInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.lblTitleInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleInvoice.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleInvoice.ForeColor = System.Drawing.Color.White;
            this.lblTitleInvoice.Location = new System.Drawing.Point(0, 0);
            this.lblTitleInvoice.Name = "lblTitleInvoice";
            this.lblTitleInvoice.Size = new System.Drawing.Size(1155, 91);
            this.lblTitleInvoice.TabIndex = 0;
            this.lblTitleInvoice.Text = "Quản Lý Đơn Hàng";
            this.lblTitleInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printOrderDialog
            // 
            this.printOrderDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printOrderDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printOrderDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printOrderDialog.Enabled = true;
            this.printOrderDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printOrderDialog.Icon")));
            this.printOrderDialog.Name = "printOrderDialog";
            this.printOrderDialog.Visible = false;
            // 
            // printOrderDialog1
            // 
            this.printOrderDialog1.UseEXDialog = true;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInvoice";
            this.Text = "FormInvoice";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dgv_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn key_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_dh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong;
        private System.Windows.Forms.DataGridView dgv_invoice;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_tongHD;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.RadioButton radio_da_thanh_toan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dateTime_den;
        private System.Windows.Forms.DateTimePicker dateTime_tu;
        private System.Windows.Forms.RadioButton radio_dich_vu;
        private System.Windows.Forms.RadioButton radio_dang_cho;
        private System.Windows.Forms.RadioButton radio_tai_kham;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private Guna.UI2.WinForms.Guna2GradientButton btnPrint;
        private System.Drawing.Printing.PrintDocument printOrder;
        private System.Windows.Forms.PrintPreviewDialog printOrderDialog;
        private System.Windows.Forms.PrintDialog printOrderDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_thanh_toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_hen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_pet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghi_chu;
    }
}