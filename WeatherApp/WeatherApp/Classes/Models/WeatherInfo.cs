using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Classes.Models
{
    public class WeatherInfo
    {
        [JsonPropertyName("temp")] 
        public float CurrentTemp { get; set; }

        [JsonPropertyName("feels_like")]
        public float FeelsLikeTemp { get; set; }

        [JsonPropertyName("temp_min")]
        public float MinTemp { get; set; }

        [JsonPropertyName("temp_max")]
        public float MaxTemp { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("sea_level")]
        public int SeaLevel { get; set; }
    }
}
