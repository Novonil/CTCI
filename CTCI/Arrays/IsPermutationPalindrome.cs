using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
	class IsPermutationPalindrome
	{
		/// <summary>
		/// O(n)
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public bool isPermutationPalindrome(string str)
		{
			int[] countOfLetters = new int[26];
			int countOfOdd = 0;
			for (int i = 0; i<str.Length; i++)
			{
				countOfLetters[str[i] - 'a']++;
			}

			for(int i = 0; i< 26; i++)
			{
				if (countOfLetters[i] % 2 != 0)
					countOfOdd++;
				if (countOfOdd > 1)
					return false;
			}
			return true;
		}

		/// <summary>
		/// O(n) optimized
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public bool IsPermutationPallindromeOptimized(string str)
		{
			int[] countOfLetter = new int[26];
			int countOfOdd = 0;
			for(int i = 0; i<str.Length; i++)
			{
				countOfLetter[str[i] - 'a']++;
				if(countOfLetter[str[i] - 'a'] % 2 != 0)
				{
					countOfOdd++;
				}
				else
				{
					countOfOdd--;
				}
			}
			if (countOfOdd > 1)
				return false;
			return true;
		}

		/// <summary>
		/// O(n) with constant space complexity
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public bool IsPermutationPallindromeBitManipulation(string str)
		{
			int a = 0;

			for (int i = 0; i < str.Length; i++)
			{
				int val = str[i] - 'a';
				int mask = 1 << val;
				if ((a & mask) == 0)
				{
					a |= mask;
				}
				else
				{
					a &= ~mask;
				}
			}

			if (a == 0)
				return true;

			if((a & (a-1)) == 0)
			{
				return true;
			}
			return false;
		}
	}
}
