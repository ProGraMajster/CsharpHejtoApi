using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using CsharpHejtoApi.Models;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class PostItem
    {
        public List<CommentItem>? comments { get; set; }
        public string? type { get; set; }
        public string? title { get; set; }
        public string? slug { get; set; }
        public string? content { get; set; }
        public string? content_plain { get; set; }
        public string? excerpt { get; set; }
        public string? status { get; set; }
        public bool? hot { get; set; }
        public List<PostImage>? images { get; set; }
        public List<Tag>? tags { get; set; }
        public ItemAuthor? author { get; set; }
        public ItemInteractions? interactions { get; set; }
        public Community? community { get; set; }
        public bool? nsfw { get; set; }
        public bool? controversial { get; set; }
        public bool? commentsEnabled { get; set; }
        public bool? favoritesEnabled { get; set; }
        public bool? likesEnabled { get; set; }
        public bool? reportsEnabled { get; set; }
        public bool? sharesEnabled { get; set; }
        public DateTime? createdAt { get; set; }
        public string? discr { get; set; }
        public ItemLinks? links { get; set; }
        public CommunityTopic? communityTopic { get; set; }
        public string? link { get; set; }
        public DateTime? updatedAt { get; set; }
        public int? numLikes { get; set; }
        public bool? isLiked { get; set; }
    }
}
