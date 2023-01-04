using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class BackgroundUrls
    {
        [JsonPropertyName("400x300")]
        public string? the400x300 { get; set; }

        [JsonPropertyName("500x500")]
        public string? the500x500 { get; set; }
        [JsonPropertyName("1200x900")]
        public string? the1200x900 { get; set; }
    }
}
