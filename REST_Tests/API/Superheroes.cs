using RestSharp;
using REST_Tests.API.Entities;

namespace REST_Tests.API
{
	public class Superheroes : BaseApiClient
	{
		public Superheroes() : base("")
		{
		}

		public Superhero AddSuperhero(Superhero superhero)
		{
			var request = new RestRequest("", Method.POST);
			request.AddHeader("Content-Type", "application/json");
			request.AddJsonBody(superhero);

			return Execute<Superhero>(request);
		}
	}
}