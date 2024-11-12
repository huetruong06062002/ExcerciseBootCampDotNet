public class QuanLyThanhToan
{
    private QuanLyGiaoDich quanLyGiaoDich = new QuanLyGiaoDich();

    public void HienThiMenu()
    {
        while (true)
        {
            Console.WriteLine("\nChọn phương thức thanh toán:");
            Console.WriteLine("1. Thanh toán tiền mặt");
            Console.WriteLine("2. Thanh toán bằng thẻ");
            Console.WriteLine("3. Thanh toán online");
            Console.WriteLine("4. Xem lịch sử giao dịch");
            Console.WriteLine("5. Thoát");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 5) break;

            switch (choice)
            {
                case 1:
                    ThucHienThanhToan(new ThanhToanTienMat(), "Tiền mặt");
                    break;
                case 2:
                    ThucHienThanhToan(new ThanhToanBangThe(), "Thẻ");
                    break;
                case 3:
                    ThucHienThanhToan(new ThanhToanOnline(), "Online");
                    break;
                case 4:
                    quanLyGiaoDich.XemLichSuGiaoDich();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }

    private void ThucHienThanhToan(IThanhToan phuongThucThanhToan, string phuongThuc)
    {
        Console.Write("Nhập số tiền cần thanh toán: ");
        double soTien = double.Parse(Console.ReadLine());

        bool ketQua = phuongThucThanhToan.ThanhToan(soTien);

        GiaoDich giaoDich = new GiaoDich
        {
            PhuongThuc = phuongThuc,
            SoTien = soTien,
            KetQua = ketQua
        };

        quanLyGiaoDich.LuuGiaoDich(giaoDich);
    }
}
