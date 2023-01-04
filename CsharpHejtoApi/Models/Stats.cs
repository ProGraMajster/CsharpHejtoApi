using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Stats
    {
        public int? numFollows { get; set; }
        public int? numPosts { get; set; }
        public int? numComments { get; set; }
    }
}
