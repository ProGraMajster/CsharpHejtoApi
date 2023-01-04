using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class ItemAuthor
    {
        public string? username { get; set; }
        public CommunityAvatar? avatar { get; set; }
        public CommunityBackground? background { get; set; }
        public string? status { get; set; }
        public string? currentRank { get; set; }
        public string? currentColor { get; set; }
        public bool? verified { get; set; }
        public bool? sponsor { get; set; }
        public DateTime? createdAt { get; set; }
        public AuthorLinks? links { get; set; }
    }
}
