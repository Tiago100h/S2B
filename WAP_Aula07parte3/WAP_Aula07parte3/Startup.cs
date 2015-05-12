using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAP_Aula07parte3.Startup))]
namespace WAP_Aula07parte3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
