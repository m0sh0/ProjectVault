using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GettingResponseFromAPI.Classes.Models
{
    public class Country
    {
        [JsonPropertyName("country")]
        public string Name { get; set; }
    }
}