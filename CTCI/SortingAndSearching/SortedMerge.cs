using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.SortingAndSearching
{
	class SortedMerge
	{
		public static void merge(int[] a, int[] b)
		{
			int current = a.Length - 1;
			int helperA = a.Length - b.Length - 1;
			int helperB = b.Length - 1;

			while (helperA >= 0 && helperB >= 0)
			{
				if (a[helperA] > b[helperB])
				{
					a[current] = a[helperA];
					helperA--;
				}
				else
				{
					a[current] = b[helperB];
					helperB--;
				}
				current--;
			}

			while (helperB >= 0)
			{
				a[current--] = b[helperB--];
			}

		}
	}
}
