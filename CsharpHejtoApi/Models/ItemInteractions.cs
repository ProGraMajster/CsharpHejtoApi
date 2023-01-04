using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class ItemInteractions
    {
        [JsonPropertyName("is_liked")]
        public bool? IsLiked { get; set; }
        //[JsonPropertyName("is_reported")]
        public bool? IsCommented { get; set; }
        public bool? IsFavorited { get; set; }
    }
}
