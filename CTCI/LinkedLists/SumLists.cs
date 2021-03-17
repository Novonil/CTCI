using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.LinkedLists
{
	class SumLists
	{
		public static Node addListsReversed(Node n1, Node n2)
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
		public static Node addLists(Node n1, Node n2)
		{
			if(n1 == null && n2 == null)
			{
				return null;
			}
			else if(n1 == null)
			{
				return n2;
			}
			else if(n2 == null)
			{
				return n1;
			}

			
			Node result = null;

			int l1 = calculateLengthOfList(n1);
			int l2 = calculateLengthOfList(n2);

			if(l1 < l2)
			{
				n1 = padZeroes(n1, Math.Abs(l1 - l2));
			}
			else if(l2<l1)
			{
				n2 = padZeroes(n2, Math.Abs(l1 - l2));
			}

			result = calculateSum(n1, n2);

			return result;
		}
		public static int calculateLengthOfList(Node n)
		{
			int len = 0;
			while(n != null)
			{
				len++;
				n = n.next;
			}
			return len;
		}
		public static Node padZeroes(Node node, int count)
		{
			while(count > 0)
			{
				Node n = new Node(0);
				n.next = node;
				node = n;
				count--;
			}
			return node;
		}
		public static Node calculateSum(Node n1, Node n2)
		{
			int carry = 0;
			Node head = null;
			Stack<(int,int)> orderedList = new Stack<(int,int)>();
			
			
			while (n1 != null)
			{
				orderedList.Push((n1.data, n2.data));
				n1 = n1.next;
				n2 = n2.next;
			}

			while(orderedList.Count > 0)
			{
				int sum = 0;
				(int, int) digits = orderedList.Pop();
				sum = digits.Item1 + digits.Item2 + carry;

				if (head == null)
				{
					Node newNode = new Node(sum % 10);
					head = newNode;
				}
				else
				{
					Node newNode = new Node(sum % 10);
					newNode.next = head;
					head = newNode;
				}
				carry = sum / 10;
			}
			if(carry != 0)
			{
				Node newNode = new Node(carry);
				newNode.next = head;
				head = newNode;
			}
			return head;
		}
	}
}
