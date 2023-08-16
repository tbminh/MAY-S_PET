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
            set { NumToTal.Value = Convert.ToDecimal(value); }
        }
        public string Serial_Key
        {
            get { return lblSerialKey.Text; }
            set { lblSerialKey.Text = value; }
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
        }
        public void NumToTal_ValueChanged(object sender, EventArgs e)
        {
            NumToTal.DecimalPlaces = 1;
            NumToTal.Text = NumToTal.Value.ToString("0.0");
            if (NumToTal.Text.Contains(".") || NumToTal.Text.Contains(","))
            {
                // Xử lý khi có dấu phân tách thập phân (dấu chấm hoặc dấu phẩy)
                float floatValue;

                if (CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator == ",")
                {
                    // Định dạng region sử dụng dấu phẩy làm phân tách thập phân
                    floatValue = float.Parse(NumToTal.Text, new CultureInfo("vi-VN"));
                }
                else
                {
                    // Định dạng region sử dụng dấu chấm làm phân tách thập phân
                    floatValue = float.Parse(NumToTal.Text, CultureInfo.InvariantCulture);
                }
                NumToTal.Value = (decimal)floatValue;
            }

            if (isFirstTime) //Khi lần đầu double click mở usercontrol sẽ vào đây để tránh valuechanged
            {
                isFirstTime = false;
                return;
            }
            if (NumToTal.Value > 0)
            {
                float result;
                float qty = float.Parse(NumToTal.Text);
                float price = float.Parse(lblPriceSale.Text.Replace(",", "").Replace(".", ""));
                result = qty * price;
                Sum_Price = result.ToString("#,##0");
                FormSelling frm = this.ParentForm as FormSelling;
                frm.Update_Invoice_Detail(Serial_Key, NumToTal.Text.Trim());
                frm.Save_Invoice();
                frm.Reload_lblTotalPrice();
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
                checkout.Save_Invoice();
                checkout.Reload_lblTotalPrice();
                this.Visible = false;
            }
        }

        private void NumToTal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hoặc dấu chấm không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ
            }
            // Kiểm tra xem đã có dấu chấm trong Guna2NumericUpDown chưa
            if (e.KeyChar == '.' && (sender as Guna.UI2.WinForms.Guna2NumericUpDown).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Ngăn chặn ký tự dấu chấm thứ hai
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (int.TryParse(NumToTal.Text, out _) || float.TryParse(NumToTal.Text, out _))
                {
                    float qty = float.Parse(NumToTal.Text);
                }
            }
        }
    }
}
