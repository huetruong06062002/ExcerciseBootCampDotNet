public abstract class SanPham
{
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public double GiaGoc { get; set; }

    public SanPham(string maSanPham, string tenSanPham, double giaGoc)
    {
        MaSanPham = maSanPham;
        TenSanPham = tenSanPham;
        GiaGoc = giaGoc;
    }

    // Phương thức trừu tượng để tính giá bán
    public abstract double TinhGiaBan();

    // Phương thức ảo để hiển thị thông tin sản phẩm
    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Mã sản phẩm: {MaSanPham}, Tên sản phẩm: {TenSanPham}, Giá gốc: {GiaGoc}");
    }
}
