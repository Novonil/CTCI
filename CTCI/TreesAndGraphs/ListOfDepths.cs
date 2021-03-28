using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.TreesAndGraphs
{
	class ListOfDepths
	{
		public static List<List<Node>> createLevelNodeList(Node root)
		{
			List<List<Node>> lists = new List<List<Node>>();

			createLevelNodeList(root, lists, 0);

			return lists;
		}

		public static void createLevelNodeList(Node root, List<List<Node>> lists, int level)
		{
			if (root == null)
				return;

			if(lists.Count == level)
			{
				List<Node> currList = new List<Node>();
				currList.Add(root);
				lists.Add(currList);
			}
			else
			{
				lists[level].Add(root);
			}

			createLevelNodeList(root.left, lists, level + 1);
			createLevelNodeList(root.right, lists, level + 1);
		}


		public static List<List<Node>> createLevelNodeListBFS(Node root)
		{
			if (root == null)
				return null;

			List<List<Node>> result = new List<List<Node>>();
			List<Node> current = new List<Node>();

			current.Add(root);

			while (current.Count > 0)
			{
				result.Add(current);
				List<Node> parents = current;
				current = new List<Node>();
				foreach (Node parent in parents)
				{
					
					if (parent.left != null)
					{
						current.Add(parent.left);
					}
					if (parent.right != null)
					{
						current.Add(parent.right);
					}
				}
			}
			return result;
		}
	}
}
