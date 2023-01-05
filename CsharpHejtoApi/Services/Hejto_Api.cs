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
                PostsResponse postsResponse = (PostsResponse)JsonSerializer.Deserialize(request.Result, typeof(PostsResponse), new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                });
                return postsResponse;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
        public PostsResponse GetPosts(string page, int limit=10)
        {
            try
            {
                string url = $"/posts?orderBy=p.createdAt&orderDir=desc&period=week&followed=0&liked=0&commented=0&favorited=0&excludeBlockedUsers=1&excludeBlockedTags=1&page={page}&limit={limit}";
                var request = client.GetStringAsync("https://api.hejto.pl"+url);
                PostsResponse postsResponse = (PostsResponse)JsonSerializer.Deserialize(request.Result, typeof(PostsResponse), new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                });
                return postsResponse;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
    }
}
