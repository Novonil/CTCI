using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	class Intersection
	{
		public static Node intersectionPoint(Node node1, Node node2)
		{
			Node n1 = node1, n2 = node2;
			Node tail1 = null, tail2 = null;
			int len1 = 0, len2 = 0;
			int diff = 0;
			while (n1 != null)
			{
				len1++;
				tail1 = n1;
				n1 = n1.next;
			}
			while(n2 != null)
			{
				len2++;
				tail2 = n2;
				n2 = n2.next;
			}
			if(tail1 != tail2)
			{
				return null;
			}
			diff = Math.Abs(len1 - len2);
			n1 = node1;
			n2 = node2;
			if(len1 > len2)
			{
				while(diff > 0)
				{
					n1 = n1.next;
					diff--;
				}
			}
			else if(len2 > len1)
			{
				while(diff > 0)
				{
					n2 = n2.next;
					diff--;
				}
			}

			while(n1 != n2)
			{
				n1 = n1.next;
				n2 = n2.next;
			}
			return n1;
		}
	}
}
