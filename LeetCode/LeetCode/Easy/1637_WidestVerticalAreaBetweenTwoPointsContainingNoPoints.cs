namespace LeetCode.Easy
{
    public static class WidestVerticalAreaBetweenTwoPointsContainingNoPoints
    {
        public static int MaxWidthOfVerticalArea(int[][] points)
        {
            Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

            int result = 0;

            for (int i = 1; i < points.Length; i++)
            {
                int width = points[i][0] - points[i - 1][0];
                result = Math.Max(result, width);
            }

            return result;
        }
    }
}