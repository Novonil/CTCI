using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	class Node
	{
		public int data;
		public Node next = null;

		public Node(int d)
		{
			data = d;
		}
	}
	class RemoveDuplicates
	{
		public static Node removeDups(Node head)
		{
			Node n = head;
			HashSet<int> hs = new HashSet<int>();
			hs.Add(n.data);

			while(n.next != null)
			{
				if(hs.Contains(n.next.data))
				{
					n.next = n.next.next;
					continue;
				}
				else
				{
					hs.Add(n.next.data);
				}
				n = n.next;
			}
			return head;
		}
		public static Node removeDp(Node head)
		{
			Node n = head;

			if (n.data == n.next.data)
				n.next = n.next.next;
			
				
			while (n.next != null)
			{
				Node temp = n.next;
				while(temp.next != null)
				{
					if(n.next.data == temp.next.data)
					{
						temp.next = temp.next.next;
					}
					temp = temp.next;
				}
				n = n.next;
			}
			return head;
		}
	}
}
