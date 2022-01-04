using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DoanhThu_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable DoanhThuTatCa(string Condition)
        {
            return KetNoi.GetDataTable("Select SUM(TongTien) AS DoanhThu from HoaDonBanHang" + Condition);
        }

        public DataTable LietKeNhapHang(string Condition)
        {
            return KetNoi.GetDataTable("select MaHDNH,NCC.TenNCC,NV.TenNV,NgayLapHDNH,TongTien,HD.TrangThai From HoaDonNhapHang HD,NhaCungCap NCC,NhanVien NV Where NV.MaNV=HD.MaNV and NCC.MaNCC=HD.MaNCC and HD.TrangThai=N'1'" + Condition);
        }
        public DataTable LietKeXuatHang(string Condition)
        {
            return KetNoi.GetDataTable("Select HoaDonBanHang.MaHDBH,TenKH,TennV,HoaDonBanHang.NgayLapHDBH,TongTien From HoaDonBanHang,NhanVien,KhachHang Where NhanVien.MaNV=HoaDonBanHang.MaNV and KhachHang.MaKH=HoaDonBanHang.MaKH " + Condition);
        }

        public DataTable DoanhThuTheoNam(string condition)
        {
            return KetNoi.GetDataTable("Select format(sum([TongTien]),'N0') as TT" +
                " From HoaDonBanHang Where YEAR(NgayLapHDBH) =" + condition + "");
        }

        public DataTable DoanhThuTheoThang(string condition, string condition1)
        {
            return KetNoi.GetDataTable("SELECT   format(sum([TongTien]),'N0') AS TT" +
              " FROM HoaDonBanHang hd WHERE Month(hd.NgayLapHDBH)=" + condition + " and Year(hd.NgayLapHDBH)=" + condition1 + " ");
        }     
        public DataTable DoanhThuTheoNgay(string condiiton)
        {
            return KetNoi.GetDataTable("" + condiiton);
        }
    
       
                      
        public DataTable DoanhThuCacThang()
        {
            return KetNoi.GetDataTable("SELECT Month(hd.NgayLapHDBH) as Thang, sum(hd.TongTien) as TongTien " +
            " FROM HoaDonBanHang hd WHERE hd.TrangThai=N'1' and Month(hd.NgayLapHDBH)>0 and MONTH(hd.NgayLapHDBH)<13  Group By Month(hd.NgayLapHDBH) ");
        }
              
       
    }
}
