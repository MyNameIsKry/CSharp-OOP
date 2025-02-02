class QuanLyPhongTro {
    public abstract class PhongTro {
        protected string IdPhong { get; set; }
        protected int SoNguoiO { get; set; }
        protected double SoDien { get; set; }
        protected double SoNuoc { get; set; }

        public PhongTro(string idPhong, int soNguoiO, double soDien, double soNuoc) {
            IdPhong = idPhong;
            SoNguoiO = soNguoiO;
            SoDien = soDien;
            SoNuoc = soNuoc;
        }

        public virtual void ShowThongTinPhong() => Console.WriteLine($"ID phòng: {IdPhong}\nSố người ở: {SoNguoiO}\nSố điện đã dùng: {SoDien}kg\nSố nước đã dùng: {SoNuoc}kg");
    }

    class PhongTroA: PhongTro {
        protected int SoNguoiThan { get; set; }
        public PhongTroA(string idPhong, int soNguoiO, double soDien, double soNuoc, int soNguoiThan): base(idPhong, soNguoiO, soDien, soNuoc) {
            SoNguoiThan = soNguoiThan;
        }

        public override void ShowThongTinPhong()
        {
            base.ShowThongTinPhong();
            Console.WriteLine($"Số người thân ở: {SoNguoiThan} người");
        }
    }

    class PhongTroB: PhongTro {
        protected double GiatUi { get; set; }
        protected int SoMay { get; set; }

        public PhongTroB(string idPhong, int soNguoiO, double soDien, double soNuoc, double giatUi, int soMay): base(idPhong, soNguoiO, soDien, soNuoc) {
            GiatUi = giatUi;
            SoMay = soMay;
        }   
        
        public override void ShowThongTinPhong()
        {
            base.ShowThongTinPhong();
            Console.WriteLine($"Khối lượng giặt ủi: {GiatUi}kg\nSố lượng máy: {SoMay} máy");
        }
    }

    public static void Main() {
        PhongTroA A = new PhongTroA("111", 3, 24, 4, 1);
        A.ShowThongTinPhong();

        Console.WriteLine("");

        PhongTroB B = new PhongTroB("222", 2, 5, 7, 2.7, 2);
        B.ShowThongTinPhong();
    }
}