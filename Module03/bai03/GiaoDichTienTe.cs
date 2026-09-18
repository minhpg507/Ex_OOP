using System;

namespace Module03.bai03
{
    public class GiaoDichTienTe : GiaoDich
    {
        public double TiGia { get; set; }
        public string LoaiTienTe { get; set; } // VN, USD, Euro[cite: 13]

        public GiaoDichTienTe() : base()
        {
            LoaiTienTe = string.Empty;
        }

        public GiaoDichTienTe(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong, double tiGia, string loaiTienTe)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            TiGia = tiGia;
            LoaiTienTe = loaiTienTe;
        }

        public override double TinhThanhTien()
        {
            // Nếu là tiền VN thì thành tiền = số lượng * đơn giá[cite: 13]
            if (LoaiTienTe.Equals("VN", StringComparison.OrdinalIgnoreCase))
            {
                return SoLuong * DonGia;
            }
            // Nếu là tiền USD hoặc Euro thì thành tiền = số lượng * đơn giá * tỉ giá[cite: 13]
            else
            {
                return SoLuong * DonGia * TiGia;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Tỉ giá: {TiGia}, Loại tiền: {LoaiTienTe}, Thành tiền: {TinhThanhTien():N0} (GD Tiền Tệ)";
        }
    }
}