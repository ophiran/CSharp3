using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPressingV2.Startup))]
namespace WebPressingV2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
