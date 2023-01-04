using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class CommunityAvatar
    {
        public AvatarUrls? urls { get; set; }
        public string? uuid { get; set; }
        public string? alt { get; set; }
    }
}
