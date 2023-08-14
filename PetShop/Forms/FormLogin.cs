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
        private void Login()
        {
            clsSql sqlquery = new clsSql();
            if (sqlquery.Check_Login(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                Form frmMain = new FormMain();
                frmMain.Show();
                this.Hide();
                taikhoan = txtTaiKhoan.Text;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }
        public FormLogin()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon; // Set icon in title bar
        }
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
