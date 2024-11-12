public class ThanhToanBangThe : IThanhToan
{
    private const string Pin = "9999"; 

    public bool ThanhToan(double soTien)
    {
        Console.Write("Nhập mã PIN: ");
        string inputPin = Console.ReadLine();

        if (inputPin == Pin)
        {
            Console.WriteLine($"Thanh toán bằng thẻ thành công: {soTien} VND");
            return true;
        }
        else
        {
            Console.WriteLine("Mã PIN không đúng, thanh toán thất bại.");
            return false;
        }
    }
}
