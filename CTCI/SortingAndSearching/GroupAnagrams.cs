using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.SortingAndSearching
{
	class GroupAnagrams
	{
		public static void sort(string[] array)
		{
			Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
			foreach(string arr in array)
			{
				string key = sortString(arr);
				if (map.ContainsKey(key))
				{
					map[key].Add(arr);
				}
				else
				{
					List<string> l = new List<String>();
					l.Add(arr);
					map.Add(key, l);
				}
			}
			int i = 0;
			foreach (KeyValuePair<string, List<string>> kv in map)
			{
				List<string> val = kv.Value;
				foreach (string v in val)
				{
					array[i++] = v;
				}
			}
		}

		public static string sortString(string str)
		{
			char[] ch = str.ToCharArray();
			Array.Sort(ch);
			return new String(ch);
		}

	}
}
