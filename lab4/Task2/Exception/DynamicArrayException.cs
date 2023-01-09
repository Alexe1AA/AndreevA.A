using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Exceptions
{
	public class DynamicArrayException : Exception
	{
		public DynamicArrayException(string message)
			: base(message) { }
	}
}
