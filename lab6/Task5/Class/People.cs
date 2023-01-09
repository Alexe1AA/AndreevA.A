using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Class
{
	class People
	{
		private  int _id;
		private  string _name;
		private  string _surname;
		private  DateTime _birthDay;
		private  int _registrationID;
		private  int? _liveID;

		public People(int id, string name, string surname, DateTime birthDay, int registrationID, int? liveID)
		{
			Name = name;
			Surname = surname;
			BirthDay = birthDay;
			ID = id;
			RegistrationID = registrationID;
			LiveID = liveID;
		}

		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
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
				_surname = value;
			}
		}
		public DateTime BirthDay
		{
			get
			{
				return _birthDay;
			}
			set
			{
				_birthDay = value;
			}
		}
		public int RegistrationID
		{
			get
			{
				return _registrationID;
			}
			set
			{
				_registrationID = value;
			}
		}
		public int? LiveID
		{
			get
			{
				return _liveID;
			}
			set
			{
				_liveID = value;
			}
		}
	}
}

