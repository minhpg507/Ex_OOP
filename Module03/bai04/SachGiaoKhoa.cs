using System;

namespace Module03.bai04
{
    public class SachGiaoKhoa : Sach
    {
        public bool TinhTrang { get; set; }

        public SachGiaoKhoa() : base() { }

        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, bool tinhTrang)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            TinhTrang = tinhTrang;
        }

        public override double GetThanhTien()
        {
            if (TinhTrang)
                return SoLuong * DonGia;
            else
                return SoLuong * DonGia * 0.5;
        }

        public override string ToString()
        {
            string strTinhTrang = TinhTrang ? "Mới" : "Cũ";
            return base.ToString() + $", Tình trạng: {strTinhTrang}, Thành tiền: {GetThanhTien():N0}";
        }
    }
}