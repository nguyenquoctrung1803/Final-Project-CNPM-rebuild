using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;


namespace BUS
{
    public class DoanhThu_BUS
    {
        DoanhThu_DAL bus = new DoanhThu_DAL();

        public DataTable DoanhThuTatCa(string condition)
        {
            return bus.DoanhThuTatCa(condition);
        }

        public DataTable DoanThuTheoNam(string condition)
        {
            return bus.DoanhThuTheoNam(condition);
        }

        public DataTable DoanhThuTheoThang(string condition, string condition1)
        {
            return bus.DoanhThuTheoThang(condition, condition1);
        }

        public DataTable DoanhThuTheoNgay(string condition)
        {
            return bus.DoanhThuTheoNgay(condition);
        }

            
        public DataTable DoanhThuCacThang()
        {
            return bus.DoanhThuCacThang();
        }

        public DataTable LietKeNhapHang(string condition)
        {
            return bus.LietKeNhapHang(condition);
        }

        public DataTable LietKeXuatHang(string condition)
        {
            return bus.LietKeXuatHang(condition);
        }
    }
}
