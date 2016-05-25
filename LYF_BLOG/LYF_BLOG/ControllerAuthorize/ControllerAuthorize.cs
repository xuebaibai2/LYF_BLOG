using LYF_BLOG.Models;
using LYF_BLOG.Utility;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LYF_BLOG.ControllerAuthorize
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AdministratorAuthorize : AuthorizeAttribute
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        protected UserManager<ApplicationUser> UserManager { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            ApplicationDbContext = new ApplicationDbContext();
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ApplicationDbContext));

            bool isAuthorized = base.AuthorizeCore(httpContext);
            if (!isAuthorized)
            {
                return false;
            }
            var id = HttpContext.Current.User.Identity.GetUserId();

            if (UserManager.IsInRole(HttpContext.Current.User.Identity.GetUserId(), DEFAULT_ROLE.ADMINISTRATOR.ROLENAME))
            {
                return true;
            }
            return false;
        }
    }
}