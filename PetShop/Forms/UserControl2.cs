using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
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
        public void NumToTal_ValueChanged(object sender, EventArgs e)
        {
            NumToTal.Text = NumToTal.Value.ToString();
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

        private void NumToTal_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumToTal.Text = NumToTal.Value.ToString();
            if (NumToTal.Value > 0)
            {
                float result;
                int qty = int.Parse(NumToTal.Text);
                int price = int.Parse(lblPriceSale.Text.Replace(",", ""));
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
    }
}
