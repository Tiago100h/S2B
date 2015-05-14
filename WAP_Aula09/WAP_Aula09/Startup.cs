using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAP_Aula09.Startup))]
namespace WAP_Aula09
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
