using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
	class IsStringUnique
	{
		/// <summary>
		/// O(C) Constant time Constant Space
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public bool IsUnique(string str)
		{
			bool[] charMap = new bool[256];

			if (str.Length > 256)
				return false;

			for(int i = 0; i< str.Length; i++)
			{
				if (charMap[str[i]])
					return false;
				charMap[str[i]] = true;
			}
			return true;
		}

		/// <summary>
		/// O(n)
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public bool IsUniqueBitManipulation(string str)
		{
			if (str.Length > 26)
				return false;

			int a = 0;
			int x;
			for(int i = 0; i< str.Length; i++)
			{
				int ind = str[i] - 'a';
				x = 1 << ind;
				if((a & x) > 0)
				{
					return false;
				}
				a |= 1 << ind;
			}
			return true;
		}
		/// <summary>
		/// O(nlogn)
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public bool IsUniqueSort(string str)
		{
			if (str.Length > 256)
				return false;

			char[] ch = str.ToCharArray();
			Array.Sort(ch);
			for(int i = 0; i < ch.Length - 1; i++)
			{
				if (ch[i] == ch[i+1])
					return false;
			}
			return true;
		}

		/// <summary>
		/// O(n^2)
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public bool IsUniqueCompare(string str)
		{
			if (str.Length > 256)
				return false;
			for(int i = 0; i<str.Length - 1; i++)
			{
				for(int j = i+1; j < str.Length; j++)
				{
					if (str[i] == str[j])
						return false;
				}
			}
			return true;
		}
	}
}
