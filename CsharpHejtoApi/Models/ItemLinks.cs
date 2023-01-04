using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class ItemLinks
    {
        [JsonPropertyName("self")]
        public First? Self { get; set; }
        [JsonPropertyName("comments")]
        public First? Comments { get; set; }
        [JsonPropertyName("likes")]
        public First? Likes { get; set; }
        [JsonPropertyName("favorites")]
        public First? Favorites { get; set; }
    }
}
