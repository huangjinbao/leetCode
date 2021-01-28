using System.Linq;

namespace HermanLeetCode
{
    public class Arithmetic_724_FindPivotIndex
    {
        public static int PivotIndex(int[] nums)
        {
            if (nums.Length <= 0)
            {
                return -1;
            }

            var sum = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                var leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }

                if (leftSum * 2 + nums[i] == sum)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}