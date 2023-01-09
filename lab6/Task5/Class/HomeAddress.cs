using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Class
{
	class HomeAddress
	{
		private  int _apartment;
		private  string _homeNumber;
		private  int _streetID;
		private  int _id;

		public int Apartment
		{
			get
			{
				return _apartment;
			}
			set
			{
				_apartment = value;
			}
		}

		public string HomeNumber
		{
			get
			{
				return _homeNumber;
			}
			set
			{
				_homeNumber = value;
			}
		}

		public int StreetID
		{
			get
			{
				return _streetID;
			}

			set
			{
				_streetID = value;
			}
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

		public HomeAddress(int id, int streetID, string homeNumber, int apartment)
		{
			ID = id;
			StreetID = streetID;
			HomeNumber = homeNumber;
			Apartment = apartment;
		}
	}
}
