using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Session
    {
        public User? user { get; set; }
        public DateTime? expires { get; set; }
        public string? accessToken { get; set; }
        public int? accessTokenExpiry { get; set; }
    }
}
