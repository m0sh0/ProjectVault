using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static GettingResponseFromAPI.GettingData;

namespace GettingResponseFromAPI.Classes.Models
{
    public class Response
    {
        [JsonPropertyName("main")]
        public MainInfo? Main { get; set; }

        [JsonPropertyName("wind")]
        public WindInfo? Wind { get; set; }

        [JsonPropertyName("sys")]
        public Country? CountryName { get; set; }
    }
}