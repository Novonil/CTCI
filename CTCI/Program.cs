using CTCI.LinkedLists;
using CTCI.SortingAndSearching;
using CTCI.TreesAndGraphs;
using System;
using System.Collections.Generic;

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

			//Node head1 = new Node(10);
			//head1.next = new Node(11);
			//head1.next.next = new Node(12);
			//head1.next.next.next = new Node(13);
			//head1.next.next.next.next = new Node(14);
			//head1.next.next.next.next.next = new Node(15);
			//head1.next.next.next.next.next.next = new Node(16);
			//head1.next.next.next.next.next.next.next = new Node(17);
			//head1.next.next.next.next.next.next.next.next = new Node(18);
			//head1.next.next.next.next.next.next.next.next.next = head1.next.next.next.next.next;

			//Node head = new Node(1);
			//head.next = new Node(2);
			//head.next.next = new Node(3);
			//head.next.next.next = new Node(4);
			//head.next.next.next.next = head1.next.next.next.next.next.next.next.next;
			//head.next.next.next.next.next.next = new Node(7);
			//head.next.next.next.next.next.next.next = new Node(8);
			//head.next.next.next.next.next.next.next.next = new Node(9);
			//head.next.next.next.next.next.next.next.next.next = new Node(10);


			//Node nodes = LoopDetection.loopBeginning(head1);
			//Console.WriteLine(nodes.data);

			//int[][] graph = new int[5][];

			//graph[0] = new int[] { 0, 1, 0, 1, 1 };
			//graph[1] = new int[] { 1, 1, 1, 1, 1 };
			//graph[2] = new int[] { 1, 1, 1, 1, 1 };
			//graph[3] = new int[] { 1, 1, 1, 1, 1 };
			//graph[4] = new int[] { 0, 0, 0, 0, 0 };

			//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };

			//while (nodes != null)
			//{
			//	Console.WriteLine(nodes.data);
			//	nodes = nodes.next;
			//}
			//bool result = RouteBetweenNodes.search(graph, 4, 1);

			//TreesAndGraphs.Node n = MinimalTree.createMinimalBST(nums);

			//InOrderTraversal.inOrderTraversal(n);
			//PreOrderTraversal.preOrderTraversal(n);
			//PostOrderTraversal.postOrderTraversal(n);

			//Console.WriteLine(result);


			//TreesAndGraphs.Node root = new TreesAndGraphs.Node(100);
			//root.left = new TreesAndGraphs.Node(50);
			//root.right = new TreesAndGraphs.Node(150);

			//root.left.left = new TreesAndGraphs.Node(25);
			//root.left.right = new TreesAndGraphs.Node(75);

			//root.right.left = new TreesAndGraphs.Node(125);
			//root.right.right = new TreesAndGraphs.Node(175);

			//root.left.left.left = new TreesAndGraphs.Node(15);
			//root.left.right.right = new TreesAndGraphs.Node(85);
			//root.right.left.right = new TreesAndGraphs.Node(137);
			//root.right.right.left = new TreesAndGraphs.Node(167);


			//List<List<TreesAndGraphs.Node>> result = ListOfDepths.createLevelNodeListBFS(root);

			//foreach(List<TreesAndGraphs.Node> list in result)
			//{
			//	foreach(TreesAndGraphs.Node n in list)
			//	{
			//		Console.Write(n.data + " ");
			//	}
			//	Console.WriteLine();
			//}
			//int[] a = { 9, 11, 12, 14, 15, 0, 0, 0, 0, 0, 0, 0, 0 };
			//int[] b = { 2, 4, 6, 7, 8, 10, 12, 14};

			//string[] str = { "bat", "cat", "tab", "race", "bar", "acre", "rab", "tac", "care" };
			////SortedMerge.merge(a, b);

			//GroupAnagrams.sort(str);

			int[] arr = { 70, 75, 17, 30, 31, 35, 50, 60 };
			int[] arr1 = { 24, 25, 26, 27, 30, 31, 13, 18, 23 };
			int[] arr2 = { 30, 30, 30, 30, 30, 30, 30, 18, 30 };
			int i = SearchInRotatedArray.searchs(arr2, 18);

			////////foreach (string i in str)
			//{
				Console.WriteLine(i);
			//}
			Console.ReadLine();
		}
	}
}

