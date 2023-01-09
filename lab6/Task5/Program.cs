using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Class;
namespace Task5
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Country> countries = Initialization.FillCountryList();
			List<City> cities = Initialization.FillCityList();
			List<Street> streets = Initialization.FillStreetList();
			List<HomeAddress> homeAddresses = Initialization.FillHomeAddressList();
			List<People> people = Initialization.FillPeopleList();
			
			List<string> olderthan18 = Request.GetByAgeListPeople(people, 18);
			List<string> saratov = Request.GetByСityListPeople(people, homeAddresses, streets, cities, "Саратов");
			List<string> namecity = Request.GetCityWithStreet(streets, cities, "Cадовая");
			List<string> residents = Request.GetAllPeoples(people, homeAddresses, streets, cities, countries);
			double averageAge = Request.GetAverageAgeOfHome(people, homeAddresses, streets, cities, countries);
			Console.WriteLine("Фамилии и имена всех жителей старше 18 лет:");
			olderthan18.WriteLine();
			Console.WriteLine("Фамилии и Имена всех жителей города Саратов:");
			saratov.WriteLine();
			Console.WriteLine("Названия городов, у которых есть улица, в названии которой встречается «Садовая»:");
			namecity.WriteLine();
			Console.WriteLine("Фамилии, имена и полный адрес всех жителей, занесенных в базу данных:");
			residents.WriteLine();
			Console.WriteLine("средний возраст жителей дома №17, по адресу Россия, Саратов, ул. 2-я Садовая:");
			Console.WriteLine("averageAge " + averageAge);

			Console.ReadLine();

		}
	}
}
