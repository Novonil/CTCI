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

			Node head1 = new Node(10);
			head1.next = new Node(11);
			head1.next.next = new Node(12);
			head1.next.next.next = new Node(13);
			head1.next.next.next.next = new Node(14);
			head1.next.next.next.next.next = new Node(15);
			head1.next.next.next.next.next.next = new Node(16);
			head1.next.next.next.next.next.next.next = new Node(17);
			head1.next.next.next.next.next.next.next.next = new Node(18);

			Node head = new Node(1);
			head.next = new Node(2);
			head.next.next = new Node(3);
			head.next.next.next = new Node(4);
			//head.next.next.next.next = head1.next.next.next.next.next.next.next.next;
			//head.next.next.next.next.next.next = new Node(7);
			//head.next.next.next.next.next.next.next = new Node(8);
			//head.next.next.next.next.next.next.next.next = new Node(9);
			//head.next.next.next.next.next.next.next.next.next = new Node(10);

			
			Node nodes = Intersection.intersectionPoint(head, head1);
			Console.WriteLine(nodes.data);



			//while (nodes != null)
			//{
			//	Console.WriteLine(nodes.data);
			//	nodes = nodes.next;
			//}

			Console.ReadLine();
		}
	}
}

