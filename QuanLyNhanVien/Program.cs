namespace BaiTapQuanLyNhanVien {
    class NhanVien {    
        private string MaNhanVien;
        private string HoTenNhanVien;
        private double HeSoLuong = 1250;
        private int NamVaoLam;

        public string MaNV {
            get { return MaNhanVien; }
            set { MaNhanVien = value; }
        }

        public string HoTenNV {
            get { return HoTenNhanVien; }
            set { HoTenNhanVien = value; }
        }

        public int NamVaoLamNV {
            get { return NamVaoLam; }
            set { NamVaoLam = value; }
        }
        
        public static readonly double MLTT = 1490;

        private double TinhHSPCTN() {
            return (DateTime.Now.Year - NamVaoLam) / 100.0;
        }

        private double TinhLuongCoBan() {
            return HeSoLuong * MLTT;
        }

        public double TinhLuong() {
            return TinhLuongCoBan() * (1 + TinhHSPCTN());
        }
    }

    class QuanLyNhanVien {
        public List<NhanVien> ListNhanVien = new List<NhanVien>();

        public void NhapDanhSachNhanVien() {
            Console.Write("Nhap so luong nhan vien: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) {
                Console.WriteLine("Vui lòng nhập số nguyên dương.");
            }

            for (int i = 0; i < n; i++) {
                NhanVien nv = new NhanVien();

                Console.WriteLine($"Nhap thong tin cho nhan vien thu {i}: ");
                Console.Write("Nhap ma nhan vien: ");
                nv.MaNV = Console.ReadLine()!;
                Console.Write("Nhap ho ten nhan vien: ");
                nv.HoTenNV = Console.ReadLine()!;
                Console.Write("Nhap nam vao lam: ");
                int nam;
                while (!int.TryParse(Console.ReadLine(), out nam) || nam <= 1900 || nam > DateTime.Now.Year) {
                    Console.WriteLine("Năm vào làm không hợp lệ, vui lòng nhập lại.");
                }
                nv.NamVaoLamNV = nam;

                ListNhanVien.Add(nv);
            }
        }

        private double tinhTongLuong() {
            double tongLuong = 0;
            foreach (NhanVien nv in ListNhanVien) {
                tongLuong += nv.TinhLuong();
            }
            return tongLuong;
        }

        public void XuatDanhSachNhanVien() {
            foreach (NhanVien nv in ListNhanVien) {
                Console.WriteLine($"{nv.MaNV} - {nv.HoTenNV} - {nv.TinhLuong()}");
            }
            Console.WriteLine($"Tong luong cua tat ca nhan vien: {tinhTongLuong()}");
        }

        public NhanVien TimNhanVienLuongCaoNhat() {
            NhanVien? nhanVien = null;
            double luongMax = 0;
            foreach(NhanVien nv in ListNhanVien) {
                double luongNV = nv.TinhLuong();
                if (nv.TinhLuong() > luongMax) {
                    luongMax = luongNV;
                    nhanVien = nv;
                }
            }

            return nhanVien!;
        }
    }

    class Program {
        public static void Main() {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.NhapDanhSachNhanVien();
            qlnv.XuatDanhSachNhanVien();
            NhanVien nv = qlnv.TimNhanVienLuongCaoNhat();

            Console.Write($"Nhan vien co luong cao nhat: {nv.MaNV} - {nv.HoTenNV}");
        }
    }
}
