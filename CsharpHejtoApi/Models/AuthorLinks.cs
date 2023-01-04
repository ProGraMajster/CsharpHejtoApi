using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class AuthorLinks
    {
        [JsonPropertyName("self")]
        public First? Self { get; set; }
        [JsonPropertyName("follows")]
        public First? Follows { get; set; }
    }
}
