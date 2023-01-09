using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Class
{
	class Street
	{
		private int _id;
		private int _cityID;
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
		public int CityID
		{
			get
			{
				return _cityID;
			}

			set
			{
				_cityID = value;
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

		public Street(int id, int cityID, string title)
		{
			ID = id;
			CityID = cityID;
			Title = title;
		}
	}
}
