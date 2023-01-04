using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Avatar
    {
        [JsonPropertyName("urls")]
        public AvatarUrls? Urls { get; set; }
        [JsonPropertyName("uuid")]
        public string? Uuid { get; set; }
        [JsonPropertyName("alt")]
        public string? Alt { get; set; }
    }
}
