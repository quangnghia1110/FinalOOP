using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace finalProject
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            Staff[] staff = new Staff[n];
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ______________________________________________________");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|       CHƯƠNG TRÌNH QUẢN LÝ CÔNG TY PHẦN MỀM C#       |");
                Console.WriteLine("|______________________________________________________|");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                   1. Thêm nhân viên                  |");
                Console.WriteLine("|                   2. Hiển thị danh sách              |");
                Console.WriteLine("|                   3. Tìm kiếm nhân viên              |");
                Console.WriteLine("|                   4. Thoát chương trình              |");
                Console.WriteLine("|______________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n***Nhập yêu cầu: ");
                int key = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                switch (key)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        NhapDanhSachNhanVien(staff);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        XuatDanhSachNhanVien(staff);
                        break;
                    case 3:
                        int id;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TimKiemNhanVien(staff);
                        XuatDanhSachNhanVien(staff);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nhân viên đã được tìm thấy");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nBạn đã chọn thoát khỏi chương trình!");
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nBạn đã nhập sai số, chỉ nhập giá trị từ 1 đến 4");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.Clear();
            }
        }
        static void XuatDanhSachNhanVien(Staff[] staff)
        {
            while (true)
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ______________________________________________________");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                HIỂN THỊ DANH SÁCH NHÂN VIÊN          |");
                Console.WriteLine("|______________________________________________________|");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                     1. Tiếp tục                      |");
                Console.WriteLine("|                     2. Thoát                         |");
                Console.WriteLine("|______________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n***Nhập yêu cầu hiển thị nhân viên: ");
                int key = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                
                switch (key)
                {
                    case 1:
                        Xuat(staff);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n==> Tổng có {0} nhân viên trong công ty", Staff.GetSoNguoi());
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nBạn đã chọn thoát khỏi chương trình!");
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nBạn đã nhập sai số, chỉ nhập giá trị từ 1 đến 4");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }    
        }
        static void Xuat(Staff[] staff)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n***Thông tin địa chỉ của nhân viên");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < staff.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                staff[i].PrintAddress();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nThông tin công việc của nhân viên");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < staff.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                staff[i].PrintJob();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nThông tin cơ bản của nhân viên");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < staff.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                staff[i].PrintStaff();
            }

        }
        static void NhapDanhSachNhanVien(Staff[] staff)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ______________________________________________________");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("|                NHẬP DANH SÁCH NHÂN VIÊN              |");
            Console.WriteLine("|______________________________________________________|");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("|                     1. Programmer                    |");
            Console.WriteLine("|                     2. Tester                        |");
            Console.WriteLine("|                     3. Thoát                         |");
            Console.WriteLine("|______________________________________________________|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n***Nhập danh sách nhân viên");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < staff.Length; i++)
            {
                int choose;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nNhập loại nhân viên: ");
                choose = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                while (choose != 1 && choose != 2 && choose != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nNhập loại nhân viên: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    choose =int.Parse(Console.ReadLine());
                   
                }
                if (choose == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBạn đã chọn thoát khỏi chương trình!");
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nhân viên thứ "+(i + 1));
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nhập thông tin chung");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tNhập mã nhân viên: ");
                string maNhanVien = Console.ReadLine();
                Console.Write("\tNhập họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("\tNhập giới tính: ");
                string gioiTinh=Console.ReadLine();
                Console.Write("\tNhập số điện thoại: ");
                string soDienThoai = Console.ReadLine();
                Console.Write("\tNhập vị trí công việc: ");
                string viTriCongViec = Console.ReadLine();
                Console.Write("\tNhập nơi đã làm việc: ");
                string noiDaLamViec = Console.ReadLine();
                Console.Write("\tNhập số năm kinh nghiệm: ");
                int soNamKinhNghiem=int.Parse(Console.ReadLine());
                Console.Write("\tNhập khả năng ngoại ngữ: ");
                string khaNangNgoaiNgu=Console.ReadLine();
                Console.Write("\tNhập trình độ chuyên môn: ");
                string trinhDoChuyenMon = Console.ReadLine();
                Console.Write("\tNhập cấp độ: ");
                string capDo = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nhập ngày tháng năm sinh của nhân viên");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tNhập năm sinh: ");
                int namSinh = int.Parse(Console.ReadLine());
                Console.Write("\tNhập tháng sinh: ");
                int thangSinh = int.Parse(Console.ReadLine());
                Console.Write("\tNhập ngày sinh: ");
                int ngaySinh = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nhập đia chỉ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tNhập số nhà: ");
                string soNha = Console.ReadLine();
                Console.Write("\tNhập tên đường: ");
                string tenDuong = Console.ReadLine();
                Console.Write("\tNhập tên phường: ");
                string tenPhuong = Console.ReadLine();
                Console.Write("\tNhập tên quận: ");
                string tenQuan = Console.ReadLine();
                Console.Write("\tNhập tên thành phố: ");
                string tenThanhPho = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nhập thông tin riêng");
                Console.ForegroundColor = ConsoleColor.White;
                if (choose==1)
                {
                    Console.Write("\tNhập lương tháng: ");
                    double luongThang = double.Parse(Console.ReadLine());
                    Console.Write("\tNhập số lỗi lập trình: ");
                    int soLoiLapTrinh = int.Parse(Console.ReadLine());
                    staff[i] = new Programmer(maNhanVien, hoTen, new DateTime(namSinh,thangSinh,ngaySinh), gioiTinh, soNha, tenDuong, tenPhuong, tenQuan, tenThanhPho, soDienThoai, viTriCongViec, noiDaLamViec, soNamKinhNghiem, khaNangNgoaiNgu, trinhDoChuyenMon,capDo, soLoiLapTrinh, luongThang);
                    Console.WriteLine("\n");
                }
                else if(choose==2)
                {
                    Console.Write("\tNhập số giờ OT: ");
                    double soGioOT=double.Parse(Console.ReadLine());
                    Console.Write("\tNhập lương cơ bản: ");
                    double luongCoBan=double.Parse(Console.ReadLine());
                    staff[i] = new Tester(maNhanVien, hoTen, new DateTime(namSinh, thangSinh, ngaySinh), gioiTinh, soNha, tenDuong, tenPhuong, tenQuan, tenThanhPho, soDienThoai, viTriCongViec, noiDaLamViec, soNamKinhNghiem, khaNangNgoaiNgu, trinhDoChuyenMon,capDo, soGioOT, luongCoBan);
                    Console.WriteLine("\n");
                }
               
                
            }  
        }
        static void TimKiemNhanVien(Staff[] staff)
        {
            while(true)
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ______________________________________________________");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                  TÌM KIẾM NHÂN VIÊN                  |");
                Console.WriteLine("|______________________________________________________|");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                       1. Họ tên                      |");
                Console.WriteLine("|                       2. Mã nhân viên                |");
                Console.WriteLine("|                       3. Cấp độ                      |");
                Console.WriteLine("|                       4. Thoát                       |");
                Console.WriteLine("|______________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n***Nhập yêu cầu tìm kiếm nhân viên: ");
                int key = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                switch (key)
                {
                    case 1:
                        Console.Write("\tNhập họ tên nhân viên: ");
                        string hoTen = Console.ReadLine();
                        for (int i = 0; i < staff.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            staff[i].SearchName(hoTen);
                        }
                        break;
                    case 2:
                        Console.Write("\tNhập mã nhân viên: ");
                        string maNhanVien = Console.ReadLine();
                        for (int i = 0; i < staff.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            staff[i].SearchId(maNhanVien);
                        }
                        break;
                    case 3:
                        Console.Write("\tNhập cấp độ nhân viên: ");
                        string capDo = Console.ReadLine();
                        for (int i = 0; i < staff.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            staff[i].SearchLevel(capDo);
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nBạn đã chọn thoát khỏi chương trình!");
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nBạn đã nhập sai số, chỉ nhập giá trị từ 1 đến 4");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

    }
}



