namespace LeetCode.Easy
{
    public static class SortArrayByParitySolution
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            //int[] arr = new int[nums.Length];

            while (left < right)
            {
                if (nums[left] % 2 > nums[right] % 2)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }

                if (nums[left] % 2 == 0) left++;
                if (nums[right] % 2 == 1) right--;
            }

            //while (left < right)
            //{
            //    if (nums[left] % 2 == 0 && nums[right] % 2 == 1)
            //    {
            //        left++;
            //        right--;
            //    }
            //    else if (nums[left] % 2 == 1 && nums[right] % 2 == 0)
            //    {
            //        int temp = nums[left];
            //        nums[left++] = nums[right];
            //        nums[right--] = temp;
            //    }
            //    else if (nums[left] % 2 == 0 && nums[right] % 2 == 0)
            //        left++;
            //    else if (nums[left] % 2 == 1 && nums[right] % 2 == 1)
            //        right--;
            //}

            //foreach (int item in nums)
            //{
            //    if (item % 2 == 0)
            //        arr[left++] = item;
            //    else
            //        arr[right--] = item;
            //}

            return nums;
        }
    }
}