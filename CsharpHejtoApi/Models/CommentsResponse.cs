using CsharpHejtoApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class CommentsResponse
    {
        int? page { get; set; }
        int? limit { get; set; }
        int? pages { get; set; }
        int? total { get; set; }
        CommentsResponseLinks? links { get; set; }
        EmbeddedPost? embedded { get; set; }
    }
}
