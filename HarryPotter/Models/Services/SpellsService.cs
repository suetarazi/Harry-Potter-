using HarryPotter.Models.Interfaces;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HarryPotter.Models.Services
{
    public class SpellsService : ISpells
    {

        private static readonly HttpClient client = new HttpClient();
        private string baseUrl = @"https://www.potterapi.com/v1/spells?key=$2a$10$mXNDWGOV/EgyBtX7QKYvi.zke0orbvTth6rqJMnLJPjvsiNWWu5S.";

        public async Task<List<Spells>> GetAllSpells()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}");

            List<Spells> results = JsonConvert.DeserializeObject<List<Spells>>(response);

            return results;
        }

        
    }
}
