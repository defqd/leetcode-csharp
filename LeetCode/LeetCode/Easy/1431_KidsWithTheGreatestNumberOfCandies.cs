namespace LeetCode.Easy
{
    public static class KidsWithTheGreatestNumberOfCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            var max = candies.Max();

            foreach (int candy in candies)
            {
                if (candy + extraCandies >= max)
                    result.Add(true);
                else
                    result.Add(false);
            }

            return result;
        }
    }
}