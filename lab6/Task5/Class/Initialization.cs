using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Class;

namespace Task5.Class
{
	class Initialization
	{
		public static List<Country> FillCountryList()
		{
			List<Country> countries = new List<Country>()
			{
				new Country(1,"Нидерланды"),
				new Country(2,"Италия"),
				new Country(3,"Россия"),
				new Country(4,"Китай"),				
				new Country(5,"Мексика")				
		};
			return countries;			
		}

		public static List<City> FillCityList()
		{
			List<City> cities = new List<City>()
			{
				new City(1,1,"Амстердам"),				
				new City(2,1,"Харлем"),
				new City(3,2,"Рим"),
				new City(4,3,"Москва"),
				new City(5,3,"Саратов"),
				new City(6,4,"Гонконг"),
				new City(7,5,"Мехико"),
			};

			return cities;
		}

		public static List<Street> FillStreetList()
		{
			List<Street> streets = new List<Street>()
			{
				new Street(1, 1, "Дамрак"),
				new Street(2, 2, "Grote Houtstraat"),
				new Street(3, 3, "Корсо"),
				new Street(4, 4, "Московская"),
				new Street(5, 4, "Моховая"),
				new Street(6, 5, "2-я Cадовая"),
				new Street(7, 5, "Чапаева"),
				new Street(8, 6, "Олдрич-стрит"),
				new Street(9, 7, "Генуя")
			};

			return streets;
		}

		public static List<HomeAddress> FillHomeAddressList()
		{
			List<HomeAddress> homeAddresses = new List<HomeAddress>()
			{
				new HomeAddress(1, 1, "5", 1),
				new HomeAddress(2, 2, "17", 2),
				new HomeAddress(3, 3, "25", 55),
				new HomeAddress(4, 4, "45", 8),
				new HomeAddress(5, 4, "71", 7),
				new HomeAddress(6, 6, "17", 12),
				new HomeAddress(7, 6, "18", 77),
				new HomeAddress(8, 7, "90", 98),
				new HomeAddress(9, 8, "11", 9),
				new HomeAddress(10, 9, "12", 19)
			};

			return homeAddresses;
		}

		public static List<People> FillPeopleList()
		{
			List<People> people = new List<People>()
			{
				new People(1, "Арсений", "Соловьев", new DateTime(1999, 1, 1), 2, 2),
				new People(2, "Василиса", "Фролова", new DateTime(2002, 2, 2), 3, 4),
				new People(3, "Станислав", "Медведев", new DateTime(1960, 3, 3), 5, null),
				new People(4, "Ярослав", "Сорокин", new DateTime(2022, 1, 5), 7, 1),
				new People(5, "Александр", "Вешняков", new DateTime(2005, 3, 7), 6, null),
				new People(6, "Демид", "Кудряшов", new DateTime(1996, 4, 4), 9, null),
				new People(7, "Савелий", "Дементьев", new DateTime(1991, 2, 1), 5, 7),
				new People(8, "Марк", "Тимофеев", new DateTime(1978, 3, 5), 8, 2),
				new People(9, "Иван", "Сухарев", new DateTime(1985, 3, 1), 3, 1),
				new People(10, "Роман", "Демьянов", new DateTime(2000, 3, 7), 8, 9),
				new People(11, "Виталий", "Соловьев", new DateTime(1979, 3, 5), 3, 6),
				new People(12, "Дамир", "Ермаков", new DateTime(1980, 3, 2), 10, 3),
			};

			return people;
		}
	}
}
