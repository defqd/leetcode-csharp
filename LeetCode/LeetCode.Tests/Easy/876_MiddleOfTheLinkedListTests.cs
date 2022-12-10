using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class MiddleOfTheLinkedListTests
    {
        [TestCaseSource(typeof(MiddleOfTheLinkedListTestSource))]
        public void MiddleNodeTest(ListNode head, ListNode expected)
        {
            var result = MiddleOfTheLinkedList.MiddleNode(head);

            Assert.That(expected, Is.EqualTo(result));
        }

        class MiddleOfTheLinkedListTestSource : IEnumerable
        {
            public ListNode Middle(ListNode head, int index)
            {
                for (int i = 0; i < index; i++)
                {
                    head = head.next;
                }
                return head;
            }

            public IEnumerator GetEnumerator()
            {
                var firstList = new ListNode
                {
                    val = 1,
                    next = new ListNode
                    {
                        val = 2,
                        next = new ListNode
                        {
                            val = 3,
                            next = new ListNode
                            {
                                val = 4,
                                next = new ListNode
                                {
                                    val = 5
                                }
                            }
                        }
                    }
                };

                var secondList = new ListNode
                {
                    val = 1,
                    next = new ListNode
                    {
                        val = 2,
                        next = new ListNode
                        {
                            val = 3,
                            next = new ListNode
                            {
                                val = 4,
                                next = new ListNode
                                {
                                    val = 5,
                                    next = new ListNode
                                    {
                                        val = 6
                                    }
                                }
                            }
                        }
                    }
                };

                yield return new object[]
                {
                    firstList,
                    Middle(firstList, 2)
                };

                yield return new object[]
                {
                    secondList,
                    Middle(secondList, 3)
                };
            }
        }
    }
}