using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class UserDetailsResponseLinks
    {
        public Follows? self { get; set; }
        public Follows? follows { get; set; }
    }
}
