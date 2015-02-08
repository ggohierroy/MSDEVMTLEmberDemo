using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MSDEVMTLEmberDemo.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("name=Blog")
        {
            Configuration.LazyLoadingEnabled = false; 
        }

        public DbSet<Post> Posts { get; set; }
    }
}