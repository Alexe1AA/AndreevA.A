using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Utility
{
	class StrMethods
	{
		public static bool IsPalindrom(string str)
		{
			if (String.IsNullOrEmpty(str))
			{				
				return false;
			}
			
			var sb = new StringBuilder();
			for(int i = 0; i < str.Length; i++)
			{
				if(char.IsLetter(str[i]))
				{
					sb.Append(char.ToLower(str[i]));					
				}
			}
			
			string s = sb.ToString();

			if(String.IsNullOrEmpty(s))
			{
				return false;
			}

			for (int i = 0; i < 0.5*s.Length; i++)
			{				
				if (s[i] != s[s.Length-1-i])
				{
					return false;
				}
			}

			return true;
		}
	}
}
