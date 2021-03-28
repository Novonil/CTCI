using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.TreesAndGraphs
{
	class MinimalTree
	{
		public static Node createMinimalBST(int[] array)
		{
			return createMinimalBSTFromArray(array, 0, array.Length - 1);
		}

		public static Node createMinimalBSTFromArray(int[] array, int start, int end)
		{
			if(end < start)
			{
				return null;
			}
			int mid = start + (end - start) / 2;

			Node r = new Node(array[mid]);

			r.left = createMinimalBSTFromArray(array, start, mid - 1);
			r.right = createMinimalBSTFromArray(array, mid + 1, end);

			return r;
		}
	}
}
