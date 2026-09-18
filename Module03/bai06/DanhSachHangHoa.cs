using System;
using System.Collections.Generic;

namespace Module03.bai06
{
    public class DanhSachHangHoa
    {
        private HangHoa[] danhSach; 
        private int count;

        public DanhSachHangHoa(int n)
        {
            danhSach = new HangHoa[n];
            count = 0;
        }

        public bool Them(HangHoa hh)
        {
            if (count >= danhSach.Length) return false;
            if (TimKiem(hh.MaHang) != null) return false;

            danhSach[count] = hh;
            count++;
            return true;
        }

        public HangHoa[] LayToanBo()
        {
            HangHoa[] result = new HangHoa[count];
            Array.Copy(danhSach, result, count);
            return result;
        }

        public HangHoa TimKiem(string maHang)
        {
            for (int i = 0; i < count; i++)
            {
                if (danhSach[i].MaHang.Equals(maHang, StringComparison.OrdinalIgnoreCase))
                    return danhSach[i];
            }
            return null;
        }

        public void SapXepTenTangDan()
        {
            Array.Sort(danhSach, 0, count, new SoSanhTen());
        }

        public void SapXepTonGiamDan()
        {
            Array.Sort(danhSach, 0, count, new SoSanhTon());
        }

        public List<HangThucPham> LayThucPhamKhoBan()
        {
            List<HangThucPham> kq = new List<HangThucPham>();
            for (int i = 0; i < count; i++)
            {
                if (danhSach[i] is HangThucPham tp && tp.DanhGia() == "khó bán")
                {
                    kq.Add(tp);
                }
            }
            return kq;
        }

        public bool Xoa(string maHang)
        {
            for (int i = 0; i < count; i++)
            {
                if (danhSach[i].MaHang.Equals(maHang, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        danhSach[j] = danhSach[j + 1];
                    }
                    danhSach[count - 1] = null;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public bool SuaDonGia(string maHang, double giaMoi)
        {
            HangHoa hh = TimKiem(maHang);
            if (hh != null)
            {
                hh.DonGia = giaMoi;
                return true;
            }
            return false;
        }

        private class SoSanhTen : IComparer<HangHoa>
        {
            public int Compare(HangHoa x, HangHoa y)
            {
                return string.Compare(x.TenHang, y.TenHang, StringComparison.OrdinalIgnoreCase);
            }
        }

        private class SoSanhTon : IComparer<HangHoa>
        {
            public int Compare(HangHoa x, HangHoa y)
            {
                return y.SoLuongTon.CompareTo(x.SoLuongTon); 
            }
        }
    }
}