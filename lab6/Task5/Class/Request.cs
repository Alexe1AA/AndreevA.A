using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Class;
namespace Task5.Class
{
	class Request
	{
		public static List<string> GetByAgeListPeople(List<People> people, int age)
		{
			List<string> list = new List<string>();
			list = (from p in people
					where  DateTime.Today.Year - p.BirthDay.Year >= age
					select (p.Name +" "+ p.Surname)).ToList();			

			return list;
		}

		public static List<string> GetByСityListPeople(List<People> people, List<HomeAddress> homeAddresses, List<Street> streets, 
			List<City> cities, string city)
		{
			List<string> list = new List<string>();
			list = (from p in people
					join h in homeAddresses on p.LiveID equals h.ID
					join s in streets on h.StreetID equals s.ID
					join c in cities on s.CityID equals c.ID
					where c.Title == city
					select (p.Name + " " + p.Surname)).ToList();
			return list;
		}

		public static List<string> GetCityWithStreet(List<Street> streets, List<City> cities, string subname)
		{
			List<string> list = new List<string>();

			list = (from c in cities
					 join s in streets on c.ID equals s.CityID
					 where s.Title.Contains(subname)
					 select (c.Title)).ToList();
			return list;
		}

		public static List<string> GetAllPeoples(List<People> people, List<HomeAddress> homeAddresses, List<Street> streets, 
			List<City> cities, List<Country> countries)
		{
			List<string> list = new List<string>();

			list = (from p in people
					join h in homeAddresses on p.RegistrationID equals h.ID
					join s in streets on h.StreetID equals s.ID
					join c in cities on s.CityID equals c.ID
					join countrie in countries on c.CountryID equals countrie.ID
					select ($"{p.Name} {p.Surname} {countrie.Title} {c.Title} {s.Title} {h.HomeNumber} {h.Apartment}")).ToList();
			return list;
		}

		public static double GetAverageAgeOfHome(List<People> people, List<HomeAddress> homeAddresses, 
			List<Street> streets, List<City> cities, List<Country> countries)
		{
			double averageAge = (from p in people
								 join h in homeAddresses on p.RegistrationID equals h.ID
								 join s in streets on h.StreetID equals s.ID
								 join c in cities on s.CityID equals c.ID
								 join countrie in countries on c.CountryID equals countrie.ID
								 where countrie.Title == "Россия" && c.Title == "Саратов" && s.Title == "2-я Cадовая" && h.HomeNumber == "17"
								 select DateTime.Today.Year - p.BirthDay.Year).Average();
			return averageAge;
		}
	}
}
