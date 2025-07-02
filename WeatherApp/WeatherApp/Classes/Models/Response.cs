using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Classes.Models
{
    public class Response
    {
        [JsonPropertyName("main")]
        public WeatherInfo? Weather { get; set; }

        [JsonPropertyName("wind")]
        public WindInfo? Wind { get; set; }

        [JsonPropertyName("sys")]
        public CountryInfo? Country { get; set; }

    }
}
