﻿using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class MergeSortedArrayTests
    {
        [TestCaseSource(typeof(MergeSortedArrayTestSource))]
        public void MergeTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            var result = MergeSortedArray.Merge(nums1, m, nums2, n);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class MergeSortedArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] 
            {
                new int[] {1, 2, 3, 0, 0, 0},
                3,
                new int[] { 2,5,6 },
                3,
                new int[] { 1, 2, 2, 3, 5, 6 } 
            };
            yield return new object[]
            {
                new int[] { 1 },
                1,
                new int[] { 0 },
                0,
                new int[] { 1 }
            };
            yield return new object[]
            {
                new int[] { 0 },
                0,
                new int[] { 1 },
                1,
                new int[] { 1 }
            };
            yield return new object[]
            {
                new int[] {4, 5, 6, 0, 0, 0},
                3,
                new int[] { 1, 2, 3 },
                3,
                new int[] { 1, 2, 3, 4, 5, 6 }
            };    
        }
    }
}