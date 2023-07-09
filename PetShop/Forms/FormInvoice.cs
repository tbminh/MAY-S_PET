using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms
{
    public partial class FormInvoice : Form
    {
        public string key_order = "";
        public FormInvoice()
        {
            InitializeComponent();
        }
        enum dgv_enum : int
        {
            stt,
            key,
            gia,
            ngay_thanh_toan,
            ten_kh,
            sdt,
            tk_nv,
            trang_thai,
            ngay_hen,
            ten_pet,
            ghi_chu,
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            int tong_DoanhThu = 0;
            clsSql sql_show = new clsSql();
            if (radio_da_thanh_toan.Checked && txt_tim.Text == "")
            {
                gia.Visible = true;
                ngay_thanh_toan.Visible = true;
                ten_kh.Visible = true;
                sdt.Visible = true;
                tk_nv.Visible = true;
                trang_thai.Visible = true;
                ghi_chu.Visible = true;
                tong_DoanhThu = sql_show.show_Invoice(dgv_invoice, radio_da_thanh_toan, radio_dang_cho, radio_tai_kham, radio_dich_vu, dateTime_tu, dateTime_den, txt_tim.Text);
                lbl_tongHD.Text = tong_DoanhThu.ToString("#,##0 đ");
                ngay_hen.Visible = false;
                ten_pet.Visible = false;
                lbl_tongHD.Visible = true;
            }
            else if (radio_dang_cho.Checked && txt_tim.Text == "")
            {
                gia.Visible = false;
                ngay_thanh_toan.Visible = false;
                sql_show.show_Invoice(dgv_invoice, radio_da_thanh_toan, radio_dang_cho, radio_tai_kham, radio_dich_vu, dateTime_tu, dateTime_den, txt_tim.Text);
                lbl_tongHD.Visible = false;
                ngay_hen.Visible = false;
                ten_pet.Visible = false;
            }
            else if (radio_tai_kham.Checked && txt_tim.Text == "")
            {
                gia.Visible = true;
                ngay_thanh_toan.Visible = true;
                ten_kh.Visible = true;
                sdt.Visible = true;
                tk_nv.Visible = true;
                trang_thai.Visible = true;
                ghi_chu.Visible = true;
                ngay_hen.Visible = true;
                ten_pet.Visible = true;
                tong_DoanhThu = sql_show.show_Invoice(dgv_invoice, radio_da_thanh_toan, radio_dang_cho, radio_tai_kham, radio_dich_vu, dateTime_tu, dateTime_den, txt_tim.Text);
                lbl_tongHD.Text = tong_DoanhThu.ToString("#,##0 đ");
                lbl_tongHD.Visible = true;
            }
            else if (radio_dich_vu.Checked && txt_tim.Text == "")
            {
                gia.Visible = true;
                ngay_thanh_toan.Visible = true;
                ten_kh.Visible = true;
                sdt.Visible = true;
                tk_nv.Visible = true;
                trang_thai.Visible = true;
                ghi_chu.Visible = true;
                tong_DoanhThu = sql_show.show_Invoice(dgv_invoice, radio_da_thanh_toan, radio_dang_cho, radio_tai_kham, radio_dich_vu, dateTime_tu, dateTime_den, txt_tim.Text);
                lbl_tongHD.Text = tong_DoanhThu.ToString("#,##0 đ");
                ngay_hen.Visible = false;
                ten_pet.Visible = false;
                lbl_tongHD.Visible = true;
            }
            else if (txt_tim.Text != "")
            {
                gia.Visible = true;
                ngay_thanh_toan.Visible = true;
                ten_kh.Visible = true;
                sdt.Visible = true;
                tk_nv.Visible = true;
                trang_thai.Visible = true;
                ghi_chu.Visible = true;
                ngay_hen.Visible = true;
                ten_pet.Visible = true;
                tong_DoanhThu = sql_show.show_Invoice(dgv_invoice, radio_da_thanh_toan, radio_dang_cho, radio_tai_kham, radio_dich_vu, dateTime_tu, dateTime_den, txt_tim.Text);
                lbl_tongHD.Text = tong_DoanhThu.ToString("#,##0 đ");
                lbl_tongHD.Visible = true;
                txt_tim.Text = "";
            }
        }
        
        private void dgv_invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsSql sql_detail = new clsSql();
            key_order = dgv_invoice.CurrentRow.Cells[(int)dgv_enum.key].Value?.ToString();
            sql_detail.show_Invoice_Detail(dgv_detail, key_order);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();

            //Set PrinterName as the selected printer in the printers list  
            pd.PrinterSettings.PrinterName = @"\\192.168.30.70\EPSON L310 Series";

            //Add PrintPage event handler  
            // pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            //Print the document  
            pd.Print();
            ///
            //pvdCORPrint.Document = printReview;
            //string a = ((ToolStrip)(pvdCORPrint.Controls[1])).Items.Count.ToString();
            //((ToolStrip)(pvdCORPrint.Controls[1])).Items.RemoveByKey("printToolStripButton");
            //pvdCORPrint.ShowDialog();
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //BarcodeLib.Barcode code128;
            //code128 = new Barcode();
            //Get the Graphics object  
            Graphics g = ev.Graphics;
            //son xau quat    dang moi dep trai
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



            ////Tên SHop 
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
                            FROM PRODUCT_INFO P, INVOICE I, INVOICE_DETAIL ID, USER_AD U
                            WHERE P.Product_Id = ID.Product_Id
                            and I.Invoice_Serial_Key = ID.Invoice
                            and U.User_Login = I.User_id
                            and ID.Invoice = '"+key_order+"'";
            string sql_user_name = @"SELECT top 1 U.User_Full_Name
                            FROM PRODUCT_INFO P, INVOICE I, INVOICE_DETAIL ID, USER_AD U
                            WHERE P.Product_Id = ID.Product_Id
                            and I.Invoice_Serial_Key = ID.Invoice
                            and U.User_Login = I.User_id
                            and ID.Invoice = '"+ key_order + "'";
            string sql_Total_Price = @"SELECT top 1 I.Total_Price
                            FROM PRODUCT_INFO P, INVOICE I, INVOICE_DETAIL ID, USER_AD U
                            WHERE P.Product_Id = ID.Product_Id
                            and I.Invoice_Serial_Key = ID.Invoice
                            and U.User_Login = I.User_id
                            and ID.Invoice = '"+ key_order + "'";

            string sSQL = @"SELECT P.Product_Name,P.Product_Sale_Price, ID.Product_Total,I.Total_Price
                            FROM PRODUCT_INFO P, INVOICE I, INVOICE_DETAIL ID, USER_AD U
                            WHERE P.Product_Id = ID.Product_Id
                            and I.Invoice_Serial_Key = ID.Invoice
                            and U.User_Login = I.User_id
                            and ID.Invoice = '"+ key_order + "'";

            OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql_invoice_key, conn);
            OleDbCommand cmd1 = new OleDbCommand(sql_user_name, conn);
            OleDbCommand cmd2 = new OleDbCommand(sql_Total_Price, conn);
            OleDbCommand cmd_SP = new OleDbCommand(sSQL, conn);
            OleDbDataReader read = cmd_SP.ExecuteReader();
            string Invoice_key = cmd.ExecuteScalar().ToString();
            string User_Name = cmd1.ExecuteScalar().ToString();
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
            g.DrawString("Tổng tiền: ", font5, brush, new Rectangle(50, product_total_pos_y - 20, 302, 30));
            g.DrawString(String.Format("{0:#,0}", Convert.ToInt32(totalPrice)), font4, brush, new Rectangle(150, product_total_pos_y - 20, 302, 30));
            //tổng tiền

            //tiền khách đưa
            g.DrawString("Tiền khách đưa: ", font5, brush, new Rectangle(50, product_total_pos_y, 302, 30));
            g.DrawString(String.Format("{0:#,0}", Convert.ToInt32(500000)), font4, brush, new Rectangle(150, product_total_pos_y, 302, 30));
            //tiền khách đưa

            //tiền thừa
            g.DrawString("Tiền thối lại: ", font5, brush, new Rectangle(50, product_total_pos_y + 20, 302, 30));
            g.DrawString(String.Format("{0:#,0}", 500000 - Convert.ToInt32(totalPrice)), font4, brush, new Rectangle(150, product_total_pos_y + 20, 302, 30));
            //tiền thừa
            g.DrawString("--------------------------------------------------------------", font2, brush, new Rectangle(10, product_total_pos_y + 30, 302, 30));




            g.DrawString("Lưu ý: Hóa đơn chỉ xuất trong ngày. Quý khách vui lòng kiểm hàng trước khi thanh toán. Hàng mua rồi không được đổi trả!", font4, brush, new Rectangle(10, product_total_pos_y + 45, 302, 60));
            g.DrawString("MAY'S PET CÁM ƠN QUÝ KHÁCH!", font6, brush, new Rectangle(15, product_total_pos_y + 110, 302, 30));
            //PictureBox picture_barcode = new PictureBox();
            //picture_barcode.Location = new System.Drawing.Point(0, product_total_pos_y + 80);
            //this.Controls.Add(picture_barcode);
            //Color forecolor = Color.Black;
            //Color backcolor = Color.Transparent;
            //Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, totalPrice +" - " + DateTime.Now.ToString("ddMMyyyy - HHmmss"), forecolor, backcolor, 275, 30); ;
            //picture_barcode.Image = barcode;
            //g.DrawImage(barcode, 0, product_total_pos_y + 130);
        }
    }
}
