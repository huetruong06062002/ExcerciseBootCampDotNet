public class DienTu : SanPham
{
    public double ThueBaoHanh { get; set; }

    public DienTu(string maSanPham, string tenSanPham, double giaGoc, double thueBaoHanh)
        : base(maSanPham, tenSanPham, giaGoc)
    {
        ThueBaoHanh = thueBaoHanh;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc + ThueBaoHanh;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giá bán (bao gồm thuế bảo hành): {TinhGiaBan()}");
    }
}
