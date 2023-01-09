using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task2;

namespace Task2
{
	 class DynamicArrayEnumerator<T> :IEnumerator<T>
	{
		private T[] _arr;
		private int _position = -1;
		private int _len;
		public DynamicArrayEnumerator(T[] arr, int len)
		{
			_arr = arr;
			_len = len;
		}	
		
		public T Current
		{
			get
			{
				return GetCurrent();
			}
		}

		object IEnumerator.Current
		{
			get
			{
				return GetCurrent();
			}
		}
		private T GetCurrent()
		{
			if (_position == -1 || _position >= _len)
			{
				throw new ArgumentOutOfRangeException("Выход за границы");
			}
			return _arr[_position];
		}		

		public bool MoveNext()
		{
			if (_position < _len - 1)
			{
				_position++;
				return true;
			}
			else
			{
				return false;
			}
				
		}
		public void Reset()
		{
			_position = -1;
		}
		public void Dispose()
		{
			return;
		}
	}
}
