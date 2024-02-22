using System.Collections;

namespace LeetCode.Easy
{
    public static class HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            List<int> numsSorted = new List<int>(nums);

            numsSorted.Sort();

            int[] result = new int[nums.Length];

            for (int i = 0; i < numsSorted.Count; i++)
            {
                result[i] = numsSorted.IndexOf(nums[i]);
            }

            return result;


            //var dic = new Dictionary<int, int>();
            //int[] copy = (int[])nums.Clone();

            //Array.Sort(copy);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!dic.ContainsKey(copy[i]))
            //    {
            //        dic.Add(copy[i], i);
            //    }
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    copy[i] = dic[nums[i]];
            //}

            //return copy;
        }
    }
}