using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Classes.Models
{
    public class WindInfo
    {
        [JsonPropertyName("speed")] 
        public float WindSpeed { get; set; }
    }
}
