// namespace QuanLyPhongTro.Factory
// {
// 	class QuanLyPhongTro {
//         public enum PhongTroType {
//             A,
//             B
//         }
// 		public abstract class PhongTro {
//             protected string IdPhong { get; set; }
//             protected int SoNguoiO { get; set; }
//             protected double SoDien { get; set; }
//             protected double SoNuoc { get; set; }   
//             public PhongTro(string idPhong, int soNguoiO, double soDien, double soNuoc) {
//                 IdPhong = idPhong;
//                 SoNguoiO = soNguoiO;
//                 SoDien = soDien;
//                 SoNuoc = soNuoc;
//             }

//             public virtual void ShowThongTinPhong() => Console.WriteLine($"ID phòng: {IdPhong}\nSố người ở: {SoNguoiO}\nSố điện đã dùng: {SoDien}kg\nSố nước đã dùng: {SoNuoc}kg");
//         }

//         class PhongTroA: PhongTro {
//             protected int SoNguoiThan { get; set; }
//             public PhongTroA(string idPhong, int soNguoiO, double soDien, double soNuoc, int soNguoiThan): base(idPhong, soNguoiO, soDien, soNuoc) {
//                 SoNguoiThan = soNguoiThan;
//             }

//             public override void ShowThongTinPhong() {
//                 base.ShowThongTinPhong();
//                 Console.WriteLine($"Số người thân: {SoNguoiThan}");
//             }
//         }

//         class PhongTroB: PhongTro {
//             protected double GiatUi { get; set; }
//             protected int SoMay { get; set; }

//             public PhongTroB(string idPhong, int soNguoiO, double soDien, double soNuoc, double giatUi, int soMay): base(idPhong, soNguoiO, soDien, soNuoc) {
//                 GiatUi = giatUi;
//                 SoMay = soMay;
//             }   
            
//             public override void ShowThongTinPhong()
//             {
//                 base.ShowThongTinPhong();
//                 Console.WriteLine($"Khối lượng giặt ủi: {GiatUi}kg\nSố lượng máy: {SoMay} máy");
//             }
//         }

//         class PhongTroFactory {
//             public static PhongTro CreatePhongTroA(string idPhong, int soNguoiO, double soDien, double soNuoc, int soNguoiThan)
//             {
//                 return new PhongTroA(idPhong, soNguoiO, soDien, soNuoc, soNguoiThan);
//             }

//             public static PhongTro CreatePhongTroB(string idPhong, int soNguoiO, double soDien, double soNuoc, double giatUi, int soMay)
//             {
//                 return new PhongTroB(idPhong, soNguoiO, soDien, soNuoc, giatUi, soMay);
//             }
//         }

//         public static void Main() {
//             PhongTro phongA = PhongTroFactory.CreatePhongTroA("A101", 3, 100, 50, 2);
//             PhongTro phongB = PhongTroFactory.CreatePhongTroB("B202", 4, 150, 60, 30.5, 2);

//             phongA.ShowThongTinPhong();
//             phongB.ShowThongTinPhong();
//         }
// 	}
// }