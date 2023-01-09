using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task2;
using Task2.Exceptions;
namespace Task2
{

	class DynamicArray<T> : IEnumerable<T>, IDisposable, ICollection
	{
		private T[] _arr;
		private int _len;

		public delegate void CapacityEventHandler(object obj, CapacityEventArgs arg);
		public event CapacityEventHandler NotifyChanged;
		public bool _disposed = false;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<T> GetEnumerator()
		{
			return new DynamicArrayEnumerator<T>(_arr, _len);
		}

		public void CopyTo(Array array, int index)
		{
			for(int i = 0; i< Length; i++)
			{
				array.SetValue(_arr[i], i);  
			}
		}
		public int Count => Length;
		public bool IsSynchronized => throw new NotImplementedException();
		public object SyncRoot => throw new NotImplementedException();

		public DynamicArray()
		{
			_arr = new T[8];
			_len = 0;
		}
		public DynamicArray(int size)
		{
			_arr = new T[size];
			_len = 0;
		}
		public DynamicArray(IEnumerable<T> collection)
		{
			_arr = new T[SizeCollection(collection)];
			_len = _arr.Length;
			int i = 0;
			foreach (var item in collection)
			{
				_arr[i] = item;
				i++;
			}
		}

		public int Length
		{
			get
			{
				return _len;
			}
			private set
			{
				_len = value;
			}
		}
		public int Capacity
		{
			get
			{
				return _arr.Length;
			}
		}

		public void AddRange(IEnumerable<T> collection)
		{
			int i = Length;
			int newSize = SizeCollection(collection) + i;
			Length = newSize;

			Resize(newSize);
			foreach (var item in collection)
			{
				_arr[i] = item;
				i++;
			}

		}
		public void Add(T a)
		{
			Resize(Capacity * 2);
			_arr[Length] = a;
			Length++;
		}
		private void Resize(int newSize)
		{
			if (Length >= Capacity)
			{
				if (NotifyChanged != null)
				{
					NotifyChanged(this, new CapacityEventArgs(Capacity, newSize));
				}
				Array.Resize(ref _arr, newSize);
			}
		}
		private int SizeCollection(IEnumerable<T> collection)
		{
			int size = 0;
			foreach (var item in collection)
			{
				size++;
			}
			return size;
		}
		public void Remove(T a, Func<T, T, bool> predicate = null)
		{
			if (predicate == null)
			{
				for (int i = 0; i < _len; i++)
				{
					if (_arr[i].Equals(a))
					{
						ArrayShift(i);
						_arr[Length - 1] = default(T);
						Length--;
					}
				}
			}
			else
			{
				for (int i = 0; i < _len; i++)
				{
					if (predicate(a, _arr[i]))
					{
						ArrayShift(i);
						_arr[Length - 1] = default(T);
						Length--;
					}
				}
			}
		}
		public bool Insert(T item, int i)
		{
			CheckPos(i);
			Resize(Length + 1);
			for (int j = Length - 1; j + 1 != i; j--)
			{
				_arr[j + 1] = _arr[j];
			}
			_arr[i] = item;
			Length++;
			return true;
		}
		public T this[int i]
		{
			get
			{
				CheckPos(i);
				return _arr[i];
			}
			set
			{
				CheckPos(i);
				_arr[i] = value;
			}
		}
		private void CheckPos(int i)
		{
			if (i < 0 || i >= Length)
			{
				throw new DynamicArrayException("Выход за границы");
			}
		}
		private void ArrayShift(int i)
		{
			CheckPos(i);
			for (int j = i; j < Length - 1; j++)
			{
				_arr[j] = _arr[j + 1];
			}

		}
		public static bool operator ==(DynamicArray<T> obj1, DynamicArray<T> obj2)
		{
			return Equals(obj1, obj2);
		}
		public static bool operator !=(DynamicArray<T> obj1, DynamicArray<T> obj2)
		{
			return !Equals(obj1, obj2);
		}


		public override bool Equals(object obj)
		{
			if (!(obj is DynamicArray<T>))
			{
				return false;
			}

			var item = obj as DynamicArray<T>;

			if (item == null)
			{
				return false;
			}
			if (Length != item.Length)
			{
				return false;
			}
			for (int i = 0; i < Length; i++)
			{
				if (!_arr[i].Equals(item._arr[i]))
				{
					return false;
				}
			}
			return true;
		}
		public override int GetHashCode()
		{
			return this.GetHashCode();
		}
		public static explicit operator T[] (DynamicArray<T> obj)
		{
			T[] arr = new T[obj.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = obj._arr[i];
			}
			return arr;
		}
		public static implicit operator DynamicArray<T>(T[] mass)
		{
			DynamicArray<T> obj = new DynamicArray<T>(mass);
			return obj;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (_disposed) return;
			if (disposing)
			{
				foreach (var item in _arr)
				{
					if (item is IDisposable)
					{
						((IDisposable)item).Dispose();
					}
					else
					{
						break;
					}
				}
			}
			Array.Clear(_arr, 0, Length);
			Length = 0;
			_disposed = true;

		}
		~DynamicArray()
		{
			Dispose(false);
		}
	}

}
