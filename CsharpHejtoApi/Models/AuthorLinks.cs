﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class AuthorLinks
    {
        public First? self { get; set; }
        public First? follows { get; set; }
    }
}
