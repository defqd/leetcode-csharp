namespace LeetCode.Easy
{
    public static class MaximumNumberOfWordsFoundInSentences
    {
        public static int MostWordsFound(string[] sentences)
        {
            int max = 0;

            foreach (string sentence in sentences)
            {
                var temp = sentence.Split();
                var length = temp.Length;

                if (length > max)
                    max = length;
            }

            return max;
        }
    }
}