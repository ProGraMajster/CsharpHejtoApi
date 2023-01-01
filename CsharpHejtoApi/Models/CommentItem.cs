using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HejtoApi.Models
{
    [Serializable]
    public class CommentItem
    {
        public string? postSlug;
        public string? content;
        public string? contentPlain;
        public List<ContentLink>? contentLinks;
        public Author? author;
        public List<dynamic>? images;
        public Interactions? interactions;
        public DateTime? createdAt;
        public String? uuid;
        public ItemLinks? links;
        public int? numLikes;
    }
}
