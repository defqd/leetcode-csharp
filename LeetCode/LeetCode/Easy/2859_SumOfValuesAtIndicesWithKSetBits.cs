using System;
using System.Numerics;

namespace LeetCode.Easy
{
    public static class SumOfValuesAtIndicesWithKSetBits
    {
        public static int SumIndicesWithKSetBits(IList<int> nums, int k)
        {
            int result = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (BitOperations.PopCount((uint)i) == k)
                {
                    result += nums[i];
                }
            }

            return result;

            //return nums.Where((t, i) => CountOnes(i) == k).Sum();
        }

        //private static int CountOnes(int num)
        //{
        //    int count = 0;
        //    while (num != 0)
        //    {
        //        if ((num & 1) == 1)
        //            ++count;
        //        num >>= 1;
        //    }
        //    return count;
        //}
    }
}
