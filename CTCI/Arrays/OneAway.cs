using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
	class OneAway
	{
		/// <summary>
		/// O9n)
		/// </summary>
		/// <param name="str1"></param>
		/// <param name="str2"></param>
		/// <returns></returns>
		public bool checkIfStringsOneEditAway(string str1, string str2)
		{
			if (str1.Length == str2.Length)
			{
				return CheckEdit(str1, str2);
			}
			else if (str1.Length - 1 == str2.Length)
			{
				return CheckAdd(str1, str2);
			}
			else if (str1.Length == str2.Length - 1)
			{
				return CheckAdd(str2, str1);
			}
			else
				return false;
		}

		/// <summary>
		/// O(n) duplicate code removed
		/// </summary>
		/// <param name="str1"></param>
		/// <param name="str2"></param>
		/// <returns></returns>
		public bool CheckEdit(string str1, string str2)
		{
			bool foundDifference = false;
			for(int i = 0; i< str1.Length; i++)
			{
				if(str1[i] != str2[i])
				{
					if (foundDifference)
						return false;
					foundDifference = true;
				}
			}
			return true;
		}

		public bool CheckAdd(string str1, string str2)
		{
			int index1 = 0, index2 = 0;
			while(index1 < str1.Length && index2 < str2.Length)
			{
				if(str1[index1] != str2[index2])
				{
					if (index1 != index2)
						return false;
					index1++;
				}
				else
				{
					index1++;
					index2++;
				}
			}
			return true;
		}

		public bool CheckOneEdit(string s1, string s2)
		{
			if (Math.Abs(s1.Length - s2.Length) > 1)
				return false;

			string str1 = s1.Length > s2.Length ? s1 : s2;
			string str2 = s1.Length > s2.Length ? s2 : s1;

			bool diffFound = false;
			int i = 0, j = 0;

			while(i < str1.Length && j < str2.Length)
			{
				if(str1[i]!=str2[j])
				{
					if (diffFound)
						return false;
					diffFound = true;
					if (str1.Length == str2.Length)
						j++;
				}
				else
				{
					j++;
				}
				i++;
			}
			return true;
		}
	}
}
