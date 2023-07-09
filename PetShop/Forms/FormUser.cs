using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop;
using System.Data.OleDb;

namespace PetShop.Forms
{
    public partial class FormUser : Form
    {
        public int width_screen = Screen.PrimaryScreen.WorkingArea.Width / 100;
        public string key = "";
        clsSql ReadData_user = new clsSql();
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            //btn_Add.Visible = false;
            ReadData_user = clsSql.Get_Data_User();
            txt_TrangThai.ReadOnly = true;
            //lbl_FullName.Text = "Xin Chào: " + ReadData_user.User_FullName;
            ReadData_user.Get_user(dgvuser1);

            cbxMonth.Text = DateTime.Now.Month.ToString();
            Show_BonusStaff();
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
            
            btn_Delete.Enabled = false;
        }

        public void Show_BonusStaff()
        {
            try
            {
                string sSQL = @"select   i.user_id, sum((id.Product_Price*Product_Total)*0.1) as tongtien, u.User_Time_In,u.User_Status,u.User_Full_Name
                                from INVOICE i, USER_AD u, INVOICE_DETAIL id
                                where id.Invoice = i.Invoice_Serial_Key 
                                and i.User_id = u.User_Login 
                                and left(id.Product_Id,2) ='dv' 
                                and i.User_id = u.User_Login
                                and Month(CONVERT(date,i.Invoice_Date)) between 7 and 12
                                --and Month(CONVERT(date,i.Invoice_Date)) = MONTH(getdate())
                                group by i.User_id,u.User_Full_Name,u.User_Time_In,u.User_Status";

                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                dgvStaffBonus.Rows.Clear();
                int t = 1;
                while (reader.Read())
                {
                    dgvStaffBonus.Rows.Add(new object[]
                    {
                        t,
                        reader["User_Full_Name"].ToString(),
                        //reader["tongtien"].ToString(),
                        String.Format("{0:#,0 VNĐ}", reader["tongtien"]),
                        reader["User_Time_In"].ToString(),
                        reader["User_Status"].ToString()
                    });
                    t++;
                }
            }
            catch
            {

            }
        }

        enum dgvenum:int
        {
            STT,
            User_Serial_Key,  
            User_Full_Name,
            User_Login,
            Password_Login,
            User_Time_In,
            UserPhone,
            User_Level,
            User_Status
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txt_HoTen.Text = "";
            txt_MatKhau.Text = "";
            txt_SDT.Text = "";
            txt_TaiKhoang.Text = "";
            txt_TrangThai.Text = "";
            ReadData_user.Get_user(dgvuser1);
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                clsSql update = new clsSql();
                update.Update_User(txt_TaiKhoang.Text.Trim());
                update.Get_user(dgvuser1);
            }
            catch
            {

            }
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoang.Text != "" || txt_MatKhau.Text != "" || txt_HoTen.Text != "" || txt_SDT.Text != "")
            {

                clsSql add = new clsSql();
                if (add.check_user(txt_TaiKhoang.Text) == true)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!!!");
                }
                else
                {
                    add.Insert_User(txt_TaiKhoang.Text, txt_MatKhau.Text, txt_HoTen.Text, txt_SDT.Text);
                    ReadData_user.Get_user(dgvuser1);
                    btnLamMoi_Click_1(sender, e);
                    //ReadData_user.Get_user(dgvuser1);
                    //Employee_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng điền đủ thông tin");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            clsSql cls = new clsSql();
            cls.Update_User_info(txt_HoTen.Text, txt_TaiKhoang.Text, txt_MatKhau.Text, txt_SDT.Text, key);
            cls.Get_user(dgvuser1);
        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sSQL = @"select   i.user_id, sum((id.Product_Price*Product_Total)*0.1) as tongtien, u.User_Time_In,u.User_Status,u.User_Full_Name
                                from INVOICE i, USER_AD u, INVOICE_DETAIL id
                                where id.Invoice = i.Invoice_Serial_Key 
                                and i.User_id = u.User_Login 
                                and left(id.Product_Id,2) ='dv' 
                                and i.User_id = u.User_Login
                                and Month(CONVERT(date,i.Invoice_Date)) = '" + cbxMonth.Text.Trim() + @"'
                                --and Month(CONVERT(date,i.Invoice_Date)) = MONTH(getdate())
                                group by i.User_id,u.User_Full_Name,u.User_Time_In,u.User_Status";

                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                dgvStaffBonus.Rows.Clear();
                int t = 1;
                while (reader.Read())
                {
                    dgvStaffBonus.Rows.Add(new object[]
                    {
                        t,
                        reader["User_Full_Name"].ToString(),
                        //reader["tongtien"].ToString(),
                        String.Format("{0:#,0 VNĐ}", reader["tongtien"]),
                        reader["User_Time_In"].ToString(),
                        reader["User_Status"].ToString()
                    });
                    t++;
                }
            }
            catch
            {

            }
        }

        private void dgvuser1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            key = dgvuser1.CurrentRow.Cells[(int)dgvenum.User_Serial_Key].Value?.ToString();
            txt_HoTen.Text = dgvuser1.CurrentRow.Cells[(int)dgvenum.User_Full_Name].Value?.ToString();
            txt_TaiKhoang.Text = dgvuser1.CurrentRow.Cells[(int)dgvenum.User_Login].Value?.ToString();
            txt_MatKhau.Text = dgvuser1.CurrentRow.Cells[(int)dgvenum.Password_Login].Value?.ToString();
            txt_SDT.Text = dgvuser1.CurrentRow.Cells[(int)dgvenum.UserPhone].Value?.ToString();
            txt_TrangThai.Text = dgvuser1.CurrentRow.Cells[(int)dgvenum.User_Status].Value?.ToString();
            txt_TrangThai.ReadOnly = true;
            btn_Add.Enabled = false;
            btn_Delete.Enabled = true;
            btn_Update.Enabled = true;
        }
    }
}
