using PetShop;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PetShop
{
    public class clsSql
    {
        
        #region Các Biến Cục Bộ
        public static string User_Login { get; set; }
        public static string User_FullName { get; set; }
        public static string User_Level { get; set; }

        private static string TaiKhoan;
        public string ID_SP { get; set; }
        public string Ten_SP { get; set; }
        public string Gia { get; set; }
        public string DVT { get; set; }
        public string SoLuong { get; set; }
        public string ID_HoaDon { get; set; }
        public string Ma_DH_Tim { get; set; }
        public string Ten_Nguoi_mua { get; set; }
        public string SDT_Nguoi_Mua { get; set; }
        public bool chek_tim { get; set; }
        public static int permission { get; set; }

        #endregion
        #region Code xử lý đăng nhập
        // kiểm tra đăng nhập from LogIn
        public bool Check_Login(string tk, string mk)
        {
            bool check = false;
            string sSQL = @"SELECT TOP 1 User_Serial_Key,User_Login,Password_Login,User_Full_Name,User_Level 
                            FROM USER_AD WHERE User_Login = '" + tk + "' and Password_Login = '" + mk + "' ";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            odcCommand.CommandTimeout = 120;
            odcConnect.Open();
            OleDbDataReader odr = odcCommand.ExecuteReader();
            if (odr.HasRows)
            {
                check = true;
                TaiKhoan = tk;
                while (odr.Read())
                {
                    permission = Convert.ToInt32(odr["User_Level"]);
                }
            }
            return check;
        }
        #endregion
        #region Code xử lý user - Tài khoản người dùng
        public static clsSql Get_Data_User()
        {
            clsSql ip = new clsSql();
            string sSQL = "SELECT TOP 1 User_Serial_Key,User_Login,Password_Login,User_Full_Name,User_Level from USER_AD where User_Login = '" + TaiKhoan + "'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            odcCommand.CommandTimeout = 120;
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            while (reader.Read())
            {
                clsSql.User_Login = reader["User_Login"].ToString();
                clsSql.User_FullName = reader["User_Full_Name"].ToString();
                clsSql.User_Level = reader["User_Level"].ToString();
            }
            return ip;
        }

        public void Get_user(DataGridView dgv)
        {
            string sSQL = "select  User_Serial_Key,User_Login,Password_Login,User_Full_Name,User_Level,User_Status,User_Phone, User_Time_In from USER_AD ";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            dgv.Rows.Clear();
            while (reader.Read())
            {
                string level_name = "";
                string Trang_thai = "";
                if (reader["User_Level"].ToString() == "1")
                {
                    level_name = "Chủ Shop";
                }
                else
                {
                    level_name = "Nhân Viên";
                }

                if (reader["User_Status"].ToString() == "0")
                {
                    Trang_thai = "Đang Làm";
                }
                else
                {
                    Trang_thai = "Đã Nghỉ";
                }

                dgv.Rows.Add(new object[] {
                    t,
                    reader["User_Serial_Key"].ToString(),
                    reader["User_Full_Name"].ToString(),
                    reader["User_Login"].ToString(),
                    reader["Password_Login"].ToString(),
                    reader["User_Time_In"].ToString(),
                    reader["User_Phone"].ToString(),
                    level_name,
                    Trang_thai
                });
                t++;
            }
        }

        public void Update_User(string tk)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string sSQL = @"UPDATE USER_AD set User_Status = '1' WHERE User_Login = '" + tk + "'";
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thao Tác Thành Công!");
                Cursor.Current = Cursors.Default;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Insert_User(string tk, string mk, string HoTen, string sdt)
        {
            string sSql = @"INSERT INTO USER_AD([User_Serial_Key]
                              ,[User_Login]
                              ,[Password_Login]
                              ,[User_Full_Name]
                              ,[User_Level]
                              ,[User_Status]
                              ,[User_Phone]
                              ,[User_Time_In]
                              ,[User_Modify_Time]) 
	                           VALUES('" + MAX_Key_User_AD() + "', '" + tk + "', '" + mk + "', N'" + HoTen + "','2','0','" + sdt + "',getdate(), getdate())";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(sSql, sqlConnect);            
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Thêm Thành Viên Thành Công");
            }
            catch { }
        }
        public void Update_User_info(string hoten, string tk, string mk,  string sdt, string key)
        {
            string sSQL = @"UPDATE USER_AD SET User_Login = '"+tk+"', Password_Login = '"+mk+"', User_Full_Name = N'"+hoten+"', User_Phone = '"+sdt+"' WHERE User_Serial_Key = '"+key+"' ";
            OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Thao Tác Thành Công!");
                //255,185,15
                //255,236,139
            }
            catch
            {

            }
            

        }
        public bool check_user(string tk)
        {
            bool check = false;
            string sSQL = @"SELECT TOP 1 User_Login FROM USER_AD WHERE User_Login = '"+tk+"'";
            OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            if(cmd.ExecuteNonQuery() != 0)
            {
                check = true;
            }
            else
            {
                check = false;
            }    
            return check;
        }
        #endregion

        #region Code xử lý sản phẩm - tồn kho chính xác

        public void getDataProductSaleMax(DataGridView dgv)
        {
            try
            {
                string sSQL = @"select distinct top 20 id.Product_Name, id.Product_Total, p.Product_Quantity, pt.Product_Type_Name
                                from INVOICE i, INVOICE_DETAIL id, PRODUCT_INFO p, PRODUCT_TYPE Pt
                                where i.Invoice_Serial_Key = id.Invoice  and p.Product_id = id.Product_id and pt.Product_Type_Serial_Key = p.Product_Type_Serial_Key
                                order by Product_Total desc";

                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                dgv.Rows.Clear();
                int t = 1;
                while (reader.Read())
                {
                    dgv.Rows.Add(new object[]
                    {
                        t,
                        reader["Product_Name"].ToString(),
                        reader["Product_total"].ToString(),
                        //String.Format("{0:#,0 VNĐ}", reader["tongtien"]),
                        reader["Product_Quantity"].ToString(),
                        reader["Product_Type_Name"].ToString(),
                        //reader["User_Status"].ToString()
                    });
                    t++;
                }
            }
            catch
            {

            }
        }
        public void Get_product(DataGridView dgv)
        {
            string sSQL = @"SELECT  p.Product_Serial_Key,
		                    p.Product_Id,
		                    p.Product_Name,
		                    p.Product_Quantity,
		                    p.Product_Cost_Price,
		                    p.Product_Sale_Price,
		                    p.Product_Date_In,
		                    c.Date_Product,
		                    c.Consignment_ID,
		                    pt.Product_Type_Name,
		                    pr.Product_Group_Name,
		                    c.Date_Expired,
		                    p.Sup_Name,
		                    p.Address_Sup,
                            p.Product_Status,
                            p.Note,
                            p.Product_Unit,
                            p.Product_Barcode
                    FROM PRODUCT_INFO p
	                    left join CONSIGNMENT c on c.Consignment_Serial_Key = p.Consignment_Serial_Key
	                    left join PRODUCT_TYPE pt on pt.Product_Type_Serial_Key = p.Product_Type_Serial_Key
	                    left join PRODUCT_GROUP pr on pr.Product_Group_Serial_Key = p.Product_Group_Serial_Key
                    --ORDER BY p.Product_Quantity ASC";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);

            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            string Status_Name = "";
            dgv.Rows.Clear();
            while (reader.Read())
            {
                string dateExpire = reader["Date_Expired"].ToString();
                string dateNow = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime convertDateExpired = Convert.ToDateTime(dateExpire);
                DateTime convertDateNow = Convert.ToDateTime(dateNow);
                //string a = (convertDateExpired - convertDateNow).ToString();
                //MessageBox.Show((convertDateExpired - convertDateNow).ToString());
                if (reader["Product_Status"].ToString() == "1" && DateTime.Now < convertDateNow)
                {
                    Status_Name = "Đang Kinh Doanh";
                }
                string cost_price = String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]);
                if (convertDateNow < convertDateExpired)
                {
                    Status_Name = "Đang Kinh Doanh";
                    for (int i = 0; i < dgv.RowCount; i++)
                    {

                        if (dgv.Rows[i].Cells[15].Value.ToString().Trim() == Status_Name.Trim())
                        {
                            dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Purple;
                        }
                    }
                    //string nd = reader["Name_device"].ToString().Trim();

                }
                else if (convertDateNow > convertDateExpired)
                {
                    Status_Name = "Ngưng Kinh Doanh";
                    for (int i = 0; i < dgv.RowCount; i++)
                    {

                        if (dgv.Rows[i].Cells[15].Value.ToString().Trim() == Status_Name.Trim())
                        {
                            dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Gray;
                            dgv.Rows[i].ReadOnly = true;
                        }
                    }
                }
                dgv.Rows.Add(new object[] {
                    t,
                    reader["Product_Serial_Key"].ToString(),
                    reader["Product_Id"].ToString(),
                    reader["Product_Name"].ToString(),
                    reader["Product_Quantity"].ToString(),
                    String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]),
                    String.Format("{0:#,0 VNĐ}", reader["Product_Sale_Price"]),
                    reader["Product_Date_In"].ToString(),
                    reader["Date_Product"].ToString(),
                    reader["Date_Expired"].ToString(),
                    reader["Consignment_ID"].ToString(),
                    reader["Product_Group_Name"].ToString(),
                    reader["Product_Type_Name"].ToString(),
                    reader["Sup_Name"].ToString(),
                    reader["Address_Sup"].ToString(),
                    Status_Name,
                    reader["Product_Unit"].ToString(),
                    reader["Product_Barcode"].ToString(),
                    reader["Note"].ToString(),


                });
                t++;

            }
        }

        //public void Get_Type_Product( ComboBox cbx)
        //{
        //    string sSql = @"SELECT Product_Type_Name from PRODUCT_TYPE";
        //    OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
        //    OleDbCommand odcCommand = new OleDbCommand(sSql, odcConnect);
        //    odcConnect.Open();
        //    OleDbDataReader read = odcCommand.ExecuteReader();
        //    while(read.Read())
        //    {
        //        cbx.Items.Add(read.GetString(0));
        //    }
        //    odcConnect.Dispose();
        //}

        public void Get_Group_Product(ComboBox cbx)
        {
            string sSql = @"SELECT Product_Group_Name from PRODUCT_GROUP";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSql, odcConnect);
            odcConnect.Open();
            OleDbDataReader read = odcCommand.ExecuteReader();
            while (read.Read())
            {
                cbx.Items.Add(read.GetString(0));
            }
            odcConnect.Dispose();
        }
        public void Get_Type_Product(ComboBox cbx)
        {
            string sSql = @"SELECT Product_Type_Name from PRODUCT_TYPE";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSql, odcConnect);
            odcConnect.Open();
            OleDbDataReader read = odcCommand.ExecuteReader();
            while (read.Read())
            {
                cbx.Items.Add(read.GetString(0));
            }
            odcConnect.Dispose();
        }


        public void Add_Product(string txtProductID, string txtProductBarcode, string txtProductName, string txtInventory, string CostPrice, string SalePrice, string Unit, string Note, string Sup_Name, string Address_Sup, string Product_Type_Serial_Key, string Product_Group_Serial_Key, string consignment_serial_key)
        {
            try
            {
                string sSQL = @"DECLARE @PRODUCT_SERIAL_KEY VARCHAR(10) = '000000000000', @NEW_NUMBER VARCHAR(15)
                            SELECT @NEW_NUMBER = RIGHT(MAX(Product_Serial_Key),13) + 1 FROM PRODUCT_INFO

                            SELECT @NEW_NUMBER = 'PR' + LEFT(@PRODUCT_SERIAL_KEY, 13 - LEN(@NEW_NUMBER)) + CONVERT(VARCHAR,@NEW_NUMBER)

                            INSERT INTO PRODUCT_INFO (
			                            [Product_Serial_Key]
                                      ,[Product_Id]
                                      ,[Product_Barcode]
                                      ,[Product_Name]
                                      ,[Product_Cost_Price]
                                      ,[Product_Sale_Price]
                                      ,[Product_Quantity]
                                      ,[Product_Unit]
                                      ,[Product_Date_In]
                                      ,[Note]
                                      ,[Product_Modify_Time]
                                      ,[Sup_Name]
                                      ,[Address_Sup]
                                      ,[Date_Modify_Time]
                                      ,[Product_Type_Serial_Key]
                                      ,[Product_Group_Serial_Key]
                                      ,[Consignment_Serial_Key]
                                    )
                            VALUES (@NEW_NUMBER,'" + txtProductID + "','" + txtProductBarcode + "',N'" + txtProductName + "','" + CostPrice + "','" + SalePrice + "','" + txtInventory + "',N'" + Unit + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',N'" + Note + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',N'" + Sup_Name + "',N'" + Address_Sup + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Product_Type_Serial_Key + "','" + Product_Group_Serial_Key + "', '" + consignment_serial_key + "')";

                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }


        }

        public void Update_Product(string product_key, string txtProductID, string txtProductBarcode, string txtProductName, string txtInventory, string CostPrice, string SalePrice, string Unit, string Note, string Sup_Name, string Address_Sup, string Product_Type_Serial_Key, string Product_Group_Serial_Key, string consignment_serial_key)
        {
            try
            {
                string sql_update = @"UPDATE PRODUCT_INFO 
                                    SET Product_id = '" + txtProductID + @"',
	                                    Product_Name = N'" + txtProductName + @"',
	                                    Product_Barcode = '" + txtProductBarcode + @"',
	                                    Product_Modify_Time = getdate(),
	                                    --Date_Modify_Time = getdate(),
	                                    Product_Cost_Price = '" + CostPrice + @"',
	                                    Product_Sale_Price = '" + SalePrice + @"',
	                                    Product_Quantity = '" + txtInventory + @"',
	                                    Product_Unit = N'" + Unit + @"',
	                                    Note = N'" + Note + @"',
	                                    Sup_Name = N'" + Sup_Name + @"',
	                                    Address_Sup = N'" + Address_Sup + @"',
	                                    Product_Type_Serial_Key = '" + Product_Type_Serial_Key + @"',
                                        Product_Group_Serial_Key = '" + Product_Group_Serial_Key + @"',
	                                    Consignment_Serial_Key = '" + consignment_serial_key + @"'
                                    WHERE Product_Serial_Key = '" + product_key + "'";

                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql_update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            catch
            {

            }

        }

        public void Product_Delete(string product_serial_key)
        {
            try
            {
                string delete_product = @"DELETE PRODUCT_INFO WHERE Product_Serial_Key = '" + product_serial_key.Trim() + "' ";
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(delete_product, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }

        }

        public string NonUnicode(string text)
        {
            // text = tksừ;
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                            "đ",
                                            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                                            "í","ì","ỉ","ĩ","ị",
                                            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                                            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                            "d",
                                            "e","e","e","e","e","e","e","e","e","e","e",
                                            "i","i","i","i","i",
                                            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                            "u","u","u","u","u","u","u","u","u","u","u",
                                            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            { //tksừ
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        public bool chek_Int(string so)
        {
            bool check = false;
            try
            {
                Convert.ToInt32(so);
                return check = true;
            }
            catch
            {
                return check;
            }
        }
        #endregion

        #region Form Orders
        public void Insert_Car(string invoice_date, string name, string sdt, string ngayhen, string tenPet)
        {
            string sql;
            if (name != "")
            {
                sql = @"INSERT INTO INVOICE (Invoice_Serial_Key,
                                                Invoice_Date,
                                                Name,
                                                Phone,
                                                Status,
                                                Date_Come_Back,
                                                Pet_Name)
                                                VALUES ('" + MAX_Invoice_Serial() + "','"+ invoice_date + "' ,N'" + name + "','" + sdt + "','waiting','" + ngayhen + "','" + tenPet + "')";
            }
            else
            {
                sql = "INSERT INTO INVOICE (Invoice_Serial_Key,Name,Phone,Status,Date_Come_Back,Pet_Name) VALUES ('" + MAX_Invoice_Serial() + "',N'Khách Vãng Lai','" + sdt + "','waiting','" + ngayhen + "','" + tenPet + "')";
            }
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(sql, sqlConnect);
            sqlCommand.CommandTimeout = 120;
            try
            {
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            catch { }
        }
        public static clsSql Get_SP(string msp)
        {
            clsSql ip = new clsSql();
            string sSQL = "select Product_Serial_Key, Product_Id,Product_Name,Product_Sale_Price,Product_Quantity,Product_Unit from PRODUCT_INFO where Product_Id = '" + msp + "'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            clsSql sqlquery = new clsSql();
            odcCommand.CommandTimeout = 120;
            odcConnect.Open();
            try
            {
                OleDbDataReader reader = odcCommand.ExecuteReader();
                while (reader.Read())
                {
                    //ip.product
                    ip.ID_SP = reader["Product_Id"].ToString();
                    ip.Ten_SP = reader["Product_Name"].ToString();
                    ip.Gia = reader["Product_Sale_Price"].ToString();
                    ip.DVT = reader["Product_Unit"].ToString();
                    ip.SoLuong = reader["Product_Quantity"].ToString();
                }
            }
            catch
            {

            }

            return ip;
        }
        public void Insert_Car_detail(string id_sp, string ten, string gia, string sl, string id_dh, string donvi)
        {
            string sqlselectProduct = "select Product_Quantity from PRODUCT_INFO where Product_Id = '" + id_sp + "'";
            OleDbConnection odcConnectProduct = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommandProduct = new OleDbCommand(sqlselectProduct, odcConnectProduct);
            odcConnectProduct.Open();
            try
            {
                int soluong = Convert.ToInt32(odcCommandProduct.ExecuteScalar());
                if (soluong > 0)
                {
                    string sqlselect = "select I.Product_Total,P.Product_Quantity from INVOICE_DETAIL I, PRODUCT_INFO P where I.Product_Id = '" + id_sp + "' and I.INVOICE = '" + id_dh + "' and I.Product_Id = P.Product_Id";
                    OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
                    OleDbCommand odcCommand = new OleDbCommand(sqlselect, sqlConnect);
                    sqlConnect.Open();
                    OleDbDataReader reader = odcCommand.ExecuteReader();

                    int soluongDH;
                    int soluongKHO;
                    string qty = "";
                    string qty_product = "";

                    while (reader.Read())
                    {
                        qty = reader["Product_Total"].ToString();
                        qty_product = reader["Product_Quantity"].ToString();

                    }

                    if (qty != "" || qty_product != "")
                    {
                        soluongDH = Convert.ToInt32(qty);
                        soluongKHO = Convert.ToInt32(qty_product);
                        soluong = soluong - soluongDH;
                    }
                    else
                    {
                        soluongDH = 0;
                    }
                    if (soluong > 0)
                    {
                        if (soluongDH >= 1)
                        {
                            soluongDH = soluongDH + 1;
                            string sqlupdete = "update INVOICE_DETAIL set Product_Total = '" + soluongDH + "' where Product_Id = '" + id_sp + "' and Invoice = '"+ id_dh + "'";
                            OleDbConnection odcConnectUpdate = new OleDbConnection(clsConnect.Connect_String);
                            OleDbCommand odcCommandUpdate = new OleDbCommand(sqlupdete, odcConnectUpdate);
                            odcConnectUpdate.Open();
                            odcCommandUpdate.ExecuteNonQuery();
                            odcConnectUpdate.Close();
                        }
                        else
                        {
                            string sql = @"insert into 
                          INVOICE_DETAIL(Invoice_Serial_Key, Product_Id, Product_Name, Product_Price, Product_Total, Invoice, Product_Unit)
                          values('" + MAX_Invoice_Detail_Serial_Key() + "', '" + id_sp + "', N'" + ten + "', " + gia + ", 1, '" + id_dh + "', '" + donvi + "')";
                            OleDbConnection sqlConnect1 = new OleDbConnection(clsConnect.Connect_String);
                            OleDbCommand sqlCommand1 = new OleDbCommand(sql, sqlConnect1);
                            sqlCommand1.CommandTimeout = 120;
                            try
                            {
                                sqlConnect1.Open();
                                sqlCommand1.ExecuteNonQuery();
                                sqlConnect1.Close();

                                //MessageBox.Show("Thêm Thành Viên Thành Công");
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        MessageBox.Show(ten + " Số Lượng Đã Hết Trong Kho");
                    }

                }
                else
                {
                    MessageBox.Show(ten + " Không Còn Trong Kho");
                }
            }
            catch
            {

            }


        }
        public static clsSql Get_ID_INVOICE()
        {
            clsSql ip = new clsSql();
            string sSql = "select top 1 Invoice_Serial_Key from INVOICE where Status = 'waiting' order by Invoice_Serial_Key desc";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSql, odcConnect);
            odcCommand.CommandTimeout = 120;

            try
            {
                odcConnect.Open();
                if (odcCommand.ExecuteNonQuery() != 0 && ip_check == "")
                {
                    ip.ID_HoaDon = odcCommand.ExecuteScalar().ToString();
                }
                else if (ip_check != "")
                {
                    ip.ID_HoaDon = ip_check;
                }
                else
                {
                    ip.ID_HoaDon = "";
                }
            }
            catch
            {

            }
            return ip;
        }
        public int Get_Invoice_Detail(DataGridView dgv, string id)
        {
            int tongtien = 0;
            string sSQL = "select Invoice_Serial_Key,Product_Id,Product_Name,Product_Price,Product_Total,Product_Unit,Invoice,(Product_Price * Product_Total) as tong from INVOICE_DETAIL where Invoice = '" + id + "'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            try
            {
                odcConnect.Open();
                OleDbDataReader reader = odcCommand.ExecuteReader();
                int t = 1;
                dgv.Rows.Clear();
                while (reader.Read())
                {
                    dgv.Rows.Add(new object[] {
                    t,
                    reader["Invoice_Serial_Key"].ToString(),
                    reader["Product_Name"].ToString(),
                    reader["Product_Total"].ToString(),
                    reader["Product_Price"].ToString(),
                    reader["Product_Unit"].ToString(),
                    reader["Invoice"].ToString(),
                    reader["tong"].ToString(),
                    reader["Product_Id"].ToString(),
                });
                    tongtien = tongtien + Convert.ToInt32(reader["tong"]);
                    t++;
                }
            }
            catch
            {

            }

            return tongtien;
        }
        public void Update_Invoice_Detail(string user_id, string tongtien, string id_dh)
        {
            string sSQL = "update INVOICE set Total_Price = '" + tongtien + "', Invoice_Date = GETDATE(), User_id = '" + user_id + "', Status = 'Done' where Invoice_Serial_Key = '" + id_dh + "'";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(sSQL, sqlConnect);
            sqlCommand.CommandTimeout = 120;
            try
            {
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                string SQL = @"select I.Product_Id,I.Product_Name,I.Product_Total,P.Product_Quantity from INVOICE_DETAIL I, PRODUCT_INFO P
                                where I.Product_Id = P.Product_Id
                                and I.Invoice = '" + id_dh + "'";
                OleDbCommand odcCommand = new OleDbCommand(SQL, sqlConnect);
                sqlConnect.Open();
                OleDbDataReader reader = odcCommand.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader["Product_Id"].ToString();
                    string qty = reader["Product_Total"].ToString();
                    string qty_product = reader["Product_Quantity"].ToString();
                    int result = Convert.ToInt32(qty_product) - Convert.ToInt32(qty);
                    Update_Qty_Product(id, result);
                }
            }
            catch { }
        }
        private void Update_Qty_Product(string product_id, int result)
        {
            string SQL = @"update PRODUCT_INFO set Product_Quantity = '" + result + "' where Product_Id = '" + product_id + @"'";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(SQL, sqlConnect);
            try
            {
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            catch (Exception exg)
            {

            }
        }
        public void Update_Quatity_Invoice_Detail(string Key_Invoice_Detail, string sl, string id_sp)
        {
            string sql = "select Product_Quantity from PRODUCT_INFO where Product_Id = '" + id_sp + "'";
            OleDbConnection sqlConnectSelect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommandSelect = new OleDbCommand(sql, sqlConnectSelect);
            try
            {
                sqlConnectSelect.Open();
                int soluong = Convert.ToInt32(sqlCommandSelect.ExecuteScalar());
                int sl_detail = Convert.ToInt32(sl);
                sqlConnectSelect.Close();
                if ((soluong - sl_detail) > 0)
                {
                    if (sl_detail <= 0)
                    {
                        string sqlDelete = "delete INVOICE_DETAIL where Invoice_Serial_Key = '" + Key_Invoice_Detail + "'";
                        OleDbConnection sqlconnetDelete = new OleDbConnection(clsConnect.Connect_String);
                        OleDbCommand sqlCommandDelete = new OleDbCommand(sqlDelete, sqlconnetDelete);
                        sqlconnetDelete.Open();
                        sqlCommandDelete.ExecuteNonQuery();
                        sqlconnetDelete.Close();
                    }
                    else
                    {
                        string sqlUpdate = "update INVOICE_DETAIL set Product_Total = '" + sl + "' where Invoice_Serial_Key = '" + Key_Invoice_Detail + "'";
                        OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
                        OleDbCommand sqlCommand = new OleDbCommand(sqlUpdate, sqlConnect);
                        sqlConnect.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Số Lượng Trong Kho Chỉ Còn: " + soluong);
                }
            }
            catch
            {

            }
        }
        public void Delete_Invoice_Detail(string ma_chitiet_hd)
        {
            string sql = "delete INVOICE_DETAIL where Invoice_Serial_Key = '" + ma_chitiet_hd + "'";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(sql, sqlConnect);
            try
            {
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            catch
            {

            }
        }


        public static string ip_check = "";
        public clsSql Check_tim_dh(string sdt)
        {

            clsSql ip = new clsSql();
            ip.chek_tim = false;

            string sqltim = "select top 1 Invoice_Serial_Key,Name,Phone from INVOICE where Phone = '" + sdt + "' and Status = 'waiting' order by Invoice_Serial_Key desc";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sqltim, odcConnect);
            try
            {
                odcConnect.Open();
                if (odcCommand.ExecuteNonQuery() != 0)
                {
                    OleDbDataReader reader = odcCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        ip.Ma_DH_Tim = reader["Invoice_Serial_Key"].ToString();
                        ip.Ten_Nguoi_mua = reader["Name"].ToString();
                        ip.SDT_Nguoi_Mua = reader["Phone"].ToString();
                        ip.chek_tim = true;
                        ip_check = ip.Ma_DH_Tim;
                    }
                }
                else
                {
                    //MessageBox.Show("Mã Đơn Hàng Không Đúng");
                    ip.chek_tim = false;
                }
            }
            catch
            {

            }

            return ip;
        }

        public void set_ip_check()
        {
            ip_check = "";
        }
        public bool check_sdt(string sdt)
        {
            bool check = false;
           
            string sql = "select * from INVOICE where Phone = '" + sdt + "' and Status = 'waiting'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sql, odcConnect);
            odcCommand.CommandTimeout = 120;
            odcConnect.Open();
            if (odcCommand.ExecuteNonQuery() != 0)
            {
                //MessageBox.Show("Số Điện Thoại Này Đã Tạo Hóa Đơn Và Chưa Thanh Toán");
            }
            else
            {
                check = true;
            }

            if (sdt.Length == 0)
            {
                check = true;
            }
            return check;
        }
        string soluongkho;
        string ten;
        public void update_Note(string note, string key)
        {
            string SQL = @"update INVOICE set Note = N'" + note + "' where Invoice_Serial_Key = '" + key + "'";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(SQL, sqlConnect);
            try
            {
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            catch (Exception exg)
            {

            }
        }
        public bool Thanh_toan(string MHD)
        {
            bool check = false;
            bool check_sl = true;

            string sql = @"select pr.Product_Name,Pr.Product_Id,pr.Product_Quantity,id.Product_Total, (pr.Product_Quantity - id.Product_Total) as sanPham_dathanhtoan from PRODUCT_INFO Pr left join INVOICE_DETAIL id on id.Product_Id = pr.Product_Id where id.Invoice = '" + MHD + "'";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(sql, sqlConnect);
            sqlConnect.Open();
            OleDbDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string ten_sp = reader["Product_Name"].ToString();
                string sl_kho = reader["Product_Quantity"].ToString();
                string sl_sau_tru = reader["sanPham_dathanhtoan"].ToString();
                if (Convert.ToInt32(sl_sau_tru) < 0)
                {
                    soluongkho = sl_kho;
                    ten = ten_sp;
                    check_sl = false;
                }

            }
            if (check_sl == true)
            {
                string sql_update = @"UPDATE PRODUCT_INFO SET Product_Quantity = (pr.Product_Quantity - id.Product_Total) from PRODUCT_INFO Pr left join INVOICE_DETAIL id on id.Product_Id = pr.Product_Id where id.Invoice = '" + MHD + "'";
                OleDbConnection sqlConnect_update = new OleDbConnection(clsConnect.Connect_String);
                OleDbCommand sqlCommand_update = new OleDbCommand(sql_update, sqlConnect);
                sqlConnect_update.Open();
                sqlCommand_update.ExecuteNonQuery();
                sqlConnect_update.Close();
                MessageBox.Show("Thêm thành công");
                check = true;
                return check;
            }
            else
            {
                MessageBox.Show("Số lượng trong kho của: " + ten + " còn lại là " + soluongkho);
                check = false;
                return check;
            }
        }
        public void update_invoid(string MHD, string user, string gia, string phuthu)
        {
            string sql = "update INVOICE set Total_Price = '" + gia + @"',
                                            Invoice_Date = GETDATE(),
                                            User_id = '" + user + @"',
                                            Status = 'Done' ,
                                            --Surcharge = '" + phuthu + @"'
                                            Surcharge = '0'
                                            where Invoice_Serial_Key = '" + MHD + "'";
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand sqlCommand = new OleDbCommand(sql, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
        #endregion

        #region FormInvoice

        public int show_Invoice(DataGridView dgv, RadioButton thanhtoan, RadioButton dangcho, RadioButton taikham, RadioButton dichvu, DateTimePicker tu, DateTimePicker den, string sdt)
        {
            int tonghd = 0;
            string sql = "";
            if (thanhtoan.Checked && sdt == "")
            {
                sql = @"  select Invoice_Serial_Key,isnull(Total_Price,0) as Total_Price,Invoice_Date,Name,Phone,User_id,Status,Date_Come_Back,Pet_Name,Note 
                              from INVOICE
                              where Status = 'Done' and convert(date,Invoice_Date) between  '" + tu.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "' and  '" + den.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "'";
            }
            else if (dangcho.Checked && sdt == "")
            {
                sql = @"  select Invoice_Serial_Key,isnull(Total_Price,0) as Total_Price,Invoice_Date,Name,Phone,User_id,Status,Date_Come_Back,Pet_Name,Note 
                              from INVOICE
                              where Status = 'waiting' and convert(date,Invoice_Date) between  '" + tu.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "' and  '" + den.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "'";
            }
            else if (taikham.Checked && sdt == "")
            {
                sql = @"  select Invoice_Serial_Key,isnull(Total_Price,0) as Total_Price,Invoice_Date,Name,Phone,User_id,Status,Date_Come_Back,Pet_Name,Note 
                              from INVOICE
                              where Status = 'Done' and convert(date,Date_Come_Back) between  '" + tu.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "' and  '" + den.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "'";
            }
            else if (dichvu.Checked && sdt == "")
            {
                sql = @"select i.Invoice_Serial_Key,isnull(i.Total_Price,0) as Total_Price,i.Invoice_Date,i.Name,i.Phone,i.User_id,i.Status,i.Date_Come_Back,i.Pet_Name,Note 
                              from INVOICE i
							  left join INVOICE_DETAIL id on i.Invoice_Serial_Key = id.Invoice
                              where Status = 'done' and convert(date,Invoice_Date) between '" + tu.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "'  and  '" + den.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "' and left(id.Product_Id,2) = 'DV'";
            }
            else if (sdt != "")
            {
                sql = @"select Invoice_Serial_Key,isnull(Total_Price,0) as Total_Price,Invoice_Date,Name,Phone,User_id,Status,Date_Come_Back,Pet_Name,Note 
                              from INVOICE
                              where phone = '" + sdt + "' and convert(date,Invoice_Date) between  '" + tu.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "' and  '" + den.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "'";
            }
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sql, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            dgv.Rows.Clear();
            string ngay_hen = "";
            while (reader.Read())
            {
                if (reader["Date_Come_Back"].ToString() == "1900-01-01")
                {
                    ngay_hen = "";
                }
                else
                {
                    ngay_hen = reader["Date_Come_Back"].ToString();
                }
                dgv.Rows.Add(new object[] {
                    t,
                    reader["Invoice_Serial_Key"].ToString(),
                    reader["Total_Price"].ToString(),
                    reader["Invoice_Date"].ToString(),
                    reader["Name"].ToString(),
                    reader["Phone"].ToString(),
                    reader["User_id"].ToString(),
                    reader["Status"].ToString(),
                    //reader["Date_Come_Back"].ToString(),
                    ngay_hen,
                    reader["Pet_Name"].ToString(),
                    reader["Note"].ToString(),
                });
                t++;
                tonghd = tonghd + Convert.ToInt32(reader["Total_Price"].ToString());
            }

            return tonghd;
        }

        public void show_Invoice_Detail(DataGridView dgv, string id)
        {
            string sql = @"select 
                            Invoice_Serial_Key
                            ,Product_Id
                            ,Product_Name
                            ,Product_Price
                            ,Product_Total
                            ,Invoice
                            ,Product_Unit 
                            ,(Product_Price * Product_Total) as tong
                            from INVOICE_DETAIL 
                            where Invoice = '" + id + "'";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sql, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 1;
            dgv.Rows.Clear();
            while (reader.Read())
            {
                dgv.Rows.Add(new object[] {
                    t,
                    reader["Invoice_Serial_Key"].ToString(),
                    reader["Product_Id"].ToString(),
                    reader["Product_Name"].ToString(),
                    reader["Product_Price"].ToString(),
                    reader["Product_Total"].ToString(),
                    reader["Invoice"].ToString(),
                    reader["Product_Unit"].ToString(),
                    reader["tong"].ToString(),
                });
                t++;

            }
        }
        #endregion

        #region Các hàm lấy KEY lớn nhất
        // lấy key Invoice_DETAIL_Serial_Key
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
        // lấy key Invoice_Serial_Key
        private static string MAX_Invoice_Serial()
        {
            string sData = "";
            int iCount = 0;
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            string sSQL = "SELECT MAX(Invoice_Serial_Key) AS Invoice_Serial_Key FROM INVOICE WHERE Invoice_Serial_Key LIKE 'IN%'";
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
        private static string MAX_Key_User_AD()
        {
            string sData = "";
            int iCount = 0;
            OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
            string sSQL = "SELECT MAX(User_Serial_Key) AS User_Serial_Key FROM USER_AD WHERE User_Serial_Key LIKE 'US%'";
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
                sData = "US0000000000001";
            else
            {
                iCount = Convert.ToInt32(sData.Replace("US", "")) + 1;
                sData = "US" + string.Format("{0:0000000000000}", iCount);
            }
            return sData;
        }
        #endregion        
    }
}
