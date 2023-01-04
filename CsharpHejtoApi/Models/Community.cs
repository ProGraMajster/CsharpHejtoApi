using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Community
    {
        public string? name { get; set; }
        public string? slug { get; set; }
        public CommunityAvatar? avatar { get; set; }
        public CommunityBackground? background { get; set; }
    }
}
