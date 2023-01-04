using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Item
    {
        public String? name { get; set; }
        public String? slug { get; set; }
        // public Status? status{ get; set; }
        public List<PostType>? postTypes { get; set; }
        public Avatar? avatar { get; set; }
        public Background? background { get; set; }
        public bool? primitive { get; set; }
        public Category? category { get; set; }
        public int? numMembers { get; set; }
        public int? numPosts { get; set; }
        public bool? isMember { get; set; }
        public int? newPosts { get; set; }
        public DateTime? updatedAt { get; set; }
        public ItemLinks? links { get; set; }
        public String? description { get; set; }
    }
}
