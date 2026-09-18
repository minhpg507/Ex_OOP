using System;

namespace Module03.bai01
{
    public class ChuyenXeNoiThanh : ChuyenXe
    {
        public int SoTuyen { get; set; }
        public double SoKm { get; set; }

        public ChuyenXeNoiThanh() : base() { }

        public ChuyenXeNoiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu, int soTuyen, double soKm)
            : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            SoTuyen = soTuyen;
            SoKm = soKm;
        }

        public override string ToString()
        {
            return base.ToString() + $", Số tuyến: {SoTuyen}, Số Km: {SoKm} (Nội thành)";
        }
    }
}