using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	class SumLists
	{
		public static Node addLists(Node n1, Node n2)
		{
			int carry = 0;
			Node result = null;
			Node current = null;
			while(n1 != null || n2 != null)
			{
				int sum = 0;
				if(n1 == null)
				{
					sum = n2.data + carry;
					n2 = n2.next;
				}
				else if(n2 == null)
				{
					sum = n1.data + carry;
					n1 = n1.next;
				}
				else
				{
					sum = n1.data + n2.data + carry;
					n1 = n1.next;
					n2 = n2.next;
				}
				carry = sum / 10;
				if(result == null)
				{
					result = new Node(sum % 10);
					current = result;
				}
				else
				{
					Node s = new Node(sum % 10);
					current.next = s;
					current = s;
				}
			}
			if(carry != 0)
			{
				Node s = new Node(carry);
				current.next = s;
				current = s;
			}
			return result;
		}
	}
}
