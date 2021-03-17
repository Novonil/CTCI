using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	class ReturnKthToLastNode
	{
		public static Node nthToLast(Node head, int k)
		{
			Node current = head;
			Node runner = head;

			while(k>0)
			{
				if (runner == null)
					return null;
				runner = runner.next;
				k--;
			}

			while(runner != null)
			{
				current = current.next;
				runner = runner.next;
			}
			return current;
		}
		public static Node nthToLastBruteForce(Node head, int k)
		{
			int size = 0;
			Node current = head;
			while(current != null)
			{
				size++;
				current = current.next;
			}
			size -= k;
			if(size < 0)
			{
				return null;
			}
			current = head;
			while(current != null)
			{
				if (size == 0)
				{
					return current;
				}
				size--;
				current = current.next;
			}
			return null;
		}
		public static int nthToLastRecursive(Node head, int k)
		{
			if(head == null)
			{
				return 0;
			}
			int countOfItem = nthToLastRecursive(head.next, k) + 1;
			if (countOfItem == k)
			{
				Console.WriteLine("Kth Node to the last node is " + head.data);
			}
			return countOfItem;
		}
	}
}
