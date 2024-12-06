namespace BaiTapQuanLyNhanVien {
    class NhanVien {    
        private string MaNhanVien;
        private string HoTenNhanVien;
        private double HeSoLuong;
        private int NamVaoLam;

        public string MaNV {
            get { return MaNhanVien; }
            set { MaNhanVien = value; }
        }

        public string HoTenNV {
            get { return HoTenNhanVien; }
            set { HoTenNhanVien = value; }
        }
        
        public static readonly double MLTT = 1490;

        private double TinhHSPCTN() {
            return (DateTime.Now.Year - NamVaoLam) / 100;
        }

        private double TinhLuongCoBan() {
            return HeSoLuong * MLTT;
        }

        public double TinhLuong() {
            return TinhLuongCoBan() * TinhHSPCTN();
        }

        
    }

    class QuanLyNhanVien {
        public List<NhanVien> ListNhanVien = new List<NhanVien>();

        public List<NhanVien> DSNhanVien {
            get { return ListNhanVien; }
            set { ListNhanVien = value; } 
        }
        public void NhapDanhSachNhanVien() {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++) {
                NhanVien nv = new NhanVien();

                Console.WriteLine($"Nhap thong tin cho nhan vien thu {i}: ");
                Console.Write("Nhap ma nhan vien: ");
                nv.MaNV = Console.ReadLine()!;
                Console.Write("Nhap ho ten nhan vien: ");
                nv.HoTenNV = Console.ReadLine()!;

                ListNhanVien.Add(nv);
            }
        }

        public void XuatDanhSachNhanVien() {
            foreach (NhanVien nv in DSNhanVien) {
                Console.WriteLine($"{nv.MaNV} - {nv.HoTenNV}");
            }
        }
    }

    class Program {
        public static void Main() {

        }
    }
}