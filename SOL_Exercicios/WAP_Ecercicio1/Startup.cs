using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAP_Ecercicio1.Startup))]
namespace WAP_Ecercicio1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
