namespace QuanLyCaSi
{
    public abstract class HopDong
    {
        private string MaHopDong;
        public string mahopdong
        {
            get { return MaHopDong; }
            set
            {
                if (value.Length != 6)
                    throw new ArgumentException("Ma hop dong phai 6 ki tu");
                if (!value.StartsWith("HD"))
                    throw new ArgumentException("Ma hop dong phai bat dau bang `HD`");
                if (!int.TryParse(value.Substring(2), out _))
                    throw new ArgumentException("4 ki tu cuoi cua ma hop dong phai la so");

                MaHopDong = value;
            }
        }

        private double DonGia;
        public double dongia
        {
            get { return DonGia; }
            set
            {
                DonGia = Math.Abs(value);
            }
        }

        public string TenCaSi;
        public int SoTietMucBieuDien;
        public DateTime NgayBieuDien;
        public double PhuPhi;

        public HopDong()
        {
            MaHopDong = "HD3418";
            TenCaSi = "Ly Khong Hay";
            SoTietMucBieuDien = 3;
            NgayBieuDien = new DateTime(2020, 10, 24);
            DonGia = 4000000;
            PhuPhi = 20000000;
        }

        public HopDong(string mhd, string tencasi, double dongia)
        {
            mahopdong = mhd;
            TenCaSi = tencasi;
            this.dongia = dongia;
            SoTietMucBieuDien = 2;
            PhuPhi = 0;
            NgayBieuDien = new DateTime(2020, 12, 24);
        }

        public abstract double PhiQuangCao();
        public double ThanhTien()
        {
            return dongia * SoTietMucBieuDien + PhuPhi + PhiQuangCao();
        }

        private static readonly double TileThue = 0.15;

        public double Thue()
        {
            return TileThue * ThanhTien();
        } 
    }
}