using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using System.Drawing.Printing;

namespace PetShop.Forms
{
    public partial class FormSelling : Form
    {
        public FormSelling()
        {
            InitializeComponent();
        }
        public string Cus_Name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string Number_Phone
        {
            get { return lblPhone.Text; }
            set { lblPhone.Text = value; }
        }
        public string SerialKey
        {
            get { return lblSerialKey.Text; }
            set { lblPhone.Text = value; }
        }
        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = clsSql.User_FullName;
        }
        enum dgv_enum : int
        {
            STT,
            Serial_Key,
            Customer_Name,
            Phone_Number,
            Order_Status,
            Surcharge,
        }
        enum dgv_list_enum : int
        {
            Product_ID,
            STT,
            Product_Name,
            Product_Sale_Price,
            Product_Quantity,
            Status,
        }
        private bool isLeavingTextbox = false;
        static int i = 1;
        private static double gia;
        private string key_order;
        private string tien_khach_dua;
        private string phu_thu;
        #region Function
        //Cập Nhật Lại Tổng Tiền
        public void Update_Total_Bill()
        {
            UserControl2 myControl = new UserControl2();
            int result = 0;
            int i = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is UserControl2)
                {
                    UserControl2 myUserControl = (UserControl2)control;
                    int price = int.Parse(myUserControl.Sum_Price.Replace(",", "").Replace(".", ""));
                    result = result + price;
                }
            }
            lblTotalPrice.Text = result.ToString("#,##0");
        }
        // Cập nhật tổng tiền của từng sản phẩm
        public void Update_Product_Total(string Serial_Key, string Qty)
        {
            string SQL = @"UPDATE INVOICE_DETAIL SET Product_Total = '" + Qty + @"'
                           WHERE Invoice_Serial_Key = '" + Serial_Key + "'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            odcConnect.Open();
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcCommand.ExecuteNonQuery();
        }
        public void Delete_Product(string Invoice_Serial_Key)
        {
            cbxSurcharge.Checked = false;
            string SQL = @"DELETE FROM INVOICE_DETAIL where Invoice_Serial_Key = '" + Invoice_Serial_Key + @"'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            odcConnect.Open();
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcCommand.ExecuteNonQuery();
            Show_Payment_Layout(lblSerialKey.Text.Trim());
        }
        // Hiển thị Chi Tiết Hóa Đơn
        public void Show_Payment_Layout(string Serial_Key)
        {
            dgvOrder.Visible = false;
            flowLayoutPanel1.Visible = true;
            pnInfoOrder.Visible = true;
            lblSerialKey.Text = Serial_Key;

            string SQL = @"SELECT * from INVOICE_DETAIL where Invoice = '" + Serial_Key + "' ORDER BY Invoice_Serial_Key DESC";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            flowLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                UserControl2 myControl = new UserControl2();
                flowLayoutPanel1.Controls.Add(myControl);
                myControl.Serial_Key = reader["Invoice_Serial_Key"].ToString();
                myControl.Product_Total_Qty = reader["Product_Total"].ToString();
                myControl.Product_Name = reader["Product_Name"].ToString();
                int number = int.Parse(reader["Product_Price"].ToString()); //Get sale price
                int qty = int.Parse(reader["Product_Total"].ToString()); //Get quantity 
                int total_price = number * qty;
                myControl.Price_Sale = number.ToString("#,##0");
                myControl.Sum_Price = total_price.ToString("#,##0");
                t++;
            }
            Update_Total_Bill(); //Cập Nhật Lại Tổng Tiền
        }
        private static string MAX_Invoice_Detail_Serial_Key()
        {
            string sData = "";
            int iCount = 0;
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            string sSQL = "SELECT MAX(Invoice_Serial_Key) AS Invoice_Serial_Key FROM INVOICE_DETAIL WHERE Invoice_Serial_Key LIKE 'IN%'";
            OleDbCommand sqlCommand = new OleDbCommand(sSQL, sqlConnect);
            sqlCommand.CommandTimeout = 120;
            try
            {
                sqlConnect.Open();
                sData = sqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception exMsg)
            {
                if (exMsg != null)
                {
                    //  DatabaseClass.WriteAlarmLog("MAX_Material_Label_Serial Alarm:" + exMsg.ToString(), "clsDatabase_Alarm.txt");
                    if (sqlCommand != null) sqlCommand.Dispose();
                    if (sqlConnect != null) sqlConnect.Dispose();
                }
            }
            finally
            {
                if (sqlCommand != null) sqlCommand.Dispose();
                if (sqlConnect != null) sqlConnect.Dispose();
            }

            if (sData.Trim().Length == 0)
                sData = "IN0000000000001";
            else
            {
                iCount = Convert.ToInt32(sData.Replace("IN", "")) + 1;
                sData = "IN" + string.Format("{0:0000000000000}", iCount);
            }
            return sData;
        }
        private bool Add_Cart(string Invoice_Serial_Key, string Product_ID, string Product_Name, string Product_Price)
        {
            bool rong = false;
            string sql = @"IF NOT EXISTS(SELECT TOP 1 * FROM INVOICE_DETAIL O 
                            WHERE Invoice = '" + Invoice_Serial_Key + @"'
							AND Product_Id = '" + Product_ID + @"')
                            BEGIN
                            -- Insert INVOICE DETAIL
                                INSERT INTO INVOICE_DETAIL(
                                                Invoice_Serial_Key,
                                                Product_Id,
                                                Product_Name,
                                                Product_Price, 
                                                Product_Total,
                                                Invoice,
                                                Product_Unit)
                              VALUES('" + MAX_Invoice_Detail_Serial_Key() + @"',
                                    '" + Product_ID + @"',
                                    N'" + Product_Name + @"',
                                    '" + Decimal.Parse(Product_Price) + @"',
                                    1,
                                    '" + Invoice_Serial_Key + @"',
                                    N'Unit')
                            END
                            -- IF NOT Exist, update quantity product
                            ELSE
                            BEGIN
                                UPDATE INVOICE_DETAIL SET Product_Total = Product_Total + 1
                                                      WHERE Invoice = '" + Invoice_Serial_Key + @"'
							                           AND Product_Id = '" + Product_ID + @"'
                            END";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(sql, sqlConnect);
            try
            {
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                Show_Payment_Layout(Invoice_Serial_Key);
                rong = true;
            }
            catch { }
            return rong;
        }
        private void Show_List_Product()
        {
            string SQL = @"SELECT TOP 20 * from PRODUCT_INFO where Product_Type_Serial_Key = 'PT0000000000001' 
                            AND Product_Status = '1'
                            AND Product_Quantity > 0";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            dgvList.Columns["Product_Quantity"].Visible = true;
            dgvList.Columns["Status"].Visible = false;
            dgvList.Rows.Clear();
            while (reader.Read())
            {
                decimal price = Convert.ToDecimal(reader["Product_Sale_Price"]);
                dgvList.Rows.Add(new object[]
                {
                    reader["Product_Id"].ToString(),
                    t,
                    reader["Product_Name"].ToString(),
                    price.ToString("#,##0"),
                    reader["Product_Quantity"].ToString(),
                    reader["Product_Status"].ToString(),
                });
                t++;
            }
        }
        private void ScanQR_Product(string keyword)
        {
            string SQL = @"SELECT * FROM PRODUCT_INFO WHERE Product_Barcode = '" + keyword + @"'
                            AND Product_Status = '1'
                            AND Product_Quantity > 0";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            dgvList.Columns["Product_Quantity"].Visible = true;
            dgvList.Columns["Status"].Visible = false;
            while (reader.Read())
            {
                string Product_ID = reader["Product_Id"].ToString();
                string Product_Name = reader["Product_Name"].ToString();
                string Product_Price = reader["Product_Sale_Price"].ToString();
                string Invoice_Serial_Key = lblSerialKey.Text;
                if (Add_Cart(Invoice_Serial_Key, Product_ID, Product_Name, Product_Price))
                {
                    txtScanQR.Text = "";
                }
            }

        }
        #endregion

        private void btnOrder_Click(object sender, EventArgs e)
        {
            dgvOrder.Visible = true;
            flowLayoutPanel1.Visible = false;
            string SQL = @"SELECT * from INVOICE where Status = 'waiting' ORDER BY Invoice_Serial_Key desc";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            dgvOrder.Rows.Clear();
            while (reader.Read())
            {
                dgvOrder.Rows.Add(new object[]
                {
                    t,
                    reader["Invoice_Serial_Key"].ToString(),
                    reader["Name"].ToString(),
                    reader["Phone"].ToString(),
                    "Đang chờ",
                    reader["Surcharge"].ToString(),
                });
                t++;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            dgvOrder.Visible = false;
            flowLayoutPanel1.Visible = true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var f2 = new FormAddOrder();
            //f2.GetStringFromAnotherForm += new frmPartial_In_Out.MyDelegate(GetContentValueBarcode);
            MaskedDialog.ShowDialog(this, f2);
            f2.Dispose();
            f2 = null;
            if (FormAddOrder.order_key != "")
            {
                clsSql get_ID_HD = new clsSql();
                get_ID_HD = clsSql.Get_ID_INVOICE();
                Show_Payment_Layout(FormAddOrder.order_key);
                lblName.Text = FormAddOrder.name;
                lblPhone.Text = FormAddOrder.phone;
                cbxSurcharge.Checked = false;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Show_List_Product();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            string SQL = @"SELECT * from PRODUCT_INFO where Product_Type_Serial_Key = 'PT0000000000002' and Product_Status = '1'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            dgvList.Columns["Product_Quantity"].Visible = false;
            dgvList.Columns["Status"].Visible = true;
            dgvList.Rows.Clear();
            while (reader.Read())
            {
                decimal price = Convert.ToDecimal(reader["Product_Sale_Price"]);
                dgvList.Rows.Add(new object[]
                {
                    reader["Product_Id"].ToString(),
                    t,
                    reader["Product_Name"].ToString(),
                    price.ToString("#,##0"),
                    reader["Product_Quantity"].ToString(),
                    "Đang Kinh Doanh",
                });
                t++;
            }
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            string SQL = @"SELECT * from PRODUCT_INFO where Product_Type_Serial_Key = 'PT0000000000003' and Product_Status = '0'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            dgvList.Columns["Product_Quantity"].Visible = false;
            dgvList.Columns["Status"].Visible = true;
            dgvList.Rows.Clear();
            while (reader.Read())
            {
                decimal price = Convert.ToDecimal(reader["Product_Sale_Price"]);
                dgvList.Rows.Add(new object[]
                {
                    reader["Product_Id"].ToString(),
                    t,
                    reader["Product_Name"].ToString(),
                    price.ToString("#,##0"),
                    reader["Product_Quantity"].ToString(),
                    "Còn Trống",
                });
                t++;
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblSerialKey.Text != "")
            {
                cbxSurcharge.Checked = false;
                string Invoice_Serial_Key = lblSerialKey.Text;
                string Product_ID = dgvList.CurrentRow.Cells[(int)dgv_list_enum.Product_ID].Value?.ToString();
                string Product_Name = dgvList.CurrentRow.Cells[(int)dgv_list_enum.Product_Name].Value?.ToString();
                string Product_Price = dgvList.CurrentRow.Cells[(int)dgv_list_enum.Product_Sale_Price].Value?.ToString();
                Add_Cart(Invoice_Serial_Key, Product_ID, Product_Name, Product_Price);
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Đơn Hàng");
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Tìm Kiếm Sản Phẩm ...";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string tim = "";
            if (txtSearch.Text.Length > 2)
            {
                tim = tim + txtSearch.Text;
                //string SQL = @"SELECT * from PRODUCT_INFO where Product_Type_Serial_Key = 'PT0000000000002' and Product_Status = '1'";
                String SQL = @"select top 10 * from PRODUCT_INFO where Product_Name LIKE  N'%" + tim + "%' or Product_Barcode like  N'%" + tim + "%'";
                OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
                OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
                odcConnect.Open();
                OleDbDataReader reader = odcCommand.ExecuteReader();
                int t = 1;
                dgvList.Columns["Product_Quantity"].Visible = false;
                dgvList.Columns["Status"].Visible = true;
                dgvList.Rows.Clear();
                while (reader.Read())
                {
                    decimal price = Convert.ToDecimal(reader["Product_Sale_Price"]);
                    dgvList.Rows.Add(new object[]
                    {
                    reader["Product_Id"].ToString(),
                    t,
                    reader["Product_Name"].ToString(),
                    price.ToString("#,##0"),
                    reader["Product_Quantity"].ToString(),
                    "Đang Kinh Doanh",
                    });
                    t++;
                }
            }
        }

        private void txtScanQR_Enter(object sender, EventArgs e)
        {
            if (!ReferenceEquals(sender, txtScanQR))//|| !(sender is Guna.UI.WinForms.GunaTextBox)
            {
                // Ignore the event if it was not raised by the TextBox control
                return;
            }
            txtScanQR.Text = "";
        }

        private void txtScanQR_TextChanged(object sender, EventArgs e)
        {
            if (isLeavingTextbox) //If I Leave TextBox chang Text, I don't want call this event
            {
                return;
            }
            ScanQR_Product(txtScanQR.Text);
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Serial_Key = dgvOrder.CurrentRow.Cells[(int)dgv_enum.Serial_Key].Value?.ToString();
            lblName.Text = dgvOrder.CurrentRow.Cells[(int)dgv_enum.Customer_Name].Value?.ToString();
            lblPhone.Text = dgvOrder.CurrentRow.Cells[(int)dgv_enum.Phone_Number].Value?.ToString();
            txtGiven.Text = "0";
            lblRemain.Text = "0";
            cbxSurcharge.Checked = false;
            if (dgvOrder.CurrentRow.Cells[(int)dgv_enum.Surcharge].Value?.ToString() == null)
            {
                txtSurcharge.Text = "0";
            }
            else
            {
                txtSurcharge.Text = dgvOrder.CurrentRow.Cells[(int)dgv_enum.Surcharge].Value?.ToString();
            }
            Show_Payment_Layout(Serial_Key);
            txtScanQR.Focus();
        }

        private void txtSurcharge_TextChanged(object sender, EventArgs e)
        {
            if (txtSurcharge.Text != "")
            {
                if (decimal.TryParse(txtSurcharge.Text, out decimal value))
                {
                    txtSurcharge.Text = value.ToString("#,##0");
                    int length = txtSurcharge.ToString().Length;
                    txtSurcharge.SelectionStart = length;
                }
                else
                {
                    txtSurcharge.Text = "0";
                }
                //lblTotalPrice.Text = (Convert.ToDouble(Convert.ToDouble(lblTotalPrice.Text) + Convert.ToDouble(txtSurcharge.Text.Trim())).ToString("#,##0"));
                lblTotalPrice.Text = (Convert.ToDouble(gia + Convert.ToDouble(txtSurcharge.Text.Trim())).ToString("#,##0"));
            }
            else
            {
                txtSurcharge.Text = "0";
            }
        }

        private void txtGiven_Leave(object sender, EventArgs e)
        {
            lblGiven.ForeColor = Color.Gray;
            lblGiven.Font = new Font(cbxSurcharge.Font.FontFamily, 8, cbxSurcharge.Font.Style);
            lblGiven.Font = new Font(lblGiven.Font.FontFamily, lblGiven.Font.Size, FontStyle.Regular);
        }

        private void txtGiven_TextChanged(object sender, EventArgs e)
        {
            if (txtGiven.Text != "")
            {
                if (decimal.TryParse(txtGiven.Text, out decimal value))
                {
                    txtGiven.Text = value.ToString("#,##0");
                    int length = txtGiven.ToString().Length;
                    txtGiven.SelectionStart = length;
                    lblRemain.Text = (Convert.ToDouble(Convert.ToDecimal(txtGiven.Text.Trim()) - Convert.ToDecimal(lblTotalPrice.Text)).ToString("#,##0"));
                }
                else
                {
                    txtGiven.Text = "0";
                }
            }
        }

        private void txtGiven_Enter(object sender, EventArgs e)
        {
            lblGiven.ForeColor = Color.OrangeRed;
            lblGiven.Font = new Font(cbxSurcharge.Font.FontFamily, 10, cbxSurcharge.Font.Style);
            lblGiven.Font = new Font(lblGiven.Font.FontFamily, lblGiven.Font.Size, FontStyle.Bold);
        }

        private void lblTotalPrice_TextChanged(object sender, EventArgs e)
        {
            txtGiven.Text = "0";
            lblRemain.Text = "0";
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!ReferenceEquals(sender, txtSearch)) //!(sender is Guna.UI.WinForms.GunaTextBox) ||
            {
                // Ignore the event if it was not raised by the TextBox control
                return;
            }
            txtSearch.Text = "";
        }
    }
}
