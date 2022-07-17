using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp0717.Startup))]
namespace WebApp0717
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
