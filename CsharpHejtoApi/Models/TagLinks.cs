using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    public class TagLinks
    {
        [JsonPropertyName("self")]
        public First? Self { get; set; }
        [JsonPropertyName("follows")]
        public First? Follows { get; set; }
        [JsonPropertyName("blocks")]
        public First? Blocks { get; set; }
    }
}
