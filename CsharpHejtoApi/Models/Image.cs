using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Image
    {
        public string? url { get; set; }
        public string? safe { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
    }
}
