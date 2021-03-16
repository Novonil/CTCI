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
			ListNode temp = head;
			ListNode prevNode = null;
			HashSet<int> visited = new HashSet<int>();

			while(temp != null)
			{
				if(visited.Contains(temp.data))
				{
					prevNode.next = temp.next;
				}
				else
				{
					visited.Add(temp.data);
					prevNode = temp;
				}
				temp = temp.next;
			}
		}

		public static void removeDups(ListNode head)
		{

		}
	}
}
