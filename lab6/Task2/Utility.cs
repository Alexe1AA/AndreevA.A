using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	public static class  Utility
	{
		public static Dictionary<string, int> FrequencyOfWords(string str)
		{
			str = str.ToLower();
			string[] words = str.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
			var dictionary = new Dictionary<string, int>();
			for(int i = 0; i < words.Length; i++)
			{
				if(dictionary.ContainsKey(words[i]))
				{
					dictionary[words[i]]++;
				}
				else
				{
					dictionary.Add(words[i], 1);
				}
			}
			return dictionary;
		}
	}
}
