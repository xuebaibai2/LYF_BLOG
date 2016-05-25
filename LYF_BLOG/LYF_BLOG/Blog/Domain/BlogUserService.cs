using LYF_BLOG.Blog.Data;
using LYF_BLOG.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Domain
{
    public class BlogUserService : BasicService
    {
        private BlogUser user;
        private List<BlogUser> userList;

        public BlogUserService(BlogDBContext context) : base(context) { }

        public BlogUserService()
        {
            user = new BlogUser();
            userList = new List<BlogUser>();
        }

        public ReturnMSG CreateUser(string providerID)
        {
            user.ProviderId = providerID;
            context.BlogUser.Add(user);
            int result = context.SaveChanges();
            if (result == 1)
            {
                return new ReturnMSG(CONTEXT_CONDITION.SUCCESS);
            }
            else
            {
                return new ReturnMSG(CONTEXT_CONDITION.FAIL);
            }
        }

        public BlogUser GetUserByProviderID(string providerID)
        {
            return context.BlogUser
                .Where(m => m.ProviderId.Equals(providerID))
                .SingleOrDefault();
        }
    }
}