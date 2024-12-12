namespace QuanLyXeDuLich {
    public class ThongTinXe {
        protected readonly string MaSoChuyen;
        protected readonly string HoTenTaiXe;
        protected readonly int SoXe;

        public ThongTinXe(string MaSoChuyen, string HoTenTaiXe, int SoXe) {
            this.MaSoChuyen = MaSoChuyen;
            this.HoTenTaiXe = HoTenTaiXe;
            this.SoXe = SoXe;
        }

        public void BaseThongTin() {
            Console.WriteLine("Mã số chuyến xe: " + MaSoChuyen);
            Console.WriteLine("Họ tên tài xế: " + HoTenTaiXe);
            Console.WriteLine("Số Xe: " + SoXe);
        }
    }

    public class XeNoiThanh : ThongTinXe {
        private int SoChuyen;
        private int SoKilometDiDuoc;
        private List<XeNoiThanh> dsXeNoiThanh = new List<XeNoiThanh>();

        public XeNoiThanh(string MaSoChuyen, string HoTenTaiXe, int SoXe, int SoChuyen, int SoKilometDiDuoc) 
            : base(MaSoChuyen, HoTenTaiXe, SoXe) {
            this.SoChuyen = SoChuyen;
            this.SoKilometDiDuoc = SoKilometDiDuoc;
        }

        public void NhapXeNoiThanh() {
            Console.Write("Nhập số lượng xe: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++) {
                Console.Write("Nhập mã chuyến xe: ");
                string maChuyenXe = Console.ReadLine()!;

                Console.Write("Nhập tên tài xế: ");
                string tenTaiXe = Console.ReadLine()!;

                Console.Write("Nhập số xe: ");
                int soXe = int.Parse(Console.ReadLine()!);

                Console.Write("Nhập số chuyến: ");
                int soChuyen = int.Parse(Console.ReadLine()!);

                Console.Write("Nhập kilomet đi được: ");
                int soKilomet = int.Parse(Console.ReadLine()!);

                XeNoiThanh xe = new XeNoiThanh(maChuyenXe, tenTaiXe, soXe, soChuyen, soKilomet);
                dsXeNoiThanh.Add(xe);
            }
        }

        public void Xuat() {
            foreach (XeNoiThanh xe in dsXeNoiThanh) {
                xe.BaseThongTin();
                Console.WriteLine("Số chuyến xe: " + xe.SoChuyen);
                Console.WriteLine("Số kilomet đi được: " + xe.SoKilometDiDuoc);
                Console.WriteLine();
            }
        }
    }

    public class XeNgoaiThanh : ThongTinXe {
        private string NoiDen;
        private int SoNgayDiDuoc;
        private List<XeNgoaiThanh> dsXeNgoaiThanh = new List<XeNgoaiThanh>();

        public XeNgoaiThanh(string MaSoChuyen, string HoTenTaiXe, int SoXe, string NoiDen, int SoNgayDiDuoc) 
            : base(MaSoChuyen, HoTenTaiXe, SoXe) {
            this.NoiDen = NoiDen;
            this.SoNgayDiDuoc = SoNgayDiDuoc;
        }

        public void NhapXeNgoaiThanh() {
            Console.Write("Nhập số lượng xe: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++) {
                Console.Write("Nhập mã chuyến xe: ");
                string maChuyenXe = Console.ReadLine()!;

                Console.Write("Nhập tên tài xế: ");
                string tenTaiXe = Console.ReadLine()!;

                Console.Write("Nhập số xe: ");
                int soXe = int.Parse(Console.ReadLine()!);

                Console.Write("Nhập nơi đến: ");
                string noiDen = Console.ReadLine()!;

                Console.Write("Nhập số ngày đi được: ");
                int soNgay = int.Parse(Console.ReadLine()!);

                XeNgoaiThanh xe = new XeNgoaiThanh(maChuyenXe, tenTaiXe, soXe, noiDen, soNgay);
                dsXeNgoaiThanh.Add(xe);
            }
        }

        public void Xuat() {
            foreach (XeNgoaiThanh xe in dsXeNgoaiThanh) {
                xe.BaseThongTin();
                Console.WriteLine("Nơi đến: " + xe.NoiDen);
                Console.WriteLine("Số ngày đi được: " + xe.SoNgayDiDuoc);
                Console.WriteLine();
            }
        }
    }

    class Program {
        public static void Main() {
            XeNoiThanh xeNoiThanh = new XeNoiThanh("", "", 0, 0, 0);
            XeNgoaiThanh xeNgoaiThanh = new XeNgoaiThanh("", "", 0, "", 0);

            Console.WriteLine("Chọn loại xe để nhập:");
            Console.WriteLine("1. Xe nội thành");
            Console.WriteLine("2. Xe ngoại thành");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice) {
                case 1:
                    xeNoiThanh.NhapXeNoiThanh();
                    Console.WriteLine("Danh sách xe nội thành:");
                    xeNoiThanh.Xuat();
                    break;
                case 2:
                    xeNgoaiThanh.NhapXeNgoaiThanh();
                    Console.WriteLine("Danh sách xe ngoại thành:");
                    xeNgoaiThanh.Xuat();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
