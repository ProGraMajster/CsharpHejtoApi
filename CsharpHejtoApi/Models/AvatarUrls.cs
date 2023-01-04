using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class AvatarUrls
    {
        [JsonPropertyName("100x100")]
        public string? The100X100 { get; set; }
        [JsonPropertyName("250x250")]
        public string? The250X250 { get; set; }
    }
}
