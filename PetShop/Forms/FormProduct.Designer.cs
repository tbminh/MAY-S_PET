
namespace PetShop.Forms
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.dgvProduct = new Guna.UI.WinForms.GunaDataGridView();
            this.dcpChoose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Product_Serial_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Cost_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consighment_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Group_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel11 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvListProductSaleMax = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel12 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel6 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtFindProduct = new Bunifu.Framework.UI.BunifuTextbox();
            this.guna2GradientPanel9 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.chxExpiry = new Guna.UI.WinForms.GunaCheckBox();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.chxExpire = new Guna.UI.WinForms.GunaCheckBox();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnNhap = new FontAwesome.Sharp.IconButton();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printReview = new System.Drawing.Printing.PrintDocument();
            this.pvdCORPrint = new System.Windows.Forms.PrintPreviewDialog();
            this.pdlgCORPrint = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel11.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductSaleMax)).BeginInit();
            this.guna2GradientPanel12.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            this.guna2GradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            this.guna2GradientPanel9.SuspendLayout();
            this.guna2GradientPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeight = 40;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcpChoose,
            this.Product_Serial_Key,
            this.Product_Id,
            this.Product_Name,
            this.Product_Quantity,
            this.Product_Cost_Price,
            this.Product_Sale_Price,
            this.Date_Expired,
            this.Consighment_Name,
            this.Product_Group_Name,
            this.Sup_Name,
            this.Product_Unit,
            this.Product_Barcode,
            this.Note});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(4, 4);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProduct.ShowCellToolTips = false;
            this.dgvProduct.Size = new System.Drawing.Size(982, 477);
            this.dgvProduct.TabIndex = 3;
            this.dgvProduct.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.dgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProduct.ThemeStyle.ReadOnly = false;
            this.dgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvProduct.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentDoubleClick);
            this.dgvProduct.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_ColumnHeaderMouseClick);
            // 
            // dcpChoose
            // 
            this.dcpChoose.HeaderText = "Chọn";
            this.dcpChoose.MinimumWidth = 6;
            this.dcpChoose.Name = "dcpChoose";
            this.dcpChoose.Width = 58;
            // 
            // Product_Serial_Key
            // 
            this.Product_Serial_Key.HeaderText = "Key Sản Phẩm ";
            this.Product_Serial_Key.MinimumWidth = 6;
            this.Product_Serial_Key.Name = "Product_Serial_Key";
            this.Product_Serial_Key.Visible = false;
            this.Product_Serial_Key.Width = 156;
            // 
            // Product_Id
            // 
            this.Product_Id.HeaderText = "Mã Sản Phẩm";
            this.Product_Id.MinimumWidth = 6;
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.Visible = false;
            this.Product_Id.Width = 148;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Tên Sản Phẩm";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Width = 149;
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.HeaderText = "Tồn Kho";
            this.Product_Quantity.MinimumWidth = 6;
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.Width = 105;
            // 
            // Product_Cost_Price
            // 
            this.Product_Cost_Price.HeaderText = "Giá Vốn";
            this.Product_Cost_Price.MinimumWidth = 6;
            this.Product_Cost_Price.Name = "Product_Cost_Price";
            this.Product_Cost_Price.Visible = false;
            this.Product_Cost_Price.Width = 101;
            // 
            // Product_Sale_Price
            // 
            this.Product_Sale_Price.HeaderText = "Giá Bán";
            this.Product_Sale_Price.MinimumWidth = 6;
            this.Product_Sale_Price.Name = "Product_Sale_Price";
            this.Product_Sale_Price.Width = 98;
            // 
            // Date_Expired
            // 
            this.Date_Expired.HeaderText = "Ngày Hết Hạn";
            this.Date_Expired.MinimumWidth = 6;
            this.Date_Expired.Name = "Date_Expired";
            this.Date_Expired.Width = 151;
            // 
            // Consighment_Name
            // 
            this.Consighment_Name.HeaderText = "Lô Hàng";
            this.Consighment_Name.MinimumWidth = 6;
            this.Consighment_Name.Name = "Consighment_Name";
            this.Consighment_Name.Width = 106;
            // 
            // Product_Group_Name
            // 
            this.Product_Group_Name.HeaderText = "Nhóm Hàng";
            this.Product_Group_Name.MinimumWidth = 6;
            this.Product_Group_Name.Name = "Product_Group_Name";
            this.Product_Group_Name.Width = 137;
            // 
            // Sup_Name
            // 
            this.Sup_Name.HeaderText = "Nhà Cung Cấp ";
            this.Sup_Name.MinimumWidth = 6;
            this.Sup_Name.Name = "Sup_Name";
            this.Sup_Name.Width = 159;
            // 
            // Product_Unit
            // 
            this.Product_Unit.HeaderText = "ĐVT";
            this.Product_Unit.MinimumWidth = 6;
            this.Product_Unit.Name = "Product_Unit";
            this.Product_Unit.Width = 72;
            // 
            // Product_Barcode
            // 
            this.Product_Barcode.HeaderText = "Mã Vạch";
            this.Product_Barcode.MinimumWidth = 6;
            this.Product_Barcode.Name = "Product_Barcode";
            this.Product_Barcode.Visible = false;
            this.Product_Barcode.Width = 107;
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi Chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Visible = false;
            this.Note.Width = 101;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1415, 103);
            this.guna2GradientPanel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1415, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.guna2GradientPanel11);
            this.guna2GradientPanel2.Controls.Add(this.guna2GradientPanel3);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 103);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1415, 659);
            this.guna2GradientPanel2.TabIndex = 9;
            // 
            // guna2GradientPanel11
            // 
            this.guna2GradientPanel11.Controls.Add(this.tableLayoutPanel2);
            this.guna2GradientPanel11.Controls.Add(this.guna2GradientPanel12);
            this.guna2GradientPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel11.Location = new System.Drawing.Point(0, 66);
            this.guna2GradientPanel11.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel11.Name = "guna2GradientPanel11";
            this.guna2GradientPanel11.ShadowDecoration.Parent = this.guna2GradientPanel11;
            this.guna2GradientPanel11.Size = new System.Drawing.Size(1415, 593);
            this.guna2GradientPanel11.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.dgvListProductSaleMax, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvProduct, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1415, 485);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // dgvListProductSaleMax
            // 
            this.dgvListProductSaleMax.AllowUserToAddRows = false;
            this.dgvListProductSaleMax.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvListProductSaleMax.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListProductSaleMax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListProductSaleMax.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.dgvListProductSaleMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListProductSaleMax.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListProductSaleMax.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProductSaleMax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListProductSaleMax.ColumnHeadersHeight = 40;
            this.dgvListProductSaleMax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Quantity_Sale,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListProductSaleMax.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListProductSaleMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListProductSaleMax.EnableHeadersVisualStyles = false;
            this.dgvListProductSaleMax.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListProductSaleMax.Location = new System.Drawing.Point(994, 4);
            this.dgvListProductSaleMax.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListProductSaleMax.Name = "dgvListProductSaleMax";
            this.dgvListProductSaleMax.ReadOnly = true;
            this.dgvListProductSaleMax.RowHeadersVisible = false;
            this.dgvListProductSaleMax.RowHeadersWidth = 51;
            this.dgvListProductSaleMax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListProductSaleMax.Size = new System.Drawing.Size(417, 477);
            this.dgvListProductSaleMax.TabIndex = 4;
            this.dgvListProductSaleMax.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvListProductSaleMax.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListProductSaleMax.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListProductSaleMax.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListProductSaleMax.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListProductSaleMax.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListProductSaleMax.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.dgvListProductSaleMax.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListProductSaleMax.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.dgvListProductSaleMax.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListProductSaleMax.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListProductSaleMax.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListProductSaleMax.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListProductSaleMax.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvListProductSaleMax.ThemeStyle.ReadOnly = true;
            this.dgvListProductSaleMax.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListProductSaleMax.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListProductSaleMax.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListProductSaleMax.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListProductSaleMax.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListProductSaleMax.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListProductSaleMax.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 23.21905F;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 67;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 50.46001F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sản Phẩm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 149;
            // 
            // Quantity_Sale
            // 
            this.Quantity_Sale.FillWeight = 73.7877F;
            this.Quantity_Sale.HeaderText = "Số lượng đã bán";
            this.Quantity_Sale.MinimumWidth = 6;
            this.Quantity_Sale.Name = "Quantity_Sale";
            this.Quantity_Sale.ReadOnly = true;
            this.Quantity_Sale.Width = 172;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 40.31951F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Còn Tồn";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 106;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 42.21371F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Loại";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // guna2GradientPanel12
            // 
            this.guna2GradientPanel12.Controls.Add(this.tableLayoutPanel1);
            this.guna2GradientPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel12.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel12.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel12.Name = "guna2GradientPanel12";
            this.guna2GradientPanel12.ShadowDecoration.Parent = this.guna2GradientPanel12;
            this.guna2GradientPanel12.Size = new System.Drawing.Size(1415, 108);
            this.guna2GradientPanel12.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.guna2TileButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2TileButton2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1415, 108);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Location = new System.Drawing.Point(4, 4);
            this.guna2TileButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Size = new System.Drawing.Size(982, 100);
            this.guna2TileButton1.TabIndex = 0;
            this.guna2TileButton1.Text = "SẢN PHẨM TỒN KHO";
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.CheckedState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.CustomImages.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.guna2TileButton2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Location = new System.Drawing.Point(994, 4);
            this.guna2TileButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(417, 100);
            this.guna2TileButton2.TabIndex = 0;
            this.guna2TileButton2.Text = "TOP SẢN PHẨM/DỊCH VỤ BÁN CHẠY";
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.Controls.Add(this.guna2GradientPanel6);
            this.guna2GradientPanel3.Controls.Add(this.guna2GradientPanel9);
            this.guna2GradientPanel3.Controls.Add(this.guna2GradientPanel5);
            this.guna2GradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.Parent = this.guna2GradientPanel3;
            this.guna2GradientPanel3.Size = new System.Drawing.Size(1415, 66);
            this.guna2GradientPanel3.TabIndex = 8;
            // 
            // guna2GradientPanel6
            // 
            this.guna2GradientPanel6.Controls.Add(this.btnPrint);
            this.guna2GradientPanel6.Controls.Add(this.txtFindProduct);
            this.guna2GradientPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel6.Location = new System.Drawing.Point(927, 0);
            this.guna2GradientPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel6.Name = "guna2GradientPanel6";
            this.guna2GradientPanel6.ShadowDecoration.Parent = this.guna2GradientPanel6;
            this.guna2GradientPanel6.Size = new System.Drawing.Size(488, 66);
            this.guna2GradientPanel6.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Image = global::PetShop.Properties.Resources.printer;
            this.btnPrint.ImageActive = null;
            this.btnPrint.Location = new System.Drawing.Point(318, 0);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 66);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 0;
            this.btnPrint.TabStop = false;
            this.btnPrint.Zoom = 10;
            // 
            // txtFindProduct
            // 
            this.txtFindProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.txtFindProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFindProduct.BackgroundImage")));
            this.txtFindProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFindProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFindProduct.Icon = ((System.Drawing.Image)(resources.GetObject("txtFindProduct.Icon")));
            this.txtFindProduct.Location = new System.Drawing.Point(0, 0);
            this.txtFindProduct.Margin = new System.Windows.Forms.Padding(5);
            this.txtFindProduct.Name = "txtFindProduct";
            this.txtFindProduct.Size = new System.Drawing.Size(319, 66);
            this.txtFindProduct.TabIndex = 2;
            this.txtFindProduct.text = "Tìm Kiếm Sản Phẩm...";
            // 
            // guna2GradientPanel9
            // 
            this.guna2GradientPanel9.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel9.Controls.Add(this.chxExpiry);
            this.guna2GradientPanel9.Controls.Add(this.chxExpire);
            this.guna2GradientPanel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel9.Location = new System.Drawing.Point(527, 0);
            this.guna2GradientPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel9.Name = "guna2GradientPanel9";
            this.guna2GradientPanel9.ShadowDecoration.Parent = this.guna2GradientPanel9;
            this.guna2GradientPanel9.Size = new System.Drawing.Size(400, 66);
            this.guna2GradientPanel9.TabIndex = 9;
            // 
            // chxExpiry
            // 
            this.chxExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chxExpiry.BaseColor = System.Drawing.Color.White;
            this.chxExpiry.CheckedOffColor = System.Drawing.Color.Gray;
            this.chxExpiry.CheckedOnColor = System.Drawing.Color.OrangeRed;
            this.chxExpiry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.chxExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chxExpiry.ForeColor = System.Drawing.Color.DimGray;
            this.chxExpiry.Location = new System.Drawing.Point(270, 25);
            this.chxExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.chxExpiry.Name = "chxExpiry";
            this.chxExpiry.Padding = new System.Windows.Forms.Padding(10);
            this.chxExpiry.Size = new System.Drawing.Size(104, 22);
            this.chxExpiry.TabIndex = 29;
            this.chxExpiry.Text = "Còn HSD";
            // 
            // cbxGroup
            // 
            this.cbxGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.cbxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroup.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.cbxGroup.ForeColor = System.Drawing.Color.White;
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(258, 13);
            this.cbxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(216, 45);
            this.cbxGroup.TabIndex = 0;
            this.cbxGroup.Visible = false;
            // 
            // chxExpire
            // 
            this.chxExpire.BaseColor = System.Drawing.Color.White;
            this.chxExpire.CheckedOffColor = System.Drawing.Color.Gray;
            this.chxExpire.CheckedOnColor = System.Drawing.Color.LimeGreen;
            this.chxExpire.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.chxExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chxExpire.ForeColor = System.Drawing.Color.DimGray;
            this.chxExpire.Location = new System.Drawing.Point(130, 25);
            this.chxExpire.Margin = new System.Windows.Forms.Padding(4);
            this.chxExpire.Name = "chxExpire";
            this.chxExpire.Padding = new System.Windows.Forms.Padding(10);
            this.chxExpire.Size = new System.Drawing.Size(99, 22);
            this.chxExpire.TabIndex = 30;
            this.chxExpire.Text = "Hết HSD";
            // 
            // guna2GradientPanel5
            // 
            this.guna2GradientPanel5.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel5.Controls.Add(this.btnNhap);
            this.guna2GradientPanel5.Controls.Add(this.cbxGroup);
            this.guna2GradientPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel5.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel5.Name = "guna2GradientPanel5";
            this.guna2GradientPanel5.ShadowDecoration.Parent = this.guna2GradientPanel5;
            this.guna2GradientPanel5.Size = new System.Drawing.Size(527, 66);
            this.guna2GradientPanel5.TabIndex = 10;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNhap.IconColor = System.Drawing.Color.White;
            this.btnNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhap.IconSize = 32;
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(0, 0);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(211, 66);
            this.btnNhap.TabIndex = 12;
            this.btnNhap.Text = "     Nhập Hàng";
            this.btnNhap.UseVisualStyleBackColor = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printReview
            // 
            this.printReview.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReview_PrintPage);
            // 
            // pvdCORPrint
            // 
            this.pvdCORPrint.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pvdCORPrint.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pvdCORPrint.ClientSize = new System.Drawing.Size(400, 300);
            this.pvdCORPrint.Enabled = true;
            this.pvdCORPrint.Icon = ((System.Drawing.Icon)(resources.GetObject("pvdCORPrint.Icon")));
            this.pvdCORPrint.Name = "pvdCORPrint";
            this.pvdCORPrint.Visible = false;
            // 
            // pdlgCORPrint
            // 
            this.pdlgCORPrint.AllowSelection = true;
            this.pdlgCORPrint.UseEXDialog = true;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 762);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduct";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel11.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductSaleMax)).EndInit();
            this.guna2GradientPanel12.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2GradientPanel3.ResumeLayout(false);
            this.guna2GradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            this.guna2GradientPanel9.ResumeLayout(false);
            this.guna2GradientPanel9.PerformLayout();
            this.guna2GradientPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvProduct;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel12;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI.WinForms.GunaDataGridView dgvListProductSaleMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printReview;
        private System.Windows.Forms.PrintPreviewDialog pvdCORPrint;
        private System.Windows.Forms.PrintDialog pdlgCORPrint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dcpChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Serial_Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Cost_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Sale_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consighment_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Group_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel6;
        private Bunifu.Framework.UI.BunifuImageButton btnPrint;
        private Bunifu.Framework.UI.BunifuTextbox txtFindProduct;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel9;
        private Guna.UI.WinForms.GunaCheckBox chxExpiry;
        private Guna.UI.WinForms.GunaCheckBox chxExpire;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel5;
        private FontAwesome.Sharp.IconButton btnNhap;
        private System.Windows.Forms.ComboBox cbxGroup;
    }
}