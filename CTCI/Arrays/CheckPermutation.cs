using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
	class CheckPermutation
	{
		/// <summary>
		/// O(n)
		/// </summary>
		/// <param name="str1"></param>
		/// <param name="str2"></param>
		/// <returns></returns>
		public bool isPermutation(string str1, string str2)
		{
			int[] charMap = new int[256];
			if (str1.Length != str2.Length)
				return false;

			for(int i = 0; i < str1.Length; i++)
			{
				charMap[str1[i]]++;
			}
			for(int i = 0; i < str2.Length; i++)
			{
				charMap[str2[i]]--;
				if(charMap[str2[i]] < 0)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// O(nlogn)
		/// </summary>
		/// <param name="str1"></param>
		/// <param name="str2"></param>
		/// <returns></returns>
		public bool isPermutationSort(string str1, string str2)
		{
			if (str1.Length != str2.Length)
				return false;
			char[] ch1 = str1.ToCharArray();
			char[] ch2 = str2.ToCharArray();
			Array.Sort(ch1);
			Array.Sort(ch2);


			for(int i = 0; i<ch1.Length; i++)
			{
				if (ch1[i] != ch2[i])
					return false;
			}
			
			return true;
		}


	}
}
