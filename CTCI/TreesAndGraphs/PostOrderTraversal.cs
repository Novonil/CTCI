using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.TreesAndGraphs
{
	class PostOrderTraversal
	{
		public static void postOrderTraversal(Node root)
		{
			if (root == null)
				return;

			postOrderTraversal(root.left);
			postOrderTraversal(root.right);
			Console.WriteLine(root.data);
		}
	}
}
