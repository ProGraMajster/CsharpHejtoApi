using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class PurpleBackground
    {
        public BackgroundUrls? urls { get; set; }
        public string? uuid { get; set; }
    }
}
