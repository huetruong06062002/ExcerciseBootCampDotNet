public class QuanLyMenu
{
    private QuanLySanPham quanLySanPham;

    public QuanLyMenu()
    {
        quanLySanPham = new QuanLySanPham();
    }

    public void HienThiMenu()
    {
        while (true)
        {
            Console.WriteLine("\nHệ thống quản lý bán hàng:");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu dự kiến");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Thoát");

            Console.Write("Lựa chọn của bạn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThemSanPhamMenu();
                    break;
                case 2:
                    quanLySanPham.HienThiDanhSach();
                    break;
                case 3:
                    Console.WriteLine($"Tổng doanh thu dự kiến: {quanLySanPham.TinhTongDoanhThu()} VND");
                    break;
                case 4:
                    Console.Write("Nhập mã sản phẩm cần xóa: ");
                    string maSanPham = Console.ReadLine();
                    quanLySanPham.XoaSanPham(maSanPham);
                    break;
                case 5:
                    Console.WriteLine("Đã thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }

    private void ThemSanPhamMenu()
    {
        Console.WriteLine("Chọn loại sản phẩm:");
        Console.WriteLine("1. Điện tử");
        Console.WriteLine("2. Thời trang");
        Console.WriteLine("3. Thực phẩm");

        int loaiSanPham = int.Parse(Console.ReadLine());

        Console.Write("Nhập mã sản phẩm: ");
        string maSanPham = Console.ReadLine();
        Console.Write("Nhập tên sản phẩm: ");
        string tenSanPham = Console.ReadLine();
        Console.Write("Nhập giá gốc: ");
        double giaGoc = double.Parse(Console.ReadLine());

        switch (loaiSanPham)
        {
            case 1:
                Console.Write("Nhập thuế bảo hành: ");
                double thueBaoHanh = double.Parse(Console.ReadLine());
                quanLySanPham.ThemSanPham(new DienTu(maSanPham, tenSanPham, giaGoc, thueBaoHanh));
                break;
            case 2:
                Console.Write("Nhập % giảm giá: ");
                double giamGia = double.Parse(Console.ReadLine());
                quanLySanPham.ThemSanPham(new ThoiTrang(maSanPham, tenSanPham, giaGoc, giamGia));
                break;
            case 3:
                Console.Write("Nhập phí vận chuyển: ");
                double phiVanChuyen = double.Parse(Console.ReadLine());
                quanLySanPham.ThemSanPham(new ThucPham(maSanPham, tenSanPham, giaGoc, phiVanChuyen));
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }
}
