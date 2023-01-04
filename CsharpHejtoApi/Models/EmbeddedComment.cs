using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class EmbeddedComment
    {
        [JsonPropertyName("items")]
        public List<CommentItem>? items;
    }
}
