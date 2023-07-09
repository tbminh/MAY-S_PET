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
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();
        }
        public Color BackColorAlertBox
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public Color ColorAlertBox
        {
            get { return LinAlertBox.BackColor; }
            set { LinAlertBox.BackColor = LblTitleAlertBox.ForeColor = LblTextAlertBox.ForeColor = value; }
        }
        private void Alert_Load(object sender, EventArgs e)
        {
            //this.Top = 100;
            //this.Left = Screen.PrimaryScreen.Bounds.Height - this.Height - 100;

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            this.Location = new Point(screenWidth - this.Width, 0);
            show.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closealert.Start();
        }

        private void show_Tick(object sender, EventArgs e)
        {
            int elapsedMilliseconds = 0;
            elapsedMilliseconds += show.Interval;
            if (elapsedMilliseconds >= 1000) // Check if elapsed time is equal or greater than 1000 milliseconds
            {
                closealert.Start();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
        }
    }
}
