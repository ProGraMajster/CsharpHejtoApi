﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Author
    {
        public string? username { get; set; }
        public Avatar? avatar { get; set; }
        public Background? background { get; set; }
        public string? status { get; set; }
        public string? current_rank { get; set; }
        public string? current_color { get; set; }
        public bool? verified { get; set; }
        public bool? sponsor { get; set; }
        public DateTime? created_at { get; set; }
        public AuthorLinks? _links { get; set; }
    }
}
