using System;
using Newtonsoft.Json;
using RestSharp;

namespace REST_Tests.API
{
	public class BaseApiClient
	{
		protected BaseApiClient(string controllerUrl)
		{
			string baseUrl = "https://superhero.qa-test.csssr.com/superheroes";
			Client = new RestClient(baseUrl);
		}

		protected RestClient Client { get; }

		public string Execute (IRestRequest request)
		{
			IRestResponse response = Client.Execute(request);
			ThrownIfNotSuccessful(response);
			return response.Content;
		}

		public Tresult Execute<Tresult>(IRestRequest request)
		{
			string content = Execute(request);

			return content != null
				? JsonConvert.DeserializeObject<Tresult>(content)
				: default;
		}

		private static void ThrownIfNotSuccessful(IRestResponse response)
		{
			if(!response.IsSuccessful)
			{
				throw new InvalidOperationException($"{response.StatusCode}. {response.Content}");
			}
		}
	}
}
