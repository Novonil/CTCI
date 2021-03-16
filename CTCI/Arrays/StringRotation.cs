using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
	class StringRotation
	{
		public bool isRotation(string str1, string str2)
		{
			if (str1.Length == str2.Length && str1.Length > 0)
			{
				string newString = str1 + str1;
				return newString.Contains(str2);
			}
			return false;
		}
	}
}
