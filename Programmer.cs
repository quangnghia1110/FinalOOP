using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Programmer:Staff
    {
        private int soLoiLapTrinh;
        private double luongThang;
        public int SoLoiLapTrinh { get => soLoiLapTrinh; set => soLoiLapTrinh = value; }
        public double LuongThang { get => luongThang; set => luongThang = value; }
        public Programmer()
        {

        }
        ~Programmer()
        {

        }
        public Programmer(int soLoiLapTrinh, double luongThang)
        {
            SoLoiLapTrinh = soLoiLapTrinh;
            LuongThang = luongThang;
        }
        public Programmer(string maNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string soNha, string tenDuong, string tenPhuong, string tenQuan, string tenThanhPho, string soDienThoai, string viTriCongViec, string noiDaLamViec, int soNamKinhNghiem, string khaNangNgoaiNgu, string trinhDoChuyenMon,string capDo,int soLoiLapTrinh, double luongThang) : base(maNhanVien,hoTen,ngaySinh,gioiTinh,soNha,tenDuong,tenPhuong,tenQuan,tenThanhPho,soDienThoai,viTriCongViec,noiDaLamViec,soNamKinhNghiem, khaNangNgoaiNgu,trinhDoChuyenMon,capDo)
        {
            SoLoiLapTrinh = soLoiLapTrinh;
            LuongThang = luongThang;
        }
        public override string toString()
        {
            return base.toString() + $"==> Lỗi lập trình: {soLoiLapTrinh} - Lương tháng: {luongThang}";
        }

        public override double tinhLuongHangThang()
        {
            if(soLoiLapTrinh<20)
            {
                return luongThang + 0.1 * luongThang ;
            }
            else 
            {
                return luongThang ;
            }
        }
       
    }
}
