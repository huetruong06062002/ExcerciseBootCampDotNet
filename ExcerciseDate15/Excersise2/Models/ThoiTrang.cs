public class ThoiTrang : SanPham
{
    public double GiamGia { get; set; } // % giảm giá

    public ThoiTrang(string maSanPham, string tenSanPham, double giaGoc, double giamGia)
        : base(maSanPham, tenSanPham, giaGoc)
    {
        GiamGia = giamGia;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc - (GiaGoc * GiamGia / 100);
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giá bán (sau khi giảm giá): {TinhGiaBan()}");
    }
}
