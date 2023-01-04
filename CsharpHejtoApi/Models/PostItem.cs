using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using CsharpHejtoApi.Models;
using System.Text.Json.Serialization;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class PostItem
    {
        [JsonPropertyName("comments")]
        public List<CommentItem>? Comments { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        [JsonPropertyName("content")]
        public string? Content { get; set; }
        [JsonPropertyName("content_plain")]
        public string? ContentPlain { get; set; }
        [JsonPropertyName("excerpt")]
        public string? Excerpt { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("hot")]
        public bool? Hot { get; set; }
        [JsonPropertyName("images")]
        public List<PostImage>? Images { get; set; }
        [JsonPropertyName("tags")]
        public List<Tag>? Tags { get; set; }
        [JsonPropertyName("author")]
        public ItemAuthor? Author { get; set; }
        [JsonPropertyName("interactions")]
        public ItemInteractions? Interactions { get; set; }
        [JsonPropertyName("community")]
        public Community? Community { get; set; }
        [JsonPropertyName("")]
        public CommunityTopic? communityTopic { get; set; }
        [JsonPropertyName("nsfw")]
        public bool? Nsfw { get; set; }
        [JsonPropertyName("controversial")]
        public bool? Controversial { get; set; }
        [JsonPropertyName("num_likes")]
        public int? NumberLikes { get; set; }
        [JsonPropertyName("num_comments")]
        public int? NumberCommented { get; set;}
        [JsonPropertyName("num_favorites")]
        public int? NumberFavorites { get; set; }
        [JsonPropertyName("is_liked")]
        public bool? IsLiked { get; set; }
        [JsonPropertyName("is_commented")]
        public bool? IsCommented { get; set;}
        [JsonPropertyName("is_favorited")]
        public bool? IsFavorited { get; set; }
        [JsonPropertyName("comments_enabled")]
        public bool? CommentsEnabled { get; set; }
        [JsonPropertyName("favorites_enabled")]
        public bool? FavoritesEnabled { get; set; }
        [JsonPropertyName("likes_enabled")]
        public bool? LikesEnabled { get; set; }
        [JsonPropertyName("reports_enabled")]
        public bool? ReportsEnabled { get; set; }
        [JsonPropertyName("shares_enabled")]
        public bool? SharesEnabled { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonPropertyName("discr")]
        public string? Discr { get; set; }
        [JsonPropertyName("_links")]
        public ItemLinks? Links { get; set; }
        /*[JsonPropertyName("")]
        public string? link { get; set; }   */
    }
}
