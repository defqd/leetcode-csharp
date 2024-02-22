namespace LeetCode.Easy
{
    public static class CountPairsWhoseSumIsLessThanTarget
    {
        public static int CountPairs(IList<int> nums, int target)
        {
            //TwoPointers
            nums = nums.OrderBy(x => x).ToList();

            int count = 0;
            int left = 0;
            int right = nums.Count - 1;

            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    count += right - left;
                    left++;
                }
                else
                    right--;
            }

            return count;

            //int count = 0;

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    for (int j = i + 1; j < nums.Count; j++)
            //    {
            //        if (nums[i] + nums[j] < target)
            //            count++;
            //    }
            //}

            //return count;


            //return nums.Select((n, i) => nums.Skip(i + 1).Count(p => n + p < target))
            //       .Sum();
        }
    }
}