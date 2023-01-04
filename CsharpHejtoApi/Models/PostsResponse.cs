using CsharpHejtoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class PostsResponse
    {
        [JsonPropertyName("page")]
        public int? Page { get; set; }
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }
        public int? pages { get; set; }
        public int? total { get; set; }
        [JsonPropertyName("_links")]
        public PostLinks? Links { get; set; }
        [JsonPropertyName("")]
        public EmbeddedPost? Embedded { get; set; }
    }
}
