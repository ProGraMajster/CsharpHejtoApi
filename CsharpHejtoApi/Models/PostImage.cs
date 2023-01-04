using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    public class PostImage
    {
        [JsonPropertyName("urls")]
        public ImageUrls? Urls { get; set; }
        [JsonPropertyName("uuid")]
        public string? Uuid { get; set; }
        [JsonPropertyName("position")]
        public int? Position { get; set; }
    }
}
