using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.SortingAndSearching
{
	class SearchInRotatedArray
	{
		public static int search(int[] arr, int k)
		{
			int len = arr.Length;
			int start = 0;
			int end = len - 1;
			int mid;

			while (start <= end)
			{
				mid = start + (end - start) / 2;

				if (k == arr[mid])
					return mid;

				else if (arr[start] < arr[mid])
				{
					if (arr[start] <= k && k < arr[mid])
					{
						end = mid - 1;
					}
					else
					{
						start = mid + 1;
					}
				}

				else if (arr[mid] < arr[end])
				{
					if (k > arr[mid] && k <= arr[end])
					{
						start = mid + 1;
					}
					else
					{
						end = mid - 1;
					}
				}
				else
				{
					if (arr[mid] == arr[start])
					{
						start = mid + 1;
					}
					else if (arr[mid] == arr[end])
					{
						end = mid - 1;
					}
				}
			}
			return -1;
		}


		public static int searchs(int[] arr, int target)
		{
			int len = arr.Length;
			int start = 0;
			int end = len - 1;
			int mid;

			while (start <= end)
			{
				mid = start + (end - start) / 2;

				if (arr[mid] == target)
					return mid;

				else if (arr[start] < arr[mid])
				{
					if (arr[start] <= target && target < arr[mid])
					{
						end = mid - 1;
					}
					else
					{
						start = mid + 1;
					}
				}
				else if (arr[mid] < arr[end])
				{
					if (arr[mid] < target && target <= arr[end])
					{
						start = mid + 1;
					}
					else
					{
						end = mid - 1;
					}
				}
				else
				{
					if (arr[mid] == arr[start])
					{
						start = mid + 1;
					}
					else if (arr[mid] == arr[end])
					{
						end = mid - 1;
					}
				}
			}
			return -1;
		}

	}
}
