using CsharpHejtoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class CommunitiesResponse
    {
        public int? page { get; set; }
        public int? limit { get; set; }
        public int? pages { get; set; }
        public int? total { get; set; }
        public CommunitiesResponseLinks? links { get; set; }
        public EmbeddedPost? embedded { get; set; }
    }
}
