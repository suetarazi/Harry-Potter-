using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HarryPotter.Models
{

    //This model is using API: https://www.potterapi.com/v1/spells?key=$2a$10$mXNDWGOV/EgyBtX7QKYvi.zke0orbvTth6rqJMnLJPjvsiNWWu5S.
    public class Spells
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("spell")]
        public string SpellName { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("__v")]
        public string V { get; set; }


    }
}
