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

namespace HejtoApi.Models
{
    [Serializable]
    public class Comments
    {
        int? page;
        int? limit;
        int? pages;
        int? total;
        CommentsResponseLinks? links;
        Embedded? embedded;
    }
}
