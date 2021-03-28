using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.TreesAndGraphs
{
	class PreOrderTraversal
	{
		public static void preOrderTraversal(Node root)
		{
			if (root == null)
				return;

			Console.WriteLine(root.data);
			preOrderTraversal(root.left);
			preOrderTraversal(root.right);

		}
	}
}
