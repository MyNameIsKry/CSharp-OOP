using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace QuanLyCaSi
{
    public class TaiNha : HopDong
    {
        private double KCDCBangOto;
        public TaiNha()
        {
            KCDCBangOto = 10;
        }

    public TaiNha(string mhd, string tencasi, double dongia, double kcdc)
        : base(mhd, tencasi, dongia)
    {
        KCDCBangOto = kcdc;
    }

        public override double PhiQuangCao()
        {
            if (KCDCBangOto < 20)
                return 400000 * KCDCBangOto;
            else
                return 300000 * KCDCBangOto > 1500000 ? 15000000 : 300000 * KCDCBangOto;
        }
    }

    public class RapNho : HopDong, IHoTro
    {
        private int QuyMo;
        public int quymo
        {
            get { return QuyMo; }
            set
            {
                if (value >= 1 || value <= 5)
                    QuyMo = value;
                else
                    QuyMo = 1;
            }
        }

        public RapNho(int qm)
        {
            quymo = qm;
        }

        public RapNho(string mhd, string tencasi, double dongia, int qm)
            : base(mhd, tencasi, dongia)
        {
            quymo = qm;
        }

        public override double PhiQuangCao()
        {
            return 10000000 + 2000000 * SoTietMucBieuDien;
        }

        public double TinhTienHT()
        {
            if (quymo <= 3)
                return 1000000;
                
            return 0;
        }
    }

    public class RapLon : HopDong, IHoTro
    {
        protected int SoLuongKhanGia;

        public RapLon(int slkg)
        {
            SoLuongKhanGia = slkg;
        }

        public RapLon(string mhd, string tencasi, double dongia, int slkg)
            : base(mhd, tencasi, dongia)
        {
            SoLuongKhanGia = slkg;
        }

        public override double PhiQuangCao()
        {
            return SoLuongKhanGia < 1000000 ? 30000000 : 50000000;
        }

        public double TinhTienHT()
        {
            return SoLuongKhanGia / 100000 > 20000000
                ? 20000000 : SoLuongKhanGia / 100000;
        }
    }

    class Program
    {
        public static void Main()
        {
            TaiNha taiNha = new TaiNha("HD001", "CucCut", 500000, 12);
            double thue = taiNha.Thue();
            double thanhtien = taiNha.ThanhTien();
            Console.WriteLine("thue: {0}", thue);
            Console.WriteLine("thanh tien: {0}", thanhtien);
        }
    }  
}