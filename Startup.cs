using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcApplication4.Startup))]
namespace MvcApplication4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
