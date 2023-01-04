using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    public class ImageUrls
    {
        [JsonPropertyName("250x250")]
        public string? The250x250 { get; set; }
        [JsonPropertyName("500x500")]
        public string? The500x500 { get; set; }
        [JsonPropertyName("1200x900")]
        public string? The1200x900 { get; set; }
    }
}
