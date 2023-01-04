using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Author
    {
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        [JsonPropertyName("avatar")]
        public Avatar? Avatar { get; set; }
        [JsonPropertyName("background")]
        public Background? Background { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("current_rank")]
        public string? CurrentRank { get; set; }
        [JsonPropertyName("current_color")]
        public string? CurrentColor { get; set; }
        [JsonPropertyName("verified")]
        public bool? Verified { get; set; }
        [JsonPropertyName("sponsor")]
        public bool? Sponsor { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("_links")]
        public AuthorLinks? Links { get; set; }
    }
}
