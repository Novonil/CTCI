using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
	class StringCompression
	{
		/// <summary>
		/// O(n) with String Builder
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public string modifiedString(string str)
		{
			StringBuilder result = new StringBuilder();
			int count = 0;
			for(int i = 0; i< str.Length; i++)
			{
				count++;
				if(((i + 1) >= str.Length) || (str[i]!= str[i+1]))
				{
					result.Append(str[i]);
					if(count > 1)
					{
						result.Append(count.ToString());
					}
					count = 0;
				}
			}
			return result.Length < str.Length ? result.ToString() : str;
		}

		/// <summary>
		/// O(n) with space benefits but with lesser efficiency (multiple looping and duplicate code)
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public string modifiedStringWithSpaceBenefit(string str)
		{
			int count = 0;
			int newLength = 0;
			for(int i = 0; i < str.Length; i++)
			{
				count++;
				if(i+1 >= str.Length || str[i] != str[i+1])
				{
					newLength = newLength + 1 + count.ToString().Length;
					count = 0;
				}
			}
			if (newLength >= str.Length)
				return str;
			
			StringBuilder result = new StringBuilder();
			count = 0;
			for (int i = 0; i < str.Length; i++)
			{
				count++;
				if (((i + 1) >= str.Length) || (str[i] != str[i + 1]))
				{
					result.Append(str[i]);
					result.Append(count.ToString());
					count = 0;
				}
			}
			return result.ToString();
		}
	}
}
