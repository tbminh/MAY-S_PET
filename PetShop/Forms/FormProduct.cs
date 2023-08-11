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
using System.Drawing.Printing;
using BarcodeLib;
using PetShop.CS;

namespace PetShop.Forms
{
    public partial class FormProduct : Form
    {
        public static string Product_Serial_Key_Send = "";
        public static string Product_Id_Send = "";
        public static string Product_Name_Send = "";
        public static string Product_Quantity_Send = "";
        public static string Product_Cost_Price_Send = "";
        public static string Product_Sale_Price_Send = "";
        public static string Product_Date_In_Send;
        public static string Product_Date_Send = DateTime.Now.ToString("yyyy/MM/dd");
        public static string Product_Expired_Date_Send = DateTime.Now.ToString("yyyy/MM/dd");
        public static string Product_Consignment_ID_Send = "";
        public static string Product_Group_Name_Send = "";
        public static string Product_Type_Name_Send = "";
        public static string Product_Sup_Name_Send = "";
        public static string Product_Address_Sup_Send = "";
        public static string Product_Status_Name_Send = "";
        public static string Product_Unit_Send = "";
        public static string Product_Barcode_Send = "";
        public static string Product_Note_Send = "";
        public FormProduct()
        {
            InitializeComponent();
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            clsSql sql = new clsSql();
            sql.Get_Group_Product(cbxGroup);
            sql.getDataProductSaleMax(dgvListProductSaleMax);
            txtFindProduct.Focus();
        }
        enum dgvenum : int
        {
            Check,
            Product_Serial_Key,
            Product_Id,
            Product_Name,
            Product_Quantity,
            Product_Cost_Price,
            Product_Sale_Price,
            Date_Product,
            Date_Expired,
            Consignment_ID,
            Product_Group_Name,
            Product_Type_Name,
            Sup_Name,
            Address_Sup,
            Product_Unit,
            Product_Barcode,
            Note,
        }
        private void txtFindProduct_OnTextChange(object sender, EventArgs e)
        {
            string sSQL = $@"SELECT		P.Product_Serial_Key,
		                                P.Product_Id,
		                                P.Product_Name,
		                                P.Product_Quantity,
		                                P.Product_Cost_Price,
		                                P.Product_Sale_Price,
		                                ISNULL(P.Date_Expired,'') as expire,
		                                C.Consignment_ID,
		                                PR.Product_Group_Name, --Nhóm hàng
		                                S.Supplier_Name,
                                        P.Product_Unit,
                                        P.Product_Barcode,
                                        P.Note
                                                FROM PRODUCT_INFO P
	                                                LEFT JOIN CONSIGNMENT C ON C.Consignment_Serial_Key = P.Consignment_Serial_Key
	                                                LEFT JOIN PRODUCT_GROUP PR ON PR.Product_Group_Serial_Key = P.Product_Group_Serial_Key
						                            LEFT JOIN SUPPLIER S ON S.Supplier_serial_key = C.Supplier_serial_key
                                                WHERE   (P.Product_Name LIKE N'%'+ '{txtFindProduct.Text.Trim()}' + '%' 
							                            OR P.Product_Barcode LIKE N'%'+ '{txtFindProduct.text.Trim()}' + '%')
						                            AND PR.Product_Type_Serial_Key = 'PT0000000000001'
					                            ORDER BY p.Product_Quantity ASC";

            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 0;
            dgvProduct.Rows.Clear();
            while (reader.Read())
            {
                string dateExpire = reader["expire"].ToString();
                string dateNow = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime convertDateExpired = Convert.ToDateTime(dateExpire);
                DateTime convertDateNow = Convert.ToDateTime(dateNow);

                string cost_price = String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]);
                dgvProduct.Rows.Add(new object[] {
                        true,
                        reader["Product_Serial_Key"].ToString(),
                        reader["Product_Id"].ToString(),
                        reader["Product_Name"].ToString(),
                        reader["Product_Quantity"].ToString(),
                        String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]),
                        String.Format("{0:#,0 VNĐ}", reader["Product_Sale_Price"]),
                        reader["expire"].ToString(),
                        reader["Consignment_ID"].ToString(),
                        reader["Product_Group_Name"].ToString(),
                        reader["Supplier_Name"].ToString(),
                        reader["Product_Unit"].ToString(),
                        reader["Product_Barcode"].ToString(),
                        reader["Note"].ToString()
                });
                if (convertDateNow <= convertDateExpired)
                {
                    dgvProduct.Rows[t].DefaultCellStyle.ForeColor = Color.Purple;
                }
                else
                {
                    dgvProduct.Rows[t].DefaultCellStyle.ForeColor = Color.Gray;
                }
                t++;
            }
        }

        private void dgvProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.CurrentRow.DefaultCellStyle.ForeColor == Color.Gray && dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Type_Name].Value.ToString() != "Dịch Vụ")
            {
                MessageBox.Show("Lô hàng đã hết hạn sử dụng");
            }
            else
            { 
                Product_Serial_Key_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Serial_Key].Value.ToString();
                Product_Id_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Id].Value.ToString();
                Product_Name_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Name].Value.ToString();
                Product_Quantity_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Quantity].Value.ToString();
                Product_Cost_Price_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Cost_Price].Value.ToString();
                Product_Sale_Price_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Sale_Price].Value.ToString();
               //Product_Consignment_ID_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Consignment_ID].Value.ToString();
                Product_Date_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Date_Product].Value.ToString();
                Product_Expired_Date_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Date_Expired].Value.ToString();
                Product_Group_Name_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Group_Name].Value.ToString();
                Product_Type_Name_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Type_Name].Value.ToString();
                Product_Sup_Name_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Sup_Name].Value.ToString();
                Product_Address_Sup_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Address_Sup].Value.ToString();
                Product_Unit_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Unit].Value.ToString();
                Product_Barcode_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Product_Barcode].Value.ToString();
                Product_Note_Send = dgvProduct.CurrentRow.Cells[(int)dgvenum.Note].Value.ToString();
                var f2 = new FormAddProduct();
                //f2.GetStringFromAnotherForm += new frmPartial_In_Out.MyDelegate(GetContentValueBarcode);
                MaskedDialog.ShowDialog(this, f2);
                f2.Dispose();
                Product_Serial_Key_Send = "";
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            var f2 = new FormAddProduct();
            //f2.GetStringFromAnotherForm += new frmPartial_In_Out.MyDelegate(GetContentValueBarcode);
            MaskedDialog.ShowDialog(this, f2);
            f2.Dispose();
            f2 = null;
        }

        private void cbxGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sSQL = @"SELECT  P.Product_Serial_Key,
		                            P.Product_Id,
		                            P.Product_Name,
		                            P.Product_Quantity,
		                            P.Product_Cost_Price,
		                            P.Product_Sale_Price,
		                            ISNULL(P.Date_Expired,'') as expire,
		                            C.Consignment_ID,
		                            PR.Product_Group_Name, --Nhóm hàng
		                            S.Supplier_Name,
                                    P.Product_Unit,
                                    P.Product_Barcode,
                                    P.Note
                                    FROM PRODUCT_INFO P
	                                    LEFT JOIN CONSIGNMENT C ON C.Consignment_Serial_Key = P.Consignment_Serial_Key
	                                    LEFT JOIN PRODUCT_GROUP PR ON PR.Product_Group_Serial_Key = P.Product_Group_Serial_Key
						                LEFT JOIN SUPPLIER S ON S.Supplier_serial_key = C.Supplier_serial_key
                                    WHERE  PR.Product_Type_Serial_Key = 'PT0000000000001'
                                    AND  PR.Product_Group_Name = N'" + cbxGroup.Text + @"' 
                                    ORDER BY p.Product_Quantity ASC";

            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 0;
            dgvProduct.Rows.Clear();
            while (reader.Read())
            {
                string dateExpire = reader["expire"].ToString();
                string dateNow = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime convertDateExpired = Convert.ToDateTime(dateExpire);
                DateTime convertDateNow = Convert.ToDateTime(dateNow);

                string cost_price = String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]);
                dgvProduct.Rows.Add(new object[] {
                        true,
                        reader["Product_Serial_Key"].ToString(),
                        reader["Product_Id"].ToString(),
                        reader["Product_Name"].ToString(),
                        reader["Product_Quantity"].ToString(),
                        String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]),
                        String.Format("{0:#,0 VNĐ}", reader["Product_Sale_Price"]),
                        reader["expire"].ToString(),
                        reader["Consignment_ID"].ToString(),
                        reader["Product_Group_Name"].ToString(),
                        reader["Supplier_Name"].ToString(),
                        reader["Product_Unit"].ToString(),
                        reader["Product_Barcode"].ToString(),
                        reader["Note"].ToString()
                });
                if (convertDateNow <= convertDateExpired)
                {
                    dgvProduct.Rows[t].DefaultCellStyle.ForeColor = Color.Purple;
                }
                else
                {
                    dgvProduct.Rows[t].DefaultCellStyle.ForeColor = Color.Gray;
                }
                t++;
            }
        }
        List<Log_Print_Label> QRCode = new List<Log_Print_Label>();
        public static int PageNum, PageNumRun = 1, CardNum, x, y, stock_count = 0;
        public static int StartNum, size_preview = 12, EndNum = 1, dang1;

        private void chxExpiry_CheckedChanged(object sender, EventArgs e)
        {
            if (chxExpiry.Checked == true)
            {
                chxExpiry.ForeColor = Color.LimeGreen;
                if (chxExpire.Checked) chxExpire.Checked = false;
                string sSQL = @"SELECT  p.Product_Serial_Key,
		                                p.Product_Id,
		                                p.Product_Name,
		                                p.Product_Quantity,
		                                p.Product_Cost_Price,
		                                p.Product_Sale_Price,
		                                c.Consignment_ID,
		                                pr.Product_Group_Name,
		                                p.Date_Expired,
		                                s.Supplier_Name,
                                        p.Note,
                                        p.Product_Unit,
                                        p.Product_Barcode
                                FROM PRODUCT_INFO p
	                            LEFT JOIN CONSIGNMENT c ON c.Consignment_Serial_Key = p.Consignment_Serial_Key
						        LEFT JOIN SUPPLIER s ON s.Supplier_serial_key = c.Supplier_serial_key
	                            LEFT JOIN PRODUCT_GROUP pr ON pr.Product_Group_Serial_Key = p.Product_Group_Serial_Key
                                WHERE Product_Status = 1";
                OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
                OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);

                odcConnect.Open();
                OleDbDataReader reader = odcCommand.ExecuteReader();
                int i = 0;
                dgvProduct.Rows.Clear();
                while (reader.Read())
                {
                    string dateExpire = reader["Date_Expired"].ToString();
                    string dateNow = DateTime.Now.ToString("yyyy-MM-dd");
                    DateTime convertDateExpired = Convert.ToDateTime(dateExpire);
                    DateTime convertDateNow = Convert.ToDateTime(dateNow);
                    //string a = (convertDateExpired - convertDateNow).ToString();
                    //string cost_price = String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]);
                    dgvProduct.Rows.Add(new object[] {
                        true,
                        reader["Product_Serial_Key"].ToString(),
                        reader["Product_Id"].ToString(),
                        reader["Product_Name"].ToString(),
                        reader["Product_Quantity"].ToString(),
                        String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]), //Giá Bán
                        String.Format("{0:#,0 VNĐ}", reader["Product_Sale_Price"]), //Giá Vốn
                        reader["Date_Expired"].ToString(),
                        reader["Consignment_ID"].ToString(), //Lô Hàng
                        reader["Product_Group_Name"].ToString(), //Nhóm hàng
                        reader["Supplier_Name"].ToString(),
                        reader["Product_Unit"].ToString(),
                        reader["Product_Barcode"].ToString(),
                        reader["Note"].ToString()
                    });
                    dgvProduct.Rows[i].DefaultCellStyle.ForeColor = Color.Purple;
                    i++;
                }
            }
            else
            {
                chxExpiry.ForeColor = Color.DimGray;
                txtFindProduct.Focus();
                clsSql sql = new clsSql();
                sql.Get_product(dgvProduct);
            }
        }

        private void chxExpire_CheckedChanged(object sender, EventArgs e)
        {
            if (chxExpire.Checked == true)
            {
                chxExpire.ForeColor = Color.OrangeRed;
                if (chxExpiry.Checked) chxExpiry.Checked = false;
                string sSQL = @"SELECT  p.Product_Serial_Key,
		                                p.Product_Id,
		                                p.Product_Name,
		                                p.Product_Quantity,
		                                p.Product_Cost_Price,
		                                p.Product_Sale_Price,
		                                c.Consignment_ID,
		                                pr.Product_Group_Name,
		                                p.Date_Expired,
		                                s.Supplier_Name,
                                        p.Note,
                                        p.Product_Unit,
                                        p.Product_Barcode
                                FROM PRODUCT_INFO p
	                            LEFT JOIN CONSIGNMENT c ON c.Consignment_Serial_Key = p.Consignment_Serial_Key
						        LEFT JOIN SUPPLIER s ON s.Supplier_serial_key = c.Supplier_serial_key
	                            LEFT JOIN PRODUCT_GROUP pr ON pr.Product_Group_Serial_Key = p.Product_Group_Serial_Key
                                WHERE Product_Status = 0";
                OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
                OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);

                odcConnect.Open();
                OleDbDataReader reader = odcCommand.ExecuteReader();
                int i = 0;
                dgvProduct.Rows.Clear();
                while (reader.Read())
                {
                    dgvProduct.Rows.Add(new object[] {
                        true,
                        reader["Product_Serial_Key"].ToString(),
                        reader["Product_Id"].ToString(),
                        reader["Product_Name"].ToString(),
                        reader["Product_Quantity"].ToString(),
                        String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]), //Giá Bán
                        String.Format("{0:#,0 VNĐ}", reader["Product_Sale_Price"]), //Giá Vốn
                        reader["Date_Expired"].ToString(),
                        reader["Consignment_ID"].ToString(), //Lô Hàng
                        reader["Product_Group_Name"].ToString(), //Nhóm hàng
                        reader["Supplier_Name"].ToString(),
                        reader["Product_Unit"].ToString(),
                        reader["Product_Barcode"].ToString(),
                        reader["Note"].ToString()
                    });
                    dgvProduct.Rows[i].DefaultCellStyle.ForeColor = Color.Gray;
                    i++;
                }
            }
            else
            {
                chxExpire.ForeColor = Color.DimGray;
                txtFindProduct.Focus();
                clsSql sql = new clsSql();
                sql.Get_product(dgvProduct);
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the CellContentClick event was triggered by a click on the checkbox column (index 0).
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dgvProduct.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Get the current checkbox cell.
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Toggle the checkbox value.
                checkboxCell.Value = !(bool)checkboxCell.Value;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dgvProduct.RowCount; i++)
            //{
            //    dang1 = i;
            //    PrintDocument pd = new PrintDocument();
            //    pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            //    pd.Print();
            //}
            //MessageBox.Show("In hoàn thành!");
            StartNum = 1;
            EndNum = 1;
            PageNum = 1;
            PageNumRun = 1;
            QRCode.Clear();
            Log_Print_Label log = new Log_Print_Label();
            for (int i = 0; i < dgvProduct.RowCount; i++)
            {
                if (dgvProduct.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    log.Material_Name = dgvProduct.Rows[i].Cells["Product_Name"].Value.ToString().Trim();
                    log.Expire_Date = Convert.ToDateTime(dgvProduct.Rows[i].Cells["Date_Expired"].Value.ToString().Trim());
                    log.Sale_Price = dgvProduct.Rows[i].Cells["Product_Sale_Price"].Value.ToString().Trim();
                    log.Barcode = dgvProduct.Rows[i].Cells["Product_Barcode"].Value.ToString().Trim();
                    QRCode.Add(log);
                    stock_count = stock_count + 1;
                }
            }
            if (CardNum % size_preview == 0)
            {
                PageNum = CardNum / size_preview;
            }
            else
            {
                PageNum = (CardNum / size_preview) + 1;
            }
            pvdCORPrint.Document = printReview;
            string a = ((ToolStrip)(pvdCORPrint.Controls[1])).Items.Count.ToString();
            ((ToolStrip)(pvdCORPrint.Controls[1])).Items.RemoveByKey("printToolStripButton");
            pvdCORPrint.ShowDialog();
        }
        private void printReview_PrintPage(object sender, PrintPageEventArgs e)
        {
            string Material_Name = "";
            string Expire_Date = "";
            string Sale_Price = "";
            string Barcode = "";
            BarcodeLib.Barcode code128;
            code128 = new Barcode();
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
            int Size_QR = 120; //80
            int size_preview = 12;

            StartNum = (PageNumRun - 1) * size_preview + 1;
            if (CardNum - StartNum >= size_preview)
                EndNum = StartNum + (size_preview - 1);
            else
                EndNum = CardNum;

            for (int i = StartNum; i <= EndNum; i++)
            {
                Material_Name = QRCode[i].Material_Name.ToString();
                Expire_Date = QRCode[i].Expire_Date.ToString("dd/MM/yyyy");
                Sale_Price = QRCode[i].Sale_Price.ToString();
                Barcode = QRCode[i].Barcode.ToString();
                Graphics g = e.Graphics;
                //Material Name 
                g.DrawString(Material_Name, font2, brush, new Rectangle(0, 0, 144, 55));
                //g.DrawRectangle(pen, new Rectangle(1, 92, 302, 40));                
                g.DrawString("HSD: " + Expire_Date, font2, brush, new Rectangle(0, 50, 144, 30));
                //g.DrawRectangle(pen, new Rectangle(1, 122, 302, 40));
                g.DrawString("Giá bán: " + Sale_Price, font2, brush, new Rectangle(0, 65, 144, 30));
                //Địa chỉ Shop
                Color forecolor = Color.Black;
                Color backcolor = Color.Transparent;
                string a = "893684456314";
                if (Barcode != "") //|| dgvProduct.Rows[dang1].Cells[14].Value?.ToString() != null
                {
                    a = Barcode;
                    Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, a, forecolor, backcolor, 144, 40);
                    g.DrawImage(barcode, new System.Drawing.PointF(0, 80));
                }
                else
                {
                    MessageBox.Show("Barcode rỗng");
                }
                if (PageNumRun < PageNum)
                {
                    e.HasMorePages = true;
                    PageNumRun++;
                }
                else
                {
                    e.HasMorePages = false;
                    PageNumRun = PageNum;
                }
            }
        }
        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = @"BIXOLON SLP-D220";
            BarcodeLib.Barcode code128;
            code128 = new Barcode();
            //code128.LabelFont = new Font("Times New Roman", 4f);
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
            g.DrawString(dgvProduct.Rows[dang1].Cells[3].Value?.ToString(), font2, brush, new Rectangle(0, 0, 144, 55));
            //g.DrawRectangle(pen, new Rectangle(1, 92, 302, 40));                
            g.DrawString("HSD: " + dgvProduct.Rows[dang1].Cells[8].Value?.ToString(), font2, brush, new Rectangle(0, 50, 144, 30));
            //g.DrawRectangle(pen, new Rectangle(1, 122, 302, 40));
            g.DrawString("Giá bán: " + dgvProduct.Rows[dang1].Cells[6].Value?.ToString(), font2, brush, new Rectangle(0, 65, 144, 30));
            //Địa chỉ Shop
            Color forecolor = Color.Black;
            Color backcolor = Color.Transparent;
            string a = "893684456314";                
            if (dgvProduct.Rows[dang1].Cells[14].Value?.ToString() != "" || dgvProduct.Rows[dang1].Cells[14].Value?.ToString() != null)
            { 
                a = dgvProduct.Rows[dang1].Cells[14].Value.ToString();
                Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, a, forecolor, backcolor, 144,40);
                g.DrawImage(barcode, new System.Drawing.PointF(0, 80));
            }
            else
            {
                MessageBox.Show("Barcode rỗng");
            }
            ev.HasMorePages = false;
        }
        enum dgv_enum : int
        {
            Product_Serial_Key,
            Product_Id,
            Product_Name,
            Product_Quantity,
            Product_Cost_Price,
            Product_Sale_Price,
            trang_thai,
            ngay_hen,
            ten_pet,
            ghi_chu,
        }
        private void txtFindProduct_Enter(object sender, EventArgs e)
        {
            string sSQL = $@"SELECT		P.Product_Serial_Key,
		                                P.Product_Id,
		                                P.Product_Name,
		                                P.Product_Quantity,
		                                P.Product_Cost_Price,
		                                P.Product_Sale_Price,
		                                ISNULL(P.Date_Expired,'') as expire,
		                                C.Consignment_ID,
		                                PR.Product_Group_Name, --Nhóm hàng
		                                S.Supplier_Name,
                                        P.Product_Unit,
                                        P.Product_Barcode,
                                        P.Note
                                                FROM PRODUCT_INFO P
	                                                LEFT JOIN CONSIGNMENT C ON C.Consignment_Serial_Key = P.Consignment_Serial_Key
	                                                LEFT JOIN PRODUCT_GROUP PR ON PR.Product_Group_Serial_Key = P.Product_Group_Serial_Key
						                            LEFT JOIN SUPPLIER S ON S.Supplier_serial_key = C.Supplier_serial_key
                                                WHERE   (P.Product_Name LIKE N'%'+ '{txtFindProduct.Text.Trim()}' + '%' 
							                            OR P.Product_Barcode LIKE N'%'+ '{txtFindProduct.text.Trim()}' + '%')
						                            AND PR.Product_Type_Serial_Key = 'PT0000000000001'
					                            ORDER BY p.Product_Quantity ASC";

            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(sSQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int t = 0;
            dgvProduct.Rows.Clear();
            while (reader.Read())
            {
                string dateExpire = reader["expire"].ToString();
                string dateNow = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime convertDateExpired = Convert.ToDateTime(dateExpire);
                DateTime convertDateNow = Convert.ToDateTime(dateNow);

                string cost_price = String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]);
                dgvProduct.Rows.Add(new object[] {
                        true,
                        reader["Product_Serial_Key"].ToString(),
                        reader["Product_Id"].ToString(),
                        reader["Product_Name"].ToString(),
                        reader["Product_Quantity"].ToString(),
                        String.Format("{0:#,0 VNĐ}", reader["Product_Cost_Price"]),
                        String.Format("{0:#,0 VNĐ}", reader["Product_Sale_Price"]),
                        reader["expire"].ToString(),
                        reader["Consignment_ID"].ToString(),
                        reader["Product_Group_Name"].ToString(),
                        reader["Supplier_Name"].ToString(),
                        reader["Product_Unit"].ToString(),
                        reader["Product_Barcode"].ToString(),
                        reader["Note"].ToString()
                });
                if (convertDateNow <= convertDateExpired)
                {
                    dgvProduct.Rows[t].DefaultCellStyle.ForeColor = Color.Purple;
                }
                else
                {
                    dgvProduct.Rows[t].DefaultCellStyle.ForeColor = Color.Gray;
                }
                t++;
            }
        }

        private bool IsCheckAll;
        private void dgvProduct_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < this.dgvProduct.Rows.Count; i++)
            {
                this.dgvProduct.Rows[i].Cells[0].Value = this.IsCheckAll;
            }
            this.IsCheckAll = !this.IsCheckAll;
            this.dgvProduct.CurrentRow.Cells[0].Selected = !this.IsCheckAll;
            dgvProduct.RefreshEdit();
        }
    }
}
