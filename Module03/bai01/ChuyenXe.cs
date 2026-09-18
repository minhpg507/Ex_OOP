using System;

namespace Module03.bai01
{
    public class ChuyenXe
    {
        public string MaSoChuyen { get; set; }
        public string HoTenTaiXe { get; set; }
        public string SoXe { get; set; }
        public double DoanhThu { get; set; }

        public ChuyenXe()
        {
            MaSoChuyen = string.Empty;
            HoTenTaiXe = string.Empty;
            SoXe = string.Empty;
        }
        public ChuyenXe(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu)
        {
            MaSoChuyen = maSoChuyen;
            HoTenTaiXe = hoTenTaiXe;
            SoXe = soXe;
            DoanhThu = doanhThu;
        }

        public override string ToString()
        {
            return $"Mã chuyến: {MaSoChuyen}, Tài xế: {HoTenTaiXe}, Số xe: {SoXe}, Doanh thu: {DoanhThu}";
        }
    }
}