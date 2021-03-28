using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.TreesAndGraphs
{
	class InOrderTraversal
	{
		public static void inOrderTraversal(Node root)
		{
			if (root == null)
				return;

			inOrderTraversal(root.left);
			Console.WriteLine(root.data);
			inOrderTraversal(root.right);
		}
	}
}
