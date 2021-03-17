using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	class PartitionLists
	{
		public static Node partition(Node head, int x)
		{
			Node firstNodeStart = null;
			Node firstNodeEnd = null;
			Node secondNodeStart = null;
			Node secondNodeEnd = null;

			while (head != null)
			{
				Node n = head.next;
				head.next = null;
				if (head.data < x)
				{
					if(firstNodeStart == null)
					{
						firstNodeStart = head;
						firstNodeEnd = head;
					}
					else
					{
						firstNodeEnd.next = head;
						firstNodeEnd = head;
					}
				}
				else
				{
					if(secondNodeStart == null)
					{
						secondNodeStart = head;
						secondNodeEnd = head;
					}
					else
					{
						secondNodeEnd.next = head;
						secondNodeEnd = head;
					}
				}
				head = n;
			}

			if (firstNodeStart == null)
				return secondNodeStart;

			firstNodeEnd.next = secondNodeStart;
			return firstNodeStart;
		}
		
		public static Node partitionOther(Node head, int x)
		{
			Node beforeStart = null;
			Node beforeEnd = null;
			Node afterStart = null;
			Node afterEnd = null;

			while(head != null)
			{
				Node n = head.next;
				head.next = null;
				if(head.data < x)
				{
					if(beforeStart == null)
					{
						beforeStart = head;
						beforeEnd = beforeStart;
					}
					else
					{
						head.next = beforeStart;
						beforeStart = head;
					}
				}
				else
				{
					if (afterStart == null)
					{
						afterStart = head;
						afterEnd = afterStart;
					}
					else
					{
						afterEnd.next = head;
						afterEnd = head;
					}
				}
				head = n;
			}
			if (beforeStart == null)
					return afterStart;

			beforeEnd.next = afterStart;
			return beforeStart;
		}
		public static Node partitionInPlace(Node head, int x)
		{
			Node start = head;
			Node end = head;

			while (head != null)
			{
				Node n = head.next;
				if (head.data < x)
				{
					head.next = start;
					start = head;
				}
				else
				{
					end.next = head;
					end = head;
				}
				head = n;
			}
			end.next = null;
			return start;
		}
		public static Node partitionInPlaceOther(Node head, int x)
		{
			Node start = head;
			Node end = head;

			while (head != null)
			{
				Node n = head.next;
				head.next = null;
				if (head.data < x)
				{
					head.next = start;
					start = head;
				}
				else
				{
					end.next = head;
					end = head;
				}
				head = n;
			}
			end.next = null;
			return start;
		}
	}
}
