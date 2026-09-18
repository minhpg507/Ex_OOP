using System;
using System.Collections.Generic; 
using Module03.bai01;
using Module03.bai02;
using Module03.bai03;
using Module03.bai04;
using Module03.bai05;
using Module03.bai06;

namespace Module03
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("\n========== MENU KIỂM NGHIỆM ==========");
                Console.WriteLine("1. Chạy thử Bài 1 (Chuyến xe)");
                Console.WriteLine("2. Chạy thử Bài 2 (Quản lý Sách)");
                Console.WriteLine("3. Chạy thử bài 3 (Quản lý Giao dịch)");
                Console.WriteLine("4. Chạy thử bài 4 (Quản lý Sách với Danh sách)");
                Console.WriteLine("5. Chạy thử bài 5 (Quản lý Nhân viên)");
                Console.WriteLine("6. Chạy thử bài 6 (Quản lý Hàng hóa)");
                Console.WriteLine("0. Thoát");
                Console.Write("Mời bạn chọn bài muốn test: ");

                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        Console.WriteLine("\n--- ĐANG CHẠY BÀI 1 ---");
                        TestBai1();
                        break;
                    case "2":
                        Console.WriteLine("\n--- ĐANG CHẠY BÀI 2 ---");
                        TestBai2();
                        break;
                    case "3":
                        Console.WriteLine("\n--- ĐANG CHẠY BÀI 3 ---");
                        TestBai3();
                        break;
                    case "4":
                        Console.WriteLine("\n--- ĐANG CHẠY BÀI 4 ---");
                        TestBai4();
                        break;
                    case "5":
                        Console.WriteLine("\n--- ĐANG CHẠY BÀI 5 ---");
                        TestBai5();
                        break;
                    case "6":
                        Console.WriteLine("\n--- ĐANG CHẠY BÀI 6 ---");
                        TestBai6();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }

        static void TestBai1()
        {
            List<ChuyenXe> danhSachChuyenXe = new List<ChuyenXe>();

            danhSachChuyenXe.Add(new ChuyenXeNoiThanh("NT01", "Nguyễn Văn A", "51A-123.45", 1500000, 15, 120));
            danhSachChuyenXe.Add(new ChuyenXeNoiThanh("NT02", "Trần Văn B", "51B-678.90", 1200000, 10, 95));
            danhSachChuyenXe.Add(new ChuyenXeNgoaiThanh("NG01", "Lê Văn C", "51C-111.22", 5000000, "Vũng Tàu", 2));
            danhSachChuyenXe.Add(new ChuyenXeNgoaiThanh("NG02", "Phạm Văn D", "51D-333.44", 8000000, "Đà Lạt", 4));

            Console.WriteLine("--- DANH SÁCH CHUYẾN XE ---");
            foreach (ChuyenXe xe in danhSachChuyenXe)
            {
                Console.WriteLine(xe.ToString());
            }

            double tongDoanhThu = 0;
            double doanhThuNoiThanh = 0;
            double doanhThuNgoaiThanh = 0;

            foreach (ChuyenXe xe in danhSachChuyenXe)
            {
                tongDoanhThu += xe.DoanhThu;

                if (xe is ChuyenXeNoiThanh)
                {
                    doanhThuNoiThanh += xe.DoanhThu;
                }
                else if (xe is ChuyenXeNgoaiThanh)
                {
                    doanhThuNgoaiThanh += xe.DoanhThu;
                }
            }

            Console.WriteLine("\n--- THỐNG KÊ DOANH THU ---");
            Console.WriteLine($"Tổng doanh thu tất cả chuyến xe: {tongDoanhThu:N0} VNĐ");
            Console.WriteLine($"Tổng doanh thu xe Nội thành: {doanhThuNoiThanh:N0} VNĐ");
            Console.WriteLine($"Tổng doanh thu xe Ngoại thành: {doanhThuNgoaiThanh:N0} VNĐ");
        }

        static void TestBai2()
        {
            List<Module03.bai02.Sach> danhSach = new List<Module03.bai02.Sach>();

            danhSach.Add(new Module03.bai02.SachGiaoKhoa("SGK01", new DateTime(2023, 1, 15), 50000, 10, "Giao Duc", "mới"));
            danhSach.Add(new Module03.bai02.SachGiaoKhoa("SGK02", new DateTime(2023, 2, 20), 60000, 5, "Tre", "cũ"));
            danhSach.Add(new Module03.bai02.SachGiaoKhoa("SGK03", new DateTime(2023, 3, 10), 45000, 20, "Giao Duc", "mới"));

            danhSach.Add(new Module03.bai02.SachThamKhao("STK01", new DateTime(2023, 4, 5), 100000, 2, "Thanh Nien", 10000));
            danhSach.Add(new Module03.bai02.SachThamKhao("STK02", new DateTime(2023, 5, 12), 150000, 3, "Tre", 15000));
            danhSach.Add(new Module03.bai02.SachThamKhao("STK03", new DateTime(2023, 6, 25), 80000, 4, "Kim Dong", 8000));

            Console.WriteLine("--- DANH SÁCH CÁC LOẠI SÁCH ---");
            foreach (Module03.bai02.Sach s in danhSach)
            {
                Console.WriteLine(s.ToString());
            }

            double tongTienSGK = 0;
            double tongTienSTK = 0;

            foreach (Module03.bai02.Sach s in danhSach)
            {
                if (s is Module03.bai02.SachGiaoKhoa)
                {
                    tongTienSGK += s.TinhThanhTien();
                }
                else if (s is Module03.bai02.SachThamKhao)
                {
                    tongTienSTK += s.TinhThanhTien();
                }
            }

            Console.WriteLine("\n--- TỔNG THÀNH TIỀN ---");
            Console.WriteLine($"Tổng thành tiền Sách Giáo Khoa: {tongTienSGK:N0}");
            Console.WriteLine($"Tổng thành tiền Sách Tham Khảo: {tongTienSTK:N0}");

            Console.WriteLine("\n--- TÌM SÁCH GIÁO KHOA THEO NXB ---");
            Console.Write("Nhập tên Nhà xuất bản (K): ");
            string nxbK = Console.ReadLine();
            bool timThay = false;

            foreach (Module03.bai02.Sach s in danhSach)
            {
                if (s is Module03.bai02.SachGiaoKhoa && s.NhaXuatBan.Equals(nxbK, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(s.ToString());
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy Sách Giáo Khoa nào của NXB này.");
            }

            Console.WriteLine("\n--- TÌM SÁCH CÓ THÀNH TIỀN CAO NHẤT ---");
            double maxThanhTien = 0;

            foreach (Module03.bai02.Sach s in danhSach)
            {
                if (s.TinhThanhTien() > maxThanhTien)
                {
                    maxThanhTien = s.TinhThanhTien();
                }
            }

            foreach (Module03.bai02.Sach s in danhSach)
            {
                if (s.TinhThanhTien() == maxThanhTien)
                {
                    Console.WriteLine(s.ToString());
                }
            }
        }
        static void TestBai3()
        {
            List<GiaoDich> danhSachGD = new List<GiaoDich>();

            danhSachGD.Add(new GiaoDichVang("GDV01", new DateTime(2023, 10, 1), 7000000, 5, "9999"));
            danhSachGD.Add(new GiaoDichVang("GDV02", new DateTime(2023, 10, 2), 6900000, 10, "SJC"));
            danhSachGD.Add(new GiaoDichVang("GDV03", new DateTime(2023, 10, 3), 1500000000, 2, "Kim Cương"));

            danhSachGD.Add(new GiaoDichTienTe("GDT01", new DateTime(2023, 10, 4), 100, 1000, 24000, "USD"));
            danhSachGD.Add(new GiaoDichTienTe("GDT02", new DateTime(2023, 10, 5), 500, 2000, 26000, "Euro"));
            danhSachGD.Add(new GiaoDichTienTe("GDT03", new DateTime(2023, 10, 6), 500000, 50, 1, "VN"));

            Console.WriteLine("--- DANH SÁCH GIAO DỊCH ---");
            foreach (GiaoDich gd in danhSachGD)
            {
                Console.WriteLine(gd.ToString());
            }

            int tongSoLuongVang = 0;
            int tongSoLuongTienTe = 0;

            double tongThanhTienTienTe = 0;
            int demGDTienTe = 0;

            foreach (GiaoDich gd in danhSachGD)
            {
                if (gd is GiaoDichVang)
                {
                    tongSoLuongVang += gd.SoLuong;
                }
                else if (gd is GiaoDichTienTe)
                {
                    tongSoLuongTienTe += gd.SoLuong;
                    tongThanhTienTienTe += gd.TinhThanhTien();
                    demGDTienTe++;
                }
            }

            Console.WriteLine("\n--- THỐNG KÊ SỐ LƯỢNG ---");
            Console.WriteLine($"Tổng số lượng Giao Dịch Vàng: {tongSoLuongVang}");
            Console.WriteLine($"Tổng số lượng Giao Dịch Tiền Tệ: {tongSoLuongTienTe}");

            Console.WriteLine("\n--- TRUNG BÌNH THÀNH TIỀN GIAO DỊCH TIỀN TỆ ---");
            if (demGDTienTe > 0)
            {
                double trungBinh = tongThanhTienTienTe / demGDTienTe;
                Console.WriteLine($"Trung bình thành tiền: {trungBinh:N0} VNĐ");
            }
            else
            {
                Console.WriteLine("Không có giao dịch tiền tệ nào.");
            }

            Console.WriteLine("\n--- CÁC GIAO DỊCH CÓ ĐƠN GIÁ > 1 TỶ ---");
            bool coGiaoDichLon = false;
            foreach (GiaoDich gd in danhSachGD)
            {
                if (gd.DonGia > 1000000000)
                {
                    Console.WriteLine(gd.ToString());
                    coGiaoDichLon = true;
                }
            }

            if (!coGiaoDichLon)
            {
                Console.WriteLine("Không có giao dịch nào thỏa điều kiện.");
            }
        }

        static void TestBai4()
        {
            Module03.bai04.DanhSachSach quanLySach = new Module03.bai04.DanhSachSach(100);

            quanLySach.Them(new Module03.bai04.SachGiaoKhoa("SGK01", new DateTime(2023, 1, 15), 50000, 10, "Giao Duc", true));
            quanLySach.Them(new Module03.bai04.SachGiaoKhoa("SGK02", new DateTime(2023, 2, 20), 60000, 5, "Tre", false));
            quanLySach.Them(new Module03.bai04.SachThamKhao("STK01", new DateTime(2023, 4, 5), 100000, 2, "Thanh Nien", 10000));

            while (true)
            {
                Console.WriteLine("\n========== QUẢN LÝ SÁCH (BÀI 4) ==========");
                Console.WriteLine("1. In danh sách các sách");
                Console.WriteLine("2. Tính tổng thành tiền Sách Giáo Khoa");
                Console.WriteLine("3. Tính tổng thành tiền Sách Tham Khảo");
                Console.WriteLine("4. Tìm Sách Giáo Khoa theo Nhà xuất bản");
                Console.WriteLine("5. Tìm thành tiền cao nhất");
                Console.WriteLine("0. Trở về Menu chính");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine("\n--- DANH SÁCH ---");
                        Console.WriteLine(quanLySach.ToString());
                        break;
                    case "2":
                        Console.WriteLine($"\nTổng thành tiền SGK: {quanLySach.TinhTongThanhTienSGK():N0} VNĐ");
                        break;
                    case "3":
                        Console.WriteLine($"\nTổng thành tiền STK: {quanLySach.TinhTongThanhTienSTK():N0} VNĐ");
                        break;
                    case "4":
                        Console.Write("\nNhập tên Nhà xuất bản cần tìm: ");
                        string nxb = Console.ReadLine();
                        List<Module03.bai04.Sach> ketQua = quanLySach.TimSachGiaoKhoaTheoNXB(nxb);
                        if (ketQua.Count > 0)
                        {
                            Console.WriteLine($"\nĐã tìm thấy {ketQua.Count} kết quả:");
                            foreach (var s in ketQua) Console.WriteLine(s.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy!");
                        }
                        break;
                    case "5":
                        Console.WriteLine($"\nMức thành tiền cao nhất trong kho: {quanLySach.TimThanhTienCaoNhat():N0} VNĐ");
                        break;
                    case "0":
                        return; 
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            }
        }

        static void TestBai5()
        {
            Employee[] danhSachNhanVien = new Employee[4];

            danhSachNhanVien[0] = new SalariedEmployee("Hà Đức", "Minh", "SSN-111", 5000000);
            danhSachNhanVien[1] = new HourlyEmployee("Lộc Tôn", "Thất", "SSN-222", 100000, 45); 
            danhSachNhanVien[2] = new CommissionEmployee("Hoàng", "Minh", "SSN-333", 50000000, 0.05); 
            danhSachNhanVien[3] = new BasePlusCommissionEmployee("Đăng", "Minh", "SSN-444", 80000000, 0.03, 6000000);

            Console.WriteLine("========== BẢNG LƯƠNG NHÂN VIÊN CÔNG TY XYZ ==========\n");

            foreach (Employee nv in danhSachNhanVien)
            {
                Console.WriteLine(nv.ToString()); 
                Console.WriteLine($"=> EARNINGS: {nv.Earnings():N0} VNĐ\n"); 
                Console.WriteLine("------------------------------------------------------");
            }
        }
        static void TestBai6()
        {
            DanhSachHangHoa kho = new DanhSachHangHoa(100);

            kho.Them(new HangThucPham("TP01", "Sữa tươi", 35000, 10, "Vinamilk", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-2))); 
            kho.Them(new HangThucPham("TP02", "Bánh mì", 15000, 50, "Kinh Do", DateTime.Now, DateTime.Now.AddDays(5)));
            kho.Them(new HangDienMay("DM01", "Tủ lạnh", 8500000, 2, 24, 150)); 
            kho.Them(new HangDienMay("DM02", "Tivi Sony", 12000000, 10, 12, 100));
            kho.Them(new HangSanhSu("SS01", "Chén sứ", 25000, 100, "Minh Long", DateTime.Now.AddDays(-15))); 

            while (true)
            {
                Console.WriteLine("\n========== QUẢN LÝ KHO SIÊU THỊ ==========");
                Console.WriteLine("1. Xem toàn bộ danh sách");
                Console.WriteLine("2. Tìm kiếm hàng hóa");
                Console.WriteLine("3. Sắp xếp theo Tên (Tăng dần)");
                Console.WriteLine("4. Sắp xếp theo Số lượng tồn (Giảm dần)");
                Console.WriteLine("5. Xem thực phẩm khó bán");
                Console.WriteLine("6. Cập nhật đơn giá");
                Console.WriteLine("7. Xóa hàng hóa");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n--- DANH SÁCH HÀNG HÓA ---");
                        foreach (var hh in kho.LayToanBo()) Console.WriteLine(hh);
                        break;
                    case "2":
                        Console.Write("\nNhập mã cần tìm: ");
                        HangHoa kq = kho.TimKiem(Console.ReadLine());
                        if (kq != null) Console.WriteLine(kq);
                        else Console.WriteLine("Không tìm thấy!");
                        break;
                    case "3":
                        kho.SapXepTenTangDan();
                        Console.WriteLine("\nĐã sắp xếp theo tên! Bấm 1 để xem.");
                        break;
                    case "4":
                        kho.SapXepTonGiamDan();
                        Console.WriteLine("\nĐã sắp xếp theo lượng tồn! Bấm 1 để xem.");
                        break;
                    case "5":
                        Console.WriteLine("\n--- THỰC PHẨM KHÓ BÁN ---");
                        List<HangThucPham> tpKhoBan = kho.LayThucPhamKhoBan();
                        if (tpKhoBan.Count > 0)
                            foreach (var tp in tpKhoBan) Console.WriteLine(tp);
                        else
                            Console.WriteLine("Không có thực phẩm nào khó bán.");
                        break;
                    case "6":
                        Console.Write("\nNhập mã hàng cần sửa giá: ");
                        string maSua = Console.ReadLine();
                        Console.Write("Nhập giá mới: ");
                        if (double.TryParse(Console.ReadLine(), out double giaMoi) && kho.SuaDonGia(maSua, giaMoi))
                            Console.WriteLine("Cập nhật thành công!");
                        else
                            Console.WriteLine("Lỗi (Sai mã hoặc sai định dạng giá)!");
                        break;
                    case "7":
                        Console.Write("\nNhập mã hàng cần xóa: ");
                        if (kho.Xoa(Console.ReadLine()))
                            Console.WriteLine("Xóa thành công!");
                        else
                            Console.WriteLine("Không tìm thấy mã hàng để xóa!");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            }
        }
    }
}