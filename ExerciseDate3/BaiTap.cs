using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseDate3
{
    public class BaiTap
    {
        public static int BaiTap1()
        {

            #region Bài 1: LstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]

            //input: lstNumber
            List<int> lstNumber = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };

            //output: Trả về tổng của tất cả các số trong mảng IstNumber
            int result = 0;

            //proccess:
            foreach (int item in lstNumber)
            {
                result += item;
            }

            return result;


            #endregion


        }

        public static int[] BaiTap2(int[] nums, int target)
        {
            //input: Lst_number = [2, 7, 11, 15], target = 9

            // Tạo dictionary để lưu trữ giá trị và chỉ số của các phần tử đã duyệt qua
            Dictionary<int, int> map = new Dictionary<int, int>();


            //output: [0, 1]
            int[] result = new int[0];


            //process:
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                //Kiểm tra xem phần bù có tồn tại trong map hay không
                if (map.ContainsKey(complement))
                {
                    // Nếu tồn tại, trả về chỉ số của complement và phần tử hiện tại
                    result = new int[] { map[complement], i };
                    return result;
                }
                // Nếu không tìm thấy complement, thêm phần tử hiện tại vào map
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }

            // Nếu không tìm thấy, trả về mảng rỗng
            result = new int[] { };
            return result;

        }

        public static int BaiTap3(int[] nums)
        {
            //input : ltNumber = [1, 1, 2, 2, 2, 3, 4, 4, 5]


            //output : = 5
            // Vị trí của phần tử không trùng lặp tiếp theo
            int index = 1;

            //proccess
            // Duyệt qua mảng
            for (int i = 1; i < nums.Length; i++)
            {
                // Kiểm tra nếu phần tử hiện tại khác với phần tử trước đó
                if (nums[i] != nums[i - 1])
                {
                    // Đặt phần tử không trùng lặp vào vị trí index và tăng index lên
                    nums[index] = nums[i];
                    index++;
                }
            }

            // Trả về số phần tử không trùng lặp (tức là index)
            return index;
        }

        //BT4: input nums = [1, 1, 1, 2, 2, 3] k = 2
        //output: : [1, 2]

        public static List<int> BaiTap4(int[] nums, int k)
        {
            //input: nums = [1, 1, 1, 2, 2, 3] k = 2

            //output: [1, 2]

            //process:
            // Tạo dictionary để lưu trữ giá trị và số lần xuất hiện của các phần tử
            Dictionary<int, int> map = new Dictionary<int, int>();

            // Duyệt qua mảng
            foreach (int num in nums)
            {
                // Nếu phần tử đã tồn tại trong map, tăng số lần xuất hiện lên 1
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                // Nếu phần tử chưa tồn tại, thêm vào map với số lần xuất hiện là 1
                else
                {
                    map[num] = 1;
                }
            }

            // Tạo danh sách để lưu trữ kết quả
            List<int> result = new List<int>();

            // Duyệt qua map
            foreach (var item in map)
            {
                // Nếu số lần xuất hiện của phần tử lớn hơn hoặc bằng k, thêm vào kết quả
                if (item.Value >= k)
                {
                    result.Add(item.Key);
                }
            }

            // Trả về kết quả
            return result;
        }



        public static int BT5(int[] prices) {
        // Nếu mảng rỗng hoặc chỉ có 1 phần tử thì không thể mua bán, trả về 0
        if (prices.Length == 0 || prices.Length == 1) {
            return 0;
        }

        // Khởi tạo giá mua ban đầu là giá ngày đầu tiên
        int minPrice = prices[0];
        int maxProfit = 0;

        // Duyệt qua các ngày từ ngày thứ 2 trở đi
        for (int i = 1; i < prices.Length; i++) {
            // Cập nhật giá mua thấp nhất nếu tìm thấy giá nhỏ hơn
            if (prices[i] < minPrice) {
                minPrice = prices[i];
            } 
            // Tính lãi nếu bán cổ phiếu tại ngày thứ i
            else {
                int profit = prices[i] - minPrice;
                // Cập nhật lãi tối đa nếu lãi tại ngày này lớn hơn lãi tối đa hiện tại
                if (profit > maxProfit) {
                    maxProfit = profit;
                }
            }
        }

        // Trả về lãi tối đa có thể đạt được
        return maxProfit;
    }

    }
}