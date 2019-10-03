using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveArrayDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(" Here is the number of non-repeated: {0}", removeDuplicates(nums));
            Console.ReadLine();
        }
        
        private static int removeDuplicates(Int32  [] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
