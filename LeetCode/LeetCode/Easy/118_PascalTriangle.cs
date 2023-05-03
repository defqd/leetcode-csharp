/*
 
118. Pascal's Triangle

https://leetcode.com/problems/pascals-triangle/

Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:


 

Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Input: numRows = 1
Output: [[1]]
 

Constraints:

1 <= numRows <= 30
 
*/

using System.Collections.Generic;

namespace LeetCode.Easy
{
    public static class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            int[][] triangle = new int[numRows][];

            if (numRows == 0)
                return null;

            for (int i = 0; i < numRows; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = triangle[i][i] = 1;

                for (int j = 1; j < i; j++)
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];

            }

            return triangle;

            //var result = new List<IList<int>>();

            //for (int i = 0; i < numRows; i++)
            //{
            //    var temp = new List<int>();

            //    for (int j = 0; j < i; j++)
            //    {
            //        if (j == 0 || j == i)
            //            temp.Add(1);
            //        else
            //            temp.Add(result[i - 1][j - 1] + result[i - 1][j]);
            //    }


            //    temp.Add(1);
            //    result.Add(temp);
            //}

            //return result;

            //var result = new List<IList<int>>
            //{
            //    new List<int> { 1 }
            //};

            //for (int i = 1; i < numRows; i++)
            //{
            //    var temp = new List<int> { 1 };

            //    for (int j = 1; j < i; j++)
            //        temp.Add(result[i - 1][j - 1] + result[i - 1][j]);

            //    temp.Add(1);
            //    result.Add(temp);
            //}

            //return result;
        }
    }
}