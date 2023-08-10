﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PetShop.Forms
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private bool isFirstTime = true;
        public string Price_Sale 
        {
            get { return lblPriceSale.Text; }
            set { lblPriceSale.Text = value; }
        }
        public string Sum_Price 
        {
            get { return lblSumPrice.Text; }
            set { lblSumPrice.Text = value; }
        }
        public static float Sumprice_Float;
        public string Product_ID
        {
            get { return lblProductID.Text; }
            set { lblProductID.Text = value; }
        }
        public string Unit
        {
            get { return lblUnit.Text; }
            set { lblUnit.Text = value; }
        }
        public string Product_Name
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
        public string Product_Total_Qty
        {
            get { return NumToTal.Text; }
            set { NumToTal.Value = long.Parse(value); }
        }
        public string Serial_Key
        {
            get { return lblSerialKey.Text; }
            set { lblSerialKey.Text = value; }
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            //string SQL = $@"SELECT I.*,P.Product_Unit as unit, P.Product_SubUnit as subunit 
            //                FROM INVOICE_DETAIL I, PRODUCT_INFO P
            //                WHERE I.Product_Id = P.Product_Id
            //                AND Invoice_Serial_Key = '{Serial_Key}'
            //                ORDER BY Invoice_Serial_Key DESC";
            //using (OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String))
            //{
            //    using (OleDbCommand cmd = new OleDbCommand(SQL, conn))
            //    {
            //        conn.Open();
            //        OleDbDataReader reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            //Product_Sale_Price = reader["Product_Sale_Price"].ToString();
            //            //Product_Sale_SubPrice = reader["Product_Sale_SubPrice"].ToString();
            //            cbxUnit.Items.Add(reader["unit"].ToString());
            //            cbxUnit.Items.Add(reader["subunit"].ToString());
            //            cbxUnit.SelectedItem = reader["Product_Unit"].ToString();
            //            //if (reader["subunit"].ToString() != "")
            //            //{
            //            //    cbxUnit.Items.Add(reader["subunit"].ToString());
            //            //    //cbxUnit.SelectedItem = reader["Sub_Unit"].ToString();
            //            //    isSubUnit = true; //Có đơn vị chi tiết
            //            //}
            //        }
            //    }
            //}
        }
        public void NumToTal_ValueChanged(object sender, EventArgs e)
        {
            NumToTal.Text = NumToTal.Value.ToString();
            if (isFirstTime)
            {
                isFirstTime = false;
                return;
            }
            if (NumToTal.Value > 0)
            {
                float result;
                int qty = int.Parse(NumToTal.Text);
                int price = int.Parse(lblPriceSale.Text.Replace(",", "").Replace(".", ""));
                result = qty * price;
                Sum_Price = result.ToString("#,##0");
                FormSelling frm = this.ParentForm as FormSelling;
                frm.Update_Product_Total(Serial_Key, NumToTal.Text.Trim());
                frm.Update_Total_Bill();
            }
            else
            {
                NumToTal.Value = 1;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormSelling checkout = this.ParentForm as FormSelling;
            if (checkout != null)
            {
                checkout.Delete_Product(Serial_Key);
                this.Visible = false;
            }
        }
    }
}
