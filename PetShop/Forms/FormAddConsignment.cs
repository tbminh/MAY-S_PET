using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms
{
    public partial class FormAddConsignment : Form
    {
        public FormAddConsignment()
        {
            InitializeComponent();
        }
        private string malohang = FormSupplier.Consignment_ID;
        private void FormAddConsignment_Load(object sender, EventArgs e)
        {
            LoadItemsIntoComboBox(cbxLoaisp, @"SELECT [Product_Group_Serial_Key], [Product_Group_Name] FROM [PRODUCT_GROUP]");
            LoadItemsComboBoxValue(cbxDonvi, @"SELECT  [Unit_Name] FROM [PRODUCT_UNIT]");
            LoadItemsComboBoxValue(cbxDonvichitiet, @"SELECT [Unit_Name] FROM [PRODUCT_UNIT]");
            Getdata();

            lblNVTtitle.Text = malohang != "" ? "NHẬP VẬT TƯ LÔ HÀNG " + malohang : "NHẬP VẬT TƯ";
        }
        private DataTable LoadsqlFromDatabase(string sql)
        {
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            DataTable dt = new DataTable();
            odcConnect.Open();
            try
            {
                //dt.Rows.Add("hello");
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
        private void resetForm()
        {
            txtDongia.Text = "";
            txtDongiachitiet.Text = "";
            txtGianhap.Text = "";
            txtTensp.Text = "";
            txtSLnhap.Text = "";
            txtSLchitiet.Text = "";
            cbxDonvi.SelectedItem = null;
            cbxDonvichitiet.SelectedItem = null;
            cbxLoaisp.SelectedItem = null;
        }
        private void bindComboboxColumnUnit()
        {
            DataTable dt = LoadsqlFromDatabase("SELECT [Unit_Name] FROM [PRODUCT_UNIT]");
            DataGridViewComboBoxColumn cbc = (dgvVatTu.Columns["dcmDonVi"] as DataGridViewComboBoxColumn);
            dgvVatTu.ReadOnly = false;
            cbc.ReadOnly = false;
            cbc.DataSource = dt;
            cbc.DisplayMember = "Unit_Name";
            cbc.ValueMember = "Unit_Name";
            cbc.DataPropertyName = "Product_Unit";

            DataGridViewComboBoxColumn chbsub = (dgvVatTu.Columns["dcmDonVichitiet"] as DataGridViewComboBoxColumn);
            dgvVatTu.ReadOnly = false;
            chbsub.ReadOnly = false;
            chbsub.DataSource = dt;
            chbsub.DisplayMember = "Unit_Name";
            chbsub.ValueMember = "Unit_Name";
            chbsub.DataPropertyName = "Product_Unit";

            DataTable dtplsp = LoadsqlFromDatabase("SELECT [Product_Group_Serial_Key], [Product_Group_Name] FROM [PRODUCT_GROUP]");
            DataGridViewComboBoxColumn cbcplsp = (dgvVatTu.Columns["dcmLoaiSP"] as DataGridViewComboBoxColumn);
            dgvVatTu.ReadOnly = false;
            cbcplsp.ReadOnly = false;
            cbcplsp.DataSource = dtplsp;
            cbcplsp.DisplayMember = "Product_Group_Name";
            cbcplsp.ValueMember = "Product_Group_Name";
            cbcplsp.DataPropertyName = "Product_Group_Name";
        }
        private void Getdata()
        {
            string SQL = $@"SELECT I.*, G.Product_Group_Name  FROM PRODUCT_INFO I JOIN PRODUCT_GROUP G ON I.Product_Group_Serial_Key= G.Product_Group_Serial_Key WHERE Consignment_Serial_Key='{malohang}' ";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();

            OleDbDataReader reader = odcCommand.ExecuteReader();
            int i = 1;
            int index = 0;
            dgvVatTu.Rows.Clear();
            bindComboboxColumnUnit();
            while (reader.Read())
            {
                string ngayhethan = reader["Date_Expired"].ToString() != "" ? Convert.ToDateTime(reader["Date_Expired"]).ToString("dd/MM/yyyy") : "";
                string ngaynhap = reader["Product_Date_In"].ToString() != "" ? Convert.ToDateTime(reader["Product_Date_In"]).ToString("dd/MM/yyyy") : "";
                dgvVatTu.Rows.Add(new object[]
                {
                    false,
                        i,
                        reader["Product_Serial_Key"].ToString(),
                        reader["Product_Name"].ToString(),
                        "",
                        reader["Product_Cost_Price"].ToString(),
                        reader["Product_Quantity"].ToString(),
                        reader["Product_Sale_Price"].ToString(),
                        "",
                        reader["Product_SubQuantity"].ToString(),
                        reader["Product_Sale_SubPrice"].ToString(),
                        "",
                        ngayhethan,
                        ngaynhap,
                        reader["Product_Total_Quantity"].ToString(),
                });


                dgvVatTu.Rows[index].Cells["dcmDonVi"].Value = reader["Product_Unit"].ToString();
                dgvVatTu.Rows[index].Cells["dcmDonVichitiet"].Value = reader["Product_SubUnit"].ToString();
                dgvVatTu.Rows[index].Cells["dcmLoaiSP"].Value = reader["Product_Group_Name"].ToString();
                index++;
                i++;

            }

            odcConnect.Close();
        }
        public void LoadItemsIntoComboBox(ComboBox comboBox, string sSql)
        {
            try
            {
                using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
                {
                    sqlConnect.Open();
                    OleDbCommand sqlCommand = new OleDbCommand(sSql, sqlConnect);
                    OleDbDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string value = reader[0].ToString();
                        string item = reader[1].ToString();
                        comboBox.Items.Add(new KeyValuePair<string, string>(value, item));
                        comboBox.DisplayMember = "Value";
                        comboBox.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
        }

        public void LoadItemsComboBoxValue(ComboBox comboBox, string sSql)
        {
            try
            {
                using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
                {
                    sqlConnect.Open();
                    OleDbCommand sqlCommand = new OleDbCommand(sSql, sqlConnect);
                    OleDbDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string value = reader[0].ToString();
                        comboBox.Items.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
        }
        private string GetMatchingProductId(string productName)
        {
            string productId = "";
            try
            {
                using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
                {
                    sqlConnect.Open();
                    string sqlTimMaxProductId = $@"
                           DECLARE @MaxProductId NVARCHAR(10);
                            SELECT TOP(1) @MaxProductId= [Product_Id]
                            FROM [PRODUCT_INFO]
                            WHERE [Product_Name] LIKE N'%{productName}%'
                            ORDER BY [Product_Id];
                            IF @MaxProductId IS NULL
                            BEGIN
                                SELECT @MaxProductId = MAX(Product_Id)
                                FROM PRODUCT_INFO;
                                SET @MaxProductId = 'PRO' + RIGHT('0000000' + CAST(CAST(RIGHT(@MaxProductId, 7) AS INT) + 1 AS NVARCHAR(7)), 7);
                            END
                            SELECT @MaxProductId;";
                    OleDbCommand sqlCommand = new OleDbCommand(sqlTimMaxProductId, sqlConnect);
                    object result = sqlCommand.ExecuteScalar();
                    if (result != null)
                    {
                        productId = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
            return productId;
        }
        private void GetSeletedLoaispvalue(ComboBox comboBox, string valueToSelect)
        {
            foreach (KeyValuePair<string, string> item in comboBox.Items)
            {
                if (item.Key == valueToSelect)
                {
                    comboBox.SelectedItem = item;
                    break;
                }
            }
        }
        private string GetSelectedKey(ComboBox comboBox)
        {
            if (comboBox.SelectedItem is KeyValuePair<string, string> selectedPair)
            {
                return selectedPair.Key;
            }
            return null;
        }
        private AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
            {

                sqlConnect.Open();
                string sqlTimBarcode = $"SELECT TOP(1) * FROM [PRODUCT_INFO] WHERE [Product_Barcode] = '{txtBarcode.Text.Trim()}'";

                using (OleDbCommand sqlCommand = new OleDbCommand(sqlTimBarcode, sqlConnect))
                {
                    using (OleDbDataReader reader = sqlCommand.ExecuteReader())
                    {
                        //Khi có barcode thì sẽ có tồn tại 
                        if (reader.Read())
                        {

                            GetSeletedLoaispvalue(cbxLoaisp, reader["Product_Group_Serial_Key"].ToString());
                            txtTensp.Text = reader["Product_Name"].ToString();
                            txtGianhap.Text = reader["Product_Cost_Price"].ToString();
                            txtDongia.Text = reader["Product_Sale_Price"].ToString();
                            txtDongiachitiet.Text = reader["Product_Sale_SubPrice"].ToString();
                            txtSLchitiet.Text = reader["Product_SubQuantity"].ToString();
                            cbxDonvi.SelectedItem = reader["Product_Unit"].ToString();
                            cbxDonvichitiet.SelectedItem = reader["Product_SubUnit"].ToString();
                            dtpkNgayHH.Value = Convert.ToDateTime(reader["Date_Expired"].ToString());
                        }
                    }
                }
            }
        }

        private void cbxLoaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKey = GetSelectedKey(cbxLoaisp);
            //temporarySuggestions.Clear();
            using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
            {
                sqlConnect.Open();
                string sSql = $@"select DISTINCT Product_Name from PRODUCT_INFO WHERE Product_Group_Serial_Key = '{selectedKey}'";
                OleDbCommand sqlCommand = new OleDbCommand(sSql, sqlConnect);
                OleDbDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string value = reader[0].ToString();
                    collection.Add(value);

                }
                txtTensp.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtTensp.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTensp.AutoCompleteCustomSource = collection;
                //txtTensp.Focus();
                //txtTensp.SelectAll();
            }
        }

        private void txtTensp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string productName = txtTensp.Text.Trim();
                using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
                {
                    sqlConnect.Open();
                    string sqlTimMaxProductId = $@"SELECT TOP(1) [Product_Cost_Price],[Product_Sale_Price],[Product_Unit],[Product_SubUnit], [Product_SubQuantity]
                                                        ,[Product_Sale_SubPrice] FROM  [PRODUCT_INFO]  WHERE Product_Name LIKE N'{productName}'";
                    OleDbCommand sqlCommand = new OleDbCommand(sqlTimMaxProductId, sqlConnect);
                    using (OleDbDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productCostPrice = reader["Product_Cost_Price"].ToString();
                            string productSalePrice = reader["Product_Sale_Price"].ToString();
                            string productUnit = reader["Product_Unit"].ToString();
                            string Product_SubQuantity = reader["Product_SubQuantity"].ToString();
                            string productSubUnit = reader["Product_SubUnit"].ToString();
                            string productSaleSubPrice = reader["Product_Sale_SubPrice"].ToString();
                            txtDongia.Text = productSalePrice;
                            txtDongiachitiet.Text = productSaleSubPrice;
                            txtGianhap.Text = productCostPrice;
                            txtSLchitiet.Text = Product_SubQuantity;
                            cbxDonvi.SelectedItem = productUnit;
                            cbxDonvichitiet.SelectedItem = productSubUnit;
                        }
                        else
                        {
                            // Không có dòng kết quả
                            // Xử lý tùy theo trường hợp của bạn
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string plspkey = GetSelectedKey(cbxLoaisp);
            string tensp = txtTensp.Text.Trim();
            string slNhap = txtSLnhap.Text.Trim();
            string slchitiet = txtSLchitiet.Text.Trim() != "" ? txtSLchitiet.Text.Trim() : slNhap;
            string giasNhap = txtGianhap.Text.Trim();
            string dongia = txtDongia.Text.Trim();
            string dongiachitiet = txtDongiachitiet.Text.Trim() != "" ? txtDongiachitiet.Text.Trim() : "1";
            string dvKey = cbxDonvi.SelectedItem != null ? cbxDonvi.SelectedItem.ToString() : "";
            string dvctKey = cbxDonvichitiet.SelectedItem != null ? cbxDonvichitiet.SelectedItem.ToString() : "";
            DateTime ngayhethan = dtpkNgayHH.Value;
            string productId = GetMatchingProductId(tensp);
            string txtbarcode = txtBarcode.Text.Trim();
            string TotalAsString = "";


            string barcode = "";
            string lohang = malohang;
            if (plspkey == "" || tensp == "" || txtSLnhap.Text.Trim() == "" || txtGianhap.Text.Trim() == "" || txtDongia.Text.Trim() == "" || cbxDonvi.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            else
            {
                float Total = float.Parse(slNhap) * float.Parse(slchitiet);
                TotalAsString = Total.ToString();
            }

            //Tìm barcode 
            using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
            {
                //sqlConnect.Open();
                //string sqlTimMaxProductId = $"SELECT * FROM [PRODUCT_INFO] WHERE [Product_Barcode] = '{txtbarcode}'";
                //using (OleDbCommand sqlCommand = new OleDbCommand(sqlTimMaxProductId, sqlConnect))
                //{
                //    object result = sqlCommand.ExecuteScalar();
                //    if (result == null || result.ToString() == "")
                //    {
                //        string sqlMaxBarcode = @"
                //            DECLARE @MaxProductBarcode NVARCHAR(15);
                //            DECLARE @CurrentDate NVARCHAR(8) = FORMAT(GETDATE(), 'yyMMdd');
                //            SELECT @MaxProductBarcode = ISNULL(MAX(Product_Barcode), 'BC' + @CurrentDate + '0000000')
                //            FROM PRODUCT_INFO
                //            WHERE Product_Barcode LIKE 'BC' + @CurrentDate + '%';
                //            SET @MaxProductBarcode = 'BC' + @CurrentDate + RIGHT('0000000' + CAST(CAST(RIGHT(@MaxProductBarcode, 7) AS INT) + 1 AS NVARCHAR(7)), 7);
                //            SELECT @MaxProductBarcode; ";
                //        using (OleDbCommand sqlCommand2 = new OleDbCommand(sqlMaxBarcode, sqlConnect))
                //        {
                //            object resultbc = sqlCommand2.ExecuteScalar();
                //            if (resultbc != null)
                //            {
                //                barcode = resultbc.ToString();
                //            }
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Mã vạch này đã tồn tại rồi");
                //    }
                //}
                sqlConnect.Open();
                string sqlTimMaxProductId = $"SELECT TOP(1) * FROM [PRODUCT_INFO] WHERE [Product_Barcode] = '{txtbarcode}'";

                using (OleDbCommand sqlCommand = new OleDbCommand(sqlTimMaxProductId, sqlConnect))
                {
                    using (OleDbDataReader reader = sqlCommand.ExecuteReader())
                    {
                        //Khi có barcode thì sẽ có tồn tại 
                        if (reader.HasRows) // Kiểm tra xem có dòng dữ liệu trả về hay không
                        {
                            reader.Read(); // Di chuyển con trỏ đến dòng dữ liệu
                            string productName = reader["Product_Name"].ToString();
                            //string update = $@"UPDATE PRODUCT_INFO SET ";

                            MessageBox.Show($"Product Name: {productName}");
                        }
                        else
                        {
                            string sqlMaxBarcode = @"
                           DECLARE @MaxProductBarcode NVARCHAR(15);
                            DECLARE @CurrentDate NVARCHAR(8) = FORMAT(GETDATE(), 'yyMMdd');
                            SELECT @MaxProductBarcode = ISNULL(MAX(Product_Barcode), 'BC' + @CurrentDate + '0000000')
                            FROM PRODUCT_INFO
                           WHERE Product_Barcode LIKE 'BC' + @CurrentDate + '%';
                            SET @MaxProductBarcode = 'BC' + @CurrentDate + RIGHT('0000000' + CAST(CAST(RIGHT(@MaxProductBarcode, 7) AS INT) + 1 AS NVARCHAR(7)), 7);
                          SELECT @MaxProductBarcode; ";
                            using (OleDbCommand sqlCommand2 = new OleDbCommand(sqlMaxBarcode, sqlConnect))
                            {
                                object resultbc = sqlCommand2.ExecuteScalar();
                                if (resultbc != null)
                                {
                                    barcode = resultbc.ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dgvVatTu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvVatTu[e.ColumnIndex, e.RowIndex].Tag is ComboBox comboBoxEditingControl)
                {
                    dgvVatTu[e.ColumnIndex, e.RowIndex].Value = comboBoxEditingControl.Text;
                }
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {

        }
    }
}
