namespace LeetCode.Easy
{
    public class FinalValueOfVariableAfterPerformingOperations
    {
        public static int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;

            foreach (var operation in operations)
            {
                switch (operation)
                {
                    case "--X":
                        --x;
                        break;
                    case "X--":
                        x--;
                        break;
                    case "++X":
                        ++x;
                        break;
                    case "X++":
                        x++;
                        break;
                }
            }

            return x;
        }
    }
}