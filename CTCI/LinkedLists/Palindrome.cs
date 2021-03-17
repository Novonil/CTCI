using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	class Palindrome
	{
		public static bool isPalindrome(Node head)
		{
			Node n = head;
			Node reversedHead = reverseList(head);
			
			while(n != null)
			{
				if(n.data != reversedHead.data)
				{
					return false;
				}
				n = n.next;
				reversedHead = reversedHead.next;
			}
			return true;
		}
		public static bool isPalindromeNoExtraSpace(Node head)
		{
			Node slow = head;
			Node fast = head;
			Stack<int> s = new Stack<int>();

			while(fast != null && fast.next != null)
			{
				s.Push(slow.data);
				slow = slow.next;
				fast = fast.next.next;
			}
			if(fast != null)
			{
				slow = slow.next;
			}
			fast = head;

			while(slow != null)
			{
				int k = s.Pop();
				if(k != slow.data)
				{
					return false;
				}
				slow = slow.next;
			}
			return true;
		}
		public static bool isPalindromeInPlaceReverse(Node head)
		{
			Node current = head;
			Node next = null;

			while (current.next != null)
			{
				next = current.next;
				Node previous = next;
				current.next = next.next;
				previous.next = head;
				head = previous;
			}
			return true;
		}
		public static Node reverseList(Node head)
		{
			Node n = head;
			Node reversedHead = null;
			while (n != null)
			{
				Node next = n.next;
				n.next = reversedHead;
				reversedHead = n;
				n = next;
			}
			return reversedHead;
		}
	}
}
