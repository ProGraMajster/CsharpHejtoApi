using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    public class TagLinks
    {
        public First? self { get; set; }
        public First? follows { get; set; }
        public First? blocks { get; set; }
    }
}
