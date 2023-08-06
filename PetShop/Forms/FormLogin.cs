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
    public partial class FormLogin : Form
    {
        public static string taikhoan;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            clsSql sqlquery = new clsSql();
            if (sqlquery.Check_Login(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                Form frmMain = new FormMain();
                frmMain.Show();
                this.Hide();
                //frmLogin.Close();
                taikhoan = txtTaiKhoan.Text;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
