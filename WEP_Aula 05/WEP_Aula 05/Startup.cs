using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEP_Aula_05.Startup))]
namespace WEP_Aula_05
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
