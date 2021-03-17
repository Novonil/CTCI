using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	class LoopDetection
	{
		public static Node loopBeginning(Node head)
		{
			Node slow = head;
			Node fast = head;

			while(fast != null && fast.next != null)
			{
				slow = slow.next;
				fast = fast.next.next;
				if (slow == fast)
				{
					break;
				}
			}

			if(fast == null || fast.next == null)
			{
				return null;
			}

			fast = head;

			while (fast != slow)
			{
				fast = fast.next;
				slow = slow.next;
			}
			return fast;
		}
	}
}
