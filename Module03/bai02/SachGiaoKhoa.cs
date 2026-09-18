using System;

namespace Module03.bai02
{
    public class SachGiaoKhoa : Sach
    {
        public string TinhTrang { get; set; }

        public SachGiaoKhoa() : base() { }

        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, string tinhTrang)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            TinhTrang = tinhTrang;
        }

        public override double TinhThanhTien()
        {
            if (TinhTrang.ToLower() == "mới")
            {
                return SoLuong * DonGia; 
            }
            else
            {
                return SoLuong * DonGia * 0.5; 
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Tình trạng: {TinhTrang}, Thành tiền: {TinhThanhTien()} (SGK)";
        }
    }
}