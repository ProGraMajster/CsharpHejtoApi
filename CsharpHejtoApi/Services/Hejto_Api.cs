using CsharpHejtoApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Services
{
    public class Hejto_Api
    {
        HttpClient client = new HttpClient();
        public PostsResponse? GetPosts()
        {
            try
            {
                var request = client.GetStringAsync("https://api.hejto.pl/posts");
                PostsResponse postsResponses  = (PostsResponse)JsonSerializer.Deserialize(request.Result, typeof(PostsResponse), new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                });
                return postsResponses;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
    }
}
