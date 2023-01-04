using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class PostLinks
    {
        public First? self { get; set; }
        public First? first { get; set; }
        public First? last { get; set; }
        public First? next { get; set; }
    }
}
