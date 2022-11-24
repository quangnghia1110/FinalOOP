using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    internal class Job
    {
        private string viTriCongViec;
        private string noiDaLamViec;
        private int soNamKinhNghiem;
        private string khaNangNgoaiNgu;
        private string trinhDoChuyenMon;
        public string ViTriCongViec { get => viTriCongViec; set => viTriCongViec = value; }
        public string NoiDaLamViec { get => noiDaLamViec; set => noiDaLamViec = value; }
        public int SoNamKinhNghiem { get => soNamKinhNghiem; set => soNamKinhNghiem = value; }
        public string KhaNangNgoaiNgu { get => khaNangNgoaiNgu; set => khaNangNgoaiNgu = value; }
        public string TrinhDoChuyenMon { get => trinhDoChuyenMon; set => trinhDoChuyenMon = value; }
        public Job()
        {

        }
        ~Job()
        {

        }
        public Job(string viTriCongViec, string noiDaLamViec, int soNamKinhNghiem, string khaNangNgoaiNgu, string trinhDoChuyenMon)
        {
            ViTriCongViec = viTriCongViec;
            NoiDaLamViec = noiDaLamViec;
            SoNamKinhNghiem = soNamKinhNghiem;
            KhaNangNgoaiNgu = khaNangNgoaiNgu;
            TrinhDoChuyenMon = trinhDoChuyenMon;
        }
        public string toString()
        {
            return $"| {viTriCongViec}{new string(' ', 26 - 2 - ViTriCongViec.Length)}| {noiDaLamViec}{new string(' ', 26 - 2 - NoiDaLamViec.Length)}| {soNamKinhNghiem}{new string(' ', 26 - 2 - ((int)SoNamKinhNghiem))}| {khaNangNgoaiNgu}{new string(' ', 26 - 2 - KhaNangNgoaiNgu.Length)}| {trinhDoChuyenMon}{new string(' ', 26 - 2 - TrinhDoChuyenMon.Length)}|";
        }
    }
}
