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
        public string? url;
        public string? site;
        public string? type;
        public string? title;
        public List<dynamic>? audios;
        public List<Image>? images;
        public List<Video>? videos;
        public Favicon? favicon;
        public string? description;
    }
}
