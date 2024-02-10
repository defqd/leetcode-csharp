namespace LeetCode.Easy
{
    public static class ShuffleTheArray
    {
        public static int[] Shuffle(int[] nums, int n)
        {
            var list = new List<int>();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                list.Add(nums[i]);
                list.Add(nums[i + n]);
            }

            return list.ToArray();

            //int[] shuffledNums = new int[n * 2];

            //for (int i = 0; i < n; i++)
            //{
            //    shuffledNums[2 * i] = nums[i];
            //    shuffledNums[2 * i + 1] = nums[i + n];
            //}

            //return shuffledNums;
        }
    }
}