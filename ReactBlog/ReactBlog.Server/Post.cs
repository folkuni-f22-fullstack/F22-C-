using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using motsvarar import

namespace ReactBlog.Server.Controllers
{
    // en klass motsvarar ett TypeScript-interface
    // det �r en mall som kan anv�ndas f�r att skapa objekt
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
