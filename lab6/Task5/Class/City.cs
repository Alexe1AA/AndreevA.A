using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Class
{
	class City
	{
		private int _id;
		private int _countryID;
		private string _title;

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
		public int CountryID
		{
			get
			{
				return _countryID;
			}

			set
			{
				_countryID = value;
			}
		}

		public string Title
		{
			get
			{
				return _title;
			}

			set
			{
				_title = value;
			}
		}

		public City(int id, int countryID, string title)
		{
			ID = id;
			CountryID = countryID;
			Title = title;
		}
	}
}
