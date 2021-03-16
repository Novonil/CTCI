using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	public class ListNode
	{
		public int data;
		public ListNode next;

		public ListNode(int data)
		{
			this.data = data;
		}
	}
	class RemoveDuplicates1
	{
		public static void removeDuplicates(ListNode head)
		{
			ListNode previous = null;
			ListNode current = head;
			HashSet<int> seenValues = new HashSet<int>();


			while(current != null)
			{
				if (seenValues.Contains(current.data))
				{
					previous.next = current.next;
				}
				else
				{
					seenValues.Add(current.data);
					previous = current;
				}
				current = current.next;
			}
		}

		public static void removeDups(ListNode head)
		{
			ListNode current = head;
			ListNode next = head;

			while(current != null)
			{
				next = current;
				while(next.next != null)
				{
					if(current.data == next.next.data)
					{
						next.next = next.next.next;
					}
					else
					{
						next = next.next;
					}
				}
				current = current.next;
			}
		}

		public static void removeDupsDummy(ListNode head)
		{
			ListNode current = head;
			ListNode next = null;
			ListNode previous = null;

			while (current != null)
			{
				previous = current;
				next = current.next;
				while (next != null)
				{
					if (current.data == next.data)
					{
						previous.next = next.next;
					}
					else
					{
						previous = next;
					}
					next = next.next;
				}
				current = current.next;
			}
		}
	}
}
