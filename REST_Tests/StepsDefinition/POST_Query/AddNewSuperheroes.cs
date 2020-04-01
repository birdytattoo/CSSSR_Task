using REST_Tests.API;
using REST_Tests.API.Entities;

namespace REST_Tests.StepsDefinition.POST_Query
{
	public class AddNewSuperheroes
	{
		public Superhero AddNewSuperhero(string name, string date, string city, string skill, string gender, string phone)
		{
			var superhero = new Superhero
			{
				fullName = name,
				birthDate = date,
				city = city,
				mainSkill = skill,
				gender = gender,
				phone = phone
			};

			var request = new Superheroes();

			var newSuperhero = request.AddSuperhero(superhero);

			return newSuperhero;
		}
	}
}
