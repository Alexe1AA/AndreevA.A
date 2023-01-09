using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class CapacityEventArgs : EventArgs
	{
		public int OldCapacity { get; set; }
		public int NewCapacity { get; set; }


		public CapacityEventArgs(int oldC, int newC)
		{
			OldCapacity = oldC;
			NewCapacity = newC;
		}
	}
}
