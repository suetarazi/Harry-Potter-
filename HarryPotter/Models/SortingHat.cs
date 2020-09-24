using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HarryPotter.Models
{
    public class SortingHat
    {
        [JsonProperty(" ")]
        public string HouseName { get; set; }
    }
}
