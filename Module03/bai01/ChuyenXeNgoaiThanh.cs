using System;

namespace Module03.bai01
{
    public class ChuyenXeNgoaiThanh : ChuyenXe
    {
        public string NoiDen { get; set; }
        public int SoNgay { get; set; }

        public ChuyenXeNgoaiThanh() : base() { }

        public ChuyenXeNgoaiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu, string noiDen, int soNgay)
            : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            NoiDen = noiDen;
            SoNgay = soNgay;
        }

        public override string ToString()
        {
            return base.ToString() + $", Nơi đến: {NoiDen}, Số ngày: {SoNgay} (Ngoại thành)";
        }
    }
}