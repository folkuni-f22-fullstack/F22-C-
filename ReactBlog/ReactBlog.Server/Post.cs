using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using motsvarar import

namespace ReactBlog.Server.Controllers
{
    // en klass motsvarar ett TypeScript-interface
    // det är en mall som kan användas för att skapa objekt
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
