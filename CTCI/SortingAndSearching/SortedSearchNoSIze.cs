using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.SortingAndSearching
{
	class SortedSearchNoSIze
	{
		public static int search(int[] arr, int target)
		{
			int start = 0;
			int end = 1;
			while (arr[end] != -1 && arr[end] >= target)
			{
				start = end;
				end *= 2;
			}
			return binarySearch(arr, start, end, target);
		}

		public static int binarySearch(int[] arr, int start, int end, int target)
		{
			int mid;

			while (start <= end)
			{
				mid = start + (end - start) / 2;
				if (arr[mid] == target)
					return mid;
				else if (arr[mid] == -1 || arr[mid] > target)
					end = mid - 1;
				else
					start = mid + 1;
			}
			return -1;
		}


	}
}
