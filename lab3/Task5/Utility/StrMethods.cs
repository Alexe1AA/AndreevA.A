using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Task5.Utility
{
	class StrMethods
	{
		public static MatchCollection DateCollection(string str)
		{
			string patterndate = @"(?<day>[0][1-9]|[12][0-9]|[3][01])-(?<month>[0][1-9]|[1][0-2])-(?<year>[0-9]{4})";
			MatchCollection dates = Regex.Matches(str, patterndate);		
			
			return dates;
		}
		public static void PrintDates(MatchCollection matchCollection)
		{
			foreach (Match match in matchCollection)
			{
				Console.WriteLine($"{ match.Value}, где день = {match.Groups["day"]}, " +
					$"месяц = {match.Groups["month"]}, год = {match.Groups["year"]}");
			}
		}
	}
}
