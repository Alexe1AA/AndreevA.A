using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Utility
{
	class StrMethods
	{
		public static double AverageWordLen(string str)
		{
			int sum = 0;
			string[] word = str.Split(new char[] { ' ', '!', '?', '.', ',', ':', ';', '"', '(', ')', '{', '}' }, 
				StringSplitOptions.RemoveEmptyEntries);
			
			for(int i = 0; i < word.Length; i++)
			{				
				sum += word[i].Length;
			}
			if(word.Length > 0)
			{
				return sum / word.Length;
			}
			else
			{
				return 0;
			}
		}
	}
}
