using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Tag
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("_links")]
        public TagLinks? Links { get; set; }
    }
}
