using HarryPotter.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HarryPotter.Models.Services
{
    public class SortingHatService : ISortingHat
    {
        private static readonly HttpClient client = new HttpClient();
        private string baseUrl = @"https://www.potterapi.com/v1/";


        /// <summary>
        /// Method for GET route to get sorting hat outcome
        /// </summary>
        /// <returns>sorting hat house assignment</returns>
        public async Task<string> SortingHatOutcome2()
        {
            string route = "sortingHat";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}/{route}");

            string houseAssignment = JsonConvert.DeserializeObject<string>(response);
            //            response = JsonSerializer.Deserialize<response>(jsonString);

            return houseAssignment;
        }

        public async Task<SortingHat> SortingHatOutcome()
        {
            string route = "sortingHat";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}/{route}");

            SortingHat houseAssignment = JsonConvert.DeserializeObject<SortingHat>(response);
            //            response = JsonSerializer.Deserialize<response>(jsonString);

            return houseAssignment;

        }

    }
}
