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


			Node head = new Node(16);
			head.next = new Node(15);
			head.next.next = new Node(14);
			head.next.next.next = new Node(13);
			head.next.next.next.next = new Node(12);
			head.next.next.next.next.next = new Node(11);
			head.next.next.next.next.next.next = new Node(10);
			//ListNode x = 
			Node n = PartitionLists.partitionInPlaceOther(head, 13);
			//Node n = head;
			while (n != null)
			{
				Console.WriteLine(n.data);
				n = n.next;
			}

			Console.ReadLine();
		}
	}
}

