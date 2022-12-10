/*
 
876. Middle of the Linked List

https://leetcode.com/problems/middle-of-the-linked-list/description/
 
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.

Example 1:


Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
Example 2:


Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one. 
*/

using System.Collections.Generic;

namespace LeetCode.Easy
{
    public static class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode middle = head;
            ListNode end = head;

            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }

            return middle;

            //var list = new List<ListNode>();

            //while (head != null)
            //{
            //    list.Add(head);
            //    head = head.next;
            //}

            //return list.ElementAt(list.Count / 2);
        }
    }
 
    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }
}