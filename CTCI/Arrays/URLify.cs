using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
	class URLify
	{
		public string URLString(string str, int trueLength)
		{
			int spaceCount = 0;
			for(int i = 0; i < trueLength; i++)
			{
				if (str[i] == ' ')
					spaceCount++;
			}

			int modLength = trueLength + (2 * spaceCount) - 1;
			char[] ch = str.ToCharArray();
			for(int i = trueLength - 1; i>=0; i--)
			{
				if(ch[i] != ' ')
				{
					ch[modLength--] = ch[i];
				}
				else
				{
					ch[modLength--] = '0';
					ch[modLength--] = '2';
					ch[modLength--] = '%';
				}
			}
			return new string(ch);
		}

		public string URLStringBuilder(string str, int trueLength)
		{
			StringBuilder result = new StringBuilder();
			for(int i = 0; i < trueLength; i++)
			{
				if(str[i] == ' ')
				{
					result.Append("%20");
				}
				else
				{
					result.Append(str[i]);
				}
			}
			return result.ToString();
		}
	}
}
