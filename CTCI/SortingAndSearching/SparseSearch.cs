using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.SortingAndSearching
{
	class SparseSearch
	{
		public static int search(string[] str, string s, int start, int end)
		{
			int mid;

			while (start <= end)
			{
				mid = start + (end - start) / 2;
				if (String.IsNullOrEmpty(str[mid]))
				{
					mid = findNearestNonEmptyString(str, start, end, mid);
					if (mid == -1)
						return -1;

				}

				if (str[mid].Equals(s))
					return mid;
				else if (str[mid].CompareTo(s) < 0)
				{
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}
			return -1;
		}

		public static int search(string[] str, string s)
		{
			if (str.Length == 0 || String.IsNullOrEmpty(s))
				return -1;
			return search(str, s, 0, str.Length - 1);
		}

		public static int findNearestNonEmptyString(string[] str,int start, int end, int mid)
		{
			int left = mid - 1;
			int right = mid + 1;
			while (true)
			{
				if (right > end && left < start)
					return -1;
				else if (right < end && !String.IsNullOrEmpty(str[right]))
					return right;
				else if (left > start && !String.IsNullOrEmpty(str[left]))
					return left;
				right++;
				left--;
			}
			return -1;
		}
	}
}
