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

namespace PetShop.Forms
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }
        public string product_key = "";
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            clsSql sql = new clsSql();
            sql.Get_Type_Product(cbxType);
            sql.Get_Group_Product(cbxGroup);
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnNhap.Enabled = false;
            txtSerialKey.Enabled = false;
            txtSerialKey.Text = FormProduct.Product_Serial_Key_Send;
            txtProductID.Text = FormProduct.Product_Id_Send;
            txtNameProduct.Text = FormProduct.Product_Name_Send;
            txtInventory.Text = FormProduct.Product_Quantity_Send;
            //string[] cost = FormProduct.Product_Cost_Price_Send.Split('.');
            txtCostPrice.Text = FormProduct.Product_Cost_Price_Send.Replace(".", "").Replace("VNĐ", "");
            txtSalePrice.Text = FormProduct.Product_Sale_Price_Send.Replace(".", "").Replace("VNĐ", "");
            txtConsignmentID.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtConsignmentID.ReadOnly = true;
            txtConsignmentID.ForeColor = Color.Red;
            dptDateProduct.Value = Convert.ToDateTime(FormProduct.Product_Date_Send.ToString());
            dptDateExpired.Value = Convert.ToDateTime(FormProduct.Product_Expired_Date_Send.ToString());
            cbxGroup.Text = FormProduct.Product_Group_Name_Send;
            cbxType.Text = FormProduct.Product_Type_Name_Send;
            txtSup.Text = FormProduct.Product_Sup_Name_Send;
            txtUnit.Text = FormProduct.Product_Unit_Send;
            txtBarcode.Text = FormProduct.Product_Barcode_Send;
            txtNote.Text = FormProduct.Product_Note_Send;
            txtAddressSup.Text = FormProduct.Product_Address_Sup_Send;

            if (FormProduct.Product_Serial_Key_Send == "")
            {
                //         string sql_add_consignment = @"DECLARE @CONSIGNMENT_SERIAL_KEY VARCHAR(15) = '000000000000000', @NEW_NUMBER VARCHAR(16)
                //                     SELECT @NEW_NUMBER = RIGHT(MAX(Consignment_Serial_Key),13) + 1 FROM CONSIGNMENT
                //--select @NEW_NUMBER = LEFT(@CONSIGNMENT_SERIAL_KEY, 13 - LEN(@NEW_NUMBER)) + CONVERT(VARCHAR,@NEW_NUMBER)
                //--select @NEW_NUMBER
                //--select 
                //                     SELECT @NEW_NUMBER = 'CS' + LEFT(@CONSIGNMENT_SERIAL_KEY, 13 - LEN(@NEW_NUMBER)) + CONVERT(VARCHAR,@NEW_NUMBER)";
                //         OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                //         conn.Open();
                //         OleDbCommand cmd = new OleDbCommand(sql_add_consignment, conn);
                //string product_key = cmd.ExecuteScalar().ToString();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnNhap.Enabled = true;
                txtSerialKey.Enabled = false;
                txtSerialKey.Text = "";
                txtProductID.Text = "";
                txtNameProduct.Text = "";
                txtInventory.Text = "";
                txtCostPrice.Text = "";
                txtSalePrice.Text = "";

                txtConsignmentID.Text = DateTime.Now.ToString("yyyy/MM/dd");
                dptDateProduct.Text = "";
                dptDateExpired.Text = "";
                cbxGroup.Text = "";
                cbxType.Text = "";
                txtSup.Text = "";
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            string sql_type = @"SELECT TOP 1 Product_Type_Serial_Key
                                FROM PRODUCT_TYPE 
                                WHERE Product_Type_Name = N'" + cbxType.Text.Trim() + "'";

            string sql_group = @"SELECT TOP 1 Product_Group_Serial_Key 
                                FROM PRODUCT_GROUP
                                WHERE Product_GROUP_Name = N'" + cbxGroup.Text.Trim() + "'";

            string sql_add_consignment = @"DECLARE @CONSIGNMENT_SERIAL_KEY VARCHAR(15) = '000000000000000', @NEW_NUMBER VARCHAR(16)
                                        SELECT @NEW_NUMBER = RIGHT(MAX(Consignment_Serial_Key),13) + 1
                                        FROM CONSIGNMENT
							            --select @NEW_NUMBER = LEFT(@CONSIGNMENT_SERIAL_KEY, 13 - LEN(@NEW_NUMBER)) + CONVERT(VARCHAR,@NEW_NUMBER)							
                                        SELECT @NEW_NUMBER = 'CS' + LEFT(@CONSIGNMENT_SERIAL_KEY, 13 - LEN(@NEW_NUMBER)) + CONVERT(VARCHAR,@NEW_NUMBER)
							
                                        INSERT INTO CONSIGNMENT (Consignment_Serial_Key, Consignment_ID, Consignment_Date, Date_Product, Date_Expired)
                                        VALUES(@NEW_NUMBER,'" + txtConsignmentID.Text.Trim() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dptDateProduct.Value.ToString("yyyy-MM-dd") + "','" + dptDateExpired.Value.ToString("yyyy-MM-dd") + "')";
            string sql_consignment = @"SELECT TOP 1 Consignment_Serial_Key FROM CONSIGNMENT WHERE Consignment_ID = '" + txtConsignmentID.Text.Trim() + "'";
            
            if (txtProductID.Text == "" || txtBarcode.Text == "" || txtNameProduct.Text == "" || txtInventory.Text == "" || txtSalePrice.Text == "" || cbxGroup.Text == "" || cbxType.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else if (txtProductID.Text.Length < 10)
            {
                MessageBox.Show("Mã Sản Phẩm phải từ 10 ký tự");
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                string sql_check_key = @"SELECT TOP 1 Product_Id from PRODUCT_INFO WHERE Product_Id = '" + txtProductID.Text.Trim() + "'";
                OleDbCommand cmdcheck = new OleDbCommand(sql_check_key, conn);
                if (cmdcheck.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Mã Sản Phẩm đã tồn tại!!!");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand(sql_type, conn);
                    OleDbCommand cmd1 = new OleDbCommand(sql_group, conn);
                    OleDbCommand cmd2 = new OleDbCommand(sql_add_consignment, conn);
                    OleDbCommand cmd3 = new OleDbCommand(sql_consignment, conn);
                    string product_type_serial_key = cmd.ExecuteScalar().ToString();
                    string product_group_serial_key = cmd1.ExecuteScalar().ToString();
                    cmd2.ExecuteNonQuery();
                    string consignment_serial_key = cmd3.ExecuteScalar().ToString();
                    clsSql insert = new clsSql();
                    insert.Add_Product(
                                txtProductID.Text,
                                txtBarcode.Text,
                                txtNameProduct.Text,
                                txtInventory.Text,
                                txtCostPrice.Text,
                                txtSalePrice.Text,
                                txtUnit.Text,
                                txtNote.Text,
                                txtSup.Text,
                                txtAddressSup.Text,
                                product_type_serial_key,
                                product_group_serial_key,
                                consignment_serial_key);
                    MessageBox.Show("Thêm Thành Công");
                    txtSerialKey.Text = "";
                    txtProductID.Text = "";
                    txtNameProduct.Text = "";
                    txtInventory.Text = "";
                    txtCostPrice.Text = "";
                    txtSalePrice.Text = "";
                    //dptDateIn.Text = "";
                    txtConsignmentID.Text = "";
                    cbxGroup.Text = "";
                    cbxType.Text = "";
                    txtSup.Text = "";
                    txtUnit.Text = "";
                    txtBarcode.Text = "";
                    txtNote.Text = "";
                    txtAddressSup.Text = "";
                    //btnback_Click(sender, e);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
            conn.Open();
            string sql_type = @"SELECT TOP 1 Product_Type_Serial_Key FROM PRODUCT_TYPE WHERE Product_Type_Name = N'" + cbxType.Text.Trim() + "'";
            string sql_group = @"SELECT TOP 1 Product_Group_Serial_Key FROM PRODUCT_GROUP WHERE Product_GROUP_Name = N'" + cbxGroup.Text.Trim() + "'";

            string sql_add_consignment = @"DECLARE @CONSIGNMENT_SERIAL_KEY VARCHAR(15) = '000000000000000', @NEW_NUMBER VARCHAR(16)
                            SELECT @NEW_NUMBER = RIGHT(MAX(Consignment_Serial_Key),13) + 1 FROM CONSIGNMENT
							--select @NEW_NUMBER = LEFT(@CONSIGNMENT_SERIAL_KEY, 13 - LEN(@NEW_NUMBER)) + CONVERT(VARCHAR,@NEW_NUMBER)
							--select @NEW_NUMBER
							--select 
                            SELECT @NEW_NUMBER = 'CS' + LEFT(@CONSIGNMENT_SERIAL_KEY, 13 - LEN(@NEW_NUMBER)) + CONVERT(VARCHAR,@NEW_NUMBER)
							--select @NEW_NUMBER
                            INSERT INTO CONSIGNMENT (Consignment_Serial_Key, Consignment_ID, Consignment_Date, Date_Product, Date_Expired)
                            VALUES(@NEW_NUMBER,'" + txtConsignmentID.Text.Trim() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dptDateProduct.Value.ToString("yyyy-MM-dd") + "','" + dptDateExpired.Value.ToString("yyyy-MM-dd") + "')";
            string sql_consignment = @"SELECT TOP 1 Consignment_Serial_Key FROM CONSIGNMENT WHERE Consignment_ID = '" + txtConsignmentID.Text.Trim() + "'";


            if (txtProductID.Text == "" || txtBarcode.Text == "" || txtNameProduct.Text == "" || txtInventory.Text == "" || txtSalePrice.Text == "" || cbxGroup.Text == "" || cbxType.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else if (txtProductID.Text.Length < 10)
            {
                MessageBox.Show("Mã Sản Phẩm phải từ 10 ký tự");
            }
            else
            {
                try
                {

                    OleDbCommand cmd = new OleDbCommand(sql_type, conn);
                    OleDbCommand cmd1 = new OleDbCommand(sql_group, conn);
                    OleDbCommand cmd2 = new OleDbCommand(sql_add_consignment, conn);
                    OleDbCommand cmd3 = new OleDbCommand(sql_consignment, conn);
                    string product_type_serial_key = cmd.ExecuteScalar().ToString();
                    string product_group_serial_key = cmd1.ExecuteScalar().ToString();
                    cmd2.ExecuteNonQuery();
                    string consignment_serial_key = cmd3.ExecuteScalar().ToString();
                    clsSql update = new clsSql();
                    update.Update_Product(
                    txtSerialKey.Text,
                    txtProductID.Text,
                    txtBarcode.Text,
                    txtNameProduct.Text,
                    txtInventory.Text,
                    txtCostPrice.Text,
                    txtSalePrice.Text,
                    txtUnit.Text,
                    txtNote.Text,
                    txtSup.Text,
                    txtAddressSup.Text,
                    product_type_serial_key,
                    product_group_serial_key,
                    consignment_serial_key);


                    string update_consignment = @"update CONSIGNMENT 
                                                set Date_Product = '"+dptDateProduct.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "'," +
                                                " Date_Expired = '"+dptDateExpired.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + "' where Consignment_Serial_Key = '"+consignment_serial_key+"' ";
                    OleDbCommand cmd_update_consign = new OleDbCommand(update_consignment, conn);
                    cmd_update_consign.ExecuteNonQuery();
                    
                }
                catch
                {

                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                clsSql sql_delete = new clsSql();
                sql_delete.Product_Delete(txtSerialKey.Text);
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {

            }
        }

        private void btnCreateID_Click(object sender, EventArgs e)
        {
            string id_product = ""; // thuốc ký sinh ừ
            string[] Product_ID = cbxGroup.Text.Split(' ');
            int len = Product_ID.Length;
            try
            {
                for (int i = 0; i <= len - 1; i++)
                {
                    // thuốc ký

                    id_product += Product_ID[i].Substring(0, 1);
                    //id_product  = t;
                }


                //id_product += Product_ID[len - 1];
                clsSql unicode = new clsSql();
                txtProductID.Text = unicode.NonUnicode(id_product).ToUpper();
                //txtProductID.Text = id_product.ToUpper();
                //tksừ

                if (txtProductID.Text.Length < 2)
                {
                    txtProductID.Text += "0000";
                }
                else if (txtProductID.Text.Length < 3)
                {
                    txtProductID.Text += "000";
                }
                else if (txtProductID.Text.Length < 4)
                {
                    txtProductID.Text += "00";
                }
                else if (txtProductID.Text.Length < 5)
                {
                    txtProductID.Text += "0";
                }
                if (txtProductID.Text.Length < 10)
                {
                    txtProductID.Text += "00100";
                }
            }
            catch
            {

            }
        }
        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if (txtProductID.Text.Length > 10)
            {
                txtProductID.Text = txtProductID.Text.Substring(0, 10);
            }
        }

        private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string id_product = "";
            //string[] Product_ID = cbxGroup.Text.Split(' ');
            //int len = Product_ID.Length;
            //try
            //{
            //    for (int i = 0; i <= len - 1; i++)
            //    {
            //        id_product += Product_ID[i].Substring(0, 1);
            //    }
            //    //id_product += Product_ID[len - 1];
            //    txtProductID.Text = id_product.ToUpper();
            //    if (txtProductID.Text.Length < 2)
            //    {
            //        txtProductID.Text += "0000";
            //    }
            //    else if (txtProductID.Text.Length < 3)
            //    {
            //        txtProductID.Text += "000";
            //    }
            //    else if (txtProductID.Text.Length < 4)
            //    {
            //        txtProductID.Text += "00";
            //    }
            //    else if (txtProductID.Text.Length < 5)
            //    {
            //        txtProductID.Text += "0";
            //    }
            //    if (txtProductID.Text.Length < 10)
            //    {
            //        txtProductID.Text += "00100";
            //    }
            //}
            //catch
            //{

            //}
        }
    }
}
