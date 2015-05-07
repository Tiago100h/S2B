using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEP_Aula04.Startup))]
namespace WEP_Aula04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
