using System.Collections.Generic;

namespace QuanLyDanhSachSinhVien {
    class SinhVien {
        private string MaSinhVien; 
        private string HoTenSinhVien; 
        private double Diem; 

        public string MaSV {
            get { return MaSinhVien; }
            set { MaSinhVien = value; }
        }

        public string HoTen {
            get { return HoTenSinhVien; }
            set { HoTenSinhVien = value; }
        }

        public double DiemSinhVien {
            get { return Diem; }
            set { Diem = value; }
        }        
    }

    class QuanLySinhVien {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public List<SinhVien> ListSV {
            get { return danhSachSinhVien; }
            set { danhSachSinhVien = value; }
        }

        public void nhapThongTinSinhVien() {
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++) {
                SinhVien sv = new SinhVien();
                Console.WriteLine($"Thong tin sinh vien thu {i}: ");
                Console.WriteLine("Nhap ma so sinh vien: ");
                sv.MaSV = Console.ReadLine()!;
                Console.WriteLine("Nhap ho ten sinh vien: ");
                sv.HoTen = Console.ReadLine()!;
                Console.WriteLine("Nhap diem sinh vien: ");
                sv.DiemSinhVien = double.Parse(Console.ReadLine()!);

                danhSachSinhVien.Add(sv);
            }
        }

        public void xuatThongTinSinhVien() {
            foreach(SinhVien sv in danhSachSinhVien) {
                Console.WriteLine($"{sv.MaSV} - {sv.HoTen} - {sv.DiemSinhVien}");
            }
        }

        public void thongTinhSinhVienById(string id) {
            SinhVien sv = findSinhVienById(id);
            Console.WriteLine($"{sv.MaSV} - {sv.HoTen} - {sv.DiemSinhVien}");
        }

        private SinhVien findSinhVienById(string id) {
            return danhSachSinhVien.Find(sv => sv.MaSV == id);
        }
    }

    class Program {
        public static void Main() {
            QuanLySinhVien ListSinhVien = new QuanLySinhVien();
            ListSinhVien.nhapThongTinSinhVien();
            ListSinhVien.xuatThongTinSinhVien();
            ListSinhVien.thongTinhSinhVienById("111");
        }
    }
}