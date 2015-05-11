using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEP_Aula06.Startup))]
namespace WEP_Aula06
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
