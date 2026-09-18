using System;

namespace Module03.bai02
{
    public class Sach
    {
        public string MaSach { get; set; }
        public DateTime NgayNhap { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string NhaXuatBan { get; set; }

        public Sach() { }

        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            SoLuong = soLuong;
            NhaXuatBan = nhaXuatBan;
        }

        public virtual double TinhThanhTien()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Mã: {MaSach}, Ngày nhập: {NgayNhap:dd/MM/yyyy}, Đơn giá: {DonGia}, Số lượng: {SoLuong}, NXB: {NhaXuatBan}";
        }
    }
}