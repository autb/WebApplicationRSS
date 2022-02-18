using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRSS.Models;

namespace WebApplicationRSS.Providers.Abstractions
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetPosts();
    }

    public class MockPostService : IPostService
    {
        public Task<IEnumerable<Post>> GetPosts()
        {
            return Task.FromResult<IEnumerable<Post>>(new List<Post>()
            {
                new Post(
                    "How Endpoint Routing works in ASP.NET Core",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum.",
                    "ASP.NET Core",
                    "Ram"),
                    new Post(
                    "Understanding Merge Sort - Comparison and Analysis",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum.",
                    "DSA",
                    "Ram"),
                    new Post(
                    "Understanding Binary Search - Comparison and Analysis",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum.",
                    "DSA",
                    "Ram"),
                    new Post(
                    "Understanding Quick Sort - Comparison and Analysis",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum.",
                    "DSA",
                    "Ram"),
                    new Post(
                    "Understanding Modules Directives and Components in Angular",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum.",
                    "Angular",
                    "Ram"),

                    new Post(
                    "Understanding BEN Modules Directives and Components in Angular",
                    "ngrok http https://192.168.0.140:5001",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum.",
                    "Angular",
                    "Ram"),

                    new Post(
                    "Understanding BEN2222 Modules Directives and Components in Angular",
                    "Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum",
                    "ngrok http https://192.168.0.140:5001 Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum. Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum Loreum Ipseum.",
                    "Angular",
                    "ben")
            });
        }
    }

}
