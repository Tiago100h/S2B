using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAP_Aula07.Startup))]
namespace WAP_Aula07
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
