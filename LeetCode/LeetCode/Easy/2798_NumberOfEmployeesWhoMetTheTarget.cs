namespace LeetCode.Easy
{
    public static class NumberOfEmployeesWhoMetTheTarget
    {
        public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            //int count = 0;

            //foreach (int hour in hours)
            //{
            //    if (hour >= target)
            //        count++;
            //}

            //return count;

            return hours.Where(hour => hour >= target).Count();
        }
    }
}