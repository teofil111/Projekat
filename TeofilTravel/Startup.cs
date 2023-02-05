using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeofilTravel.Startup))]
namespace TeofilTravel
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
