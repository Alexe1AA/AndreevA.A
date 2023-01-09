using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Task1.Exceptions;
namespace Task1
{	
	class User
	{
		private string _name;
		private string _surname;
		private string _mail;		
		private string _login;

		private DateTime _birthdate = new DateTime();
		private DateTime _registrdate = new DateTime();

		private const int MaxlenName = 50;
		private const int MaxlenSurname = 200;
		private const int MaxlenLogin = 20;

		private const string PatternName = @"^([А-ЯЁ][а-яё]*)$|^([A-Z][a-z]*)$";
		private const string PatternSurname = @"^(([А-ЯЁ]([a-яё]*-[А-ЯЁ])*[а-яё]*)$|^([A-Z]([a-z]*-[A-Z])*[a-z]*))$";
		private const string PatternLogin = @"^[a-zA-Z]+$";
		private const string PatternMail = @"^[0-9a-z]([\w.-]*[0-9a-z])?@([0-9a-z]([\w-]*[0-9a-z])?\.)+[a-z]{2,6}$";		

		public User(string name, string surname, string login, DateTime registrdate)
		{
			Name = name;
			Surname = surname;
			Login = login;
			Registrdate = registrdate;
		}

		public string Name
		{
			get
			{
				return _name;
			}
			
			set
			{				
				if(String.IsNullOrEmpty(value))
				{
					throw new UserException("Пустая строка");
				}
				else if(value.Length > MaxlenName)
				{
					throw new UserException("Недопустимая длина");
				}
				else if(Regex.IsMatch(value, PatternName))
				{
					_name = value;
				}
				else
				{
					throw new UserException("Недопустимый формат");
				}
		
			}
		}

		public string Surname
		{
			get
			{
				return _surname;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new UserException("Пустая строка");
				}
				else if (value.Length > MaxlenSurname)
				{
					throw new UserException("Недопустимая длина");
				}
				else if (Regex.IsMatch(value, PatternSurname))
				{
					_surname = value;
				}
				else
				{
					throw new UserException("Недопустимый формат");
				}

			}
		}

		public string Login
		{
			get
			{
				return _login;
			}

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new UserException("Пустая строка");
				}
				else if (value.Length > MaxlenLogin)
				{
					throw new UserException("Недопустимая длина");
				}
				else if (Regex.IsMatch(value, PatternLogin))
				{
					_login = value;
				}
				else
				{
					throw new UserException("Недопустимый формат");
				}

			}
		}

		public string Mail
		{
			get
			{
				return _mail;
			}

			set
			{								
				if (Regex.IsMatch(value, PatternMail))
				{
					_mail = value;
				}
				else
				{
					throw new UserException("Недопустимый формат");
				}
			}
		}

		public DateTime Birthdate
		{
			get
			{
				return _birthdate;
			}

			set
			{
				if (value > Registrdate)
				{
					throw new UserException("Регистрация не может быть раньше дня рождения");
				}
				_birthdate = value;
			}
		}

		public DateTime Registrdate
		{
			get
			{
				return _registrdate;
			}

			set
			{
				if(value == null)
				{
					throw new UserException("Обязательное поле должно быть заполнено");
				}
				if(Birthdate != null)
				{
					if(Birthdate > Registrdate)
					{
						throw new UserException("Регистрация не может быть раньше дня рождения");
					}
				}
				_registrdate = value;
			}
		}

		public override string ToString() => $"{Login} {Name} {Surname} {Mail} " +
			$"{Birthdate.ToString("dd-MM-yyyy")}";

		public void SetFromLine(string str)
		{
			string[] input = str.Split(new char[] {' '});
			if(input.Length!=5)
			{
				throw new UserException("Не все аргументы представлены в строке");
			}

			Login = input[0];
			Name = input[1];
			Surname = input[2];
			Mail = input[3];
			Birthdate = DateTime.Parse(input[4]);			
		}

	}
}
