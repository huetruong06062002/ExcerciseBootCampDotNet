public class ThanhToanTienMat : IThanhToan
{
    public bool ThanhToan(double soTien)
    {
        Console.WriteLine($"Thanh toán tiền mặt thành công: {soTien} VND");
        return true;
    }
}
