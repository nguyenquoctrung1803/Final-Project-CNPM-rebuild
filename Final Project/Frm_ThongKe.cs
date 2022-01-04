using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;


namespace Final_Project
{
    public partial class Frm_ThongKe : Form
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
            
        }

        DoanhThu_BUS bus = new DoanhThu_BUS();

       
       
        public void HienThiDoanhThuTheoNam(string condition)
        {
            cboDoanhThu.DataSource = bus.DoanThuTheoNam("" + condition);
            cboDoanhThu.DisplayMember = "TT";
        }

        public void HienThiDoanhThuTheoNgay(string condition, string condition1)
        {
            chart1.DataSource = bus.DoanhThuTheoNgay("Select  format(sum([TongTien]),'N0') AS 'Doanh Thu'" +
                " From HoaDonBanHang Where(NgayLapHDBH) BETWEEN '" + condition + "' and '" + condition1 + "' ");

        }

        public void DoanhThuTheoThang(string condition, string condition1)
        {
            cboDoanhThu.DataSource = bus.DoanhThuTheoThang("" + condition, condition1);
            cboDoanhThu.DisplayMember = "TT";
        }

        
       
          
        public void LoadBieuDo()
        {
            int year = DateTime.Now.Year;
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "{#,###} Đ";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;
    
            chart1.DataSource = bus.DoanhThuCacThang();
            chart1.Series["Doanh Thu"].XValueMember = "Thang";
            chart1.Series["Doanh Thu"].YValueMembers = "TongTien";
            chart1.Titles.Add("Doanh Thu Các Tháng Của Năm" + " " + year);
        }


        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pM_BanLinhKienPCDataSet1.CT_HoaDonBanHang' table. You can move, or remove it, as needed.
            this.cT_HoaDonBanHangTableAdapter.Fill(this.pM_BanLinhKienPCDataSet1.CT_HoaDonBanHang);
            // TODO: This line of code loads data into the 'pM_BanLinhKienPCDataSet.CT_HoaDonNhapHang' table. You can move, or remove it, as needed.
            this.cT_HoaDonNhapHangTableAdapter.Fill(this.pM_BanLinhKienPCDataSet.CT_HoaDonNhapHang);

            Fill_CmbYear();
            LoadBieuDo();
        }


        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {

            if (radioTheoThang.Checked == true)
            {
                string condition = comboBoxThang.Text;
                string condition1 = comboBoxNam.Text;
                DoanhThuTheoThang(condition, condition1);
            }
            if (radioDoanhThuYea.Checked == true)
            {
                string condition2 = comboBoxNam.Text;
                HienThiDoanhThuTheoNam(condition2);
            }
            if (radioButThuChi.Checked == true)
            {
                string condition = comboBoxThang.Text;
                string condition1 = comboBoxNam.Text;             
            }
            if (radioButKhanChiNam.Checked == true)
            {
                string condition = comboBoxNam.Text;
            }
           
        }

        private void fillChart()
        {
            float x1 = 34;
            float x2 = 24;
            float x3 = 31;
            float x4 = 20;
            float x5 = 14;
            float x6 = 10;
            float x7 = 36;
            float x8 = 9;
            float x9 = 18;
            float x10 = 28;
            float x11 = 44;
            float x12 = 48;

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 50;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("Doanh Thu");
            chart1.Series["Doanh Thu"].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsVisibleInLegend = false;

            chart1.Series["Doanh Thu"].Points.AddXY(1, x1);
            chart1.Series["Doanh Thu"].Points.AddXY(2, x2);
            chart1.Series["Doanh Thu"].Points.AddXY(3, x3);
            chart1.Series["Doanh Thu"].Points.AddXY(4, x4);
            chart1.Series["Doanh Thu"].Points.AddXY(5, x5);
            chart1.Series["Doanh Thu"].Points.AddXY(6, x6);
            chart1.Series["Doanh Thu"].Points.AddXY(7, x7);
            chart1.Series["Doanh Thu"].Points.AddXY(8, x8);
            chart1.Series["Doanh Thu"].Points.AddXY(9, x9);
            chart1.Series["Doanh Thu"].Points.AddXY(10, x10);
            chart1.Series["Doanh Thu"].Points.AddXY(11, x11);
            chart1.Series["Doanh Thu"].Points.AddXY(12, x12);
        }



        private void Fill_CmbYear()
        {
            try
            {
                comboBoxNam.Items.Clear();
                comboBoxNam.Items.Add("Select");
                for (int i = DateTime.Now.Year - 1; i < DateTime.Now.Year + 1; i++)
                {
                    comboBoxNam.Items.Add(i);
                }              
            }
            catch
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewXuatHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewXuatHang.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void DataGridViewNhapHang_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewNhapHang.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
