using REST_Tests.StepsDefinition.POST_Query;
using REST_Tests.API.Entities;
using TechTalk.SpecFlow;
using Xunit;

namespace REST_Tests.StepsDefinition
{
	[Binding]
	public class CommonSteps
	{
		private static Superhero addSuperhero;

		public static Superhero AddSuperheroes(string name, string date, string city, string skill, string gender, string phone)
		{
			var superheroes = new AddNewSuperheroes();
			return addSuperhero = superheroes.AddNewSuperhero(name, date, city, skill, gender, phone);
		}

		[Given(@"Superhero with name = '(.+)', birthDate = '(.+)', city = '(.+)', mainSkill = '(.+)', gender = '(.+)', phone = '(.+)'")]
		public void GivenData(string name, string date, string city, string skill, string gender, string phone)
		{
		}

		[Then(@"Execute query and in response parameter name = '(.+)', birthDate = '(.+)', city = '(.+)', mainSkill = '(.+)', gender = '(.+)', phone = '(.+)'")]
		public void AddNew(string name, string date, string city, string skill, string gender, string phone)
		{
			var superhero = AddSuperheroes(name, date, city, skill, gender, phone);

			string sh_name = superhero.fullName;

			string sh_date = superhero.birthDate;

			string sh_city = superhero.city;

			string sh_skill = superhero.mainSkill;

			string sh_gender = superhero.gender;

			string sh_phone = superhero.phone;

			Assert.Equal(name, sh_name);
			Assert.Equal(date, sh_date);
			Assert.Equal(city, sh_city);
			Assert.Equal(skill, sh_skill);
			Assert.Equal(gender, sh_gender);
			Assert.Equal(phone, sh_phone);
		}
	}
}