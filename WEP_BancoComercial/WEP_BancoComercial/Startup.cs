using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEP_BancoComercial.Startup))]
namespace WEP_BancoComercial
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
