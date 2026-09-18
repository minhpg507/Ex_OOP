using System;

namespace Module03.bai02
{
    public class SachThamKhao : Sach
    {
        public double Thue { get; set; }

        public SachThamKhao() : base() { }

        public SachThamKhao(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            Thue = thue;
        }

        public override double TinhThanhTien()
        {
            return (SoLuong * DonGia) + Thue; 
        }

        public override string ToString()
        {
            return base.ToString() + $", Thuế: {Thue}, Thành tiền: {TinhThanhTien()} (STK)";
        }
    }
}