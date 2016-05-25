using System.Web.Mvc;

namespace LYF_BLOG.Areas.BlogAdmin
{
    public class BlogAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BlogAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BlogAdmin_default",
                "BlogAdmin/{controller}/{action}/{id}",
                new { controller = "Board", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "LYF_BLOG.Areas.BlogAdmin.Controllers" }
            );
        }
    }
}