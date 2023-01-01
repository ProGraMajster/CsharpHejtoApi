using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Avatar
    {
        public AvatarUrls? urls;
        public string? uuid;
        public string? alt;
    }
}
