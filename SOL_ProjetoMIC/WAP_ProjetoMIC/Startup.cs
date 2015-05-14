using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAP_ProjetoMIC.Startup))]
namespace WAP_ProjetoMIC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
