using System;

namespace Module03.bai04
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

        public override double GetThanhTien()
        {
            return (SoLuong * DonGia) + Thue; 
        }

        public override string ToString()
        {
            return base.ToString() + $", Thuế: {Thue:N0}, Thành tiền: {GetThanhTien():N0}";
        }
    }
}