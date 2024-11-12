public class ThanhToanOnline : IThanhToan
{
    private const string Otp = "1234";

    public bool ThanhToan(double soTien)
    {
        Console.Write("Nhập mã OTP: ");
        string inputOtp = Console.ReadLine();

        if (inputOtp == Otp)
        {
            Console.WriteLine($"Thanh toán online thành công: {soTien} VND");
            return true;
        }
        else
        {
            Console.WriteLine("Mã OTP không đúng, thanh toán thất bại.");
            return false;
        }
    }
}
