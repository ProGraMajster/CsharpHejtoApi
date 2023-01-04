using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Favicon
    {
        public string? url { get; set; }
        public string? safe { get; set; }
    }
}
