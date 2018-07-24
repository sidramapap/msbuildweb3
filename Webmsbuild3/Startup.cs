using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webmsbuild3.Startup))]
namespace Webmsbuild3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
