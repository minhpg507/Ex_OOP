using System;

namespace Module03.bai06
{
    public class HangDienMay : HangHoa
    {
        private int thoiGianBaoHanh;
        private double congSuat;

        public int ThoiGianBaoHanh
        {
            get => thoiGianBaoHanh;
            set => thoiGianBaoHanh = value >= 0 ? value : 0; 
        }

        public double CongSuat
        {
            get => congSuat;
            set => congSuat = value >= 0 ? value : 0; 
        }

        public HangDienMay(string maHang, string tenHang, double donGia, int soLuongTon, int thoiGianBaoHanh, double congSuat)
            : base(maHang, tenHang, donGia, soLuongTon)
        {
            ThoiGianBaoHanh = thoiGianBaoHanh;
            CongSuat = congSuat;
        }

        public override double TinhVAT()
        {
            return DonGia * 0.10; 
        }

        public override string DanhGia()
        {
            if (SoLuongTon < 3)
                return "bán được"; 
            return "không đánh giá"; 
        }

        public override string ToString()
        {
            return "[Điện máy]  " + base.ToString() + $" | BH: {ThoiGianBaoHanh} tháng | CS: {CongSuat} KW";
        }
    }
}