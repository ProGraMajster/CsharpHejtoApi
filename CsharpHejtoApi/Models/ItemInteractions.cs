using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class ItemInteractions
    {
        public bool? isLiked { get; set; }
        public bool? isCommented { get; set; }
        public bool? isFavorited { get; set; }
    }
}
