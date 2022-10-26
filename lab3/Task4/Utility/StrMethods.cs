using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Task4.Utility
{
	class StrMethods
	{
		public static string DellTagsUseRegex(string str)
		{
			string pattern = @"<[^>]*>";
			string replacement = "_";
			str = Regex.Replace(str, pattern, replacement);
			return str;
		}

		public static string DellTags(string str)
		{			
			int index1 = str.IndexOf('<');
			int index2 = str.IndexOf('>', index1 + 1);
			while (index1 != -1 && index2 != -1)
			{				
				str = str.Replace(str.Substring(index1, index2 - index1 + 1), "_");				
				index1 = 0;
				index2 = 0;
				index1 = str.IndexOf('<');
				index2 = str.IndexOf('>', index1 + 1);
			}
			return str;
		}
			
	}
}
