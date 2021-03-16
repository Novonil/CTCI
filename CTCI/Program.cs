using CTCI.LinkedLists;
using System;

namespace CTCI
{
	class Program
	{
		static void Main(string[] args)
		{
			////-------------------  ******  Test Justification Starts  ******  -------------------
			//StringRotation Isu = new StringRotation();
			//int[,] mat =   { 
			//					{100, 1, 0, 3},
			//					{1, 1, 9, 10},
			//					{2, 5, 11, 2 },
			//					{3, 7, 3, 12}
			//				};

			//Console.WriteLine(Isu.isRotation("waterbottle","erbottlewat"));
			////-------------------  ******  Test Justification Starts  ******  -------------------


			ListNode head = new ListNode(10);
			head.next = new ListNode(11);
			head.next.next = new ListNode(11);
			head.next.next.next = new ListNode(12);
			head.next.next.next.next = new ListNode(11);
			head.next.next.next.next.next = new ListNode(11);

			//ListNode x = 
			RemoveDuplicates1.removeDupsDummy(head);
			ListNode n = head;
			Console.WriteLine(n.data);
			while (n.next != null)
			{
				Console.WriteLine(n.next.data);
				n = n.next;
			}

			Console.Read();
		}
	}
}

