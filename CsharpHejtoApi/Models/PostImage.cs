using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    public class PostImage
    {
        public ImageUrls? urls { get; set; }
        public string? uuid { get; set; }
        public int? position { get; set; }
    }
}
