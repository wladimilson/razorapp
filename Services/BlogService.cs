using System;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApp.Services
{
    public class BlogService 
    {
        public Task<Post[]> GetPostsAsync()
        {
            return Task.FromResult<Post[]>(new Post[]
            {
                new Post { Title = "Post 1", Content = "Conteúdo do Post 1" },
                new Post { Title = "Post 2", Content = "Conteúdo do Post 2" },
                new Post { Title = "Post 3", Content = "Conteúdo do Post 3" },
                new Post { Title = "Post 4", Content = "Conteúdo do Post 4" }
            });
        }
    }
}
