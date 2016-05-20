using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LYF_BLOG.Startup))]
namespace LYF_BLOG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
