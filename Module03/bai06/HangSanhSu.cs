using System;

namespace Module03.bai06
{
    public class HangSanhSu : HangHoa
    {
        private DateTime ngayNhapKho;

        public string NhaSanXuat { get; set; }

        public DateTime NgayNhapKho
        {
            get => ngayNhapKho;
            set => ngayNhapKho = value <= DateTime.Now ? value : DateTime.Now; 
        }

        public HangSanhSu(string maHang, string tenHang, double donGia, int soLuongTon, string nhaSanXuat, DateTime ngayNhapKho)
            : base(maHang, tenHang, donGia, soLuongTon)
        {
            NhaSanXuat = nhaSanXuat;
            NgayNhapKho = ngayNhapKho;
        }

        public override double TinhVAT()
        {
            return DonGia * 0.10; 
        }

        public override string DanhGia()
        {
            TimeSpan thoiGianLuuKho = DateTime.Now - NgayNhapKho;
            if (SoLuongTon > 50 && thoiGianLuuKho.TotalDays > 10)
                return "bán chậm"; 
            return "không đánh giá"; 
        }

        public override string ToString()
        {
            return "[Sành sứ]   " + base.ToString() + $" | NSX: {NhaSanXuat,-10} | Nhập: {NgayNhapKho:dd/MM/yyyy}";
        }
    }
}