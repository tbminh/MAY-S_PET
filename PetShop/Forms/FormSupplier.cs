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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }
        private string maNCC = "";
        public static string Consignment_ID = "";
        #region Function
        private void resetFormSuppllier()
        {
            txt_tenncc.Text = "";
            txtdiachincc.Text = "";
            txt_sdtncc.Text = "";
        }
        private void resetFormConsignment()
        {
            txtLH_name.Text = "";
            dtp_ngaynhap.Value = DateTime.Now;
        }
        private void GetdataConsignment(string SupplierSerialKey)
        {
            string SQL = $@" SELECT C.[Consignment_Serial_Key],C.[Consignment_ID], C.[Consignment_Date],
              S.[Supplier_Name], COUNT(Product_Barcode) AS Total_Quantity
	                FROM [CONSIGNMENT] C
	                JOIN [SUPPLIER] S ON S.[Supplier_serial_key] = C.[Supplier_serial_key]
	                LEFT JOIN [PRODUCT_INFO] P ON P.[Consignment_Serial_Key] = C.[Consignment_Serial_Key]  WHERE S.[Supplier_serial_key] ='{SupplierSerialKey}'
	                GROUP BY C.[Consignment_Serial_Key],C.[Consignment_ID], C.[Consignment_Date], S.[Supplier_Name]  ";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int i = 1;
            dvgLoHang.Rows.Clear();
            while (reader.Read())
            {
                dvgLoHang.Rows.Add(new object[]
                {
                        i,
                        reader["Consignment_Serial_Key"].ToString(),
                        reader["Consignment_ID"].ToString(),
                        Convert.ToDateTime(reader["Consignment_Date"]).ToString("dd/MM/yyyy"),
                        reader["Supplier_Name"].ToString(),
                        reader["Total_Quantity"].ToString(),

                });
                i++;
            }
            odcConnect.Close();
        }
        private void btnNCCreset_Click(object sender, EventArgs e)
        {
            resetFormSuppllier();
        }
        private void Getdatasupplier()
        {
            string SQL = $@" SELECT  S.[Supplier_serial_key] ,[Supplier_Name] ,[Suppiler_Address] ,[Suppiler_Phone], COUNT([Consignment_Serial_Key]) AS Total_LH 
	                        FROM [CONSIGNMENT] C RIGHT JOIN [SUPPLIER] S ON S.[Supplier_serial_key] = C.[Supplier_serial_key]
	                        GROUP BY S.[Supplier_serial_key],[Supplier_Name] ,[Suppiler_Address] ,[Suppiler_Phone];";
            OleDbConnection odcConnect = new OleDbConnection(clsConnect.Connect_String);
            OleDbCommand odcCommand = new OleDbCommand(SQL, odcConnect);
            odcConnect.Open();
            OleDbDataReader reader = odcCommand.ExecuteReader();
            int i = 1;
            dvgNCC.Rows.Clear();
            while (reader.Read())
            {
                dvgNCC.Rows.Add(new object[]
                {
                        i,
                        reader["Supplier_serial_key"].ToString(),
                        reader["Supplier_Name"].ToString(),
                        reader["Suppiler_Address"].ToString(),
                        reader["Suppiler_Phone"].ToString(),
                        reader["Total_LH"].ToString(),


                });
                i++;
            }
            odcConnect.Close();
        }
        #endregion
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string TenNCC = txt_tenncc.Text.Trim();
            string DiaChiNCC = txtdiachincc.Text.Trim();
            string SdtNCC = txt_sdtncc.Text.Trim();
            if (TenNCC == "" || DiaChiNCC == "" || SdtNCC == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin");
                return;
            }
            using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
            {
                sqlConnect.Open();
                string sql = $@"DECLARE @MaxSupplierkey NVARCHAR(10);
                            SELECT @MaxSupplierkey = ISNULL(MAX([Supplier_serial_key]), 'SL'  + '00000000')
                            FROM [SUPPLIER]
                            WHERE [Supplier_serial_key] LIKE 'SL%';
                            SET @MaxSupplierkey = 'SL' + RIGHT('00000000' + CAST(CAST(RIGHT(@MaxSupplierkey, 8) AS INT) + 1 AS NVARCHAR(8)),8);
                             INSERT INTO [SUPPLIER] ([Supplier_serial_key],[Supplier_Name],[Suppiler_Address],[Suppiler_Phone]) VALUES(@MaxSupplierkey,N'{TenNCC}',N'{DiaChiNCC}',N'{SdtNCC}');
                            ";
                using (OleDbCommand sqlCommandInsert = new OleDbCommand(sql, sqlConnect))
                {
                    int rowsAffected = sqlCommandInsert.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Getdatasupplier();
                        resetFormSuppllier();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại");
                    }
                }
            }
        }
        private void dvgNCC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = "";
                if (dvgNCC.Columns[e.ColumnIndex].Name == "dcmNCC_tenncc")
                {
                    columnName = "Supplier_Name";
                }
                else if (dvgNCC.Columns[e.ColumnIndex].Name == "dcmNCC_diachi")
                {
                    columnName = "Suppiler_Address";
                }
                else if (dvgNCC.Columns[e.ColumnIndex].Name == "dcmNCC_sdt")
                {
                    columnName = "Suppiler_Phone";
                }
                string colName = dvgNCC.Columns[e.ColumnIndex].Name;
                DataGridViewRow editedRow = dvgNCC.Rows[e.RowIndex];
                string newValue = editedRow.Cells[colName].Value.ToString();
                string idValue = editedRow.Cells["dcmNCC_serialkey"].Value.ToString();

                string updateQuery = $"UPDATE SUPPLIER SET {columnName} = N'{newValue}' WHERE Supplier_serial_key = '{idValue}'";
                using (OleDbConnection connection = new OleDbConnection(clsConnect.Connect_String))
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dvgNCC_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dvgNCC.Rows[e.RowIndex];
                //string column1Value = selectedRow.Cells["ColumnName1"].Value.ToString(); 
                maNCC = selectedRow.Cells["dcmNCC_serialkey"].Value.ToString();
                string dcmNCC_serialkey = selectedRow.Cells["dcmNCC_serialkey"].Value.ToString();
                GetdataConsignment(dcmNCC_serialkey);
                panelnhaplohang.Visible = true;
                PanelNcc.Visible = false;
            }
        }

        private void dvgLoHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dvgLoHang.Rows[e.RowIndex];
                Consignment_ID = selectedRow.Cells["dcmLH_lohangkey"].Value.ToString();
            }
            var f2 = new FormAddConsignment();

            MaskedDialog.ShowDialog(this, f2);
            f2.Dispose();
            f2 = null;
        }

        private void btnbackPanel_Click(object sender, EventArgs e)
        {
            PanelNcc.Visible = true;
            panelnhaplohang.Visible = false;
        }

        private void btnAddConsignment_Click(object sender, EventArgs e)
        {
            string tenlohang = txtLH_name.Text.Trim();
            string ngaynhaplo = dtp_ngaynhap.Value.ToString("yyyy-MM-dd");
            if (tenlohang == "" || ngaynhaplo == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin");
                return;
            }
            using (OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String))
            {
                sqlConnect.Open();
                string sql = $@"DECLARE @MaxConsignment NVARCHAR(15);
                            SELECT @MaxConsignment = ISNULL(MAX([Consignment_Serial_Key]), 'CS'  + '0000000000000')
                            FROM [CONSIGNMENT]
                            WHERE [Consignment_Serial_Key] LIKE 'CS%';
							SET @MaxConsignment = 'CS' + RIGHT('0000000000000' + CAST(CAST(RIGHT(@MaxConsignment, 13) AS INT) + 1 AS NVARCHAR(13)),13);
                            INSERT INTO [CONSIGNMENT] ([Consignment_Serial_Key],[Consignment_ID],[Consignment_Date],[Supplier_serial_key]) VALUES 
                            (@MaxConsignment, N'{tenlohang}','{ngaynhaplo}','{maNCC}') 
                            ";
                using (OleDbCommand sqlCommandInsert = new OleDbCommand(sql, sqlConnect))
                {
                    int rowsAffected = sqlCommandInsert.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        resetFormConsignment();
                        GetdataConsignment(maNCC);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại");
                    }
                }
            }
        }

        private void btnResetConsignment_Click(object sender, EventArgs e)
        {
            resetFormConsignment();
        }

        private void dvgLoHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn editedColumn = dvgLoHang.Columns[e.ColumnIndex];
                string columnName = "";
                if (editedColumn.Name == "dcmLH_ngay")
                {
                    columnName = "Consignment_Date";
                }
                else if (editedColumn.Name == "dcmLH_tenlh")
                {
                    columnName = "Consignment_ID";
                }
                else
                {
                    // Handle other columns if needed
                    return;
                }

                DataGridViewRow editedRow = dvgLoHang.Rows[e.RowIndex];
                string colName = editedColumn.Name;

                string newValue = "";
                if (columnName == "Consignment_Date")
                {
                    string originalValue = editedRow.Cells["dcmLH_ngay"].Value.ToString();
                    if (!DateTime.TryParseExact(originalValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        MessageBox.Show($"Giá trị không hợp lệ cho ngày: {originalValue}");
                        return;
                    }
                    newValue = Convert.ToDateTime(originalValue).ToString("yyyy-MM-dd");
                    DateTime ngay = Convert.ToDateTime(editedRow.Cells["dcmLH_ngay"].Value);
                }
                else
                {
                    newValue = editedRow.Cells["dcmLH_tenlh"].Value.ToString();
                }
                string idValue = editedRow.Cells["dcmLH_lohangkey"].Value.ToString();
                string updateQuery = $"UPDATE CONSIGNMENT SET {columnName} = N'{newValue}' WHERE Consignment_Serial_Key = '{idValue}'";
                using (OleDbConnection connection = new OleDbConnection(clsConnect.Connect_String))
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        } //End dvgLoHang_CellEndEdit
    }
}
