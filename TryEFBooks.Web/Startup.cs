using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryEFBooks.Web.Startup))]
namespace TryEFBooks.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
