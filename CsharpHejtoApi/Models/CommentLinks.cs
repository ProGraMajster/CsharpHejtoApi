using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class CommentLinks
    {
        public First? self { get; set; }
        public First? likes { get; set; }
    }
}
