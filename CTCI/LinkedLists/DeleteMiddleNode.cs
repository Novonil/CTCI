using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	public class ListNode
	{
		public int data;
		public bool isDummy = false;
		public ListNode next;
		public ListNode(int data, bool isDummy)
		{
			this.data = data;
			this.isDummy = isDummy;
		}
	}
	class DeleteMiddleNode
	{
		public static bool deleteNode(Node n)
		{
			//Does not work if the node is the last node
			if(n == null || n.next == null)
			{
				return false;
			}

			n.data = n.next.data;
			n.next = n.next.next;
			return true;
		}

		public static bool deleteMiddleNodeLastNode(ListNode n)
		{
			if (n == null)
				return false;
			if(n.next == null)
			{
				n.isDummy = true;
				return true;
			}
			n.data = n.next.data;
			n.next.isDummy = true;
			n.next = n.next.next;
			return true;
		}
	}
}
