using System;
using System.Collections.Generic;

namespace Module03.bai04
{
    public class DanhSachSach
    {
        private Sach[] list; 
        private int count;

        public DanhSachSach(int n)
        {
            list = new Sach[n];
            count = 0;
        }

        public bool Them(Sach s)
        {
            if (count < list.Length)
            {
                list[count] = s;
                count++;
                return true;
            }
            return false;
        }

        public double TinhTongThanhTienSGK()
        {
            double tong = 0;
            for (int i = 0; i < count; i++)
            {
                if (list[i] is SachGiaoKhoa)
                {
                    tong += list[i].GetThanhTien();
                }
            }
            return tong;
        }

        public double TinhTongThanhTienSTK()
        {
            double tong = 0;
            for (int i = 0; i < count; i++)
            {
                if (list[i] is SachThamKhao)
                {
                    tong += list[i].GetThanhTien();
                }
            }
            return tong;
        }

        public List<Sach> TimSachGiaoKhoaTheoNXB(string nxb)
        {
            List<Sach> ketQua = new List<Sach>();
            for (int i = 0; i < count; i++)
            {
                if (list[i] is SachGiaoKhoa && list[i].NhaXuatBan.Equals(nxb, StringComparison.OrdinalIgnoreCase))
                {
                    ketQua.Add(list[i]);
                }
            }
            return ketQua;
        }

        public double TimThanhTienCaoNhat()
        {
            if (count == 0) return 0;
            double max = list[0].GetThanhTien();
            for (int i = 1; i < count; i++)
            {
                if (list[i].GetThanhTien() > max)
                {
                    max = list[i].GetThanhTien();
                }
            }
            return max;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += list[i].ToString() + "\n";
            }
            return result;
        }
    }
}