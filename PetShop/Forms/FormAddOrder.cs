using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms
{
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string order_key = "";
        public static string name = "";
        public static string phone = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsSql sql = new clsSql();
            FormCheckOut checkout = new FormCheckOut();
            if ((txt_sdt.Text.Length == 10 && txt_sdt.Text.Substring(0, 1) == "0" && sql.chek_Int(txt_sdt.Text) == true) || (txt_ten.Text.Length == 0 || txt_ten.Text.Length == 10))
            {
                if (sql.check_sdt(txt_sdt.Text) == true || txt_sdt.Text.Length == 0)
                {
                    string invoice_date = DateTime.Now.ToString("yyyy/MM/dd");
                    if (chkb_taikham.Checked == true)
                    {
                        clsSql carts = new clsSql();
                        string ngay = datatime_ngaytaikham.Value.ToString("yyyy/MM/dd");
                        string tenPet = txt_tenpet.Text;
                        carts.Insert_Car(invoice_date, txt_ten.Text, txt_sdt.Text, ngay, tenPet);
                        carts.set_ip_check();
                    }
                    else
                    {
                        clsSql carts = new clsSql();
                        carts.Insert_Car(invoice_date,txt_ten.Text, txt_sdt.Text, "", "");
                        carts.set_ip_check();
                    }
                    txt_tenpet.Text = "";
                    clsSql get_ID_HD = new clsSql();
                    get_ID_HD = clsSql.Get_ID_INVOICE();
                    //checkout.Cus_Name = txt_ten.Text;
                    //checkout.Number_Phone = txt_sdt.Text;
                    //checkout.SerialKey = get_ID_HD.ID_HoaDon;
                    order_key = get_ID_HD.ID_HoaDon;
                        
                    phone = txt_sdt.Text;
                    
                    if (txt_ten.Text.Length == 0)
                    {
                        name = "Khách Vãng Lai";
                    }
                    else
                    {
                        name = txt_ten.Text;
                    }
                //checkout.Show_Payment_Layout(get_ID_HD.ID_HoaDon);
                this.Close();
                }
                else
                {
                    //MessageBox.Show("Số Điện Thoại Này Đã Tạo Hóa Đơn Và Chưa Thanh Toán");

                    DialogResult result = MessageBox.Show("Số Điện Thoại Này Đã Tạo Hóa Đơn Và Chưa Thanh Toán Bạn Muốn Tiếp Tục Với Số Điện Thoại Này", "Save Changes", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                            
                        string sql1 = "select Invoice_Serial_Key from INVOICE where Phone = '"+ txt_sdt.Text + "' and Status = 'waiting'";
                        OleDbConnection sqlConnect = new OleDbConnection(clsConnect.Connect_String);
                        OleDbCommand sqlCommand = new OleDbCommand(sql1, sqlConnect);
                        sqlConnect.Open();
                        order_key = sqlCommand.ExecuteScalar().ToString();
                        sqlConnect.Close();
                        this.Close();
                    }
                    else if (result == DialogResult.No)
                    {
                        // User clicked No button
                        // Discard changes here
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                //else
                //{
                //    MessageBox.Show("Số " + txt_sdt.Text + " đã được tạo hóa đơn");
                //}
            }
            else
            {
                MessageBox.Show("Số Điện Thoại Không Đúng Định Dạng");
            }
        }
        private void chkb_taikham_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_taikham.Checked)
            {
                datatime_ngaytaikham.Enabled = true;
                datatime_ngaytaikham.FillColor = Color.FromArgb(247, 72, 115);
                txt_tenpet.Enabled = true;
                txt_tenpet.FillColor = Color.White;
                txtNote.Enabled = true;
                txtNote.FillColor = Color.White;
            }
            else
            {
                datatime_ngaytaikham.Enabled = false;
                datatime_ngaytaikham.FillColor = Color.FromArgb(224, 224, 224);
                txt_tenpet.Enabled = false;
                txt_tenpet.FillColor = Color.FromArgb(224, 224, 224);
                txtNote.Enabled = false;
                txtNote.FillColor = Color.FromArgb(224, 224, 224);
            }
        }
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Length >= 10)
            {
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                string SQL = $"SELECT Customer_Full_Name FROM CUSTOMER_INFO WHERE Customer_Phone_Number = '{txt_sdt.Text}'";
                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    txt_ten.Text = result.ToString();
                }
            }
        }
    }
}
