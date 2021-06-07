using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatterAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public DateTime Created { get; set; }
        public bool IsFlagged { get; set; }

        public string UserImage { get; set; }

        public string Thread { get; set; }

        public string SubThread { get; set; }

    }
}
