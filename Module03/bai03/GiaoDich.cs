using System;

namespace Module03.bai03
{
    public class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public GiaoDich()
        {
            MaGiaoDich = string.Empty;
        }

        public GiaoDich(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong)
        {
            MaGiaoDich = maGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public virtual double TinhThanhTien()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Mã GD: {MaGiaoDich}, Ngày: {NgayGiaoDich:dd/MM/yyyy}, Đơn giá: {DonGia:N0}, Số lượng: {SoLuong}";
        }
    }
}