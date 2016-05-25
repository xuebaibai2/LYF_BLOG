using LYF_BLOG.Blog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Domain
{
    public class BasicService : IDisposable
    {
        protected BlogDBContext context;
        public BasicService()
        {
            context = new BlogDBContext();
        }
        public BasicService(BlogDBContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}