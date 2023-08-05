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

namespace PetShop.Forms
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            addItemComboBox();

            getRevenueQuarter1();
            getRevenueQuarter2();
            getRevenueQuarter3();
            getRevenueQuarter4();
            getRevenueMonth();
            getRevenueYear();
            fillChart();
            //cbxMonth.Text = DateTime.Now.Month.ToString();
        }
        public void addItemComboBox()
        {
            cbxYear.Items.Add((DateTime.Now.Year - 1).ToString());
            cbxYear.Items.Add((DateTime.Now.Year).ToString());
            cbxYear.Items.Add((DateTime.Now.Year + 1).ToString());
            cbxYear.Text = cbxYear.Items[1].ToString();
        }

        public void getRevenueYear()
        {
            try
            {
                string sSQL = @"select ISNULL(SUM(Total_Price),0) from INVOICE where YEAR(Invoice_Date) = '" + cbxYear.SelectedItem.ToString() + "'";
                //string sSQL = @"select SUM(Total_Price) from INVOICE where YEAR(Invoice_Date) = '2023'";
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                lblRevenueYears.Text = String.Format("{0:#,0 VNĐ}", Convert.ToInt32(cmd.ExecuteScalar().ToString()));
            }
            catch (Exception e)
            {

            }
        }
        public void getRevenueMonth()
        {
            try
            {
                string sSQL = @"select ISNULL(SUM(Total_Price),0) from INVOICE where  Month(Invoice_Date) = Month(GETDATE()) and YEAR(Invoice_Date) = '" + cbxYear.SelectedItem.ToString() + "'";
                //string sSQL = @"select SUM(Total_Price) from INVOICE where YEAR(Invoice_Date) = '2023'";
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                lblRevenueMonths.Text = String.Format("{0:#,0 VNĐ}", Convert.ToInt32(cmd.ExecuteScalar().ToString()));
            }
            catch (Exception e)
            {

            }
        }

        public void getRevenueQuarter1()
        {
            try
            {
                string sSQL = @"select ISNULL(SUM(Total_Price),0) from INVOICE where Month(Invoice_Date) BETWEEN 1 and 3 and YEAR(Invoice_Date) = '" + cbxYear.SelectedItem.ToString() + "'";
                //string sSQL = @"select SUM(Total_Price) from INVOICE where YEAR(Invoice_Date) = '2023'";
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                lblRevenueQuarters1.Text = String.Format("{0:#,0 VNĐ}", Convert.ToInt32(cmd.ExecuteScalar().ToString()));
            }
            catch (Exception e)
            {

            }
        }
        public void getRevenueQuarter2()
        {
            try
            {
                string sSQL = @"select ISNULL(SUM(Total_Price),0) from INVOICE where Month(Invoice_Date) BETWEEN 4 and 6 and YEAR(Invoice_Date) = '" + cbxYear.SelectedItem.ToString() + "'";
                //string sSQL = @"select SUM(Total_Price) from INVOICE where YEAR(Invoice_Date) = '2023'";
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                lblRevenueQuarters2.Text = String.Format("{0:#,0 VNĐ}", Convert.ToInt32(cmd.ExecuteScalar().ToString()));
            }
            catch (Exception e)
            {

            }
        }
        public void getRevenueQuarter3()
        {
            try
            {
                string sSQL = @"select ISNULL(SUM(Total_Price),0) from INVOICE where Month(Invoice_Date) BETWEEN 7 and 9 and YEAR(Invoice_Date) = '" + cbxYear.SelectedItem.ToString() + "'";
                //string sSQL = @"select SUM(Total_Price) from INVOICE where YEAR(Invoice_Date) = '2023'";
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                lblRevenueQuarters3.Text = String.Format("{0:#,0 VNĐ}", Convert.ToInt32(cmd.ExecuteScalar().ToString()));
            }
            catch (Exception e)
            {

            }
        }
        public void getRevenueQuarter4()
        {
            try
            {
                string sSQL = @"select ISNULL(SUM(Total_Price),0) from INVOICE where Month(Invoice_Date) BETWEEN 10 and 12 and YEAR(Invoice_Date) = '" + cbxYear.SelectedItem.ToString() + "'";
                //string sSQL = @"select SUM(Total_Price) from INVOICE where YEAR(Invoice_Date) = '2023'";
                OleDbConnection conn = new OleDbConnection(clsConnect.Connect_String);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                lblRevenueQuarters4.Text = String.Format("{0:#,0 VNĐ}", Convert.ToInt32(cmd.ExecuteScalar().ToString()));
            }
            catch (Exception e)
            {

            }
        }
        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            getRevenueMonth();
            getRevenueYear();
            getRevenueQuarter1();
            getRevenueQuarter2();
            getRevenueQuarter3();
            getRevenueQuarter4();
        }

        private void fillChart()
        {
            ChartRevenue.Series["Salary"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            //AddXY value in chart1 in series named as Salary  
            ChartRevenue.Series["Salary"].Points.AddXY("1", "10000");
            ChartRevenue.Series["Salary"].Points.AddXY("2", "8000");
            ChartRevenue.Series["Salary"].Points.AddXY("3", "7000");
            ChartRevenue.Series["Salary"].Points.AddXY("4", "10000");
            ChartRevenue.Series["Salary"].Points.AddXY("5", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("7", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("6", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("8", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("9", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("10", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("11", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("13", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("14", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("15", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("16", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("17", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("18", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("19", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("20", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("21", "8500");
            ChartRevenue.Series["Salary"].Points.AddXY("22", "8500");
            ChartRevenue.Series["Salary"].Points[0].Label = "20000";
            //chart title  
            
            ChartRevenue.Titles.Add("Revenue Chart");
        }

        private void ChartRevenue_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
