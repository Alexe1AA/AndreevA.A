using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Class
{
	class Country
	{
		private int _id;
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

		public Country(int id, string title)
		{
			ID = id;			
			Title = title;
		}
	}
}
