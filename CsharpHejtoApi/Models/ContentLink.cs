using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class ContentLink
    {
        public string? url { get; set; }
        public string? site { get; set; }
        public string? type { get; set; }
        public string? title { get; set; }
        public List<dynamic>? audios { get; set; }
        public List<Image>? images { get; set; }
        public List<Video>? videos { get; set; }
        public Favicon? favicon { get; set; }
        public string? description { get; set; }
    }
}
