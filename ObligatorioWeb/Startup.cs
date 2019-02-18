using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ObligatorioWeb.Startup))]
namespace ObligatorioWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
