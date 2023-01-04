using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class BackgroundUrls
    {
        public string? the400X300 { get; set; }
        public string? the1200X900 { get; set; }
        public string? original { get; set; }
    }
}
