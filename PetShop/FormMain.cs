using PetShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PetShop
{
    public partial class FormMain : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Color color = Color.FromArgb(41, 128, 185);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        public FormMain()
        {
            InitializeComponent();
            random = new Random();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            clsSql.Get_Data_User();
            if (clsSql.User_Level == "2")
            {
                btnUser.Visible = false;
                btnList.Visible = false;
                btnInvoice.Visible = false;
            }
        }
        private void DisableButton()
        {
            //foreach (IconButton button in this.Controls.OfType<IconButton>())
            //{
            //    if (button.GetType() == typeof(IconButton))
            //    {
            //        //button.BackColor = Color.FromArgb(51, 51, 76);
            //        button.BackColor = color;
            //        button.ForeColor = Color.Gainsboro;
            //        button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    }
            //}

            if (currentButton != null)
            {
                //currentButton.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Close(); // Close the form
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        bool sidebarExpand;
        private void Expand_SideBar()
        {
            if (sidebarExpand)
            {
                //Minimize
                panelMenu.Width = panelMenu.MinimumSize.Width;
                sidebarExpand = false;
                sidebarTimer.Stop();
                btnUser.Text = "";
                btnProduct.Text = "";
                btnSale.Text = "";
                btnList.Text = "";
                btnInvoice.Text = "";
                btnNotification.Text = "";
                btnSetting.Text = "";
                btnLogOut.Text = "";
            }
            else
            {
                //Maximize
                panelMenu.Width = panelMenu.MaximumSize.Width;
                sidebarExpand = true;
                sidebarTimer.Stop();
                btnUser.Text = "Người Dùng";
                btnProduct.Text = "Sản Phẩm";
                btnSale.Text = "Bán Hàng";
                btnList.Text = "Thống Kê";
                btnInvoice.Text = "Hóa Đơn";
                btnNotification.Text = "Thông Báo";
                btnSetting.Text = "Cài Đặt";
                btnLogOut.Text = "Đăng Xuất";
            }
        }
        private void Reset()
        {
            DisableButton();
            btnHome.Text = "Trang Chủ";
            btnHome.BackColor = Color.FromArgb(41, 128, 185);
            panelTitleBar.BackColor = Color.FromArgb(41, 128, 185);
            panelLogo.BackColor = Color.FromArgb(41, 128, 185);
            panelMenu.BackColor = Color.FromArgb(41, 128, 185);
            currentButton = null;
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();
                    currentButton = (IconButton)btnSender;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.ForeColor = Color.Gainsboro;
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.IconColor = Color.Gainsboro;
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentButton.ImageAlign = ContentAlignment.MiddleRight;
                    currentButton.BackColor = color;

                    panelTitleBar.BackColor = color;
                    btnHome.BackColor = color;
                    panelMenu.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                    //Left border button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (clsSql.permission == 1)
            {
                //color = SelectThemeColor();
                OpenChildForm(new Forms.FormUser(), sender);
                btnHome.Text = "Người Dùng";
                btnHome.IconChar = btnUser.IconChar;
            }
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            //color = Color.FromArgb(128, 128, 255);
            //OpenChildForm(new Forms.FormProduct(), sender);
            //btnHome.Text = "Sản Phẩm";
            //btnHome.IconChar = btnProduct.IconChar;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            //color = SelectThemeColor();
            OpenChildForm(new Forms.FormSelling(), sender);
            btnHome.Text = "Cài Đặt";
            btnHome.IconChar = btnNotification.IconChar;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //color = SelectThemeColor();
            OpenChildForm(new Forms.FormReport(), sender);
            btnHome.Text = "Danh Sách";
            btnHome.IconChar = btnList.IconChar;
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            //color = Color.FromArgb(128, 128, 255);
            OpenChildForm(new Forms.FormInvoice(), sender);
            btnHome.Text = "Hóa Đơn";
            btnHome.IconChar = btnProduct.IconChar;
        }
        private void btnNotification_Click(object sender, EventArgs e)
        {
            //color = SelectThemeColor();
            btnHome.Text = btnInvoice.Text;
            btnHome.IconChar = btnInvoice.IconChar;
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            //color = Color.FromArgb(128, 128, 255);
            OpenChildForm(new Forms.FormSelling(), sender);
            btnHome.Text = "Hóa Đơn";
            btnHome.IconChar = btnProduct.IconChar;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Close();
            frm.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Expand_SideBar();
            DisableButton();
        }
        private void lblBrand_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
    }
}
