using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Video
    {
        public string? url { get; set; }
        public string? type { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public string? secureUrl { get; set; }
    }
}
