using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class CommentStats
    {
        public int? numLikes { get; set; }
        public int? numReports { get; set; }
    }
}
