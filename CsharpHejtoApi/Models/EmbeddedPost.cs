using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class EmbeddedPost
    {
        [JsonPropertyName("items")]
        public List<PostItem>? Items { get; set; }
    }
}
    