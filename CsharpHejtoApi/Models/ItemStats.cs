using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    public class ItemStats
    {
        public int? numLikes { get; set; }
        public int? numComments { get; set; }
        public int? numFavorites { get; set; }
        public int? hotness { get; set; }
    }
}
