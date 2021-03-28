using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.TreesAndGraphs
{
	public class Node
	{
		public int data;
		public Node left;
		public Node right;
		public Node(int data)
		{
			this.data = data;
			this.left = null;
			this.right = null;
		}
	}
}
