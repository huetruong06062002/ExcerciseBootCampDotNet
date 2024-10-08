
using ExerciseDate3;

partial class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        //BT1:
        Console.WriteLine($"Tổng các phần tử trong list BT1: {BaiTap.BaiTap1()} ");


        //BT2:
        int[] nums = { 2, 7, 11, 15 };
        int target = 18;

        int[] result = BaiTap.BaiTap2(nums, target);
        Console.WriteLine("---------------------------BT2-----------------------------------");
        if (result.Length > 0)
        {
            Console.WriteLine("Output: [" + result[0] + ", " + result[1] + "]");
        }
        else
        {
            Console.WriteLine("Không tìm thấy cặp số thỏa mãn");
        }

        //BT3:
        int[] numsBT3 = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
        int length = BaiTap.BaiTap3(numsBT3);
        Console.WriteLine("---------------------------BT3-----------------------------------");

        Console.WriteLine("Output: " + length);
        Console.Write("Mảng mới là: [");
        for (int i = 0; i < length; i++)
        {
            Console.Write(numsBT3[i]);
            if (i < length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");


        //BT4:
         int[] numsBT4 = {1, 1, 1, 2, 2, 3};
        int k = 2;

        // Gọi hàm TopKFrequent và in kết quả
        List<int> resultBT4 = BaiTap.BaiTap4(numsBT4, k);
        Console.WriteLine("---------------------------BT4-----------------------------------");

        Console.WriteLine("Output: [" + string.Join(", ", resultBT4) + "]");



        //BT5:
          int[] prices = {7, 1, 5, 3, 6, 4};

        // Gọi hàm MaxProfit và in kết quả
        int resultBT5 = BaiTap.BT5(prices);
        Console.WriteLine("---------------------------BT5-----------------------------------");
        
        Console.WriteLine("Output: " + resultBT5); // Output: 5
    }
}






