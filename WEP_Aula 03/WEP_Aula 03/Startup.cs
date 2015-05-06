using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEP_Aula_03.Startup))]
namespace WEP_Aula_03
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
