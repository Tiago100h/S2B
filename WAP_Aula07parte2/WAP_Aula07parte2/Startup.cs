using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAP_Aula07parte2.Startup))]
namespace WAP_Aula07parte2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
