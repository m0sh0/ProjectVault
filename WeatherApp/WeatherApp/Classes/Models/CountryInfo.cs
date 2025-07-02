using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Classes.Models
{
    public class CountryInfo
    {
        [JsonPropertyName("country")] 
        public string Name { get; set; }
    }
}
