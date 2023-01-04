using CsharpHejtoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class CommentItem
    {
        public string? postSlug { get; set; }
        public string? content { get; set; }
        public string? contentPlain { get; set; }
        public List<ContentLink>? contentLinks { get; set; }
        public Author? author { get; set; }
        public List<dynamic>? images { get; set; }
        public Interactions? interactions { get; set; }
        public DateTime? createdAt { get; set; }
        public String? uuid { get; set; }
        public ItemLinks? links { get; set; }
        public int? numLikes { get; set; }
    }
}
