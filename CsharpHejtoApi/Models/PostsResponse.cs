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
        public int? limit { get; set; }
        public int? pages { get; set; }
        public int? total { get; set; }
        [JsonPropertyName("_links")]
        public PostLinks? Links { get; set; }
        [JsonPropertyName("_embedded")]
        public EmbeddedPost? Embedded { get; set; }
    }
}
