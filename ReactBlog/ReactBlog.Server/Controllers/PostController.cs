using Microsoft.AspNetCore.Mvc;

namespace ReactBlog.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        
        [HttpGet(Name = "Posts")]
        public IEnumerable<Post> Get()
        {
            return new Post[]
            {
                new Post{Id="1", Title="You won't believe the amazingness!!", Author="Anton Antonsson"},
                new Post{Id="2", Title="5 ways to make a cat", Author="Catty Cat"},
                new Post{Id="3", Title="ASP.NET MVC Core", Author="Techy Tech"}
            };
        }
    }
}
