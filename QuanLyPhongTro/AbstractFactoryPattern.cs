namespace QuanLyPhongTro.AbstractFactory {
    class QuanLyPhongTro {
        abstract class PhongTro {
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

        interface IPhongTro {
            PhongTro CreateNewPhongTro(string idPhong, int soNguoiO, double soDien, double soNuoc);
        }

        class PhongTroA: PhongTro {
            protected int SoNguoiThan { get; set; }
            public PhongTroA(string idPhong, int soNguoiO, double soDien, double soNuoc, int soNguoiThan): base(idPhong, soNguoiO, soDien, soNuoc) {
                SoNguoiThan = soNguoiThan;
            }

            public override void ShowThongTinPhong() {
                base.ShowThongTinPhong();
                Console.WriteLine($"Số người thân: {SoNguoiThan}");
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

        class PhongTroAFactory: IPhongTro {
            protected int SoNguoiThan { get; set; }
            public PhongTroAFactory(int soNguoiThan) {
                SoNguoiThan = soNguoiThan;
            }
            public PhongTro CreateNewPhongTro(string idPhong, int soNguoiO, double soDien, double soNuoc) {
                return new PhongTroA(idPhong, soNguoiO, soDien, soNuoc, SoNguoiThan);
            }
        }

        class PhongTroBFactory: IPhongTro {
            protected double GiatUi { get; set; }
            protected int SoMay { get; set; }

            public PhongTroBFactory(double giatUi, int soMay) {
                GiatUi = giatUi;
                SoMay = soMay;
            }

            public PhongTro CreateNewPhongTro(string idPhong, int soNguoiO, double soDien, double soNuoc) {
                return new PhongTroB(idPhong, soNguoiO, soDien, soNuoc, GiatUi, SoMay);
            }
        }

        public static void Main() {
            IPhongTro phongTroA = new PhongTroAFactory(2);
            IPhongTro phongTroB = new PhongTroBFactory(3.5, 3);

            phongTroA.CreateNewPhongTro("111", 4, 6.5, 3.4).ShowThongTinPhong();
            Console.WriteLine("");
            phongTroB.CreateNewPhongTro("222", 3, 8.7, 5.6).ShowThongTinPhong();
        }
    }
}
