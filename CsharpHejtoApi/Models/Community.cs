using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Community
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        [JsonPropertyName("avatar")]
        public CommunityAvatar? Avatar { get; set; }
        [JsonPropertyName("background")]
        public CommunityBackground? Background { get; set; }
    }
}
