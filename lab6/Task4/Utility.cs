using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4
{
	public static class Utility
	{
		public static bool IsPositiveNumber(this string str)
		{
			string pattern = @"^[0-9]+$";
			return Regex.IsMatch(str, pattern);
		}
	}
}
