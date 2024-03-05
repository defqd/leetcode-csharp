namespace LeetCode.Easy
{
    public class RangeSumQueryImmutable
    {
        private readonly int[] _nums;
        public RangeSumQueryImmutable(int[] nums)
        {
            _nums = nums;

            //_nums = new int[nums.Length + 1];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    _nums[i + 1] = _nums[i] + nums[i];
            //}
        }

        public int SumRange(int left, int right)
        {
            int result = 0;

            for (int i = left; i <= right; i++)
                result += _nums[i];

            return result;

            //return _nums[right + 1] - _nums[left];
        }
    }
}
