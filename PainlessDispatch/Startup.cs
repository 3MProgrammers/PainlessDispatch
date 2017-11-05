using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PainlessDispatch.Startup))]
namespace PainlessDispatch
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
