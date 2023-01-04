using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class CommentInteractions
    {
        public bool? isLiked { get; set; }
        public bool? isReported { get; set; }
    }
}
