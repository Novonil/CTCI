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


			ListNode head = new ListNode(1,false);
			head.next = new ListNode(2,false);
			head.next.next = new ListNode(3,false);
			head.next.next.next = new ListNode(4,false);
			head.next.next.next.next = new ListNode(5,false);
			head.next.next.next.next.next = new ListNode(4,false);
			head.next.next.next.next.next.next = new ListNode(3,false);
			head.next.next.next.next.next.next.next = new ListNode(2,false);
			head.next.next.next.next.next.next.next.next = new ListNode(1,false);
			//head.next.next.next.next.next.next.next.next.next = new ListNode(10);

			//ListNode head1 = new ListNode(9);
			//head1.next = new ListNode(9);
			//head1.next.next = new ListNode(9);
			//head1.next.next.next = new ListNode(9);
			//head1.next.next.next.next = new ListNode(9);
			//head1.next.next.next.next.next = new ListNode(9);
			//head1.next.next.next.next.next.next = new ListNode(6);

			bool n = DeleteMiddleNode.deleteMiddleNodeLastNode(head.next.next.next.next.next.next.next.next);
			Console.WriteLine(n);

			ListNode nodes = head;
			while (nodes != null)
			{
				Console.WriteLine(nodes.data + " " + nodes.isDummy);
				nodes = nodes.next;
			}

			Console.ReadLine();
		}
	}
}

