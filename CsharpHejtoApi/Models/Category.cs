using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Category
    {
        public string? name { get; set; }
        public string? slug { get; set; }
        public int? numPosts { get; set; }
    }
}
