using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Author
    {
        public string? username;
        public Avatar? avatar;
        public Background? background;
        public AuthorStatus? status;
        public string? currentRank;
        public string? currentColor;
        public bool? verified;
        public bool? sponsor;
        public DateTime? createdAt;
        public AuthorLinks? links;
    }
}
