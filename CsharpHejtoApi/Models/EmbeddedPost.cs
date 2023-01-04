using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class EmbeddedPost
    {
        public List<PostItem> items { get; set; }
    }
}
