using System;
using Task2;
using Task2.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayTests
{

	[TestClass]
	public class UnitTest1
	{
		private DynamicArray<int> _arrTest;
		private int[] _mass;		

		[TestInitialize]
		public void Initialize()
		{
			_mass = new int[] {1,2,3,4,5};
			_arrTest = new DynamicArray<int>(_mass);
		}

		[TestMethod]
		public void DefaultConstructor()
		{
			DynamicArray<int> obj = new DynamicArray<int>();
			Assert.AreEqual(obj.Capacity, 8);
			Assert.AreEqual(obj.Length, 0);			
		}

		[TestMethod]
		public void ParameterConstructor()
		{
			DynamicArray<int> obj = new DynamicArray<int>(14);
			Assert.AreEqual(obj.Capacity, 14);
			Assert.AreEqual(obj.Length, 0);
		}

		[TestMethod]
		public void CollectionParameterConstructor()
		{
			DynamicArray<int> obj = new DynamicArray<int>(_mass);
			Assert.AreEqual(obj.Capacity, 5);
			Assert.AreEqual(obj.Length, 5);
			CollectionAssert.AreEqual(obj, _mass);
		}

		[TestMethod]
		public void EventTest()
		{
			_arrTest.Add(75);
			_arrTest.NotifyChanged += (sender, arg) =>
			{
				Assert.AreEqual(5, arg.OldCapacity);
				Assert.AreEqual(10, arg.NewCapacity);
			};
		}

		[TestMethod]		
		public void AddTest()
		{
			int[] test = new int[] {1, 2, 3, 4, 5, 75 };
			_arrTest.Add(75);			
			CollectionAssert.AreEqual(_arrTest, test);
			Assert.AreEqual(_arrTest.Length, 6);
			Assert.AreEqual(_arrTest.Capacity, 10);

		}

		[TestMethod]
		public void AddRangeTest()
		{
			int[] add = new int[] {6,7,8,9,10};
			int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			_arrTest.AddRange(add);
			CollectionAssert.AreEqual(_arrTest, test);
			Assert.AreEqual(_arrTest.Length, 10);
		}

		[TestMethod]
		public void RemoveTest()
		{			
			int[] test = new int[] {1, 3, 4, 5};
			_arrTest.Remove(2);
			CollectionAssert.AreEqual(_arrTest, test);
			Assert.AreEqual(_arrTest.Length, 4);
			Assert.AreEqual(_arrTest.Capacity, 5);
		}

		[TestMethod]
		public void RemoveDelegatTest()
		{
			Func<int, int, bool> predicate = (i, j) => i == j;
			int[] test = new int[] { 1, 3, 4, 5 };
			_arrTest.Remove(2,predicate);
			CollectionAssert.AreEqual(_arrTest, test);
			Assert.AreEqual(_arrTest.Length, 4);
			Assert.AreEqual(_arrTest.Capacity, 5);
		}

		[TestMethod]
		public void InsertTest()
		{
			int[] test = new int[] { 1, 2, 1024, 3, 4, 5 };
			_arrTest.Insert(1024,2);
			CollectionAssert.AreEqual(_arrTest, test);
			Assert.AreEqual(_arrTest.Length, 6);
			Assert.AreEqual(_arrTest.Capacity,6);
		}

		[DataTestMethod]
		[DataRow(50,-1)]
		[DataRow(50, 10)]
		[ExpectedException(typeof(DynamicArrayException), "Исключение не было выдано")]
		public void InsertTestException(int item, int i)
		{		
			_arrTest.Insert(item, i);			
		}

		[TestMethod]
		public void EqualityOperatorTest()
		{
			int[] test = new int[] {4, 8, 9, 3, 7, };
			DynamicArray<int> equality = new DynamicArray<int>(_mass);
			DynamicArray<int> notequality = new DynamicArray<int>(test);			
			CollectionAssert.AreEqual(_arrTest, equality);
			CollectionAssert.AreNotEqual(_arrTest, notequality);
		}

		[TestMethod]
		public void ConvertingToAnArray()
		{
			int[] test = (int[])_arrTest;
			CollectionAssert.AreEqual(_arrTest, test);
		}

		[TestMethod]
		public void ConvertingToAnDynamicArray()
		{
			int[] test = new int[] {1,2,3,4,5};
			DynamicArray<int> equality = test;
			CollectionAssert.AreEqual(_arrTest, equality);
		}

		[DataTestMethod]
		[DataRow(new int[] {5, 4, 3, 2, 1})]
		[DataRow(new int[] {4, 6, 89, 66, 1,7,8,9,60})]
		public void EqualsTest(int[] test)
		{			
			DynamicArray<int> equality = new DynamicArray<int>(_mass);
			DynamicArray<int> notequality = new DynamicArray<int>(test);
			Assert.IsTrue(_arrTest.Equals(equality));
			Assert.IsFalse(_arrTest.Equals(notequality));
		}

		[TestMethod]
		public void IndexTest()
		{
			int i = 0;
			foreach(var item in _arrTest)
			{
				Assert.AreEqual(_arrTest[i], item);
				i++;
			}
		}

		[DataTestMethod]
		[DataRow(-10)]
		[DataRow(60)]
		[DataRow(-1)]
		[DataRow(6)]
		[ExpectedException(typeof(DynamicArrayException), "Исключение не было выдано")]
		public void IndexTestEception(int i)
		{
			int element = _arrTest[i];			
		}
	}
}
