using Dapper.Contrib.Extensions;
using Blog.Model;
using Blog.Repositories;

namespace Blog.Model
{
    [Table("[Post]")]

    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}