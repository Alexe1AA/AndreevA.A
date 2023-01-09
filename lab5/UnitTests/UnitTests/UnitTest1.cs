using System;
using Task11;
using Task1.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class UserTest
	{
		private User _userTest; 

		[TestInitialize]
		public void Initialize()
		{
			DateTime date = new DateTime(2021, 10, 25);
			_userTest = new User("Федор", "Федоров", "Login", date);
		}

		[DataTestMethod]
		[DataRow("a@mail.ru")]
		[DataRow("alex@a.ru")]
		[DataRow("alex@aa.ss.dd.ff.gg.hh.jj.kk.ru")]
		[DataRow("alex2001@mail.com")]
		[DataRow(null)]
		public void MailTest(string mail)
		{
			_userTest.Mail = mail;
			Assert.AreEqual(_userTest.Mail, mail);
		}

		[DataTestMethod]
		[DataRow("aa@.ru")]
		[DataRow("aa@..ru")]
		[DataRow("")]
		[DataRow("mail.ry")]
		[DataRow("“_aa@mail.ru")]		
		[ExpectedException(typeof(UserException), "Исключение не было выдано")]
		public void MailTestExceptions(string mail)
		{
			_userTest.Mail = mail;
		}

		[DataTestMethod]
		[DataRow("Name")]
		[DataRow("Имя")]
		[DataRow("Сёма")]		
		public void NameTest(string name)
		{
			_userTest.Name = name;
			Assert.AreEqual(name, _userTest.Name);
		}

		[DataTestMethod]
		[DataRow("1212qwe")]
		[DataRow("аоек")]
		[DataRow("Deйуук")]
		[DataRow("Nameфффы")]
		[DataRow("Федорrr")]
		[DataRow(null)]
		[ExpectedException(typeof(UserException), "Исключение не было выдано")]
		public void NameTestExceptions(string name)
		{
			_userTest.Name = name;			
		}

		[DataTestMethod]
		[DataRow("Sur-Name")]
		[DataRow("Surname")]
		[DataRow("Федоров")]
		public void SurnameTest(string surname)
		{
			_userTest.Surname = surname;
			Assert.AreEqual(surname, _userTest.Surname);
		}

		[DataTestMethod]
		[DataRow(null)]
		[DataRow("Sur-name")]
		[DataRow("Sur--Name")]
		[DataRow("Фе1доров")]
		[DataRow("Фудorоv")]
		[ExpectedException(typeof(UserException), "Исключение не было выдано")]
		public void SurnameTestExceptions(string surname)
		{
			_userTest.Surname = surname;			
		}

		[DataTestMethod]
		[DataRow("Login")]
		[DataRow("qweewr")]
		[DataRow("qweeWFFFa")]
		public void LoginTest(string login)
		{
			_userTest.Login = login;
			Assert.AreEqual(login, _userTest.Login);
		}

		[DataTestMethod]
		[DataRow("Login123")]
		[DataRow("qwуккаeewr")]
		[DataRow("qweeы__WFFFa")]
		[DataRow(null)]
		[DataRow("Log-in")]
		[ExpectedException(typeof(UserException), "Исключение не было выдано")]
		public void LoginTestExceptions(string login)
		{
			_userTest.Login = login;			
		}
		[TestMethod]			
		public void RegdateTest()
		{
			DateTime date = new DateTime(2023, 1, 06);
			_userTest.Registrdate = date;
			Assert.AreEqual(date, _userTest.Registrdate);
		}
		[TestMethod]
		public void BirthdateTest()
		{
			DateTime date = new DateTime(2003, 10, 06);
			_userTest.Birthdate = date;
			Assert.AreEqual(date, _userTest.Birthdate);
		}

		[TestMethod]
		[ExpectedException(typeof(UserException), "Исключение не было выдано")]
		public void RegdateTestException()
		{
			DateTime date1 = new DateTime(2023, 1, 06);
			DateTime date2 = new DateTime(2021, 1, 06);
			_userTest.Birthdate = date1;
			_userTest.Registrdate = date2;
		}

		[TestMethod]
		public void ToStringTest()
		{			
			DateTime date = new DateTime(2003, 10, 21);			
			_userTest.Mail = "alexei2003@inbox.ru";
			_userTest.Birthdate = date;
			string s = "Login Федор Федоров alexei2003@inbox.ru 21-10-2003";
			Assert.AreEqual(s, _userTest.ToString());
		}

		[TestMethod]
		public void SetFromLineTest()
		{			
			string s = "Login Федор Федоров alexei2003@inbox.ru 21-10-2003";
			_userTest.SetFromLine(s);
			Assert.AreEqual("Login", _userTest.Login);
			Assert.AreEqual("Федор", _userTest.Name);
			Assert.AreEqual("Федоров", _userTest.Surname);
			Assert.AreEqual("alexei2003@inbox.ru", _userTest.Mail);
			Assert.AreEqual("21-10-2003", _userTest.Birthdate.ToString("dd-MM-yyyy"));
		}

		[TestMethod]
		[ExpectedException(typeof(UserException), "Исключение не было выдано")]
		public void SetFromLineTestException()
		{
			string s = "Login Федоров alexei2003@inbox.ru 21-10-2003";
			_userTest.SetFromLine(s);			
		}

	}
}
