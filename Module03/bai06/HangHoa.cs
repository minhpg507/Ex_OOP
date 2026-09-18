using System;

namespace Module03.bai06
{
    public abstract class HangHoa
    {
        private readonly string maHang; 
        private string tenHang;
        private double donGia;
        private int soLuongTon;

        public string MaHang => maHang; 

        public string TenHang
        {
            get => tenHang;
            set => tenHang = string.IsNullOrWhiteSpace(value) ? "xxx" : value; 
        }

        public double DonGia
        {
            get => donGia;
            set => donGia = value >= 0 ? value : 0; 
        }

        public int SoLuongTon
        {
            get => soLuongTon;
            set => soLuongTon = value >= 0 ? value : 0; 
        }

        public HangHoa(string maHang, string tenHang, double donGia, int soLuongTon)
        {
            if (string.IsNullOrWhiteSpace(maHang))
                throw new ArgumentException("Mã hàng không được để trống.");

            this.maHang = maHang;
            TenHang = tenHang;
            DonGia = donGia;
            SoLuongTon = soLuongTon;
        }

        public abstract double TinhVAT();
        public abstract string DanhGia();

        public override string ToString()
        {
            return $"Mã: {MaHang,-10} | Tên: {TenHang,-15} | Giá: {DonGia,10:N0} | Tồn: {SoLuongTon,5} | VAT: {TinhVAT(),10:N0} | Đánh giá: {DanhGia(),-15}";
        }
    }
}