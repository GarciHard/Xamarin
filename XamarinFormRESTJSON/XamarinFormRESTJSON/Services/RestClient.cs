using System;
using XamarinFormRESTJSON.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace XamarinFormRESTJSON.Services
{
	public class RestClient
	{
		public string Serialize()
		{
			var countries = new[] {
				new Country { Name = "México" },
				new Country { Name = "Argentina" }
			};

			string json = JsonConvert.SerializeObject(countries);
			return json;
		}

		public void Deserialize()
		{
			var json = Serialize();
			var parsedJson = JsonConvert.DeserializeObject<IEnumerable<Country>>(json);

			foreach (Country item in parsedJson)
			{
				Debug.WriteLine(item.Name);
			}
		}

		public async Task<IEnumerable<Country>> GetCountries()
		{
			return await GetAsJson();
		}

		protected string BaseUrl { get; set; } = "http://restcountries.eu/rest/v1";

		public async Task<IEnumerable<Country>> GetAsJson()
		{
			var result = Enumerable.Empty<Country>();
			using (var httpClient = new HttpClient())
			{
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(
					new MediaTypeWithQualityHeaderValue("application/json")
				);

				var response = await httpClient.GetAsync(BaseUrl).ConfigureAwait(false);

				if (response.IsSuccessStatusCode)
				{
					var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

					if (!string.IsNullOrWhiteSpace(json))
					{
						result = await Task.Run(() =>
						{
							return JsonConvert.DeserializeObject<IEnumerable<Country>>(json);
						}).ConfigureAwait(false);
					}
				}
			}
			return result;
		}
	}
}
