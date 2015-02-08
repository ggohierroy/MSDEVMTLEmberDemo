using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSDEVMTLEmberDemo.Models
{
    public class PostsDTO
    {
        public IQueryable<Post> Posts { get; set; }

        public Meta Meta { get; set; }
    }
}