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
        //public string Cus_Name
        //{
        //    get { return lblName.Text; }
        //    set { lblName.Text = value; }
        //}
        //public string Number_Phone
        //{
        //    get { return lblPhone.Text; }
        //    set { lblPhone.Text = value; }
        //}
        //public string SerialKey
        //{
        //    get { return lblSerialKey.Text; }
        //    set { lblPhone.Text = value; }
        //}
        private void FormSelling_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = clsSql.User_FullName;
        }
        private bool isLeaving = false;
        private string key_order;
        private string tien_khach_dua = "100000";
        private string phu_thu = "20000";
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
            Product_Unit,
            Product_Barcode,
            Status,
        }
        private bool isLeavingTextbox = false;
        private bool isShowInvoiceDetail = false; //Show phụ thu và giảm giá để không vào hàm textchange
        int i = 0;
        private static double gia, discount;
        #region Function
        //Cập Nhật Lại Tổng Tiền
        public void Reload_lblTotalPrice()
        {
            //txtSurcharge.Text = surcharge == "" ? txtSurcharge.Text : surcharge;
            //txtDiscount.Text = discount == "" ? txtDiscount.Text : surcharge;
            //foreach (Control control in flowLayoutPanel1.Controls)
            //{
            //    if (control is UserControl2)
            //    {
            //        UserControl2 myUserControl = (UserControl2)control;
            //        int price = int.Parse(myUserControl.Sum_Price.Replace(",", "").Replace(".", ""));
            //        result = result + price;
            //    }
            //}
            //lblTotalPrice.Text = result.ToString("#,##0");
            string SQL = $@"SELECT Total_Price,Surcharge, Discount 
                            FROM INVOICE 
                            WHERE Invoice_Serial_Key = '{lblSerialKey.Text}'";
            using (OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(SQL, conn))
                {
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtSurcharge.Text = (Convert.ToInt32(reader["Surcharge"])).ToString("#,##0");
                        txtDiscount.Text = (Convert.ToInt32(reader["Discount"])).ToString("#,##0");
                        lblTotalPrice.Text = (Convert.ToInt32(reader["Total_Price"])).ToString("#,##0");
                    }
                }
            }
        }

        // Cập nhật tổng tiền của từng sản phẩm
        public void Update_Invoice_Detail(string Serial_Key, string Qty)
        {
            Qty = Qty.Replace(",", ".");
            string SQL = $@"UPDATE INVOICE_DETAIL 
                            SET Product_Total = '{Qty}',
                                Product_Price =  CONVERT(FLOAT,'{Qty}') * Unit_Price
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
            Show_Invoice_Detail(lblSerialKey.Text.Trim());
        }
        // Hiển thị Chi Tiết Hóa Đơn
        public void Show_Invoice_Detail(string Serial_Key)
        {
            dgvOrder.Visible = false;
            flowLayoutPanel1.Visible = true;
            pnInfoOrder.Visible = true;
            lblSerialKey.Text = Serial_Key;

            string SQL = @"SELECT C.Consignment_ID as Consignment,I.*
                            FROM INVOICE_DETAIL I
							JOIN PRODUCT_INFO P
							ON I.Product_Barcode = P.Product_Barcode
							JOIN CONSIGNMENT C
							ON P.Consignment_Serial_Key = C.Consignment_Serial_Key
                            WHERE Invoice = '" + Serial_Key + @"'
                            ORDER BY Invoice_Serial_Key DESC ";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            flowLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                UserControl2 myControl = new UserControl2();
                float number = float.Parse(reader["Unit_Price"].ToString()); //Get sale price
                float qty = float.Parse(reader["Product_Total"].ToString()); //Get quantity 
                float total_price = number * qty;
                myControl.Serial_Key = reader["Invoice_Serial_Key"].ToString();
                myControl.Product_ID = reader["Product_Id"].ToString();
                myControl.Product_Total_Qty = reader["Product_Total"].ToString();
                myControl.Product_Name = reader["Product_Name"].ToString();
                myControl.Unit = reader["Product_Unit"].ToString();
                myControl.Consignment = reader["Consignment"].ToString();
                myControl.Price_Sale = number.ToString("#,##0");
                myControl.Sum_Price = total_price.ToString("#,##0");
                flowLayoutPanel1.Controls.Add(myControl);
                t++;
            }
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
        private bool Add_Cart(string Invoice_Serial_Key, string Product_ID, string Product_Name, string Product_Price, string Unit, string Barcode)
        {
            bool result = false;
            string sql = @"IF NOT EXISTS(SELECT TOP 1 * FROM INVOICE_DETAIL O 
                            WHERE Invoice = '" + Invoice_Serial_Key + @"'
							AND Product_Barcode = '" + Barcode + @"'
                            AND Product_Unit = '" + Unit + @"')
                            BEGIN
                                INSERT INTO INVOICE_DETAIL(
                                                Invoice_Serial_Key,
                                                Product_Id,
                                                Product_Name,
                                                Product_Price, 
                                                Product_Total,
                                                Unit_Price,
                                                Invoice,
                                                Product_Unit,
                                                Product_Barcode)
                              VALUES('" + MAX_Invoice_Detail_Serial_Key() + @"', --Serial_Key
                                    '" + Product_ID + @"',
                                    N'" + Product_Name + @"',
                                    '" + Decimal.Parse(Product_Price) + @"', --Product Price
                                    1, --Product Total
                                    '" + Decimal.Parse(Product_Price) + @"', --Unit Price
                                    '" + Invoice_Serial_Key + @"',
                                    N'" + Unit + @"',
                                    N'" + Barcode + @"')
                            END
                            ELSE
                            BEGIN
                                --CẬP NHẬT SỐ LƯỢNG VÀ TỔNG TIỀN CỦA 1 SẢN PHẨM
                                UPDATE INVOICE_DETAIL SET Product_Total = Product_Total + 1,
                                                            Product_Price = (Product_Total + 1) * Unit_Price
                                                      WHERE Invoice = '" + Invoice_Serial_Key + @"'
							                          AND Product_Barcode = '" + Barcode + @"'
                            END";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(sql, sqlConnect);
            try
            {
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                result = true;
            }
            catch(Exception exg) { }

            return result;
        }
        public bool Save_Invoice() 
        {
            bool result = false;
                string SQL = @" DECLARE @Surcharge FLOAT = '" + Decimal.Parse(txtSurcharge.Text) + @"'
                                DECLARE @Discount FLOAT = '" + Decimal.Parse(txtDiscount.Text) + @"'
                                UPDATE INVOICE 
                                SET Surcharge = @Surcharge,
                                    Discount = @Discount,
                                    Total_Price = (SELECT SUM(Product_Price) + @Surcharge - @Discount
							                        FROM INVOICE_DETAIL
							                        WHERE Invoice = '" + lblSerialKey.Text + @"')
                                FROM INVOICE I
		                        JOIN INVOICE_DETAIL ID
		                        ON I.Invoice_Serial_Key = ID.Invoice
		                        WHERE I.Invoice_Serial_Key = '" + lblSerialKey.Text + "' ";
            OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand cmd = new OleDbCommand(SQL, conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                result = true;
            }
            conn.Close();
            return result;
        }
        private void Show_List_Product()
        {
            string SQL = @"SELECT TOP 200
                                I.Product_Id,
					            I.Product_Name,
					            I.Product_Sale_Price as price,
					            I.Product_Quantity,
					            I.Product_Unit,
					            isnull(I.Product_Sale_SubPrice,'') as subprice,
					            ISNULL(I.Product_SubUnit,'') as subunit,
					            I.Product_Barcode,
					            I.Product_Status
                            FROM PRODUCT_INFO I, PRODUCT_GROUP P
                            WHERE I.Product_Group_Serial_Key = P.Product_Group_Serial_Key
                            AND P.Product_Type_Serial_Key = 'PT0000000000001' 
                            AND Product_Status = '1'
                            AND I.Product_Quantity > 0
                            AND I.Product_Total_Quantity > 0";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            int index = 0;
            dgvList.Rows.Clear();
            while (reader.Read())
            {
                bindComboboxColumn(reader["Product_Barcode"].ToString(), index);
                decimal price = Convert.ToDecimal(reader["subunit"].ToString() == "" ? reader["price"] : reader["subprice"]);
                dgvList.Rows.Add(new object[]
                {
                    reader["Product_Id"].ToString(),
                    t,
                    reader["Product_Name"].ToString(),
                    price.ToString("#,##0"),
                    reader["Product_Quantity"].ToString(),
                    "", //Sub unit
                    reader["Product_Barcode"].ToString(),
                    reader["Product_Status"].ToString(),
                });
                dgvList.Rows[index].Cells["dcpUnit"].Value = reader["subunit"].ToString() == "" ? reader["Product_Unit"].ToString() : reader["subunit"].ToString();
                t++;
                index++;
            }
        }
        private void Searching_Order(string keyword)
        {
            string SQL = @"SELECT * FROM INVOICE WHERE Phone = '" + keyword + @"'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            dgvList.Columns["Product_Quantity"].Visible = true;
            dgvList.Columns["Status"].Visible = false;
            while (reader.Read())
            {
                
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
            dgvList.Columns["Product_Quantity"].Visible = true;
            dgvList.Columns["Status"].Visible = false;
            while (reader.Read())
            {
                string Product_ID = reader["Product_Id"].ToString();
                string Product_Name = reader["Product_Name"].ToString();
                string Product_Price = reader["Product_Sale_Price"].ToString();
                string Unit = reader["Product_Unit"].ToString();
                string Invoice_Serial_Key = lblSerialKey.Text;
                if (Add_Cart(Invoice_Serial_Key, Product_ID, Product_Name, Product_Price, Unit, keyword))
                {
                    Save_Invoice();
                    Show_Invoice_Detail(Invoice_Serial_Key);
                    Reload_lblTotalPrice(); //Cập Nhật Lại Tổng Tiền
                }
            }
        }
        private bool CheckOut_Invoice(string serial_key)
        {
            bool result = false;
            float total_remain = 0;
            string old_barcode = "";
            string new_barcode = "";
            string SQL = $@"SELECT I.Product_Barcode,D.Product_Total as SLBan,D.Product_Unit as DonViMua,I.Product_Unit,Product_SubUnit,Product_Quantity,Product_SubQuantity,Product_Total_Quantity
                            FROM PRODUCT_INFO I JOIN INVOICE_DETAIL D
                            ON I.Product_Barcode = D.Product_Barcode
                            WHERE Invoice = '{serial_key}'
                            ORDER BY I.Product_Barcode";
            OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(SQL, conn);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                new_barcode = read["Product_Barcode"].ToString();
                if (old_barcode == read["Product_Barcode"].ToString())
                {
                    if (read["DonViMua"].ToString() == read["Product_SubUnit"].ToString())
                    {
                        total_remain = total_remain - float.Parse(read["SLBan"].ToString());
                    }
                    else
                    {
                        total_remain = total_remain - (float.Parse(read["SLBan"].ToString()) * float.Parse(read["Product_SubQuantity"].ToString()));
                    }
                }
                else
                {
                    if (read["DonViMua"].ToString() == read["Product_SubUnit"].ToString())
                    {
                        total_remain = float.Parse(read["Product_Total_Quantity"].ToString()) - float.Parse(read["SLBan"].ToString());
                        old_barcode = read["Product_Barcode"].ToString();
                    }
                    else
                    {
                        total_remain = float.Parse(read["Product_Total_Quantity"].ToString()) - (float.Parse(read["SLBan"].ToString()) * float.Parse(read["Product_SubQuantity"].ToString()));
                    }
                }
                string SQL_Total = $@"UPDATE PRODUCT_INFO
							            SET Product_Total_Quantity = '{total_remain}' ";
                if (total_remain == 0)
                {
                    SQL_Total += @",Product_Status = '0' ";
                }
                SQL_Total += $@"WHERE Product_Barcode = '{new_barcode}'";
                using (OleDbConnection con = new OleDbConnection(clsConnect.Connect_String))
                {
                    con.Open();
                    using (OleDbCommand command = new OleDbCommand(SQL_Total, con))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            clsSql.Get_Data_User();
            string SQL_Invoice = $@"UPDATE INVOICE SET Status = 'Done', Emp_Name= N'{clsSql.User_FullName}' 
                                    WHERE Invoice_Serial_Key = '{lblSerialKey.Text}'";
            //Update Invoice status
            using (OleDbConnection connect = new OleDbConnection(clsConnect.Connect_String))
            {
                connect.Open();
                using (OleDbCommand command = new OleDbCommand(SQL_Invoice, connect))
                {
                    command.ExecuteNonQuery();
                }
            }
            return result;
        }
        private void Get_Invoice(string invoice_serial_key) //Hiển thị phần tổng tiền, phụ thu, giảm giá
        {
            string SQL = $@"SELECT Total_Price,Discount, Surcharge
                            FROM  INVOICE WHERE Invoice_Serial_Key = '{invoice_serial_key}'";
            OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand cmd = new OleDbCommand(SQL, conn);
            conn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                lblTotalPrice.Text = (Convert.ToInt32(read["Total_Price"])).ToString("#,##0");
                txtSurcharge.Text = (Convert.ToInt32(read["Surcharge"])).ToString("#,##0");
                txtDiscount.Text = (Convert.ToInt32(read["Discount"])).ToString("#,##0");
            }
        }
        private DataTable LoadsqlFromDatabase(string sql)
        {
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            DataTable dt = new DataTable();
            odcConnect.Open();
            try
            {
                using (OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sql, odcConnect))
                {
                    myDataAdapter.Fill(dt);
                }
                DataRow dtR = dt.NewRow();
                dtR[0] = " ";
                int columnIndex = 1; // Đây là chỉ số của cột mà bạn muốn gán giá trị
                if (columnIndex >= 0 && columnIndex < dtR.ItemArray.Length)
                {
                    dtR[columnIndex] = " ";
                }
                dt.Rows.InsertAt(dtR, 0);
            }
            catch (Exception exMsg)
            {
                MessageBox.Show("Lỗi truy vấn " + exMsg);
            }
            finally
            {
                if (odcConnect != null) odcConnect.Dispose();
            }
            return dt;
        }
        private void bindComboboxColumn(string Barcode, int rowIndex)
        {
            if (rowIndex < 0)
            {
                string sql = $@"SELECT Merged_Unit
                                FROM (
                                    SELECT [Product_Unit] AS Merged_Unit
                                    FROM [PRODUCT_INFO]
                                    WHERE [Product_Barcode] = '{Barcode}'
                                    UNION ALL
                                    SELECT ISNULL([Product_SubUnit],'') AS Merged_Unit
                                    FROM [PRODUCT_INFO]
                                    WHERE [Product_Barcode] = '{Barcode}'
                                          AND [Product_SubUnit] IS NOT NULL
                                ) AS UnionResults
                                WHERE '{Barcode}' IS NOT NULL";
                DataTable dt = LoadsqlFromDatabase(sql);
                DataGridViewComboBoxCell cbc = dgvList.Rows[rowIndex-1].Cells["dcpUnit"] as DataGridViewComboBoxCell;
                dgvList.ReadOnly = false;
                cbc.ReadOnly = false;
                cbc.DataSource = dt;
                cbc.DisplayMember = "Merged_Unit";
                cbc.ValueMember = "Merged_Unit";
                //cbc.DataPropertyName = "Product_Unit";
                //dt.Rows.Clear();
            }
        }
        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //BarcodeLib.Barcode code128;
            //code128 = new Barcode();
            //Get the Graphics object  
            Graphics g = ev.Graphics;
            //Create a font Arial with size 16  
            Font font = new Font("Arial", 15, FontStyle.Bold);
            Font font2 = new Font("Arial", 9, FontStyle.Regular);
            Font font3 = new Font("Arial", 9, FontStyle.Bold);
            Font font4 = new Font("Arial", 11, FontStyle.Italic);
            Font font5 = new Font("Arial", 9, FontStyle.Italic);
            Font font6 = new Font("Arial", 11, FontStyle.Bold);

            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Blue, 1);

            ////Tên Shop 
            g.DrawString("MAY'S PET SHOP", font, brush, new Rectangle(55, 100, 302, 30));
            //g.DrawRectangle(pen, new Rectangle(1, 92, 302, 40));
            ////Tên Shop /////for(int i = 150 ; i <302 ; i+=20)
            ////Địa chỉ Shop
            g.DrawString("78, Phan Văn Trị, ấp Thị Tứ, thị trấn Phong ", font2, brush, new Rectangle(15, 150, 302, 30));
            //g.DrawRectangle(pen, new Rectangle(1, 122, 302, 40));
            g.DrawString("Điền, huyện Phong Điền, thành phố Cần Thơ", font2, brush, new Rectangle(10, 170, 302, 30));
            //////Địa chỉ Shop
            g.DrawString("_______________________________", font2, brush, new Rectangle(30, 190, 302, 30));
            //g.DrawRectangle(pen, new Rectangle(1, 172, 302, 40));
            ////Tiêu đề hóa đơn
            g.DrawString("PHIẾU THANH TOÁN", font, brush, new Rectangle(35, 210, 302, 30));
            //g.DrawRectangle(pen, new Rectangle(1, 192, 302, 40));
            ////Tiêu đề hóa đơn
            string sql_invoice_key = @"SELECT top 1 I.Invoice_Serial_Key
                            FROM PRODUCT_INFO P, INVOICE I, INVOICE_DETAIL ID--, USER_AD U
                            WHERE P.Product_Id = ID.Product_Id
                            and I.Invoice_Serial_Key = ID.Invoice
                            --and U.User_Login = I.User_id
                            and ID.Invoice = '" + key_order + "'";
            string sql_user_name = @"SELECT top 1 U.User_Full_Name
                            FROM PRODUCT_INFO P, INVOICE I, INVOICE_DETAIL ID, USER_AD U
                            WHERE P.Product_Id = ID.Product_Id
                            and I.Invoice_Serial_Key = ID.Invoice
                            and U.User_Login = I.User_id
                            and ID.Invoice = '" + key_order + "'";
            string sql_Total_Price = @"SELECT top 1 I.Total_Price
                            FROM PRODUCT_INFO P, INVOICE I, INVOICE_DETAIL ID--, USER_AD U
                            WHERE P.Product_Id = ID.Product_Id
                            and I.Invoice_Serial_Key = ID.Invoice
                            --and U.User_Login = I.User_id
                            and ID.Invoice = '" + key_order + "'";

            string sSQL = @"SELECT P.Product_Name,P.Product_Sale_Price, ID.Product_Total,I.Total_Price
                            FROM PRODUCT_INFO P, INVOICE I, INVOICE_DETAIL ID--, USER_AD U
                            WHERE P.Product_Id = ID.Product_Id
                            and I.Invoice_Serial_Key = ID.Invoice
                            --and U.User_Login = I.User_id
                            and ID.Invoice = '" + key_order + "'";

            OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql_invoice_key, conn);
            OleDbCommand cmd1 = new OleDbCommand(sql_user_name, conn);
            OleDbCommand cmd2 = new OleDbCommand(sql_Total_Price, conn);
            OleDbCommand cmd_SP = new OleDbCommand(sSQL, conn);
            OleDbDataReader read = cmd_SP.ExecuteReader();
            string Invoice_key = cmd.ExecuteScalar().ToString();
            //string User_Name = cmd1.ExecuteScalar().ToString();
            string User_Name = "Bao Minh";
            string totalPrice = cmd2.ExecuteScalar().ToString();
            ////Số hóa đơn
            g.DrawString("Số HĐ: ", font2, brush, new Rectangle(10, 240, 302, 30));
            g.DrawString(Invoice_key, font3, brush, new Rectangle(60, 240, 302, 30));
            ////Số hóa đơn    
            ////Ngày Hóa Đơn
            g.DrawString("Ngày HĐ: ", font2, brush, new Rectangle(10, 270, 302, 30));
            g.DrawString(DateTime.Now.ToString(), font3, brush, new Rectangle(80, 270, 302, 30));
            ////Ngày hóa đơn
            ////Nhân viên
            g.DrawString("Nhân viên: ", font2, brush, new Rectangle(10, 300, 302, 30));
            g.DrawString(User_Name, font3, brush, new Rectangle(80, 300, 302, 30));
            ////Nhân viên
            g.DrawString("---------------------------------------------------", font2, brush, new Rectangle(30, 320, 302, 30));
            ////Sản phẩm
            g.DrawString("Số lượng", font4, brush, new Rectangle(10, 340, 302, 30));
            g.DrawString("Giá bán", font4, brush, new Rectangle(110, 340, 302, 30));
            g.DrawString("Thành tiền", font4, brush, new Rectangle(210, 340, 302, 30));

            int product_name_pos_y = 370;
            int product_total_pos_y = 400;
            int product_sale_price_pos_y = 400;
            int total_price_y = 400;
            while (read.Read())
            {
                g.DrawString(read["Product_Name"].ToString(), font2, brush, new Rectangle(15, product_name_pos_y, 302, 30));
                g.DrawString(read["Product_Total"].ToString(), font2, brush, new Rectangle(25, product_total_pos_y, 302, 30));
                g.DrawString(String.Format("{0:#,0}", Convert.ToInt32(read["Product_Sale_Price"].ToString())), font2, brush, new Rectangle(115, product_sale_price_pos_y, 302, 30));
                g.DrawString(String.Format("{0:#,0}", Convert.ToInt32(read["Product_Total"].ToString()) * Convert.ToInt32(read["Product_Sale_Price"].ToString())), font2, brush, new Rectangle(215, total_price_y, 302, 30));

                //g.DrawString("Thuốc xịt chó - thuốc xịt mèo", font2, brush, new Rectangle(15, 430, 302, 30));
                //g.DrawString("3", font2, brush, new Rectangle(25, 460, 302, 30));
                //g.DrawString(String.Format("{0:#,0}", 30000), font2, brush, new Rectangle(115, 460, 302, 30));
                //g.DrawString(String.Format("{0:#,0}", 120000), font2, brush, new Rectangle(215, 460, 302, 30));
                product_name_pos_y = product_name_pos_y + 60;
                product_total_pos_y = product_total_pos_y + 60;
                product_sale_price_pos_y = product_sale_price_pos_y + 60;
                total_price_y = total_price_y + 60;
            }
            g.DrawString("--------------------------------------------------------------", font2, brush, new Rectangle(10, product_total_pos_y - 40, 302, 30));
            //tổng tiền
            g.DrawString("Phụ thu: ", font5, brush, new Rectangle(50, product_total_pos_y - 20, 302, 30));
            g.DrawString(String.Format("{0:#,0}", Convert.ToInt32(phu_thu.Replace(",", "").Replace(".", ""))), font4, brush, new Rectangle(150, product_total_pos_y - 20, 302, 30));
            //tổng tiền
            //tổng tiền
            g.DrawString("Tổng tiền: ", font5, brush, new Rectangle(50, product_total_pos_y, 302, 30));
            g.DrawString(String.Format("{0:#,0}", Convert.ToInt32(totalPrice.Replace(",", "").Replace(".", "")) + Convert.ToInt32(phu_thu.Replace(",", "").Replace(".", ""))), font4, brush, new Rectangle(150, product_total_pos_y, 302, 30));
            //tổng tiền

            //tiền khách đưa
            g.DrawString("Tiền khách đưa: ", font5, brush, new Rectangle(50, product_total_pos_y + 20, 302, 30));
            g.DrawString(String.Format("{0:#,0}", Convert.ToInt32(tien_khach_dua.Replace(",", "").Replace(".", ""))), font4, brush, new Rectangle(150, product_total_pos_y + 20, 302, 30));
            //tiền khách đưa

            //tiền thừa
            g.DrawString("Tiền thối lại: ", font5, brush, new Rectangle(50, product_total_pos_y + 40, 302, 30));
            g.DrawString(String.Format("{0:#,0}", Convert.ToInt32(tien_khach_dua.Replace(",", "").Replace(".", "")) - Convert.ToInt32(totalPrice.Replace(",", "").Replace(".", ""))), font4, brush, new Rectangle(150, product_total_pos_y + 40, 302, 30));
            //tiền thừa
            g.DrawString("--------------------------------------------------------------", font2, brush, new Rectangle(10, product_total_pos_y + 50, 302, 30));

            g.DrawString("Lưu ý: Hóa đơn chỉ xuất trong ngày. Quý khách vui lòng kiểm hàng trước khi thanh toán. Hàng mua rồi không được đổi trả!", font4, brush, new Rectangle(0, product_total_pos_y + 65, 302, 60));
            g.DrawString("MAY'S PET CÁM ƠN QUÝ KHÁCH!", font6, brush, new Rectangle(15, product_total_pos_y + 130, 302, 30));
            //PictureBox picture_barcode = new PictureBox();
            //picture_barcode.Location = new System.Drawing.Point(0, product_total_pos_y + 80);
            //this.Controls.Add(picture_barcode);
            //Color forecolor = Color.Black;
            //Color backcolor = Color.Transparent;
            //Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, totalPrice +" - " + DateTime.Now.ToString("ddMMyyyy - HHmmss"), forecolor, backcolor, 275, 30); ;
            //picture_barcode.Image = barcode;
            //g.DrawImage(barcode, 0, product_total_pos_y + 130);
        }
        private void printReview_PrintPage(object sender, PrintPageEventArgs e)
        {
            pd_PrintPage(sender, e);
        }

        #endregion

        private void btnOrder_Click(object sender, EventArgs e)
        {
            dgvOrder.Visible = true;
            flowLayoutPanel1.Visible = false;
            i = 0;
            txtScanQR.Text = "Tìm Đơn Hàng...";
            string SQL = @"SELECT * FROM INVOICE WHERE Status = 'waiting' ORDER BY Invoice_Serial_Key DESC";
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
                    "", //Ngày Bán
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
                Show_Invoice_Detail(FormAddOrder.order_key);
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
            string SQL = @"SELECT I.* 
                            FROM PRODUCT_INFO I, PRODUCT_GROUP P
                            WHERE I.Product_Group_Serial_Key = P.Product_Group_Serial_Key
                            AND Product_Type_Serial_Key = 'PT0000000000001' 
                            AND Product_Status = '1'";
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
                    "", //Đơn Vị
                    reader["Product_Barcode"].ToString(), //Đơn Vị
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                isLeaving = true;
                txtSearch.Text = "Tìm Kiếm Sản Phẩm ...";
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string tim = "";
            if (isLeaving)
            {
                return;
            }
            if (txtSearch.Text.Length > 1)
            {
                tim = txtSearch.Text;
                string SQL = @"SELECT  Product_Id, 
								                Product_Name, 
								                isnull(Product_SubUnit,'') as subunit,
								                Product_Unit,
								                 ISNULL(Product_Sale_Price,'') as price,
								                ISNULL(Product_Sale_SubPrice,'') as subprice,
								                Product_Barcode,
								                Product_Status,
								                Product_Quantity
                                FROM PRODUCT_INFO P, PRODUCT_GROUP G
                                WHERE P.Product_Group_Serial_Key = G.Product_Group_Serial_Key
                                AND (Product_Name LIKE  N'%" + tim + @"%' 
                                    OR Product_Barcode LIKE  N'%" + tim + @"%')
                                AND Product_Type_Serial_Key = 'PT0000000000001' 
                                AND Product_Status = '1'    
                                AND P.Product_Total_Quantity > 0";
                OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
                OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
                odcConnect.Open();
                OleDbDataReader reader = odcCommand.ExecuteReader();
              
                dgvList.Rows.Clear();
                if (!reader.HasRows)
                {
                    return; // or do something else
                }
                int t = 1;
                int index = 0;
                while (reader.Read())
                {
                    bindComboboxColumn(reader["Product_Barcode"].ToString(), index);
                    decimal price = Convert.ToDecimal(reader["subunit"].ToString() == "" ? reader["price"] : reader["subprice"]);
                    dgvList.Rows.Add(new object[]
                    {
                    reader["Product_Id"].ToString(),
                    t,
                    reader["Product_Name"].ToString(),
                    price.ToString("#,##0"),
                    reader["Product_Quantity"].ToString(),
                    "",
                    reader["Product_Barcode"].ToString(),
                    reader["Product_Status"].ToString(),
                    });
                    t++;
                    dgvList.Rows[index].Cells["dcpUnit"].Value = reader["subunit"].ToString() == "" ? reader["Product_Unit"].ToString() : reader["subunit"].ToString();
                    index++;
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
            i = 1;
            txtScanQR.Text = "Quét Mã QR Code...";
            txtGiven.Text = "0";
            lblRemain.Text = "0";
            cbxSurcharge.Checked = false;
            chxDiscount.Checked = false;
            if (dgvOrder.CurrentRow.Cells[(int)dgv_enum.Surcharge].Value?.ToString() == null)
            {
                txtSurcharge.Text = "0";
            }
            else
            {
                txtSurcharge.Text = dgvOrder.CurrentRow.Cells[(int)dgv_enum.Surcharge].Value?.ToString();
            }
            Show_Invoice_Detail(Serial_Key); //Hiển thị chi tiết sản phẩm trong hóa đơn
            //isShowInvoiceDetail = true;
            Get_Invoice(Serial_Key); //Hiển thị TỔNG TIỀN (PHỤ THU, GIẢM GIÁ nếu có)
            txtScanQR.Focus();
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
            //if (!ReferenceEquals(sender, txtSearch)) //!(sender is Guna.UI.WinForms.GunaTextBox) ||
            //{
            //    // Ignore the event if it was not raised by the TextBox control
            //    return;
            //}
            //txtSearch.Text = "";
            if (txtSearch.Text == "Tìm Kiếm Sản Phẩm ...")
            {
                txtSearch.Text = string.Empty;
                isLeaving = false;
            }
        }
        private void cbxSurcharge_CheckedChanged(object sender, EventArgs e)
        {
            isShowInvoiceDetail = false;
            if (cbxSurcharge.Checked)
            {
                cbxSurcharge.ForeColor = Color.OrangeRed;
                lblUnit.ForeColor = Color.OrangeRed;
                txtSurcharge.Enabled = true;
                txtSurcharge.Focus();
                cbxSurcharge.Font = new Font(cbxSurcharge.Font.FontFamily, 10, cbxSurcharge.Font.Style);
                cbxSurcharge.Font = new Font(cbxSurcharge.Font.FontFamily, cbxSurcharge.Font.Size, FontStyle.Bold);
                cbxSurcharge.Size = new Size(75, 20);
                gia = Convert.ToDouble(lblTotalPrice.Text);
            }
            else
            {
                cbxSurcharge.ForeColor = Color.Gray;
                cbxSurcharge.Font = new Font(cbxSurcharge.Font.FontFamily, 8, cbxSurcharge.Font.Style);
                cbxSurcharge.Font = new Font(cbxSurcharge.Font.FontFamily, cbxSurcharge.Font.Size, FontStyle.Regular);
                cbxSurcharge.Size = new Size(71, 20);
                lblUnit.ForeColor = Color.Gray;
                txtSurcharge.Enabled = false;
                //if (lblTotalPrice.Text == "")
                //{
                //    lblTotalPrice.Text = "0";
                //}
                //lblTotalPrice.Text = gia.ToString("#,##0");
            }
        }

        private void txtScanQR_Leave(object sender, EventArgs e)
        {
            txtScanQR.Text = "Quét Mã QR Code...";
        }

        private void gunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Đảm bảo giá trị Value nằm trong phạm vi hợp lệ
            int maxValue = dgvList.RowCount - dgvList.DisplayedRowCount(true);
            int newValue = Math.Max(0, Math.Min(maxValue, gunaVScrollBar1.Value));

            // Gán giá trị Value mới
            gunaVScrollBar1.Value = newValue;

            // Đặt giá trị FirstDisplayedScrollingRowIndex của GunaDataGridView
            // để cuộn đến dòng mong muốn
            dgvList.FirstDisplayedScrollingRowIndex = newValue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save_Invoice();
            //Show_Invoice_Detail(lblSerialKey.Text);
            Reload_lblTotalPrice();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "")
            {
                if (decimal.TryParse(txtDiscount.Text, out decimal value))
                {
                    txtDiscount.Text = value.ToString("#,##0");
                    int length = txtDiscount.ToString().Length;
                    txtDiscount.SelectionStart = length;
                }
                else
                {
                    txtDiscount.Text = "0";
                }
            }
            else
            {
                txtDiscount.Text = "0";
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lblSerialKey.Text == "")
            {
                return;
            }
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xuất hóa đơn","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Save_Invoice();
                //if (CheckOut_Invoice(lblSerialKey.Text))
                //{
                    //btnOrder_Click(sender, e);
                    flowLayoutPanel1.Controls.Clear();
                    key_order = lblSerialKey.Text;
                    //tien_khach_dua = txtGiven.Text.Replace(".", "");
                    lblSerialKey.Text = "";
                    txtSurcharge.Text = "0";
                    txtDiscount.Text = "0";
                    lblTotalPrice.Text = "0";
                    txtGiven.Text = "";
                    lblRemain.Text = "";
                    PrintDocument pd = new PrintDocument();
                    //pd.PrinterSettings.PrinterName = @"\\192.168.30.70\EPSON L310 Series";
                    pd.PrinterSettings.PrinterName = @"POS-80C";
                    pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                    pd.Print();
                    //pvdCORPrint.Document = printReview;
                    //string a = ((ToolStrip)(pvdCORPrint.Controls[1])).Items.Count.ToString();
                    //((ToolStrip)(pvdCORPrint.Controls[1])).Items.RemoveByKey("printToolStripButton");
                    //pvdCORPrint.ShowDialog();
                }
            //}
            else
            {
                Save_Invoice();
                clsSql sql = new clsSql();
                if (CheckOut_Invoice(lblSerialKey.Text.Trim()))
                {
                    btnOrder_Click(sender, e);
                    flowLayoutPanel1.Controls.Clear();
                    key_order = lblSerialKey.Text;
                    //tien_khach_dua = txtGiven.Text.Replace(".", "");
                    lblSerialKey.Text = "";
                    txtSurcharge.Text = "0";
                    txtDiscount.Text = "0";
                    lblTotalPrice.Text = "0";
                    txtGiven.Text = "";
                    lblRemain.Text = "";
                }
            }
            MessageBox.Show("Thanh Toán Thành Công");
        }
        private void txtSurcharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lblTotalPrice.Text = (Convert.ToDouble(gia + Convert.ToDouble(txtSurcharge.Text.Trim())).ToString("#,##0"));
                Save_Invoice();
                Get_Invoice(lblSerialKey.Text.Trim());
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lblTotalPrice.Text = (Convert.ToDouble(gia - Convert.ToDouble(txtDiscount.Text.Trim())).ToString("#,##0"));
                Save_Invoice();
                Get_Invoice(lblSerialKey.Text.Trim());
            }
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
            }
            else
            {
                txtSurcharge.Text = "0";
            }
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox comboBox)
            {
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            string newValue = comboBox.SelectedItem.ToString(); // hoặc comboBox.Text; 

            DataGridView dataGridView = (DataGridView)comboBox.Parent.Parent;
            //int rowIndex = dataGridView.CurrentCell.RowIndex;
            //int columnIndex = dataGridView.CurrentCell.ColumnIndex;
        }

        private void dgvList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lblSerialKey.Text != "")
            {
                cbxSurcharge.Checked = false;
                string Invoice_Serial_Key = lblSerialKey.Text;
                string Product_ID = dgvList.CurrentRow.Cells[(int)dgv_list_enum.Product_ID].Value?.ToString();
                string Product_Name = dgvList.CurrentRow.Cells[(int)dgv_list_enum.Product_Name].Value?.ToString();
                string Product_Price = dgvList.CurrentRow.Cells[(int)dgv_list_enum.Product_Sale_Price].Value?.ToString();
                string Unit = dgvList.CurrentRow.Cells[(int)dgv_list_enum.Product_Unit].Value?.ToString();
                string Barcode = dgvList.CurrentRow.Cells[(int)dgv_list_enum.Product_Barcode].Value?.ToString();
                if (Add_Cart(Invoice_Serial_Key, Product_ID, Product_Name, Product_Price, Unit, Barcode))
                {
                    Save_Invoice();
                    Show_Invoice_Detail(Invoice_Serial_Key);
                    Reload_lblTotalPrice(); //Cập Nhật Lại Tổng Tiền
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Đơn Hàng");
            }
        }

        private void cbxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            isShowInvoiceDetail = false;
            if (chxDiscount.Checked)
            {
                lblUnitDisCount.ForeColor = Color.OliveDrab;
                txtDiscount.Enabled = true;
                txtDiscount.Focus();
                chxDiscount.Font = new Font(chxDiscount.Font.FontFamily, 10, chxDiscount.Font.Style);
                chxDiscount.Font = new Font(chxDiscount.Font.FontFamily, chxDiscount.Font.Size, FontStyle.Bold);
                chxDiscount.Size = new Size(75, 20);
                gia = Convert.ToDouble(lblTotalPrice.Text);
            }
            else
            {
                chxDiscount.ForeColor = Color.Gray;
                chxDiscount.Font = new Font(chxDiscount.Font.FontFamily, 8, chxDiscount.Font.Style);
                chxDiscount.Font = new Font(chxDiscount.Font.FontFamily, chxDiscount.Font.Size, FontStyle.Regular);
                chxDiscount.Size = new Size(71, 20);
                lblUnitDisCount.ForeColor = Color.Gray;
                //lblTotalPrice.Text = gia.ToString("#,##0");
                //txtDiscount.Text = "0";
                txtDiscount.Enabled = false;
            }
        }
    }
}
