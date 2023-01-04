using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class CommentAuthor
    {
        public string? username { get; set; }
        public PurpleAvatar? avatar { get; set; }
        public PurpleBackground? background { get; set; }
        public string? status { get; set; }
        public string? currentRank { get; set; }
        public string? currentColor { get; set; }
        public bool? verified { get; set; }
        public bool? sponsor { get; set; }
        public DateTime? createdAt { get; set; }
        public AuthorLinks? links { get; set; }
    }
}
