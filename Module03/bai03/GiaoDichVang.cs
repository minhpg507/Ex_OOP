using System;

namespace Module03.bai03
{
    public class GiaoDichVang : GiaoDich
    {
        public string LoaiVang { get; set; }

        public GiaoDichVang() : base()
        {
            LoaiVang = string.Empty;
        }

        public GiaoDichVang(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong, string loaiVang)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            LoaiVang = loaiVang;
        }

        public override double TinhThanhTien()
        {
            return SoLuong * DonGia; // Thành tiền = số lượng * đơn giá
        }

        public override string ToString()
        {
            return base.ToString() + $", Loại vàng: {LoaiVang}, Thành tiền: {TinhThanhTien():N0} (GD Vàng)";
        }
    }
}