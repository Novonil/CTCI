﻿using CTCI.LinkedLists;
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


			Node head = new Node(1);
			head.next = new Node(2);
			head.next.next = new Node(3);
			head.next.next.next = new Node(4);
			head.next.next.next.next = new Node(5);
			head.next.next.next.next.next = new Node(4);
			head.next.next.next.next.next.next = new Node(3);
			head.next.next.next.next.next.next.next = new Node(2);
			head.next.next.next.next.next.next.next.next = new Node(1);
			//head.next.next.next.next.next.next.next.next.next = new Node(10);

			//Node head1 = new Node(9);
			//head1.next = new Node(9);
			//head1.next.next = new Node(9);
			//head1.next.next.next = new Node(9);
			//head1.next.next.next.next = new Node(9);
			//head1.next.next.next.next.next = new Node(9);
			//head1.next.next.next.next.next.next = new Node(6);

			bool n = Palindrome.isPalindrome(head);
			Console.WriteLine(n);
			//while (n != null)
			//{
			//	Console.WriteLine(n.data);
			//	n = n.next;
			//}

			Console.ReadLine();
		}
	}
}

