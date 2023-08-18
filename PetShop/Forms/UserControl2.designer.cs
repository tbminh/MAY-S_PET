
namespace PetShop.Forms
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblConsignment = new Guna.UI.WinForms.GunaLabel();
            this.lblUnit = new Guna.UI.WinForms.GunaLabel();
            this.lblProductID = new Guna.UI.WinForms.GunaLabel();
            this.NumToTal = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblSerialKey = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblSumPrice = new Guna.UI.WinForms.GunaLabel();
            this.lblPriceSale = new Guna.UI.WinForms.GunaLabel();
            this.lblProductName = new Guna.UI.WinForms.GunaLabel();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumToTal)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.AutoSize = true;
            this.gunaLinePanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.gunaLinePanel1.Controls.Add(this.lblConsignment);
            this.gunaLinePanel1.Controls.Add(this.lblUnit);
            this.gunaLinePanel1.Controls.Add(this.lblProductID);
            this.gunaLinePanel1.Controls.Add(this.NumToTal);
            this.gunaLinePanel1.Controls.Add(this.lblSerialKey);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel1.Controls.Add(this.lblSumPrice);
            this.gunaLinePanel1.Controls.Add(this.lblPriceSale);
            this.gunaLinePanel1.Controls.Add(this.lblProductName);
            this.gunaLinePanel1.Controls.Add(this.btnDelete);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaLinePanel1.MaximumSize = new System.Drawing.Size(740, 65);
            this.gunaLinePanel1.MinimumSize = new System.Drawing.Size(740, 65);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(740, 65);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // lblConsignment
            // 
            this.lblConsignment.AutoSize = true;
            this.lblConsignment.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblConsignment.ForeColor = System.Drawing.Color.Gray;
            this.lblConsignment.Location = new System.Drawing.Point(129, 41);
            this.lblConsignment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsignment.Name = "lblConsignment";
            this.lblConsignment.Size = new System.Drawing.Size(79, 15);
            this.lblConsignment.TabIndex = 13;
            this.lblConsignment.Text = "Consignment";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUnit.ForeColor = System.Drawing.Color.Gray;
            this.lblUnit.Location = new System.Drawing.Point(497, 20);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(54, 20);
            this.lblUnit.TabIndex = 12;
            this.lblUnit.Text = "Đơn Vị";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProductID.ForeColor = System.Drawing.Color.Gray;
            this.lblProductID.Location = new System.Drawing.Point(257, 37);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(71, 19);
            this.lblProductID.TabIndex = 11;
            this.lblProductID.Text = "ProductID";
            this.lblProductID.Visible = false;
            // 
            // NumToTal
            // 
            this.NumToTal.BackColor = System.Drawing.Color.Transparent;
            this.NumToTal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NumToTal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumToTal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumToTal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumToTal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumToTal.DisabledState.Parent = this.NumToTal;
            this.NumToTal.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumToTal.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumToTal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumToTal.FocusedState.Parent = this.NumToTal;
            this.NumToTal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumToTal.ForeColor = System.Drawing.Color.Black;
            this.NumToTal.Location = new System.Drawing.Point(425, 11);
            this.NumToTal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumToTal.Name = "NumToTal";
            this.NumToTal.ShadowDecoration.Parent = this.NumToTal;
            this.NumToTal.Size = new System.Drawing.Size(72, 36);
            this.NumToTal.TabIndex = 10;
            this.NumToTal.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NumToTal.UpDownButtonForeColor = System.Drawing.Color.White;
            this.NumToTal.ValueChanged += new System.EventHandler(this.NumToTal_ValueChanged);
            this.NumToTal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumToTal_KeyPress);
            // 
            // lblSerialKey
            // 
            this.lblSerialKey.AutoSize = true;
            this.lblSerialKey.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSerialKey.ForeColor = System.Drawing.Color.Gray;
            this.lblSerialKey.Location = new System.Drawing.Point(343, 37);
            this.lblSerialKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerialKey.Name = "lblSerialKey";
            this.lblSerialKey.Size = new System.Drawing.Size(69, 19);
            this.lblSerialKey.TabIndex = 7;
            this.lblSerialKey.Text = "Seiral_Key";
            this.lblSerialKey.Visible = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(72, 37);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(38, 19);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "VND";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.749999F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(656, 18);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(42, 18);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "VNĐ";
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.749999F, System.Drawing.FontStyle.Bold);
            this.lblSumPrice.Location = new System.Drawing.Point(553, 18);
            this.lblSumPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(81, 18);
            this.lblSumPrice.TabIndex = 4;
            this.lblSumPrice.Text = "1,000,000";
            // 
            // lblPriceSale
            // 
            this.lblPriceSale.AutoSize = true;
            this.lblPriceSale.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPriceSale.ForeColor = System.Drawing.Color.Gray;
            this.lblPriceSale.Location = new System.Drawing.Point(4, 37);
            this.lblPriceSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceSale.Name = "lblPriceSale";
            this.lblPriceSale.Size = new System.Drawing.Size(41, 19);
            this.lblPriceSale.TabIndex = 2;
            this.lblPriceSale.Text = "1000";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(4, 17);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(204, 20);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Pasta in Tomato Sauce";
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BaseColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedImage")));
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.Location = new System.Drawing.Point(692, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(44, 32);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "gunaAdvenceButton1";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gunaLinePanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(740, 65);
            this.MinimumSize = new System.Drawing.Size(740, 65);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(740, 65);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumToTal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel lblSumPrice;
        private Guna.UI.WinForms.GunaLabel lblPriceSale;
        private Guna.UI.WinForms.GunaLabel lblProductName;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblSerialKey;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumToTal;
        private Guna.UI.WinForms.GunaLabel lblProductID;
        private Guna.UI.WinForms.GunaLabel lblUnit;
        private Guna.UI.WinForms.GunaLabel lblConsignment;
    }
}
