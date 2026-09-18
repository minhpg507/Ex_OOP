using System;

namespace Module03.bai06
{
    public class HangThucPham : HangHoa
    {
        private DateTime ngaySanXuat;
        private DateTime ngayHetHan;

        public string NhaCungCap { get; set; }

        public DateTime NgaySanXuat
        {
            get => ngaySanXuat;
            set => ngaySanXuat = value <= DateTime.Now ? value : DateTime.Now; 
        }

        public DateTime NgayHetHan
        {
            get => ngayHetHan;
            set => ngayHetHan = value >= NgaySanXuat ? value : NgaySanXuat; 
        }

        public HangThucPham(string maHang, string tenHang, double donGia, int soLuongTon, string nhaCungCap, DateTime ngaySanXuat, DateTime ngayHetHan)
            : base(maHang, tenHang, donGia, soLuongTon)
        {
            NhaCungCap = nhaCungCap;
            NgaySanXuat = ngaySanXuat;
            NgayHetHan = ngayHetHan;
        }

        public override double TinhVAT()
        {
            return DonGia * 0.05; 
        }

        public override string DanhGia()
        {
            if (SoLuongTon > 0 && NgayHetHan < DateTime.Now)
                return "khó bán"; 
            return "không đánh giá"; 
        }

        public override string ToString()
        {
            return "[Thực phẩm] " + base.ToString() + $" | NCC: {NhaCungCap,-10} | HSD: {NgayHetHan:dd/MM/yyyy}";
        }
    }
}