using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class UserIcon
    {
        public IconUrls? urls { get; set; }
        public string? alt { get; set; }
        public string? uuid { get; set; }
    }
}
