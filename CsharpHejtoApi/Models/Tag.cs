﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class Tag
    {
        public string? name { get; set; }
        public TagLinks? links { get; set; }
    }
}