using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAP_Exercicio2.Startup))]
namespace WAP_Exercicio2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
