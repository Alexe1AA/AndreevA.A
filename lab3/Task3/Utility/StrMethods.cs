using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3.Utility
{
	class StrMethods
	{
		public static bool IsMail(string str)
		{
			string pattern = @"^[0-9a-z]([\w.-]*[0-9a-z])?@([0-9a-z]([\w-]*[0-9a-z])?\.)+[a-z]{2,6}$";

			return Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase);			
		}
	}
}
