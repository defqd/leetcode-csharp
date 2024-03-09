namespace LeetCode.Easy
{
    public static class MaximumNumberOfBalloons
    {
        public static int MaxNumberOfBalloons(string text)
        {
            //var result = text.Length;

            var count = new Dictionary<char, int>()
            {
                {'b', 0 },
                {'a', 0 },
                {'l', 0 },
                {'o', 0 },
                {'n', 0 },
            };

            for (int i = 0; i < text.Length; i++)
            {
                if (count.ContainsKey(text[i]))
                    count[text[i]]++;
            }

            count['l'] /= 2;
            count['o'] /= 2;

            return count.Values.Min();

            //foreach (var c in count.Values)
            //    result = Math.Min(result, c);

            //return result;

            //***

            //var result = text.Length;

            //var balloon = new Dictionary<char, int>()
            //{
            //    {'b', 1 },
            //    {'a', 1 },
            //    {'l', 2 },
            //    {'o', 2 },
            //    {'n', 1 },
            //};

            //var count = new Dictionary<char, int>();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (count.ContainsKey(text[i]))
            //        count[text[i]]++;
            //    else
            //        count[text[i]] = 1;
            //}

            //foreach (char c in balloon.Keys)
            //{
            //    if (count.ContainsKey(c))
            //        result = Math.Min(result, count[c] / balloon[c]);
            //    else
            //        return 0;
            //}

            //return result;
        }
    }
}